USE [master]
GO

IF  EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = 'DietApp')
DROP DATABASE DietApp
GO

CREATE DATABASE DietApp
GO

USE DietApp
GO

CREATE TABLE users (
  userId int PRIMARY KEY NOT NULL IDENTITY(1,1),  
  username varchar(50) NOT NULL,
  firstName varchar(50),
  lastName varchar(50),
  email varchar(50),
  password varchar(50) NOT NULL, 
  initialWeight int,
  heightInches int, 
  dailyCalorieGoal int,
  goalWeight int,
  CONSTRAINT UNQ_username UNIQUE(username)
)
	
CREATE TABLE measurementTypes (
  measurementTypeId int PRIMARY KEY NOT NULL IDENTITY(1,1),
  measurementTypeName varchar(50) NOT NULL,
  measurementDefaultUnit varchar(50) NOT NULL,
  CONSTRAINT UNQ_measurementTypeName UNIQUE(measurementTypeName)
)
     
CREATE TABLE dailyMeasurements (
  date date NOT NULL,
  userId int NOT NULL FOREIGN KEY REFERENCES users(userId),
  typeId int NOT NULL FOREIGN KEY REFERENCES measurementTypes(measurementTypeId),
  value int NOT NULL,
  primary key (date, userId, typeId)
)

CREATE TABLE itemConsumed (
  dateTimeConsumed datetime NOT NULL,
  userId int NOT NULL FOREIGN KEY REFERENCES users(userId),
  name varchar(50) NOT NULL,
  calories int,
  protein int,
  fat int,
  carbohydrate int,
  primary key (dateTimeConsumed, userId, name)
)

CREATE TABLE defaultNutritionalValues (
  food varchar(50) primary key NOT NULL,
  calories int,
  fat int,
  protein int,
  carbohydrates int
)