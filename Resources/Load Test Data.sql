USE DietApp
GO

DELETE FROM users

SET IDENTITY_INSERT users ON 

-- password abc
INSERT INTO users (userId, username, firstName, lastName, email, password, initialWeight, heightInches, dailyCalorieGoal, goalWeight)
VALUES (1,'aa', 'Al', 'Adams', 'aladams@example.com', '0x40bd001563085fc35165329ea1ff5c5ecbdbbeef', 220, 70, 2500, 180) 

-- password 123
INSERT INTO users (userId, username, firstName, lastName, email, password, initialWeight, heightInches, dailyCalorieGoal, goalWeight)
VALUES (2, 'bb', 'Betsy', 'Brown', 'bbrown@example.com', '0xa9993e364706816aba3e25717850c26c9cd0d89d', 190, 65, 2000, 150) 

-- password xyz
INSERT INTO users (userId, username, password)
VALUES (3, 'cc', '0x66b27417d37e024c46526c2f6d358a754fc552f3') 

SET IDENTITY_INSERT users OFF 

SET IDENTITY_INSERT dailyMeasurements ON 

INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(1,CONVERT(datetime,'06/23/2016'),'1','1','210');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(2,CONVERT(datetime,'06/23/2016'),'1','2','65');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(3,CONVERT(datetime,'06/23/2016'),'1','3','100');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(4,CONVERT(datetime,'06/23/2016'),'1','4','80');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(5,CONVERT(datetime,'06/24/2016'),'1','1','204');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(6,CONVERT(datetime,'06/24/2016'),'1','2','68');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(7,CONVERT(datetime,'06/24/2016'),'1','3','105');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(8,CONVERT(datetime,'06/24/2016'),'1','4','79');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(9,CONVERT(datetime,'06/25/2016'),'1','1','195');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(10,CONVERT(datetime,'06/25/2016'),'1','2','61');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(11,CONVERT(datetime,'06/25/2016'),'1','3','110');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(12,CONVERT(datetime,'06/25/2016'),'1','4','82');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(13,CONVERT(datetime,'06/23/2016'),'2','1','165');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(14,CONVERT(datetime,'06/23/2016'),'2','2','72');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(15,CONVERT(datetime,'06/23/2016'),'2','3','98');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(16,CONVERT(datetime,'06/23/2016'),'2','4','68');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(17,CONVERT(datetime,'06/24/2016'),'2','1','167');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(18,CONVERT(datetime,'06/24/2016'),'2','2','68');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(19,CONVERT(datetime,'06/24/2016'),'2','3','97');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(20,CONVERT(datetime,'06/24/2016'),'2','4','57');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(21,CONVERT(datetime,'06/25/2016'),'2','1','155');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(22,CONVERT(datetime,'06/25/2016'),'2','2','70');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(23,CONVERT(datetime,'06/25/2016'),'2','3','98');
INSERT INTO dailyMeasurements (dailyMeasurementId,date,userId,measurementTypeId,measurement) VALUES(24,CONVERT(datetime,'06/25/2016'),'2','4','61');



SET IDENTITY_INSERT dailyMeasurements OFF 