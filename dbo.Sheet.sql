CREATE TABLE [dbo].[Sheet] (
    [ID]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX)  NULL,
    [Date]        DATETIME2 (7)   NOT NULL,
    [Time]        DATETIME2 (7)   NOT NULL,
    [Temperature] DECIMAL (18, 2) NOT NULL,
    [Sex]         NVARCHAR (MAX)  NULL,
    [Address]     NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_Sheet] PRIMARY KEY CLUSTERED ([ID] ASC)
);

