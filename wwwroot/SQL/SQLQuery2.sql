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


CREATE UNIQUE CLUSTERED INDEX IX_Teacher_Id ON Teacher(Id)
DROP INDEX Teacher.IX_Teacher_Id

select * from Student

select * from Teacher
insert Teacher(id,[Name],age) values(2,N'小哥',22)--插入

drop index Teacher.IX_Teacher_id_2--删 除索引
drop index Teacher.IX_Teacher_name
drop index Teacher.IX_Teacher_name_age

--


CREATE TABLE Students(
Id INT NOT NULL, 
[Name] NVARCHAR(25),
Age INT,
Gender BIT
)

UPDATE Students SET Gender=1 WHERE Id%2=1

CREATE UNIQUE CLUSTERED INDEX IX_Students_Id  ON Students(Id)--创建聚集索引
CREATE  INDEX IX_Students_Id_1 ON Students(Id)--聚集索引上建非聚集索引

CREATE UNIQUE INDEX IX_Students_Name  ON Students([Name]) --创建非聚集索引

CREATE INDEX IX_Students_Age ON Students(Age) --非聚集非唯一

CREATE INDEX IX_Students_Age_1 ON Students(Age) --在一个列上添加多个非聚集非唯一

CREATE UNIQUE INDEX IX_Students_Age_Name ON Students(Age,[Name]) --在两个列上建组合索引（提高查询性能）--提高where [name]=N'' and Age = ?查询

INSERT Students VALUES(1,N'飞哥',22,1)
INSERT Students VALUES(2,N'飞哥',22,1)
INSERT Students VALUES(3,N'飞哥',22,0)
INSERT Students VALUES(4,N'飞哥',22,1)
INSERT Students VALUES(5,N'飞哥',22,1)
INSERT Students VALUES(6,N'飞哥',22,0)
INSERT Students VALUES(7,N'飞哥',22,1)

INSERT Students SELECT [Name],Age,Gender FROM Students  --复制表

DROP INDEX Students.IX_Students_Id_1  --删除索引

--自动建立索引
DROP TABLE IF EXISTS Students

ALTER TABLE Students ADD CONSTRAINT UQ_Students_Name UNIQUE([Name]) --创建唯一约束

-- [type]：1 聚集; >1 非聚集
SELECT [name], [type], is_unique, is_primary_key, is_unique_constraint 
FROM sys.indexes --系统的索引
WHERE object_id = OBJECT_ID('Students')

--在创建唯一约束的系统会自动创建一个唯一索引

DROP TABLE IF EXISTS Students

CREATE CLUSTERED INDEX IX_Students_Name ON Students([ame])--建立聚集索引

ALTER  TABLE Students ADD CONSTRAINT PK_Students_Id PRIMARY KEY (Id) --添加主键索引（不是聚集）

--加一个主键约束一定会加一个唯一索引，是否聚集要看前面的表有没有索引（没有就建聚集唯一，反之）

--索引失效
SELECT * FROM  Teacher
WHERE Gender = 0 --=1

CREATE INDEX IX_Teacher_Gender ON Teacher(Gender) --创建索引

SELECT Age,AVG(Score) FROM Teacher GROUP BY Age




select *from Student
alter table Student
ADD Descripion  nvarchar(100)
update Student set Age=22 where id= 7

select Age,avg(Score)
from Student
group by Age
having avg(Score)>1

--视图

--创建
GO

CREATE VIEW V_Student -- V_Student是新创建View的名称 
AS SELECT Id, [Name], 
YEAR(Enroll) YearEnroll, -- 新增的计算列 
Month(Enroll) MonthEnroll, -- 必须指定列名 
Day(Enroll) DayEnroll, -- 列名不能重复 
Age, Score FROM Student -- 还可以添加其他的WHERE/GROUP/HAVING等子句

GO
SELECT * FROM V_Student
SELECT * FROM Student

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


GO
CREATE UNIQUE CLUSTERED INDEX IX_STUDENT_HH ON STUDENT(HH)
CREATE UNIQUE CLUSTERED INDEX IX_DD_ZZ ON DD(ZZ)
CREATE UNIQUE NONCLUSTERED INDEX IX_SS_DD ON SS(DD)
CREATE INDEX IX_AA_SS ON AA(SS)

DROP INDEX AA.IX_AA_SS
DROP INDEX SS.IX_AA_ZZ


PRINT @@version

declare @n int = 0
while(@n<50)
begin
set @n+=1
print floor(rand()*1000)
end
--print @n

print replicate(N'大傻逼',10)

CREATE UNIQUE CLUSTERED  INDEX IX_HAH_ADH ON HAHA(ADH)

CREATE UNIQUE CLUSTERED INDEX ID_AA_AA ON AA(AA)

print getdate()
select year(getdate())

CREATE TABLE GUIDSample(Id VARCHAR(50) ) --GUID
INSERT GUIDSample VALUES(NEWID())
SELECT * FROM GUIDSample


--外键
SELECT * FROM Student
SELECT * FROM Teacher

INSERT Teacher VALUES(1,N'飞哥',22,1)
INSERT Teacher VALUES(2,N'飞弟',23,0)

ALTER TABLE Student  --在Student添加TeacherId列
ADD TeacherId INT

UPDATE Student SET TeacherId = 1 WHERE ID=1 --更改数据

ALTER TABLE Student --添加外键约束
ADD CONSTRAINT FK_Teacher_Id FOREIGN KEY(TeacherId ) REFERENCES Teacher(Id)

ALTER TABLE Student --添加新列的时候添加外键
ADD TeacherId int CONSTRAINT FK_Teacher_Id FOREIGN KEY REFERENCES Teacher(Id)

CREATE TABLE Major
( 
Id INT NOT NULL PRIMARY KEY, 
[Name] NVARCHAR(25), 
TaughtBy INT /*CONSTRAINT FK_Teacher_Id*/ FOREIGN KEY REFERENCES Teacher(Id)--在添加表时就指定外键列 
)


SELECT S.id,S.[Name],S.Age,T.[Name],C.[NAME] FROM Student s -- *指的是Join过后两张表的所有列，s是给表Student的别名 
JOIN Teacher T -- 给表City一个别名，使用JOIN将Student和City连接起来 
ON s.TeacherId = T.Id -- 指定表Student（别名s）和City（别名c）连接的条件
JOIN City C
ON s.TeacherId =C.ID

CREATE TABLE City(
ID INT ,
[NAME] NVARCHAR(20),
Province NVARCHAR(20)
)

INSERT City VALUES(1,N'南岸',N'重庆')
INSERT City VALUES(2,N'沙坪坝',N'重庆')
INSERT City VALUES(3,N'成都',N'四川')

SELECT * FROM Teacher
SELECT * FROM Student
SELECT * FROM City

SELECT * FROM Student S 
JOIN Teacher T
ON T.Id=S.TeacherId
JOIN City C
ON C.ID=S.FroMCityId


SELECT S.id,S.[Name],S.Age,T.[Name] AS Teachername,C.[NAME],G FROM Student S 
JOIN Teacher T
ON T.Id=S.TeacherId
JOIN City C
ON C.ID=S.FroMCityId

SELECT * FROM Student S
JOIN City C
ON C.ID=S.FroMCityId







UPDATE Student SET TeacheriD=2 WHERE ID=105

UPDATE Student SET FroMCityId=3 WHERE ID=1
UPDATE Student SET FroMCityId=2 WHERE ID=3
UPDATE Student SET FroMCityId=1 WHERE ID=6
UPDATE Student SET FroMCityId=1 WHERE ID=7
UPDATE Student SET FroMCityId=1 WHERE ID=1
UPDATE Student SET FroMCityId=2 WHERE ID=100
UPDATE Student SET FroMCityId=1 WHERE ID=105

ALTER TABLE Student
ADD  FroMCityId INT


--CASE表达式 
SELECT *FROM Student

SELECT ID,[NAME],SCORE,
CASE 
  WHEN SCORE>=90 THEN N'优秀'
  WHEN SCORE>=70 THEN N'棒'
  ELSE  N'及格'
END
FROM Student

ALTER TABLE Student
ADD Grade NVARCHAR(20)

UPDATE Student SET Grade=  --更新Grade满足下面的条件就更新
CASE 
  WHEN SCORE>=90 THEN N'优秀'
  WHEN SCORE>=70 THEN N'棒'
  ELSE  N'及格'
END
FROM Student


SELECT* FROM TSCORE--行列转行

CREATE TABLE TSCORE
(
[Name] NVARCHAR(20),
[Subject] NVARCHAR(20),
Score INT
)
INSERT TSCORE VALUES(N'小哥','SQL',98)
INSERT TSCORE VALUES(N'小哥','C#',89)
INSERT TSCORE VALUES(N'小哥','JS',76)
INSERT TSCORE VALUES(N'大哥','SQL',87)
INSERT TSCORE VALUES(N'大哥','C#',95)
INSERT TSCORE VALUES(N'大哥','JS',88)
SELECT 
[Name],
--[Subject],
--Score,
MAX(CASE [Subject] WHEN N'SQL' THEN  Score ELSE 0  END )AS N'SQL',
MAX(CASE [Subject] WHEN N'C#' THEN  Score ELSE 0  END ) AS N'C#',
MAX(CASE [Subject] WHEN N'JS' THEN  Score ELSE 0 END ) AS N'JS'
FROM TSCORE
GROUP BY [Name]


--查出每个同学的成绩和所有同学平均成绩的差距

SELECT * FROM Student --子查询

--子查询（）里面的那个select称为子查询。查出来只能是一列
SELECT [Name],Score,Score-(SELECT AVG(Score)FROM Student)FROM Student   

--用id=7的成绩替换id=100的成绩
UPDATE Student SET Score=(SELECT Score FROM Student WHERE ID=7) WHERE ID =100   

--删除表中的重复记录


SELECT Score FROM Student GROUP BY Score   --查出没有重复的
SELECT DISTINCT Score FROM Student    --查出没有重复的 

BEGIN TRAN
DELETE Student WHERE Id NOT IN
(SELECT MIN(ID)FROM Student GROUP BY Score )
ROLLBACK

--集合运算
--ANY 或SOME(满足一个条件为真)
IF (100<SOME(SELECT ID FROM Student)) SELECT 1
IF (100<ANY(SELECT ID FROM Student)) SELECT 1

--ALL(所有条件都满足 为真)
IF (1<ALL(SELECT ID FROM Student)) SELECT 1

--IN(查找某个值是不是存在)
IF (10 IN(SELECT ID FROM Student)) SELECT 1
IF (10 NOT IN(SELECT ID FROM Student)) SELECT 1


--https://17bang.ren/Article/439
--新建一个数据库：17bang，能指定/查看该数据库存放位置
--依次备份/删除/恢复该数据库

--备份数据库
BACKUP DATABASE [17bang] TO DISK = 'D:\\17bang.ht'

--切换
USE [17bang]

--创建
CREATE DATABASE [17bang];

--删除数据库
DROP DATABASE [17bang];

--恢复数据库
RESTORE DATABASE [17bang] FROM DISK = 'D:\\17bang.ht'

--修改表结构 
--增加列
ALTER TABLE Student 
ADD Score DECIMAL(3,1);

--删除
ALTER TABLE Student 
DROP COLUMN Score;

--修改
ALTER TABLE Student 
ALTER COLUMN [Name] NVARCHAR(10);


ALTER TABLE Student 
ADD Enroll DATE;

ALTER TABLE Student 
ALTER COLUMN Enroll DATETIME;

--https://17bang.ren/Article/443
--观察“一起帮”的注册和发布求助功能，试着建立表User：包含UserName（用户名），Password（密码）……
--为User表添加一列：邀请人（InvitedBy），类型为INT
--将InvitedBy类型修改为NVARCHAR(10)
--删除列InvitedBy

CREATE TABLE [dbo].[User]
(
[UserName] nvarchar(100),
[Password] nvarchar(10),
[VerifyPassword] varchar(10),
[VerificationCode] INT,
);

ALTER TABLE [User]
ADD  InvitedBy INT;

ALTER TABLE [User]
ALTER COLUMN InvitedBy NVARCHAR(10);

ALTER TABLE [User]
DROP COLUMN InvitedBy;

--https://17bang.ren/Article/666
--作业
--观察“一起帮”的发布求助功能，试着建立表Problem，包含：
--Id
--Title（标题）
--Content（正文）
--NeedRemoteHelp（需要远程求助）
--Reward（悬赏）
--PublishDateTime（发布时间）……
--请为这些列选择合适的数据类型。

CREATE TABLE [dbo].Problem
(
   [Id] INT NOT NULL PRIMARY KEY,
   [Title] nvarchar(200) NULL,
   [Content] BIGINT NULL,
   [NeedRemoteHelp] BIT NULL,
   [Reward] INT NULL,
   [PublishDateTime] DATETIME NULL
);

--https://17bang.ren/Article/668
--作业
--在User表中插入以下四行数据：
--UserName     Password
--17bang       1234
--Admin        NULL
--Admin-1
--SuperAdmin   123456

INSERT [User](UserName, [Password]) VALUES(N'17bang',1234);
INSERT [User](UserName, [Password]) VALUES(N'Admin  ',NULL);
INSERT [User](UserName, [Password]) VALUES(N'Admin-1',' ');
INSERT [User](UserName, [Password]) VALUES(N'SuperAdmin',123456);

--将Problem表中的Reward全部更新为0
UPDATE Problem SET Reward=0;--把Problem全部更新为0

--使用事务，
--删除User表中的全部数据，
--回滚事务，撤销之前的删除行为

BEGIN TRAN  --开始 s事务
DELETE [User];--删除user表
ROLLBACK --回滚  [user]

select [Password] from [user]

--https://17bang.ren/Article/669
--作业
--在User表中：
--查找没有录入密码的用户
--删除用户名（UserName）中包含“管理员”或者“17bang”字样的用户
 select * from [User]
 where [Password] is  null

 begin tran 
 delete [User] where UserName like N'17bang'
 rollback

--在Problem表中：
--给所有悬赏（Reward）大于10的求助标题加前缀：【推荐】
select * from Problem
begin tran
update Problem set Title=N'【管理员】'+Title where Reward>10

--给所有悬赏大于20且发布时间（Created）在2019年10月10日之后的求助标题加前缀：【加急】
begin tran
update Problem  set title=N'【加急】'+title where PublishDateTime > '2005/10/10'
rollback

--删除所有标题以中括号【】开头（无论其中有什么内容）的求助
delete Problem where Title like N'%【%】%'

--查找Title中第5个起，字符不为“数据库”且包含了百分号（%）的求助
select Problem where title=N'___数据库%'

--在Keyword表中：
--找出所有被使用次数（Used）大于10小于50的关键字名称（Name）
select * from keyword
where used > 10 and used < 50 

--如果被使用次数（Used）小于等于0，或者是NULL值，或者大于100的，将其更新为1
begin tran
update Keyword set used=1 where  used<=0 or used is null or used>100 
rollback

--删除所有使用次数为奇数的Keyword
begin tran
delete Keyword where used%2=1
rollback

--注意，上述作业需要自己插入数据进行测试



--https://17bang.ren/Article/445
--作业
--在User表上的基础上：
--添加Id列，让Id成为主键
select * from [user]
alter table [user]
add Id int not null primary key identity(1,1)


--添加约束，让UserName不能重复
select *from [user]
alter table [user]
add CONSTRAINT UQ_UserName UNIQUE(UserName)


--在Problem表的基础上：
--为NeedRemoteHelp添加NOT NULL约束，再删除NeedRemoteHelp上NOT NULL的约束
select * from problem
alter table [problem]
--ALTER COLUMN NeedRemoteHelp BIT NOT NULL --添加约束
ALTER COLUMN NeedRemoteHelp BIT  NULL      --删除约束

--添加自定义约束，让Reward不能小于10
alter table [problem]
add constraint CK_Reward check(Reward>=10)


--https://17bang.ren/Article/670
--作业
--观察一起帮的“关键字”功能，新建Keyword表，要求带一个自增的主键Id，起始值为10，步长为5；并存入若干条数据
create table  Keyword2
(
id int primary key identity(10,5),
[name] nvarchar(10) 
);
insert Keyword2 values(N'java');
select *from Keyword2

--将User表中Id列修改为可存储GUID的类型，并存入若干条包含GUID值的数据
alter table  [user] alter column id varchar(50)  
insert [User](id) values (NEWID())

--Problem表已有Id列，如何给该列加上IDENTITY属性？ 


--作业
--1.在Problem中插入不同作者（Author）不同悬赏（Reward）的若干条数据，以便能完成以下操作：
select * from [Problem]
alter table [Problem]
add Author nvarchar(20)

select * from [Problem]
update [Problem] set Author=N'飞哥' where id=1
update [Problem] set Author=N'李智博' where id=2
update [Problem] set Author=N'周丁浩' where id=3
update [Problem] set Author=N'刘伟' where id=4
update [Problem] set Author=N'龚廷义' where id=5
update [Problem] set Author=N'皱丽' where id=6
update [Problem] set Author=N'小孩' where id=7
 
 insert [Problem] values(8,9,10,1,34,2200/1/2,N'小孩') 

--查找出Author为“飞哥”的、Reward最多的3条求助
select top 3 * from [Problem]
where Author=N'飞哥' order by Reward desc

--所有求助，先按作者“分组”，然后在“分组”中按悬赏从大到小排序
select  Author,Reward
from  [Problem]
order by Reward desc

--查找并统计出每个作者的：求助数量、悬赏总金额和平均值
select Author,count(title),sum(Reward),avg(Reward)
from [Problem] 
group by Author

--找出平均悬赏值少于10的作者并按平均值从小到大排序
select Author,avg(Reward)
from [problem]
group by Author
having avg(Reward)<10
order by avg(Reward) desc

--2.以Problem中的数据为基础，使用SELECT INTO，新建一个Author和Reward都没有NULL值的新表：NewProblem 
--（把原Problem里Author或Reward为NULL值的数据删掉）
select Author,Reward
into NewProblem
from Problem
where Author is not null and Reward is not null

select * from NewProblem
--3.使用INSERT SELECT, 将Problem中Reward为NULL的行再次插入到NewProblem中

insert NewProblem
select Author,Reward
from Problem
where Reward is null --Author is  null 

