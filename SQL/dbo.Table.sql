CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NCHAR(50) NULL,
	[LastName] NCHAR(50) NULL,
	[Email] NCHAR(10) NULL,
	[Password]	NCHAR(50) NULL
)
