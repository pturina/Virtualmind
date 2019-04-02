
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/01/2019 22:02:53
-- Generated from EDMX file: F:\Repositorios\Virtualmind\TestGenérico\TestGenérico\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TestGenerico];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- INSERT

INSERT INTO dbo.UserSet(Nombre, Apellido, Email, [Password])
VALUES 
('Raul','Gomez','rgomez@gmail.com','1568152'),
('Rodolfo','Sanchez','rsanchez@gmail.com','1563213'),
('Alberto','Perez','aperez@gmail.com','11351423'),
('Silvia','Castro','scastro@gmail.com','1535132'),
('Marta','Gonzalez','mgonzalez@gmail.com','84563'),
('Alex','Jones','ajones@gmail.com','65781'),
('Jose','Gimenez','jgimenez@gmail.com','518625'),
('Ana','Rodriguez','arodriguez@gmail.com','89132'),
('Dario','Ramirez','dramirez@gmail.com','68432'),
('Daniela','Garcia','dgarcia@gmail.com','8232135'),
('Pedro','Salazar','psalazar@gmail.com','41538'),
('Barbara','Zapiola','bzapiola@gmail.com','234825'),
('Lucas','Molina','lmolina@gmail.com','35485'),
('Jesica','Ponce','jponce@gmail.com','756135'),
('Marcelo','Bustamante','mbustamante@gmail.com','9513215'),
('Marcos','Mendez','mmendez@gmail.com','515682'),
('Juan','Alvear','jalvear@gmail.com','35135'),
('Maria','Alvarez','malvarez@gmail.com','521385')

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------