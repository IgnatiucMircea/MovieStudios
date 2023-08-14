CREATE DATABASE MovieStudios
use MovieStudios

-- Studios table
CREATE TABLE Studios (
    Sid INT PRIMARY KEY,
    Name VARCHAR,
    NrMovies INT
);

-- Directors table
CREATE TABLE Directors (
    Did INT PRIMARY KEY,
    FK_Sid INT,
    Name VARCHAR,
    YearsOfExperience INT,
    FOREIGN KEY (FK_Sid) REFERENCES Studios(Sid)
);

-- Apprentices table
CREATE TABLE Apprentices (
    Aid INT PRIMARY KEY,
    FK_Did INT,
    Name VARCHAR,
    University VARCHAR,
    FOREIGN KEY (FK_Did) REFERENCES Directors(Did)
);

-- Movies table
CREATE TABLE Movies (
    Mid INT PRIMARY KEY,
    FK_Did INT,
    Name VARCHAR,
    Price MONEY,
    FOREIGN KEY (FK_Did) REFERENCES Directors(Did)
);
