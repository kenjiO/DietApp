USE [master]
GO

IF  EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = 'DietApp')
BEGIN
DROP DATABASE DietApp
END
GO

CREATE DATABASE DietApp
 CONTAINMENT = NONE
GO

USE DietApp

CREATE TABLE users
   (userId int PRIMARY KEY NOT NULL,  
    username varchar(50) NOT NULL,
	firstName varchar(50),
	lastName varchar(50),
	password varchar(50) NOT NULL, 
    initialWeight int,
	heightFeet int, 
	heightInches int, 
    dailyCalorieGoal int,
	goalWeight int,
	CONSTRAINT UNIQUE_userId UNIQUE(UserId)
)


CREATE TABLE measurmentsTypes (
  measurmentTypeId int PRIMARY KEY NOT NULL, 
  measurmentTypeName varchar(50) NOT NULL,
  measurmentDefaultUnit varchar(10) NOT NULL,
  measurmentDefaultValue int NOT NULL 
)
	
CREATE TABLE dailyMeasurments (
  dailyMeasurmentId int PRIMARY KEY NOT NULL, 
  date date NOT NULL,
  userId int NOT NULL FOREIGN KEY REFERENCES users(userId),
  measurmentTypeId int NOT NULL FOREIGN KEY REFERENCES measurmentsTypes(measurmentTypeId),
  mesasurement int NOT NULL,
)



CREATE TABLE defaultNutritionalValues (
	foodId int PRIMARY KEY NOT NULL, 
    food varchar(50)  NOT NULL,
	calories int,
	fat int,
	protein int,
	carbohydrates int
)

CREATE TABLE itemConsumed (
  dateTimeConsumed datetime NOT NULL,
  userId int NOT NULL FOREIGN KEY REFERENCES users(userId),
  foodId int NOT NULL FOREIGN KEY REFERENCES defaultNutritionalValues(foodId)
  primary key (dateTimeConsumed, userId, foodId)
)