--https://17bang.ren/Article/439
--作业
--使用SQL语句（以后所有作业均是要求使用SQL语句完成，不再额外声明）
--1.新建一个数据库：17bang，能指定/查看该数据库存放位置
--2.依次备份/删除/恢复该数据库
BACKUP DATABASE [17bang] TO DISK ='D:\\17bang.ht'

DROP DATABASE [17bang]

RESTORE DATABASE [17bang] FROM DISK ='D:\\17bang.ht'


--修改（alter）表结构
--增加
ALTER TABLE [User]
ADD Score INT
--删除
ALTER TABLE [User]
DROP COLUMN Score
--修改
ALTER TABLE [User]
ALTER COLUMN [Name] NVARCHAR(10)

--https://17bang.ren/Article/443
--作业
--1.观察“一起帮”的注册和发布求助功能，试着建立表User：包含UserName（用户名），Password（密码）……
CREATE TABLE [User](
Username NVARCHAR(20),
[Password] VARCHAR(20)
);
SELECT * FROM [User]--查看表

--2.为User表添加一列：邀请人（InvitedBy），类型为INT
ALTER TABLE [User]
ADD InvitedBy INT

--3.将InvitedBy类型修改为NVARCHAR(10)
ALTER TABLE [User]
ALTER COLUMN InvitedBy NVARCHAR(10)

--4.删除列InvitedBy
ALTER TABLE [User]
DROP COLUMN InvitedBy

--https://17bang.ren/Article/666
--作业
--观察“一起帮”的发布求助功能，试着建立表Problem，包含：
--1.Id
--2.Title（标题）
--3.Content（正文）
--4.NeedRemoteHelp（需要远程求助）
--5.Reward（悬赏）
--6.PublishDateTime（发布时间）……
--请为这些列选择合适的数据类型。
CREATE TABLE Problem(
Id INT NOT NULL PRIMARY KEY,
Title NVARCHAR(20),
Content TEXT,
NeedRemoteHelp BIT ,
Reward INT,
PublishDateTime DATETIME
)


--https://17bang.ren/Article/668
--作业
--1.在User表中插入以下四行数据：
--UserName     Password
--17bang       1234
--Admin        NULL
--Admin-1
--SuperAdmin   123456
INSERT [User](UserName,[Password]) VALUES(N'17bang',1234)
INSERT [User](Username,[Password]) VALUES(N'Admin',NULL)
INSERT [User](Username,[Password]) VALUES(N'Admin-1','')
INSERT [User](Username,[Password]) VALUES(N'SuperAdmin',123456)

SELECT *  FROM [User]

--2.将Problem表中的Reward全部更新为0
SELECT *  FROM Problem

UPDATE Problem SET Reward=0

--3.使用事务，
--删除User表中的全部数据，
--回滚事务，撤销之前的删除行为
BEGIN TRAN--开始事务
DROP TABLE [User]

ROLLBACK--回滚

--https://17bang.ren/Article/669
--作业
--1.在User表中：
--查找没有录入密码的用户
SELECT * FROM [User]
WHERE [Password]=''--[Password] IS NULL

--删除用户名（UserName）中包含“管理员”或者“17bang”字样的用户
BEGIN TRAN
DELETE [User]
WHERE UserName LIKE /*'%管理员%'OR*/ '%17bang%'

COMMIT--提交
ROLLBACK
SELECT @@TRANCOUNT--查看当前是否有事务

--2.在Problem表中：
--给所有悬赏（Reward）大于10的求助标题加前缀：【推荐】
SELECT * FROM Problem

BEGIN TRAN--开始事务
UPDATE Problem SET Title=N'【推荐】'+Title WHERE Reward>10

COMMIT--提交
ROLLBACK--回滚

--给所有悬赏大于20且发布时间（Created）在2019年10月10日之后的求助标题加前缀：【加急】
BEGIN TRAN 
UPDATE Problem SET Title=N'【加急】'+Title WHERE PublishDateTime>'2019/10/10'AND Reward>20

COMMIT--提交
ROLLBACK

--删除所有标题以中括号【】开头（无论其中有什么内容）的求助
BEGIN TRAN
DELETE Problem WHERE Title LIKE N'%【%】%'

COMMIT--提交
ROLLBACK

--查找Title中第5个起，字符不为“数据库”且包含了百分号（%）的求助
SELECT *FROM Problem WHERE Title NOT LIKE N'___数据库%' AND Title LIKE N'%#%% ' ESCAPE'#'



--3.在Keyword表中：
CREATE TABLE Keywords(
[Name] nvarchar(10),
Used int
)
SELECT * FROM Keywords
INSERT Keywords VALUES(N'小艾',15)
INSERT Keywords VALUES(N'小孩',null)
INSERT Keywords VALUES(N'小新','')
INSERT Keywords VALUES(N'小狗',null)
INSERT Keywords VALUES(N'小猫',200)
INSERT Keywords VALUES(N'小熊',66)
INSERT Keywords VALUES(N'小胖',33)
INSERT Keywords VALUES(N'小蓝',77)
INSERT Keywords VALUES(N'小绿',89)

--找出所有被使用次数（Used）大于10小于50的关键字名称（Name）
SELECT * FROM Keywords
WHERE Used>10 AND Used<50

--如果被使用次数（Used）小于等于0，或者是NULL值，或者大于100的，将其更新为1
BEGIN TRAN
UPDATE Keywords SET Used=1 WHERE Used = 0 OR USED IS NULL OR USED>100
ROLLBACK

--删除所有使用次数为奇数的Keyword
--注意，上述作业需要自己插入数据进行测试
SELECT * FROM Keywords
BEGIN TRAN
DELETE Keywords WHERE Used%2=1
ROLLBACK

--https://17bang.ren/Article/445
--作业
--1.在User表上的基础上：
--添加Id列，让Id成为主键
SELECT * FROM [USER]

ALTER TABLE [User]
ADD Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY --IDENTITY（自增）

--添加约束，让UserName不能重复
ALTER TABLE [User]
ADD CONSTRAINT UQ_UserName UNIQUE(UserName)

INSERT [User] VALUES(N'17bang',1)--测试约束是否创建

--2.在Problem表的基础上：
--为NeedRemoteHelp添加NOT NULL约束，再删除NeedRemoteHelp上NOT NULL的约束
SELECT * FROM Problem
--添加
ALTER TABLE Problem
ALTER COLUMN  NeedRemoteHelp BIT NOT NULL
--删除
ALTER TABLE Problem
ALTER COLUMN NeedRemoteHelp BIT NULL

--添加自定义约束，让Reward不能小于10
BEGIN TRAN
DELETE Problem WHERE Reward<10  --删除Reward<10
COMMIT

ALTER TABLE Problem
ADD CONSTRAINT CK_Reward CHECK(Reward>=10)--添加约束

begin tran
insert Problem values(8,8,'1',1,11,N'2000/1/1')--测试约束是否建立
rollback

--https://17bang.ren/Article/670
--作业
--1.观察一起帮的“关键字”功能，新建Keyword表，要求带一个自增的主键Id，起始值为10，步长为5；并存入若干条数据
CREATE TABLE Keyword(
Id INT IDENTITY(10,5) NOT NULL PRIMARY KEY,
[Name] NVARCHAR(10)
)
SELECT * FROM Keyword
INSERT Keyword VALUES(N'C#')
INSERT Keyword VALUES(N'JAVA')
INSERT Keyword VALUES(N'CSS')
INSERT Keyword VALUES(N'HTML')
INSERT Keyword VALUES(N'SQL')
INSERT Keyword VALUES(N'.NET')

--2.将User表中Id列修改为可存储GUID的类型，并存入若干条包含GUID值的数据
SELECT * FROM [User]

ALTER TABLE [User]
ALTER COLUMN Id VARCHAR(50) 
INSERT [User](Id) VALUES(NEWID())


--3.Problem表已有Id列，如何给该列加上IDENTITY属性？
SELECT * FROM Problem
--ALTER TABLE Problem
--ALTER Id INT NOT NULL IDENTITY(1,1)
CREATE TABLE Problem1(
Id INT IDENTITY(1,1) PRIMARY KEY
)




--https://17bang.ren/Article/455
--作业
--1.在Problem中插入不同作者（Author）不同悬赏（Reward）的若干条数据，以便能完成以下操作：
SELECT * FROM Problem

ALTER TABLE Problem
ADD Author NVARCHAR(20)

ALTER TABLE Problem  --删除约束
DROP CONSTRAINT CK_Reward

UPDATE Problem SET Author = N'飞哥' WHERE Id = 7

--  查找出Author为“飞哥”的、Reward最多的3条求助
SELECT TOP 3* FROM Problem
WHERE Author = N'飞哥' ORDER BY Reward DESC

--  所有求助，先按作者“分组”，然后在“分组”中按悬赏从大到小排序
SELECT Author,Reward
FROM Problem
ORDER BY Author , Reward DESC

--  查找并统计出每个作者的：求助数量、悬赏总金额和平均值
SELECT * FROM Problem

SELECT Author,COUNT(Title),SUM(Reward),AVG(Reward)
FROM Problem
GROUP BY Author

--  找出平均悬赏值少于10的作者并按平均值从小到大排序
SELECT Author,AVG(Reward)
FROM Problem
GROUP BY Author
HAVING AVG(Reward)<10
ORDER BY AVG(Reward) ASC

--2.以Problem中的数据为基础，使用SELECT INTO，新建一个Author和Reward都没有NULL值的新表：
--NewProblem （把原Problem里Author或Reward为NULL值的数据删掉）

SELECT Author,Reward
INTO NewProblem
FROM Problem WHERE Author IS NOT NULL AND  Reward IS NOT NULL

SELECT * FROM NewProblem

--3.使用INSERT SELECT, 将Problem中Reward为NULL的行再次插入到NewProblem中
INSERT NewProblem
SELECT Author ,Reward
FROM Problem WHERE Author IS NULL



--https://17bang.ren/Article/444
--作业
--制作PPT，全面的解释说明SQL Server的索引机制，包括但不限于：
--无索引时如何进行全表扫描
--索引是一个什么样的数据结构，如何构建和使用
--聚集索引和非聚集索引的区别，唯一索引和非唯一索引的区别
--……
CREATE TABLE Teacher(     --练习
Id INT, 
[Name] NVARCHAR(25), 
Age INT,
Gender BIT 
)

--建立索引
CREATE UNIQUE CLUSTERED INDEX IX_Teacher_ID ON Teacher(ID)  --在teacher id上建立 集聚(clustered)唯一(unique) 索引(index)
CREATE UNIQUE /*NONCLUSTERED*/ INDEX IX_Teacher_Name ON teacher([Name])  --建立唯一(UNIQUE)非聚集(NONCLUSTERED)索引(INDEX),加不加NONCLUSTERED 都一样 不加默认NONCLUSTERED
CREATE INDEX IX_Teacher_Age ON Teacher(Age)   --建立非聚集非唯一索引
CREATE INDEX IX_Teacher_Age_2 ON Teacher(Age)  --在重复的索引列上面建索引
CREATE INDEX IX_Teacher_Name_Age ON Teacher([Name],Age)  --组合，提高查询性能，WHERE [Name]=N'' AND Age=?

INSERT Teacher(Id,[Name]) VALUES(1,N'哈')
SELECT * FROM Teacher

DROP INDEX Teacher.IX_Teacher_Name_Age  --删除索引


-- [type]：1 聚集; >1 非聚集
SELECT [name], [type], is_unique, is_primary_key, is_unique_constraint 
FROM sys.indexes 
WHERE object_id = OBJECT_ID('Teacher')

--执行计划
SELECT * FROM Student

SELECT Age,AVG(Score)--HAVING 语句
FROM Student
GROUP BY Age
HAVING AVG(Age)>20

SELECT Age,AVG(Score)--WHERE语句
FROM Student
--WHERE Age>20
GROUP BY Age


--https://17bang.ren/Article/441
--作业
--新建表Message(Id, FromUser, ToUser, UrgentLevel, Kind, HasRead, IsDelete, Content)，使用该表和SQL语句，证明：
DROP TABLE IF EXISTS [Message]

CREATE TABLE [Message](
Id INT ,--NOT NULL IDENTITY(1,1) PRIMARY KEY,
FromUser NVARCHAR(20),
ToUser varchar(10),
UrgentLevel VARCHAR(10), 
Kind INT,
HasRead INT, 
IsDelete BIT,
Content TEXT
)
SELECT * FROM [Message]

-- [type]：1 聚集; >1 非聚集
SELECT [name], [type], is_unique, is_primary_key, is_unique_constraint --出现在这个表上就说明他是一个索引
FROM sys.indexes 
WHERE object_id = OBJECT_ID('[Message]')

--  唯一约束依赖于唯一索引
ALTER TABLE [Message]  --添加唯一约束，唯一约束后面一定有一个唯一索引
ADD CONSTRAINT UQ_Message_FromUser  UNIQUE([FromUser]) --约束（constraint）

ALTER TABLE [Message]  --删除唯一约束，把唯一约束所依赖的唯一索引一起删掉
DROP CONSTRAINT UQ_Message_FromUser 

--  主键上可以是非聚集（clustered）索引
CREATE CLUSTERED INDEX  IX_Message_FromUser ON [Message](FromUser) --创建聚集索引

ALTER TABLE [Message] --添加id不能为null
ALTER COLUMN Id INT NOT NULL

ALTER TABLE [Message] ADD CONSTRAINT PK_Message_Id PRIMARY KEY(Id)  --添加主键约束
--加一个主键约束一定非加一个唯一索引（是否聚集，前面表里面是否有聚集索引，有就是非聚集唯一索引，反之就是聚集唯一索引）

--并利用“执行计划”图演示说明：Scan、Seek和Lookup的使用和区别。







--https://17bang.ren/Article/667
--作业
--1.观察并模拟17bang项目中的：
--   用户资料，新建用户资料（Profile）表，和User形成1:1关联（有无约束？）。用SQL语句演示：
SELECT * FROM [User]
SELECT * FROM [Profile]

DROP TABLE [Profile]

CREATE TABLE [Profile](
Id INT NOT NULL  PRIMARY KEY,
Gegder BIT,
BirthYear INT,
BirthMonth INT,
BirthConstellation NVARCHAR(10),
Keyword VARCHAR(50),
Maselfd NVARCHAR(500)
);
INSERT [Profile] VALUES(1,1,1999,1,N'双子座', N'JAVA', N'自我介绍')
INSERT [Profile] VALUES(2,1,1991,1,N'狮子座', N'SQL', N'自我介绍')
INSERT [Profile] VALUES(3,1,1991,1,N'白羊座', N'HTML', N'自我介绍')
INSERT [Profile] VALUES(4,1,1991,1,N'双鱼座', N'C#', N'自我介绍')
INSERT [Profile] VALUES(5,1,1991,1,N'金牛座', N'MVC', N'自我介绍')

ALTER TABLE [User]--添加新列
ADD  [ProfileId] INT
--DROP COLUMN [ProfileId]--删除列

ALTER TABLE [User]--在ProfileId上添加唯一约束
ADD CONSTRAINT  UQ_User_ProfileId UNIQUE(ProfileId)
--DROP CONSTRAINT UQ_UserName--删除唯一约束


ALTER TABLE [User]
--DROP CONSTRAINT FK_Profile_Id
DROP COLUMN [ProfileId]



ALTER TABLE [User]--添加外键约束
ADD CONSTRAINT FK_Profile_Id FOREIGN KEY(ProfileId) REFERENCES [Profile](Id)

DELETE  [User] WHERE ID=6 --删除某个

UPDATE [User] SET [ProfileId]=1 WHERE ID=1--更新数据
UPDATE [User] SET [ProfileId]=2 WHERE ID=2--更新数据
UPDATE [User] SET [ProfileId]=3 WHERE ID=3--更新数据
UPDATE [User] SET [ProfileId]=4 WHERE ID=4--更新数据

UPDATE [User] SET [ProfileId]=4 WHERE ID=9--更新数据,因为有唯一约束不能添加

--   新建一个填写了用户资料的注册用户
INSERT [User](Username,[Password]) VALUES(N'小夏',1212)--添加一个新用户
UPDATE [User] SET [ProfileId]=5 WHERE ID=10--更新数据

--   通过Id查找获得某注册用户及其用户资料
SELECT * FROM [User] WHERE ID=2
--   删除某个Id的注册用户
DELETE [Profile] WHERE ID =1
DELETE [User] WHERE ID= 1

--2.帮帮点说明：新建Credit表，可以记录用户的每一次积分获得过程，即：某个用户，在某个时间，因为某某原因，获得若干积分 
CREATE TABLE Credit(
ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
[UserId] INT  CONSTRAINT FK_User_UserId FOREIGN KEY REFERENCES [User](Id),
[Time] DATETIME,
Cause NVARCHAR(200),
Integral INT
)
SELECT * FROM Credit
--3.发布求助，在Problem和User之间建立1:n关联（含约束）。用SQL语句演示：

SELECT * FROM Problem
SELECT * FROM [User]

ALTER TABLE Problem  --新建UserId列
ADD UserId INT

ALTER TABLE Problem --添加外键约束
ADD CONSTRAINT PK_User_ID FOREIGN KEY(UserId) REFERENCES [User](Id)

--   某用户发布一篇求助，

INSERT Problem VALUES(15,N'求助','12',1,11,'2021/3/23',N'啊哈',1)
INSERT Problem VALUES(16,N'求助','12',1,11,'2021/3/23',N'啊哈',2)
INSERT Problem VALUES(17,N'求助','12',1,11,'2021/3/23',N'啊哈',3)
INSERT Problem VALUES(18,N'求助','12',1,11,'2021/3/23',N'啊哈',4)
INSERT Problem VALUES(19,N'求助','12',1,11,'2021/3/23',N'啊哈',10)
INSERT Problem VALUES(20,N'求助','12',1,11,'2021/3/23',N'啊哈',10)

--   将该求助的作者改成另外一个用户
UPDATE Problem SET UserId = 4 WHERE ID=16

--   删除该用户
BEGIN TRAN
DELETE Problem WHERE UserId=10
DELETE [User] WHERE ID=10
ROLLBACK

--4.求助列表：新建Keyword表，和Problem形成n:n关联（含约束）。用SQL语句演示：

SELECT * FROM Keyword
SELECT * FROM Problem
SELECT * FROM Keyword2Problem

DROP TABLE IF EXISTS Keyword


CREATE TABLE Keyword(
Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
[Key] NVARCHAR(20)
)

INSERT Keyword VALUES(N'C#')
INSERT Keyword VALUES(N'JAVA')
INSERT Keyword VALUES(N'SQL')
INSERT Keyword VALUES(N'HTML')

CREATE TABLE Keyword2Problem(  --建立关系表（主表）
Id INT IDENTITY(1,1),
KeywordId INT CONSTRAINT FK_Keyword2Problem_KeywordId FOREIGN KEY REFERENCES Keyword(Id),
ProblemId INT CONSTRAINT FK_Keyword2Problem_ProblemId FOREIGN KEY REFERENCES Problem(Id)
)

INSERT Keyword2Problem VALUES(1,2)
INSERT Keyword2Problem VALUES(1,8)
INSERT Keyword2Problem VALUES(2,8)

--   查询获得：某求助使用了多少关键字，某关键字被多少求助使用
SELECT COUNT(KeywordId),KeywordId 
FROM Keyword2Problem WHERE KeywordId=1
GROUP BY KeywordId

--   发布了一个使用了若干个关键字的求助
INSERT Problem VALUES(21,N'哦豁','22',1,44,'2000/2/2',N'小胖',2)
INSERT Keyword2Problem VALUES(4,21)
INSERT Keyword2Problem VALUES(3,21)

--   该求助不再使用某个关键字
BEGIN TRAN
DELETE Keyword2Problem WHERE ProblemId=21 AND KeywordId=3  --删除求助是21且关键字是3的
ROLLBACK

--   删除该求助
BEGIN TRAN
DELETE Keyword2Problem WHERE ProblemId=21
DELETE Keyword WHERE ID=21

--   删除某关键字
BEGIN TRAN
DELETE Keyword2Problem WHERE KeywordId=2
DELETE Keyword WHERE ID=2
ROLLBACK


--https://17bang.ren/Article/458
--作业
--1.联表查出求助的标题和作者用户名
SELECT *FROM [User]
SELECT *FROM Problem

SELECT P.Title,U.Username FROM [User] U 
JOIN Problem P
ON U.ID =P.ID

--2.查找并删除从未发布过求助的用户
SELECT *FROM [User]
SELECT *FROM Problem


SELECT * FROM  [User] U 
LEFT JOIN Problem P ON U.ID =P.ID

BEGIN TRAN
--ALTER TABLE Problem --删除约束
--DROP CONSTRAINT PK_User_ID
DELETE [User] FROM  [User] U  --查出没有发布的人，删除为null的
LEFT JOIN Problem P ON U.ID =P.ID
WHERE P.Title IS NULL
ROLLBACK

--3.用一句SELECT显示出用户和他的邀请人用户名
SELECT A.[UserName],B.[UserName] FROM [User] A JOIN [User] B
ON A.[UserName]=B.[UserName]

--4.17bang的关键字有“一级”“二级”和其他“普通（三）级”的区别：
--   请在表Keyword中添加一个字段，记录这种关系
ALTER TABLE Keyword ADD Relation INT

SELECT *FROM Keyword
INSERT  Keyword VALUES(N'编程开发语言',null)
INSERT  Keyword VALUES(N'工具软件',null)
INSERT  Keyword VALUES(N'CAD',7)
INSERT  Keyword VALUES(N'VS',7)

--   然后用一个SELECT语句查出所有普通关键字的上一级、以及上上一级的关键字名称，比如：
--   点击看大图
SELECT * FROM Keyword K1 LEFT JOIN Keyword K2 ON K1 .Id=K2.Relation 

--5.17bang中除了求助（Problem），还有意见建议（Suggest）和文章（Article），他们都包含Title、Content、PublishTime和Auhthor四个字段，但是：
--   建议和文章没有悬赏（Reward）
--   建议多一个类型：Kind NVARCHAR(20)）
--   文章多一个分类：Category INT）

SELECT * FROM Problem
SELECT * FROM Suggest
SELECT * FROM Article
SELECT * FROM [User]


CREATE TABLE Suggest(
ID INT IDENTITY(1,1) PRIMARY KEY,
Title NVARCHAR(50),
Content NVARCHAR(MAX),
PublishTime  DATETIME,
Kind NVARCHAR(20),
AuhthorId INT CONSTRAINT FK_Suggest_AuhthorId FOREIGN KEY  REFERENCES [User](Id)
)
INSERT Suggest VALUES(N'聚集',N'嗷嗷','2000/2/2',N'蛋糕',10)
INSERT Suggest VALUES(N'聚集',N'嗷嗷','2000/2/2',N'蛋糕',1)
INSERT Suggest VALUES(N'聚集',N'嗷嗷','2000/2/2',N'蛋糕',2)
INSERT Suggest VALUES(N'聚集',N'嗷嗷','2000/2/2',N'蛋糕',3)
INSERT Suggest VALUES(N'聚集',N'嗷嗷','2000/2/2',N'蛋糕',4)


CREATE TABLE Article(
ID INT IDENTITY(1,1) PRIMARY KEY,
Title NVARCHAR(50),
Content NVARCHAR(MAX),
PublishTime  DATETIME,
Category INT,
AuhthorId INT CONSTRAINT FK_Article_AuhthorId FOREIGN KEY  REFERENCES [User](Id)
)
INSERT Article VALUES(N'聚集',N'嗷嗷','2000/2/2',11,1)
INSERT Article VALUES(N'聚集',N'嗷嗷','2000/2/2',11,2)
INSERT Article VALUES(N'聚集',N'嗷嗷','2000/2/2',11,3)
INSERT Article VALUES(N'聚集',N'嗷嗷','2000/2/2',11,4)
INSERT Article VALUES(N'聚集',N'嗷嗷','2000/2/2',11,10)

--请按上述描述建表。然后，用一个SQL语句显示某用户发表的求助、建议和文章的Title、Content，并按PublishTime降序排列

SELECT A.Title,A.Content,A.PublishTime FROM Article A JOIN [User] U ON A.AuhthorId=U.ID 
UNION
SELECT S.Title,S.Content,S.PublishTime FROM Suggest S JOIN [User] U ON S.AuhthorId=U.ID 
UNION
SELECT P.Title,P.Content,P.PublishTime FROM Problem P JOIN [User] U ON P.UserId=U.ID 

--https://17bang.ren/Article/457
--作业：
--为求助添加一个发布时间（TPublishTime），使用子查询：
SELECT * FROM Problem

--1.删除每个作者悬赏最低的求助
BEGIN TRAN 
DELETE Problem WHERE Reward IN(
SELECT  MIN(Reward) FROM Problem 
--WHERE  PL.UserId = UserId
GROUP BY Author
)

BEGIN TRAN 
DELETE Problem WHERE ID IN(
  SELECT ID FROM Problem OP WHERE ID=(
  SELECT  MIN(Reward) FROM Problem [IP]
WHERE OP.UserId=[IP].UserId
))
SELECT * FROM Problem


DROP TABLE Keyword2Problem

ROLLBACK
--2.找到从未成为邀请人的用户
SELECT *FROM  [User] WHERE ID NOT IN(
SELECT InvitedBy FROM [User]
WHERE InvitedBy IS NOT NULL
)


--3.如果一篇求助的关键字大于3个，将它的悬赏值翻倍

BEGIN TRAN 
update problem set Reward=Reward*2 where id IN
(select ProblemId from Keyword2Problem group by ProblemId having COUNT(*)>=3)

ROLLBACK
SELECT * FROM Keyword2Problem

--4.查出所有发布一篇以上（不含一篇）文章的用户信息
SELECT * FROM Problem
SELECT * FROM Article
SELECT * FROM [User]


SELECT * FROM [User]
WHERE ID IN(
SELECT AuthorID from Article  group by AuthorID having COUNT(*)>1
)


--5.查找每个作者最近发布的一篇文章
SELECT * FROM Problem WHERE PublishTime =(
SELECT MAX(PublishTime)  FROM Problem 
)

--6.查出每一篇求助的悬赏都大于5个帮帮币的作者
SELECT Author, Reward FROM Problem WHERE Reward  IN(
SELECT Reward FROM Problem WHERE Reward>5
)




--https://17bang.ren/Article/464
--作业（表表达式）
--分别使用派生表和CTE，查询求助表（表中只有一列整体的发布时间，没有年月的列），以获得：
--1.一起帮每月各发布了求助多少篇
SELECT *,Month(PublishTime)AS PMonth,Year(PublishTime)AS PYear FROM Problem  ORDER BY PMonth,PYear

SELECT * FROM  Problem
GO
WITH MP
AS( 
SELECT *,Month(PublishTime)AS PMonthr FROM Problem
)
SELECT COUNT(*),PMonthr FROM MP GROUP BY MP.PMonthr


--2.每月发布的求助中，悬赏最多的3篇
SELECT TOP 3 * FROM Problem 
WHERE Id NOT IN ( 
    SELECT TOP 3 Id FROM Problem ORDER BY Reward ) 
ORDER BY Reward DESC



--3.每个作者，每月发布的，悬赏最多的3篇
GO
WITH MP
AS( 
SELECT *,Month(PublishTime)AS PMonth,Year(PublishTime)AS PYear FROM Problem
)
SELECT * FROM (
SELECT ROW_NUMBER() 
OVER(PARTITION BY Author,PMonth,PYear ORDER BY Reward DESC
)AS TI,
* FROM MP)
 as TIT where TIT.TI <=3
 SELECT *FROM Problem


--4.分别按发布时间和悬赏数量进行分页查询的结果

SELECT * FROM (
 SELECT ROW_NUMBER() OVER(ORDER BY PublishTime)PT,
 * FROM Problem
)PO
WHERE PO.PT BETWEEN 2 AND 6
GO
SELECT * FROM Problem ORDER BY Reward 
OFFSET 2 ROWS -- 略过6行  
FETCH NEXT 6 ROWS ONLY -- 取其后的3行


--作业：
--尽可能多的写出“查找每个用户关键字最多的求助” 的SQL语句，利用执行计划，找出效率最高的一个。

--https://17bang.ren/Article/462
--作业（视图）
--1.创建求助的应答表 TResponse(Id, Content, AuthorId, ProblemId, CreateTime)
CREATE TABLE TResponse(
Id INT IDENTITY PRIMARY KEY, 
Content  NVARCHAR(500),
AuthorId INT, 
ProblemId INT , 
CreateTime DATETIME
)
SELECT * FROM TResponse
SELECT * FROM [User]
SELECT * FROM Problem

--2.然后生成一个视图VResponse(ResponseId, Content, AuthorId, AuthorName, ProblemId, ProblemTitle, CreateTime)，要求该视图：
--   能展示应答作者的用户名、应答对应求助的标题和作者用户名
--   只显示求助悬赏值大于5的数据
--   已被加密
--   保证其使用的基表结构无法更改

GO
CREATE VIEW VResponse--(ResponseId, Content, AuthorId, AuthorName, ProblemId, ProblemTitle, CreateTime)
WITH SCHEMABINDING , ENCRYPTION
AS 
SELECT 
TR.Id TResponseId,
TR.Content Content,
TR.AuthorId TResponseAuthorId,
TRU.Username  TResponseAuthorName,
TR.ProblemId ProblemId ,
TPU.Username  TProblemAuthorName,
TP.Title ProblemTitle,
TR.CreateTime CreateTime
FROM dbo.TResponse TR  
JOIN dbo.Problem TP ON TR.ProblemId=TP.Id
JOIN dbo.[User] TRU ON TR.AuthorId=TRU.Id
JOIN dbo.[User] TPU  ON TP.Id=TPU.Id
WHERE TP.Reward>5
WITH CHECK OPTION



GO
SELECT * FROM VResponse
SELECT * FROM TResponse
SELECT * FROM [User]
SELECT * FROM Problem
GO
DROP VIEW VResponse

--3.演示：在VResponse中插入一条数据，却不能在视图中显示

INSERT VResponse(ResponseId, Content, AuthorId, AuthorName, ProblemId, ProblemTitle, CreateTime) VALUES(1,N'给',3,9,'2021年3月27日')
--4.修改VResponse，让其能避免上述情形
GO
ALTER VIEW VResponse
WITH SCHEMABINDING 
AS SELECT Id, [Name], Enroll, Score, Age 
FROM dbo.Student 
WHERE Score > 60 
WITH CHECK OPTION -- 添加到WHERE子句之后

--5.创建视图VProblemKeyword(ProblemId, ProblemTitle, ProblemReward, KeywordAmount)，要求该视图：
--   能反映求助的标题、使用关键字数量和悬赏
--   在ProblemId上有一个唯一聚集索引
--   在ProblemReward上有一个非聚集索引
GO
CREATE VIEW VProblemKeyword(ProblemId, ProblemTitle, ProblemReward, KeywordAmount)
WITH SCHEMABINDING
AS
SELECT  P.ID,P.Title,P.Reward,COUNT_BIG(*)
FROM dbo.Keyword2Problem KP
JOIN dbo.Problem P ON P.Id=KP.

GO
CREATE UNIQUE CLUSTERED INDEX IX_ProblemId ON VProblemKeyword(ProblemId)
CREATE UNIQUE INDEX IX_ProblemReward ON VProblemKeyword(ProblemReward)

DROP TABLE VProblemKeyword

SELECT * FROM Problem
SELECT * FROM VProblemKeyword

--6.在基表中插入/删除数据，观察VProblemKeyword是否相应的发生变化



--https://17bang.ren/Article/449
--作业：（事务和异常）
--用户发布一篇悬赏币若干的求助（TProblem），他（TReigister）的帮帮币（BMoney）也会相应减少，但他的帮帮币总额不能少于0分：
--请综合使用TRY...CATCH和事务完成上述需求。

--https://17bang.ren/Article/473
--作业：（锁）
--重复演示各种并发问题，解释/显示锁能否应对上述问题。

--作业：
--利用图和SQL语句演示 READ COMMITTED 和 SERIALIZABLE 存在的和可避免的问题。参考图：

--思考题：游戏买装备
--比如只有100个游戏币，装备30个游戏币一套。
--恶意用户利用软件，瞬间向服务器发送无数条购买装备的请求。
--结果就真的到手了n多装备，这是怎么一回事呢？

--https://17bang.ren/Article/450
--作业：
--1.打印如下所示的等腰三角形： 
--      1

--    333

--  55555

--7777777

--2.TProblem中：
--   找出所有周末发布的求助（添加CreateTime列，如果还没有的话）
--   找出每个作者所有求助悬赏的平均值，精确到小数点后两位
--   有一些标题以test、[test]后者Test-开头的求助，找打他们并把这些前缀都换成大写
--3.定义一个函数RANDINT(INT max)，可以取0-max之间的最大值

--作业：
--1.检查用户名是否重复。如果重复，返回错误代码：1
--2.检查用户名密码是否符合“长度不小于4位”的要求。如果不符合，返回错误代码：2
--3.如果有邀请人：
--   检查邀请人是否存在，如果不存在，返回错误代码：10
--   检查邀请码是否正确，如果邀请码不正确，返回错误代码：11
--4.将用户名、密码和邀请人存入数据库（TRegister）
--5.给邀请人增加10个帮帮点积分
--6.通知邀请人（TMessage中生成一条数据）某人使用了他作为邀请人。
