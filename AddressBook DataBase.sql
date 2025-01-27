USE AddressBook

----------------Country---------------------------
--Select All--
CREATE or ALTER PROCEDURE PR_GetAllCountries
AS
BEGIN
    SELECT
	CountryID, 
	CountryName,
	CountryCode,
	CreationDate, 
	UserID
    FROM Country;
END;
EXEC PR_GetAllCountries;

--Select by ID--
CREATE OR ALTER PROCEDURE PR_GetCountryByID
    @CountryID INT
AS
BEGIN
    SELECT CountryID, CountryName, CountryCode, CreationDate, UserID
    FROM Country
    WHERE CountryID = @CountryID;
END;

--Insert--
CREATE OR ALTER PROCEDURE PR_InsertCountry
    @CountryName VARCHAR(100),
    @CountryCode VARCHAR(50),
    @UserID INT
AS
BEGIN
    INSERT INTO Country (CountryName, CountryCode, UserID)
    VALUES (@CountryName, @CountryCode, @UserID);
END;

--Update--
CREATE OR ALTER PROCEDURE PR_UpdateCountry
    @CountryID INT,
    @CountryName VARCHAR(100),
    @CountryCode VARCHAR(50),
    @UserID INT
AS
BEGIN
    UPDATE Country
    SET CountryName = @CountryName, CountryCode = @CountryCode, UserID = @UserID
    WHERE CountryID = @CountryID;
END;

--Delete--
CREATE OR ALTER PROCEDURE PR_DeleteCountry
    @CountryID INT
AS
BEGIN
    DELETE FROM Country
    WHERE CountryID = @CountryID;
END;


----------------------State------------------------
--Select All--
CREATE OR ALTER PROCEDURE PR_GetAllStates
AS
BEGIN
    SELECT StateID, CountryID, StateName, StateCode, CreationDate, UserID
    FROM State;
END;
EXEC PR_GetAllStates;

--Select by Id--
CREATE OR ALTER PROCEDURE PR_GetStateByID
    @StateID INT
AS
BEGIN
    SELECT StateID, CountryID, StateName, StateCode, CreationDate, UserID
    FROM State
    WHERE StateID = @StateID;
END;

--Insert--
CREATE OR ALTER PROCEDURE PR_InsertState
    @CountryID INT,
    @StateName VARCHAR(100),
    @StateCode VARCHAR(50),
    @UserID INT
AS
BEGIN
    INSERT INTO State (CountryID, StateName, StateCode, UserID)
    VALUES (@CountryID, @StateName, @StateCode, @UserID);
END;

--Update--
CREATE OR ALTER PROCEDURE PR_UpdateState
    @StateID INT,
    @CountryID INT,
    @StateName VARCHAR(100),
    @StateCode VARCHAR(50),
    @UserID INT
AS
BEGIN
    UPDATE State
    SET CountryID = @CountryID, StateName = @StateName, StateCode = @StateCode, UserID = @UserID
    WHERE StateID = @StateID;
END;

--Delete--
CREATE OR ALTER PROCEDURE PR_DeleteState
    @StateID INT
AS
BEGIN
    DELETE FROM State
    WHERE StateID = @StateID;
END;


--------------------------City--------------------------
--Select All--
CREATE OR ALTER PROCEDURE PR_GetAllCities
AS
BEGIN
    SELECT CityID, StateID, CountryID, CityName, STDCode, PinCode, CreationDate, UserID
    FROM City;
END;
EXEC PR_GetAllCities

--Select by Id--
CREATE OR ALTER PROCEDURE PR_GetCityByID
    @CityID INT
AS
BEGIN
    SELECT CityID, StateID, CountryID, CityName, STDCode, PinCode, CreationDate, UserID
    FROM City
    WHERE CityID = @CityID;
END;

--Insert--
CREATE OR ALTER PROCEDURE PR_InsertCity
    @StateID INT,
    @CountryID INT,
    @CityName VARCHAR(100),
    @STDCode VARCHAR(50),
    @PinCode VARCHAR(6),
    @UserID INT
AS
BEGIN
    INSERT INTO City (StateID, CountryID, CityName, STDCode, PinCode, UserID)
    VALUES (@StateID, @CountryID, @CityName, @STDCode, @PinCode, @UserID);
END;

--Update--
CREATE OR ALTER PROCEDURE PR_UpdateCity
    @CityID INT,
    @StateID INT,
    @CountryID INT,
    @CityName VARCHAR(100),
    @STDCode VARCHAR(50),
    @PinCode VARCHAR(6),
    @UserID INT
AS
BEGIN
    UPDATE City
    SET StateID = @StateID, CountryID = @CountryID, CityName = @CityName, 
        STDCode = @STDCode, PinCode = @PinCode, UserID = @UserID
    WHERE CityID = @CityID;
END;

--Delete--
CREATE OR ALTER PROCEDURE PR_DeleteCity
    @CityID INT
AS
BEGIN
    DELETE FROM City
    WHERE CityID = @CityID;
END;


--------------------------------User------------------------------------
--Select All--
CREATE OR ALTER PROCEDURE PR_GetAllUsers
AS
BEGIN
    SELECT UserID, UserName, MobileNo, EmailID, CreationDate
    FROM [User];
END;
EXEC PR_GetAllUsers

--Select by id--
CREATE OR ALTER PROCEDURE PR_GetUserByID
    @UserID INT
AS
BEGIN
    SELECT UserID, UserName, MobileNo, EmailID, CreationDate
    FROM [User]
    WHERE UserID = @UserID;
END;

--Insert--
CREATE OR ALTER PROCEDURE PR_InsertUser
    @UserName VARCHAR(100),
    @MobileNo VARCHAR(50),
    @EmailID VARCHAR(100)
AS
BEGIN
    INSERT INTO [User] (UserName, MobileNo, EmailID)
    VALUES (@UserName, @MobileNo, @EmailID);
END;

--Update--
CREATE OR ALTER PROCEDURE PR_UpdateUser
    @UserID INT,
    @UserName VARCHAR(100),
    @MobileNo VARCHAR(50),
    @EmailID VARCHAR(100)
AS
BEGIN
    UPDATE [User]
    SET UserName = @UserName, MobileNo = @MobileNo, EmailID = @EmailID
    WHERE UserID = @UserID;
END;

--Delete--
CREATE OR ALTER PROCEDURE PR_DeleteUser
    @UserID INT
AS
BEGIN
    DELETE FROM [User]
    WHERE UserID = @UserID;
END;