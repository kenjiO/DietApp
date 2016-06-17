
-- password abc
INSERT INTO users (username, firstName, lastName, email, password, initialWeight, heightInches, dailyCalorieGoal, goalWeight)
VALUES ('aa', 'Al', 'Adams', 'aladams@example.com', '0x40bd001563085fc35165329ea1ff5c5ecbdbbeef', 220, 70, 2500, 180) 

-- password 123
INSERT INTO users (username, firstName, lastName, email, password, initialWeight, heightInches, dailyCalorieGoal, goalWeight)
VALUES ('bb', 'Betsy', 'Brown', 'bbrown@example.com', '0xa9993e364706816aba3e25717850c26c9cd0d89d', 190, 65, 2000, 150) 

-- password xyz
INSERT INTO users (username, password)
VALUES ('cc', '0x66b27417d37e024c46526c2f6d358a754fc552f3') 
