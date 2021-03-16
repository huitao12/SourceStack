

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

--将Problem表中的Reward全部更新为0
--使用事务，
--删除User表中的全部数据，
--回滚事务，撤销之前的删除行为

INSERT [User](UserName, [Password]) VALUES(N'17bang',1234);
INSERT [User](UserName, [Password]) VALUES(N'Admin  ',NULL);
INSERT [User](UserName, [Password]) VALUES(N'Admin-1',' ');
INSERT [User](UserName, [Password]) VALUES(N'SuperAdmin',123456);

UPDATE Problem SET Reward=0;--把Problem全部更新为0

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


--https://17bang.ren/Article/444
--作业
--制作PPT，全面的解释说明SQL Server的索引机制，包括但不限于：
--无索引时如何进行全表扫描
--索引是一个什么样的数据结构，如何构建和使用
--聚集索引和非聚集索引的区别，唯一索引和非唯一索引的区别


--https://17bang.ren/Article/441
--作业
--新建表Message(Id, FromUser, ToUser, UrgentLevel, Kind, HasRead, IsDelete, Content)，使用该表和SQL语句，证明：
--唯一约束依赖于唯一索引
--主键上可以是非聚集索引
--并利用“执行计划”图演示说明：Scan、Seek和Lookup的使用和区别。



--https://17bang.ren/Article/667
--作业
--1.观察并模拟17bang项目中的：
--用户资料，新建用户资料（Profile）表，和User形成1:1关联（有无约束？）。用SQL语句演示：
--新建一个填写了用户资料的注册用户
--通过Id查找获得某注册用户及其用户资料
--删除某个Id的注册用户

--2.帮帮点说明：新建Credit表，可以记录用户的每一次积分获得过程，即：某个用户，在某个时间，因为某某原因，获得若干积分

--3.发布求助，在Problem和User之间建立1:n关联（含约束）。用SQL语句演示：
--某用户发布一篇求助，
--将该求助的作者改成另外一个用户
--删除该用户

--4.求助列表：新建Keyword表，和Problem形成n:n关联（含约束）。用SQL语句演示：
--查询获得：某求助使用了多少关键字，某关键字被多少求助使用
--发布了一个使用了若干个关键字的求助
--该求助不再使用某个关键字
--删除该求助
--删除某关键字


--https://17bang.ren/Article/458
--作业
--联表查出求助的标题和作者用户名
--查找并删除从未发布过求助的用户
--用一句SELECT显示出用户和他的邀请人用户名
--17bang的关键字有“一级”“二级”和其他“普通（三）级”的区别：
--请在表Keyword中添加一个字段，记录这种关系
--然后用一个SELECT语句查出所有普通关键字的上一级、以及上上一级的关键字名称，比如：

--17bang中除了求助（Problem），还有意见建议（Suggest）和文章（Article），他们都包含Title、Content、PublishTime和Auhthor四个字段，但是：
--建议和文章没有悬赏（Reward）
--建议多一个类型：Kind NVARCHAR(20)）
--文章多一个分类：Category INT）
--请按上述描述建表。然后，用一个SQL语句显示某用户发表的求助、建议和文章的Title、Content，并按PublishTime降序排列

--https://17bang.ren/Article/457
--作业：
--为求助添加一个发布时间（TPublishTime），使用子查询：
--删除每个作者悬赏最低的求助
--找到从未成为邀请人的用户
--如果一篇求助的关键字大于3个，将它的悬赏值翻倍
--查出所有发布一篇以上（不含一篇）文章的用户信息
--查找每个作者最近发布的一篇文章
--查出每一篇求助的悬赏都大于5个帮帮币的作者