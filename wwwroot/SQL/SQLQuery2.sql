drop table Student

CREATE TABLE Student( 
    Id INT identity CONSTRAINT PK_Student_Id PRIMARY KEY, --主键约束，名PK_Student_Id
    [Name] NVARCHAR(10) CONSTRAINT UQ_Student_Name UNIQUE, --唯一约束，名UQ_Student_Name 
    Enroll DATETIME /*CONSTRAINT NU_Enroll*/ NOT NULL, --Enroll不能为空 
    Age SMALLINT CONSTRAINT CK_Student_Age CHECK(Age>0), --自定义约束，名CK_Student_Age 
    Score FLOAT, --没有约束 
    IsFemale BIT CONSTRAINT DF_Student_IsFemale DEFAULT(1) --默认约束，名DF_Student_IsFemale
)
select *from Student
insert Student values(N'刘晓','2000/1/3',22,null,NULL);
insert Student([NAME],Enroll,Age,Score) values(N'晓哥','2000/1/3',22,null);
insert Student([NAME],Enroll,Age) values(N'巧儿','2000/1/3',22);
insert Student([NAME],Enroll,Age) values(N'巧','2000/1/3',22);

--
drop table studengts
create table studengts
(
id int identity(100,5),--设置起始值从100开始，每次步增为5
[name] nvarchar(10)
)
insert studengts values(N'晓')
select * from studengts

select newid()
select *from guidsample
create table guidsample(id char(40))
insert guidsample values(newid())

drop table Student
create table Student(
id int not null  primary key,
[Name] nvarchar(20),
Enroll datetime,
Age int,
Score int,
)




select * from Teacher
drop table Teacher

CREATE TABLE Teacher(--创建
Id INT /*not null primary key*/,
[Name] NVARCHAR(25),
Age INT, Gender BIT 
)

create clustered index IX_Teacher_Name on Teacher([name])--创建name聚集索引

alter table Teacher
--alter column id int not null
ADD constraint PK_Teacher_Id primary key(id)--添加主键约束

alter table Teacher--添加唯一约束
ADD constraint UQ_Teacher_Name UNIQUE([Name])

alter table Teacher--删除约束
drop constraint  UQ_Teacher_Name

create unique index IX_Teacher_Name on Teacher([Name])--唯一索引

-- [type]：1 聚集; >1 非聚集
SELECT [name], [type], is_unique, is_primary_key, is_unique_constraint 
FROM sys.indexes 
WHERE object_id = OBJECT_ID('Teacher')

create unique/*唯一*/ clustered/*聚集*/ INDEX/*索引*/ IX_Teacher_id ON Teacher(id)--建立唯一聚集索引
create  INDEX/*索引*/ IX_Teacher_id_2 ON Teacher(id)--聚集索引上建非聚集索引


create unique nonclustered index IX_Teacher_name on teacher([name])--唯一非聚集（不写nonclustered，默认nonclustered）

create index IX_Teacher_Age on Teacher(Age)--非唯一非聚集
create index IX_Teacher_Age_1 on Teacher(Age)--非唯一非聚集

create unique index IX_Teacher_Name_Age on Teacher([name],Age)
--提高where [name]=N'' and Age = ?查询

select * from Student

select * from Teacher
insert Teacher(id,[Name],age) values(2,N'小哥',22)--插入

drop index Teacher.IX_Teacher_id_2--删 除索引
drop index Teacher.IX_Teacher_name
drop index Teacher.IX_Teacher_name_age


select *from Student
alter table Student
ADD Descripion  nvarchar(100)
update Student set Age=22 where id= 7

select Age,avg(Score)
from Student
group by Age
having avg(Score)>90

--视图

--创建
GO

CREATE VIEW V_Student -- V_Student是新创建View的名称 
AS SELECT Id, [Name], 
YEAR(Enroll) YearEnroll, -- 新增的计算列 
Month(Enroll) MonthEnroll, -- 必须指定列名 
Day(Enroll) DayEnroll, -- 列名不能重复 
Age, Score FROM Student -- 还可以添加其他的WHERE/GROUP/HAVING等子句

GO--另外一种创建视图
CREATE VIEW V_Student([No],[Year],[Month],[Day],Age,Score) -- V_Student是新创建View的名称 
AS SELECT Id, [Name], 
YEAR(Enroll) , -- 新增的计算列 
Month(Enroll) , -- 必须指定列名 
Day(Enroll) , -- 列名不能重复 
Age, Score FROM Student -- 还可以添加其他的WHERE/GROUP/HAVING等子句

GO--修改列名（修改要全部写一遍与新建视图差不多）
alter VIEW V_Student([No],[Name],[Year],[Month],[Day],Age,Score) -- V_Student是新创建View的名称 
AS SELECT Id, [Name], 
YEAR(Enroll) , -- 新增的计算列 
Month(Enroll) , -- 必须指定列名 
Day(Enroll) , -- 列名不能重复 
Age, Score FROM Student -- 还可以添加其他的WHERE/GROUP/HAVING等子句

GO
select * from V_Student

alter table Student drop column score --删除score列

go
drop view V_Student -- 删除试图，可删除多个

GO  --绑定了架构的视图
CREATE VIEW V_Student_Schema 
WITH SCHEMABINDING -- 指明Schema Bind 
AS SELECT Id, [Name], Score 
FROM dbo.Student -- 必须使用dbo.Student

GO
alter table Student drop column score --删除score列（视图绑定的是删除不掉的）

GO --视图加密（视图的具体创建的内容看不见）
CREATE VIEW V_Student_Encrypt 
WITH ENCRYPTION 
AS SELECT * FROM Student

