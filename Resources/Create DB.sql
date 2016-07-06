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
  dailyMeasurementId int PRIMARY KEY NOT NULL IDENTITY(1,1),
  date date NOT NULL,
  userId int NOT NULL FOREIGN KEY REFERENCES users(userId),
  measurementTypeId int NOT NULL FOREIGN KEY REFERENCES measurementTypes(measurementTypeId),
  measurement int NOT NULL,
  CONSTRAINT UNQ_dailyMeasurement UNIQUE(date,userId,measurementTypeId)
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

SET IDENTITY_INSERT measurementTypes ON 

INSERT INTO measurementTypes (measurementTypeId,measurementTypeName, measurementDefaultUnit) Values(1,'weight','lb.');
INSERT INTO measurementTypes (measurementTypeId,measurementTypeName, measurementDefaultUnit) Values(2,'heartRate','bpm.');
INSERT INTO measurementTypes (measurementTypeId,measurementTypeName, measurementDefaultUnit) Values(3,'systolicBP','mom');
INSERT INTO measurementTypes (measurementTypeId,measurementTypeName, measurementDefaultUnit) Values(4,'diastolicBP','mom');

SET IDENTITY_INSERT measurementTypes OFF 


DROP VIEW dailyNutrients
GO

CREATE VIEW dailyNutrients
AS
SELECT userId, CONVERT(date, dateTimeConsumed) as day, SUM(calories) as calories, SUM(fat) as fat, SUM(protein) as protein, SUM(carbohydrate) as carbohydrates from itemConsumed
GROUP BY userId, CONVERT(date, dateTimeConsumed);
GO