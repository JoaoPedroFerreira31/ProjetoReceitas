USE [master]
GO
/****** Object:  Database [JoaoPedro_ReceitasEstrelares]    Script Date: 08/12/2020 00:30:43 ******/
CREATE DATABASE [JoaoPedro_ReceitasEstrelares]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ReceitasEstrelares', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ReceitasEstrelares.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ReceitasEstrelares_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ReceitasEstrelares_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JoaoPedro_ReceitasEstrelares].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET ARITHABORT OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET  MULTI_USER 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET QUERY_STORE = OFF
GO
USE [JoaoPedro_ReceitasEstrelares]
GO
/****** Object:  Table [dbo].[Account_tbl]    Script Date: 08/12/2020 00:30:44 ******/
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
/****** Object:  Table [dbo].[Comments_tbl]    Script Date: 08/12/2020 00:30:44 ******/
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
/****** Object:  Table [dbo].[Ingredients_tbl]    Script Date: 08/12/2020 00:30:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredients_tbl](
	[IdIngredient] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Quantity] [int] NULL,
	[Unit] [nvarchar](100) NULL,
 CONSTRAINT [PK_Ingredients_tbl] PRIMARY KEY CLUSTERED 
(
	[IdIngredient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ratings_tbl]    Script Date: 08/12/2020 00:30:44 ******/
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
/****** Object:  Table [dbo].[RecipeIngredient_tbl]    Script Date: 08/12/2020 00:30:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecipeIngredient_tbl](
	[IdRecipe] [int] NOT NULL,
	[IdIngredient] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recipes_tbl]    Script Date: 08/12/2020 00:30:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recipes_tbl](
	[IdRecipe] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](120) NOT NULL,
	[Description] [nvarchar](250) NOT NULL,
	[Duration] [time](7) NOT NULL,
	[Difficulty] [tinyint] NOT NULL,
	[IdRating] [tinyint] NULL,
	[IsValidated] [bit] NOT NULL,
	[Category] [tinyint] NOT NULL,
	[IdUser] [int] NOT NULL,
 CONSTRAINT [PK_Recipes_tbl] PRIMARY KEY CLUSTERED 
(
	[IdRecipe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_tbl]    Script Date: 08/12/2020 00:30:44 ******/
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
	[IsAdmin] [bit] NULL,
	[Blocked] [bit] NULL,
	[MembershipUsername] [nvarchar](150) NULL,
 CONSTRAINT [PK_IdUser] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account_tbl] ON 

INSERT [dbo].[Account_tbl] ([IdAccount], [Username], [Password], [IdUser]) VALUES (1, N'TesteAccount', N'Password', NULL)
INSERT [dbo].[Account_tbl] ([IdAccount], [Username], [Password], [IdUser]) VALUES (2, N'TesteAccount', N'Password', NULL)
INSERT [dbo].[Account_tbl] ([IdAccount], [Username], [Password], [IdUser]) VALUES (3, N'TesteAccount', N'Password', NULL)
INSERT [dbo].[Account_tbl] ([IdAccount], [Username], [Password], [IdUser]) VALUES (4, N'TesteAccount5', N'Password', NULL)
INSERT [dbo].[Account_tbl] ([IdAccount], [Username], [Password], [IdUser]) VALUES (5, N'TesteAccount5', N'Password', NULL)
INSERT [dbo].[Account_tbl] ([IdAccount], [Username], [Password], [IdUser]) VALUES (6, N'username', N'password', 43)
INSERT [dbo].[Account_tbl] ([IdAccount], [Username], [Password], [IdUser]) VALUES (7, N'naosouadmin', N'1234', 44)
INSERT [dbo].[Account_tbl] ([IdAccount], [Username], [Password], [IdUser]) VALUES (8, N'adminwindows', N'1234', 45)
SET IDENTITY_INSERT [dbo].[Account_tbl] OFF
GO
SET IDENTITY_INSERT [dbo].[Ingredients_tbl] ON 

INSERT [dbo].[Ingredients_tbl] ([IdIngredient], [Name], [Quantity], [Unit]) VALUES (1, N'Ovos', 0, NULL)
SET IDENTITY_INSERT [dbo].[Ingredients_tbl] OFF
GO
SET IDENTITY_INSERT [dbo].[Recipes_tbl] ON 

INSERT [dbo].[Recipes_tbl] ([IdRecipe], [Name], [Description], [Duration], [Difficulty], [IdRating], [IsValidated], [Category], [IdUser]) VALUES (2, N'Teste', N'khadjggagsjhgjsa', CAST(N'06:15:20' AS Time), 2, 5, 0, 3, 36)
INSERT [dbo].[Recipes_tbl] ([IdRecipe], [Name], [Description], [Duration], [Difficulty], [IdRating], [IsValidated], [Category], [IdUser]) VALUES (3, N'Bolo', N'khadjggagsjhgjsa', CAST(N'06:15:20' AS Time), 2, 5, 0, 3, 36)
SET IDENTITY_INSERT [dbo].[Recipes_tbl] OFF
GO
SET IDENTITY_INSERT [dbo].[Users_tbl] ON 

INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (24, N'Marco', N'Filipe', CAST(N'1962-07-22' AS Date), 1, N'Exemplo@exemplo.pt', 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (28, N'Maria', N'Do Carmo', CAST(N'1976-03-02' AS Date), 2, N'Exemplo@exemplo.pt', 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (29, N'Manuel', N'Mendonça', CAST(N'1963-06-16' AS Date), 1, N'exemplo@exemplo.pt', NULL, NULL, 0, 0, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (36, N'João Pedro', N'Ferreira', CAST(N'2001-10-31' AS Date), NULL, N'jpmferreira31@exemplo.pt', NULL, NULL, 1, NULL, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (37, N'Liliana', N'Marques', CAST(N'2000-12-08' AS Date), 2, N'exemplo@exemplo.pt', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (38, N'Jorge', N'Marques', CAST(N'1997-02-24' AS Date), 1, N'exemplo@exemplo.pt', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (39, N'Miguel', N'Cabral', CAST(N'1986-02-04' AS Date), 1, N'exemplo@exemplo.pt', NULL, NULL, 1, NULL, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (40, N'Diogo', N'Pinto', CAST(N'1977-08-03' AS Date), 1, N'exemplo@exemplo.pt', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (41, N'Diogo', N'Pinto', CAST(N'1977-08-03' AS Date), 1, N'exemplo@exemplo.pt', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (42, N'Ruben', N'Sousa', CAST(N'1987-08-16' AS Date), 1, N'exemplo@exemplo.pt', NULL, NULL, 1, NULL, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (43, N'TesteWindows', N'Forms', CAST(N'2020-11-29' AS Date), 1, N'teste@teste.com', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (44, N'windows', N'forms', CAST(N'2020-11-29' AS Date), 3, N'teste@teste.pt', NULL, NULL, 0, NULL, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (45, N'Admin', N'WindowsForms', CAST(N'2020-11-29' AS Date), 1, N'teste@teste.pt', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (46, N'TesteAndre', N'Teste', CAST(N'2020-12-06' AS Date), 1, N'Exemplo@exemplo.com', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (47, N'TesteAndre', N'pedro', CAST(N'2019-08-31' AS Date), 1, N'Exemplo@exemplo.com', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (48, N'TesteCompletoUser', N'Teste', CAST(N'2020-12-31' AS Date), 3, N'teste@teste.pt', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Users_tbl] ([IdUser], [FirstName], [LastName], [BirthDate], [Gender], [Email], [IdAccount], [IdRecipe], [IsAdmin], [Blocked], [MembershipUsername]) VALUES (49, N'TesteCompletoUser2', N'DeVez', CAST(N'2020-05-21' AS Date), 3, N'TesteDeVEZ@email.com', NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Users_tbl] OFF
GO
/****** Object:  Index [UQ_IdUser]    Script Date: 08/12/2020 00:30:45 ******/
ALTER TABLE [dbo].[Users_tbl] ADD  CONSTRAINT [UQ_IdUser] UNIQUE NONCLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
ALTER TABLE [dbo].[Recipes_tbl]  WITH CHECK ADD  CONSTRAINT [FK_Recipes_tbl_Users_tbl] FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users_tbl] ([IdUser])
GO
ALTER TABLE [dbo].[Recipes_tbl] CHECK CONSTRAINT [FK_Recipes_tbl_Users_tbl]
GO
/****** Object:  StoredProcedure [dbo].[spGetLoggedInUser]    Script Date: 08/12/2020 00:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetLoggedInUser]
@MembershipUsername nvarchar(150)
AS
BEGIN
SELECT * FROM Users_tbl WHERE MembershipUsername = @MembershipUsername
END;
GO
/****** Object:  StoredProcedure [dbo].[spInsertAccounts]    Script Date: 08/12/2020 00:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertAccounts]
@Username nvarchar(50),
@Password nvarchar(50),
@IdUser int,
@IdAccount int out
as
BEGIN
	INSERT INTO Account_tbl(UserName, Password, IdUser) 
	VALUES (@UserName, @Password, @IdUser)
	SELECT @IdAccount = SCOPE_IDENTITY()
	RETURN @IdAccount
END;
GO
/****** Object:  StoredProcedure [dbo].[spInsertAdmin]    Script Date: 08/12/2020 00:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertAdmin]
@FirstName nvarchar(100),
@LastName nvarchar(100),
@BirthDate datetime,
@Gender tinyInt,
@Email nvarchar(150),
@IsAdmin bit,
@IdUser int output
AS
BEGIN
INSERT INTO Users_tbl (FirstName, LastName, BirthDate, Gender, Email, IsAdmin) 
VALUES (@FirstName, @LastName, @BirthDate, @Gender, @Email, @IsAdmin)
SELECT @IdUser = SCOPE_IDENTITY()
RETURN @IdUser
END;
GO
/****** Object:  StoredProcedure [dbo].[spInsertCategory]    Script Date: 08/12/2020 00:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertCategory]
@IdCategory int output,
@Name varchar(120)
AS
BEGIN
INSERT INTO Category_tbl (Name)
VALUES (@Name)
SELECT @IdCategory = SCOPE_IDENTITY()
RETURN @IdCategory
END;
GO
/****** Object:  StoredProcedure [dbo].[spInsertIngredient]    Script Date: 08/12/2020 00:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertIngredient]
@IdIngredient int output,
@Name nvarchar(100),
@Quantity int = null,
@Unit nvarchar(100) = null
AS
BEGIN
INSERT INTO Ingredients_tbl (Name, Quantity, Unit)
VALUES (@Name, @Quantity, @Unit)
SELECT @IdIngredient = SCOPE_IDENTITY()
RETURN @IdIngredient
END;
GO
/****** Object:  StoredProcedure [dbo].[spInsertUsers]    Script Date: 08/12/2020 00:30:45 ******/
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
@IdUser int output
AS
BEGIN
INSERT INTO Users_tbl (FirstName, LastName, BirthDate, Gender, Email) 
VALUES (@FirstName, @LastName, @BirthDate, @Gender, @Email) 
SET @IdUser = SCOPE_IDENTITY()
RETURN @IdUser;
END;
GO
/****** Object:  StoredProcedure [dbo].[spReadAccounts]    Script Date: 08/12/2020 00:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadAccounts] 
AS
SELECT * FROM Account_tbl
GO;
GO
/****** Object:  StoredProcedure [dbo].[spReadAccountsById]    Script Date: 08/12/2020 00:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadAccountsById]
@IdAccount int
AS
BEGIN
SELECT * FROM Account_tbl WHERE IdAccount = @IdAccount;
END;
GO
/****** Object:  StoredProcedure [dbo].[spReadCategories]    Script Date: 08/12/2020 00:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadCategories]
AS
SELECT * FROM Category_tbl;
GO
/****** Object:  StoredProcedure [dbo].[spReadIngredients]    Script Date: 08/12/2020 00:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadIngredients]
AS
SELECT * FROM Ingredients_tbl
GO;
GO
/****** Object:  StoredProcedure [dbo].[spReadIngredientsById]    Script Date: 08/12/2020 00:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadIngredientsById]
@IdIngredient int 
AS
BEGIN
SELECT * FROM Ingredients_tbl WHERE IdIngredient = @IdIngredient
END;
GO
/****** Object:  StoredProcedure [dbo].[spReadRecipeByName]    Script Date: 08/12/2020 00:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadRecipeByName]
@Name nvarchar(120)
AS
BEGIN
SELECT * FROM Recipes_tbl WHERE [Name] = @Name;
END;
GO
/****** Object:  StoredProcedure [dbo].[spReadRecipes]    Script Date: 08/12/2020 00:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadRecipes]
AS
SELECT * FROM Recipes_tbl
GO;
GO
/****** Object:  StoredProcedure [dbo].[spReadRecipesByCategory]    Script Date: 08/12/2020 00:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadRecipesByCategory]
@Category tinyint
AS
BEGIN
SELECT * FROM Recipes_tbl WHERE Category = @Category
END;
GO
/****** Object:  StoredProcedure [dbo].[spReadRecipesById]    Script Date: 08/12/2020 00:30:45 ******/
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
/****** Object:  StoredProcedure [dbo].[spReadRecipesByUsersId]    Script Date: 08/12/2020 00:30:45 ******/
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
/****** Object:  StoredProcedure [dbo].[spReadUser]    Script Date: 08/12/2020 00:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadUser]
AS
	SELECT * FROM Users_tbl
GO;
GO
/****** Object:  StoredProcedure [dbo].[spReadUsersByFirstName]    Script Date: 08/12/2020 00:30:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReadUsersByFirstName] 
@FirstName nvarchar(100)
AS
BEGIN
SELECT * FROM Users_tbl WHERE FirstName = @FirstName;
END;
GO
/****** Object:  StoredProcedure [dbo].[spReadUsersById]    Script Date: 08/12/2020 00:30:45 ******/
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
ALTER DATABASE [JoaoPedro_ReceitasEstrelares] SET  READ_WRITE 
GO
