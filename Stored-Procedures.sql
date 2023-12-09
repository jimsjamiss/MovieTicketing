use db_movie_ticketing

Alter Procedure sp_update_moviesInfo 
@movieId int, 
@movieName varchar(50), 
@movieDate varchar(50), 
@movieHours varchar(50), 
@movieGenre varchar(50),
@moviePrice decimal(18,0)
AS 
UPDATE movieShows 
SET 
moviName = @movieName,
movieType = @movieGenre, 
movieDate = @movieDate,
movieHour = @movieHours,
moviePrice = @moviePrice
WHERE movieId = @movieId;


Alter Procedure sp_delete_movies 
@id int, 
@movieName varchar(50), 
@movieDate varchar(50), 
@movieHours varchar(50), 
@movieGenre varchar(50),
@moviePrice decimal(18,0)
AS
DELETE  from movieShows WHERE movieId = @id

Alter Procedure sp_createMovies  
@movieName varchar(50), 
@movieDate varchar(50), 
@movieHours varchar(50), 
@movieGenre varchar(50), 
@moviePrice decimal(18,0)
AS
INSERT INTO movieShows(moviName,movieType,movieDate,movieHour,moviePrice) 
VALUES (@movieName,@movieGenre,@movieDate, @movieHours,@moviePrice)