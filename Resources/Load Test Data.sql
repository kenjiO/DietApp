
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
