CREATE TABLE [dbo].[Emails] (
    [Id]     INT            NOT NULL,
    [Email] NVARCHAR (MAX) NOT NULL,
    [Name]   NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Email_Id] PRIMARY KEY CLUSTERED ([Id] ASC)
);

