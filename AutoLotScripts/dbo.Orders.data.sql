TRUNCATE TABLE dbo.Orders;
CREATE TABLE [dbo].[Orders] (
    [OrderID] INT IDENTITY (1, 1) NOT NULL,
    [CustID]  INT NOT NULL,
    [CarID]   INT NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderID] ASC)
);

SET IDENTITY_INSERT [dbo].[Orders] ON
INSERT INTO [dbo].[Orders] ([OrderID], [CustID], [CarID]) VALUES (1, 5, 3)
INSERT INTO [dbo].[Orders] ([OrderID], [CustID], [CarID]) VALUES (2, 2, 8)
INSERT INTO [dbo].[Orders] ([OrderID], [CustID], [CarID]) VALUES (3, 7, 6)
INSERT INTO [dbo].[Orders] ([OrderID], [CustID], [CarID]) VALUES (4, 4, 9)
INSERT INTO [dbo].[Orders] ([OrderID], [CustID], [CarID]) VALUES (5, 12, 5)
INSERT INTO [dbo].[Orders] ([OrderID], [CustID], [CarID]) VALUES (6, 1, 13)
INSERT INTO [dbo].[Orders] ([OrderID], [CustID], [CarID]) VALUES (7, 4, 10)
INSERT INTO [dbo].[Orders] ([OrderID], [CustID], [CarID]) VALUES (8, 8, 7)
SET IDENTITY_INSERT [dbo].[Orders] OFF
