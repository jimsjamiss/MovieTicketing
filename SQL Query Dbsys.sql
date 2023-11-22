CREATE DATABASE db_movie_ticketing 

USE db_movie_ticketing

CREATE TABLE usersInfo (
	userId int NOT NULL, 
	userFName varchar(50) NOT NULL, 
	userLName varchar(50) NOT NULL,
	userAddress varchar(50) NOT NULL,
	userPNumber int NOT NULL,
	userRole varchar(50) NOT NULL,
)
CREATE TABLE movieOffers (
	movieId int NOT NULL,
	movieName varchar(50) NOT NULL,
	movieTime varchar(50) NOT NULL
)
CREATE TABLE approvedTickets (
	ticketId int NOT NULL,
	userId int NOT NULL,
	movieId int NOT NULL,
	movieTime varchar(50) NOT NULL
)
