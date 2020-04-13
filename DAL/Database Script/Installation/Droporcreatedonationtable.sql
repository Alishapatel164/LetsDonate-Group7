USE [Contact]
GO

/****** Object: Table [dbo].[Donate] Script Date: 2020-04-13 6:14:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Donate];


GO
CREATE TABLE [dbo].[Donate] (
    [Organization] VARCHAR (50)  NULL,
    [Donar_name]   VARCHAR (50)  NULL,
    [Address]      VARCHAR (250) NULL,
    [City]         VARCHAR (50)  NULL,
    [Contact_no]   BIGINT        NULL,
    [Email_id]     VARCHAR (50)  NULL,
    [Amount]       INT           NULL,
    [Our_Org]      VARCHAR (5)   NULL
);


