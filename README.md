# TesteSebrae

Criar no banco de dados:

CREATE TABLE [dbo].[Conta] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Nome]      VARCHAR (100) NOT NULL,
    [Descricao] VARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

