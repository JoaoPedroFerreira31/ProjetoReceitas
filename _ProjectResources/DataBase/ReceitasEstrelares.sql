USE [master]
GO
/****** Object:  Database [ReceitasEstrelares]    Script Date: 22/11/2020 15:59:51 ******/
CREATE DATABASE [ReceitasEstrelares]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ReceitasEstrelares', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ReceitasEstrelares.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ReceitasEstrelares_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ReceitasEstrelares_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ReceitasEstrelares] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ReceitasEstrelares].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ReceitasEstrelares] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET ARITHABORT OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ReceitasEstrelares] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ReceitasEstrelares] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ReceitasEstrelares] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ReceitasEstrelares] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ReceitasEstrelares] SET  MULTI_USER 
GO
ALTER DATABASE [ReceitasEstrelares] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ReceitasEstrelares] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ReceitasEstrelares] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ReceitasEstrelares] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ReceitasEstrelares] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ReceitasEstrelares] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ReceitasEstrelares] SET QUERY_STORE = OFF
GO
USE [ReceitasEstrelares]
GO
/****** Object:  Table [dbo].[Account_tbl]    Script Date: 22/11/2020 15:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account_tbl](
	[IdAccount] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](25) NOT NULL,
	[Password] [nvarchar](16) NOT NULL,
	[IdUser] [int] NULL,
 CONSTRAINT [PK_Account_tbl] PRIMARY KEY CLUSTERED 
(
	[IdAccount] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category_tbl]    Script Date: 22/11/2020 15:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category_tbl](
	[IdCategory] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](120) NOT NULL,
 CONSTRAINT [PK_Category_tbl] PRIMARY KEY CLUSTERED 
(
	[IdCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comments_tbl]    Script Date: 22/11/2020 15:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments_tbl](
	[IdComment] [int] IDENTITY(1,1) NOT NULL,
	[Comment] [nvarchar](150) NOT NULL,
	[Date] [datetime] NOT NULL,
	[IdRecipe] [int] NOT NULL,
	[IdUser] [int] NOT NULL,
 CONSTRAINT [PK_Comments_tbl] PRIMARY KEY CLUSTERED 
(
	[IdComment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingredients_tbl]    Script Date: 22/11/2020 15:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredients_tbl](
	[IdIngredient] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Unit] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Ingredients_tbl] PRIMARY KEY CLUSTERED 
(
	[IdIngredient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ratings_tbl]    Script Date: 22/11/2020 15:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ratings_tbl](
	[IdUser] [int] NOT NULL,
	[IdRecipe] [int] NOT NULL,
	[Rating] [tinyint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecipeIngredient_tbl]    Script Date: 22/11/2020 15:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecipeIngredient_tbl](
	[IdRecipe] [int] NOT NULL,
	[IdIngredient] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recipes_tbl]    Script Date: 22/11/2020 15:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recipes_tbl](
	[IdRecipe] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](120) NOT NULL,
	[Description] [nvarchar](250) NOT NULL,
	[Duration] [time](7) NOT NULL,
	[Difficulty] [int] NOT NULL,
	[IdRating] [int] NULL,
	[IsValidated] [real] NOT NULL,
	[IdCategory] [int] NOT NULL,
	[IdUser] [int] NOT NULL,
 CONSTRAINT [PK_Recipes_tbl] PRIMARY KEY CLUSTERED 
(
	[IdRecipe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_tbl]    Script Date: 22/11/2020 15:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_tbl](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Gender] [tinyint] NULL,
	[Email] [nvarchar](150) NOT NULL,
	[IdAccount] [int] NULL,
	[IdRecipe] [int] NULL,
	[IsAdmin] [real] NULL,
	[Blocked] [real] NULL,
 CONSTRAINT [PK_Users_tbl] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Users_tbl] UNIQUE NONCLUSTERED 
(
	[IdAccount] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Comments_tbl]  WITH CHECK ADD  CONSTRAINT [FK_Comments_tbl_Recipes_tbl] FOREIGN KEY([IdRecipe])
REFERENCES [dbo].[Recipes_tbl] ([IdRecipe])
GO
ALTER TABLE [dbo].[Comments_tbl] CHECK CONSTRAINT [FK_Comments_tbl_Recipes_tbl]
GO
ALTER TABLE [dbo].[Comments_tbl]  WITH CHECK ADD  CONSTRAINT [FK_Comments_tbl_Users_tbl] FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users_tbl] ([IdUser])
GO
ALTER TABLE [dbo].[Comments_tbl] CHECK CONSTRAINT [FK_Comments_tbl_Users_tbl]
GO
ALTER TABLE [dbo].[Ratings_tbl]  WITH CHECK ADD  CONSTRAINT [FK_Ratings_tbl_Recipes_tbl] FOREIGN KEY([IdRecipe])
REFERENCES [dbo].[Recipes_tbl] ([IdRecipe])
GO
ALTER TABLE [dbo].[Ratings_tbl] CHECK CONSTRAINT [FK_Ratings_tbl_Recipes_tbl]
GO
ALTER TABLE [dbo].[Ratings_tbl]  WITH CHECK ADD  CONSTRAINT [FK_Ratings_tbl_Users_tbl] FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users_tbl] ([IdUser])
GO
ALTER TABLE [dbo].[Ratings_tbl] CHECK CONSTRAINT [FK_Ratings_tbl_Users_tbl]
GO
ALTER TABLE [dbo].[RecipeIngredient_tbl]  WITH CHECK ADD  CONSTRAINT [FK_RecipeIngredient_tbl_Ingredients_tbl] FOREIGN KEY([IdIngredient])
REFERENCES [dbo].[Ingredients_tbl] ([IdIngredient])
GO
ALTER TABLE [dbo].[RecipeIngredient_tbl] CHECK CONSTRAINT [FK_RecipeIngredient_tbl_Ingredients_tbl]
GO
ALTER TABLE [dbo].[RecipeIngredient_tbl]  WITH CHECK ADD  CONSTRAINT [FK_RecipeIngredient_tbl_Recipes_tbl] FOREIGN KEY([IdRecipe])
REFERENCES [dbo].[Recipes_tbl] ([IdRecipe])
GO
ALTER TABLE [dbo].[RecipeIngredient_tbl] CHECK CONSTRAINT [FK_RecipeIngredient_tbl_Recipes_tbl]
GO
ALTER TABLE [dbo].[Recipes_tbl]  WITH CHECK ADD  CONSTRAINT [FK_Recipes_tbl_Category_tbl] FOREIGN KEY([IdCategory])
REFERENCES [dbo].[Category_tbl] ([IdCategory])
GO
ALTER TABLE [dbo].[Recipes_tbl] CHECK CONSTRAINT [FK_Recipes_tbl_Category_tbl]
GO
ALTER TABLE [dbo].[Recipes_tbl]  WITH CHECK ADD  CONSTRAINT [FK_Recipes_tbl_Users_tbl] FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users_tbl] ([IdUser])
GO
ALTER TABLE [dbo].[Recipes_tbl] CHECK CONSTRAINT [FK_Recipes_tbl_Users_tbl]
GO
/****** Object:  StoredProcedure [dbo].[spInsertUsers]    Script Date: 22/11/2020 15:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertUsers]
@FirstName nvarchar(100),
@LastName nvarchar(100),
@BirthDate date,
@Gender tinyInt,
@Email nvarchar(150),
@IsAdmin real,
@Blocked real  
AS
BEGIN
INSERT INTO Users_tbl (FirstName, LastName, BirthDate, Gender, Email, IsAdmin, Blocked ) 
VALUES (@FirstName, @LastName, @BirthDate, @Gender, @Email, @IsAdmin, @Blocked) 
SELECT cast(SCOPE_IDENTITY() as int);
END;
GO
/****** Object:  StoredProcedure [dbo].[spReadAccounts]    Script Date: 22/11/2020 15:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadAccounts] 
AS
SELECT * FROM Account_tbl
GO;
GO
/****** Object:  StoredProcedure [dbo].[spReadRecipes]    Script Date: 22/11/2020 15:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadRecipes]
AS
SELECT * FROM Recipes_tbl
GO;
GO
/****** Object:  StoredProcedure [dbo].[spReadRecipesById]    Script Date: 22/11/2020 15:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadRecipesById]
@IdRecipe int
AS
BEGIN
SELECT * FROM Recipes_tbl WHERE IdRecipe = @IdRecipe; 
END;
GO
/****** Object:  StoredProcedure [dbo].[spReadRecipesByUsersId]    Script Date: 22/11/2020 15:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadRecipesByUsersId]
@IdUser int
AS
BEGIN
SELECT * FROM Recipes_tbl WHERE IdUser = @IdUser;
END;
GO
/****** Object:  StoredProcedure [dbo].[spReadUser]    Script Date: 22/11/2020 15:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadUser]
AS
	SELECT * FROM Users_tbl
GO;
GO
/****** Object:  StoredProcedure [dbo].[spReadUsersById]    Script Date: 22/11/2020 15:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadUsersById] 
@IdUser int
AS
BEGIN
SELECT * FROM Users_tbl WHERE IdUser = @IdUser;
END;
GO
USE [master]
GO
ALTER DATABASE [ReceitasEstrelares] SET  READ_WRITE 
GO
