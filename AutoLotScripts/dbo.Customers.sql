CREATE TABLE [dbo].[Customers] (
    [CustID]    INT  IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (25) NOT NULL,
    [LastName]  VARCHAR (25) NOT NULL,
    PRIMARY KEY CLUSTERED ([CustID] ASC)
);

