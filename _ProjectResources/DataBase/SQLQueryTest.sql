USE JoaoPedro_ReceitasEstrelares;

Exec spReadUser

INSERT INTO Users_tbl (FirstName, LastName, BirthDate, Email, IsAdmin) VALUES ('João Pedro', 'Ferreira','2001-10-31','jpmferreira31@exemplo.pt', 1);

INSERT INTO Users_tbl (FirstName, LastName, BirthDate, Gender, Email, IsAdmin, Blocked) VALUES ('Maria', 'Do Carmo','1976-03-02', 2, 'Exemplo@exemplo.pt', 4);

SELECT * FROM Account_tbl;

DELETE FROM Users_tbl
WHERE IdUser = 22;

Insert into Account_tbl (Username, Password) VALUES ('TesteAccount5', 'Password')

SELECT * FROM Users_tbl where Gender = 1;

 

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

-- GetLoggedInUser
CREATE PROCEDURE spGetLoggedInUser
@MembershipUsername nvarchar(150)
AS
BEGIN
SELECT * FROM Users_tbl WHERE MembershipUsername = @MembershipUsername
END;
-- GetById()
CREATE PROCEDURE spReadUsersById 
@IdUser int
AS
BEGIN
SELECT * FROM Users_tbl WHERE IdUser = @IdUser;
END;

EXEC spReadUsersById 22;

-- GetByFirstName()
CREATE PROCEDURE spReadUsersByFirstName 
@FirstName nvarchar(100)
AS
BEGIN
SELECT * FROM Users_tbl WHERE FirstName = @FirstName;
END;

EXEC spReadUsersByFirstName "João Pedro"

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

-- Insert Admin
CREATE PROCEDURE spInsertAdmin
@FirstName nvarchar(100),
@LastName nvarchar(100),
@BirthDate datetime,
@Gender tinyInt,
@Email nvarchar(150),
@IsAdmin bit
AS
BEGIN
INSERT INTO Users_tbl (FirstName, LastName, BirthDate, Gender, Email, IsAdmin) 
VALUES (@FirstName, @LastName, @BirthDate, @Gender, @Email, @IsAdmin)
SELECT cast(SCOPE_IDENTITY() as int);
END;

-- RECIPE

-- Set default values

-- isValidated
ALTER TABLE Recipes_tbl
ADD CONSTRAINT df_isValidated
DEFAULT 0 FOR isValidated;

-- idRating
ALTER TABLE Recipes_tbl
ADD CONSTRAINT df_idRating
DEFAULT 0 FOR idRating;


INSERT INTO Recipes_tbl VALUES ('Peixe', 'khadjggagsjhgjsa' , '06:15:20', 2, 5, 0, 3, 36 );

-- GetAll()
CREATE PROCEDURE spReadRecipes
AS
SELECT * FROM Recipes_tbl
GO;

EXEC spReadRecipes;

-- GetAllValidated()
CREATE PROCEDURE spReadRecipesValidated
AS
BEGIN
SELECT * FROM Recipes_tbl WHERE IsValidated = 1
END;

-- GetAllNonValidated()
CREATE PROCEDURE spReadNonValidatedRecipes
AS
BEGIN
SELECT * FROM Recipes_tbl WHERE IsValidated = 0
END;

EXEC spReadRecipesValidated

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

-- GetRecipeByCategory
CREATE PROCEDURE spReadRecipesByCategory
@Category tinyint
AS
BEGIN
SELECT * FROM Recipes_tbl WHERE Category = @Category
END;

EXEC spReadRecipesByCategory 3

-- GetRecipebyName
CREATE PROCEDURE spReadRecipeByName
@Name nvarchar(120)
AS
BEGIN
SELECT * FROM Recipes_tbl WHERE [Name] = @Name;
END;

EXEC spReadRecipeByName Teste

-- InsertRecipe
CREATE PROCEDURE spInsertRecipe
@Name nvarchar(120),
@Description nvarchar(250),
@Duration time(7),
@Difficulty tinyInt,
@Category tinyInt,
@IdRecipe int output
AS
BEGIN
INSERT INTO Recipes_tbl (Name, Description, Duration, Difficulty, Category) 
VALUES (@Name, @Description, @Duration, @Difficulty, @Category)
SET @IdRecipe = SCOPE_IDENTITY();
RETURN @IdRecipe
END;


SELECT * FROM Recipes_tbl;

--Ingredient

-- GetAll
CREATE PROCEDURE spReadIngredients
AS
SELECT * FROM Ingredients_tbl
GO;

-- GetById
CREATE PROCEDURE spReadIngredientsById
@IdIngredient int 
AS
BEGIN
SELECT * FROM Ingredients_tbl WHERE IdIngredient = @IdIngredient
END;

EXEC spReadIngredientsById 

-- InsertIngredient
CREATE PROCEDURE spInsertIngredient
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

-- Category

-- GetAll
CREATE PROCEDURE spReadCategories
AS
SELECT * FROM Category_tbl;
GO

-- Insert
CREATE PROCEDURE spInsertCategory
@IdCategory int output,
@Name varchar(120)
AS
BEGIN
INSERT INTO Category_tbl (Name)
VALUES (@Name)
SELECT @IdCategory = SCOPE_IDENTITY()
RETURN @IdCategory
END;

-- ACCOUNT

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