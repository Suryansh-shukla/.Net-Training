CREATE DATABASE [FlightSearchEngineDb];
GO

USE [FlightSearchEngineDb];
GO

CREATE TABLE [Flights]
(
FlightId int Primary key identity(1,1),
FlightName NVARCHAR(100) NOT NULL,
FlightType NVARCHAR(50) NOT NULL,
[Source] NVARCHAR(100) NOT NULL,
Destination NVARCHAR(100) NOT NULL,
PricePerSeat DECIMAL(18,2) NOT NULL
);

CREATE TABLE [Hotels]
(HotelId int Primary Key identity(1,1),
HotelName Nvarchar(100) not null,
HotelType nvarchar(50) not null,
[Location] nvarchar(100) not null,
PricePerDay Decimal(18,2) not null
);

CREATE PROCEDURE sp_GetSources
AS 
BEGIN
SELECT DISTINCT [SOURCE] FROM [Flights];
END
GO

CREATE PROCEDURE sp_GetDestinations
AS
BEGIN
SELECT DISTINCT Destination FROM [Flights];
END 
GO

CREATE OR ALTER PROCEDURE sp_SearchFlights
    @Source NVARCHAR(100),
    @Destination NVARCHAR(100),
    @Persons INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @Persons <= 0
    BEGIN
        RAISERROR('Number of persons must be greater than 0', 16, 1);
        RETURN;
    END

    SELECT 
        FlightId,
        FlightName,
        FlightType,
        Source,
        Destination,
        PricePerSeat,
        @Persons AS Persons,
        (PricePerSeat * @Persons) AS TotalCost
    FROM Flights
    WHERE Source = @Source
      AND Destination = @Destination;
END
GO

CREATE OR ALTER PROCEDURE sp_SearchFlightsWithHotels
    @Source NVARCHAR(100),
    @Destination NVARCHAR(100),
    @Persons INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @Persons <= 0
    BEGIN
        RAISERROR('Persons must be greater than 0', 16, 1);
        RETURN;
    END

    SELECT 
        f.FlightId,
        f.FlightName,
        f.FlightType,
        f.Source,
        f.Destination,
        f.PricePerSeat,
        h.HotelId,
        h.HotelName,
        h.HotelType,
        h.Location,
        h.PricePerDay,
        @Persons AS Persons,
        (f.PricePerSeat * @Persons) AS FlightCost,
        h.PricePerDay AS HotelCost,
        ((f.PricePerSeat * @Persons) + h.PricePerDay) AS TotalCost
    FROM Flights f
    INNER JOIN Hotels h 
        ON f.Destination = h.Location
    WHERE f.Source = @Source
      AND f.Destination = @Destination;
END
GO