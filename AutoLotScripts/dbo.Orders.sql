CREATE TABLE [dbo].[Orders] (
    [OrderID] INT IDENTITY (1, 1) NOT NULL,
    [CustID]  INT NOT NULL,
    [CarID]   INT NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderID] ASC)
);