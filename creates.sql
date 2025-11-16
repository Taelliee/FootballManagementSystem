CREATE TABLE Countries (
    CountryID INT PRIMARY KEY IDENTITY,
    CountryName NVARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE Stadiums (
    StadiumID INT PRIMARY KEY IDENTITY,
    StadiumName NVARCHAR(100) NOT NULL,
    CountryID INT NOT NULL,
    FOREIGN KEY (CountryID) REFERENCES Countries(CountryID)
);

CREATE TABLE Teams (
    TeamID INT PRIMARY KEY IDENTITY,
    TeamName NVARCHAR(100) NOT NULL UNIQUE,
    TeamIcon VARBINARY(MAX),
    CountryID INT NOT NULL,
    FOREIGN KEY (CountryID) REFERENCES Countries(CountryID)
);

CREATE TABLE Positions (
    PositionID INT PRIMARY KEY IDENTITY,
    PositionName NVARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE Footballers (
    FootballerID INT PRIMARY KEY IDENTITY,
    FullName NVARCHAR(120) NOT NULL,
    TeamID INT NOT NULL,
    CountryID INT NOT NULL,
    ShirtNumber INT NOT NULL,
    FOREIGN KEY (TeamID) REFERENCES Teams(TeamID),
    FOREIGN KEY (CountryID) REFERENCES Countries(CountryID)
);

CREATE TABLE Staff (
    StaffID INT PRIMARY KEY IDENTITY,
    FullName NVARCHAR(120) NOT NULL,
    PositionID INT NOT NULL,
    CountryID INT NOT NULL,
    FOREIGN KEY (PositionID) REFERENCES Positions(PositionID),
    FOREIGN KEY (CountryID) REFERENCES Countries(CountryID)
);

CREATE TABLE Competitions (
    CompetitionID INT PRIMARY KEY IDENTITY,
    FootballerID INT NOT NULL,
    StaffID INT NOT NULL,
    EventDate DATETIME NOT NULL,
    CountryID INT NOT NULL,
    StadiumID INT NOT NULL,
    Goals INT NOT NULL DEFAULT 0,

    FOREIGN KEY (FootballerID) REFERENCES Footballers(FootballerID),
    FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
    FOREIGN KEY (CountryID) REFERENCES Countries(CountryID),
    FOREIGN KEY (StadiumID) REFERENCES Stadiums(StadiumID)
);