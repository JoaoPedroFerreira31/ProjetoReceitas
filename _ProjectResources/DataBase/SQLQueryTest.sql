USE JoaoPedro_ReceitasEstrelares;

Exec spReadUser

INSERT INTO Users_tbl (FirstName, LastName, BirthDate, Email, IsAdmin) VALUES ('João Pedro', 'Ferreira','2001-10-31','jpmferreira31@exemplo.pt', 1);

INSERT INTO Users_tbl (FirstName, LastName, BirthDate, Gender, Email, IsAdmin, Blocked) VALUES ('Maria', 'Do Carmo','1976-03-02', 2, 'Exemplo@exemplo.pt', 4);

SELECT * FROM Account_tbl;

DELETE FROM Users_tbl
WHERE IdUser = 22;

Insert into Account_tbl (Username, Password) VALUES ('TesteAccount5', 'Password')

SELECT * FROM Users_tbl

-- USER

-- Set default values

-- Blocked
ALTER TABLE Users_tbl
ADD CONSTRAINT df_Blocked
DEFAULT 0 FOR Blocked;

-- IsAdmin
ALTER TABLE Users_tbl
ADD CONSTRAINT df_IsAdmin
DEFAULT 0 FOR IsAdmin;


-- GetById()
CREATE PROCEDURE spReadUsersById 
@IdUser int
AS
BEGIN
SELECT * FROM Users_tbl WHERE IdUser = @IdUser;
END;

EXEC spReadUsersById 22;

-- Insert User
CREATE PROCEDURE spInsertUsers
@FirstName nvarchar(100),
@LastName nvarchar(100),
@BirthDate datetime,
@Gender tinyInt,
@Email nvarchar(150)
AS
BEGIN
INSERT INTO Users_tbl (FirstName, LastName, BirthDate, Gender, Email) 
VALUES (@FirstName, @LastName, @BirthDate, @Gender, @Email)
SELECT cast(SCOPE_IDENTITY() as int);
END;

-- RECIPE

-- GetAll()
CREATE PROCEDURE spReadRecipes
AS
SELECT * FROM Recipes_tbl
GO;

EXEC spReadRecipes;

-- GetById()
CREATE PROCEDURE spReadRecipesById
@IdRecipe int
AS
BEGIN
SELECT * FROM Recipes_tbl WHERE IdRecipe = @IdRecipe; 
END;

EXEC spReadRecipesById 1

-- GetByUserId
CREATE PROCEDURE spReadRecipesByUsersId
@IdUser int
AS
BEGIN
SELECT * FROM Recipes_tbl WHERE IdUser = @IdUser;
END;

EXEC spReadRecipesByUsersId 1

-- Account

-- GetAll
CREATE PROCEDURE spReadAccounts 
AS
SELECT * FROM Account_tbl
GO;

-- GetById
CREATE PROCEDURE spReadAccountsById
@IdAccount int
AS
BEGIN
SELECT * FROM Account_tbl WHERE IdAccount = @IdAccount;
END;

EXEC spReadAccountsById 2