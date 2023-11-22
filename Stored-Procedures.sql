use db_movie_ticketing
Alter Procedure sp_update_moviesInfo @movieId int, @movieName varchar(50), @movieDate varchar(50), @movieHours varchar(50), @movieGenre varchar(50) 
AS 
UPDATE movieShows 
SET 
moviName = @movieName,
movieType = @movieGenre, 
movieDate = @movieDate,
movieHour = @movieHours
WHERE movieId = movieId;


CREATE Procedure sp_delete_movies @id int, @movieName varchar(50), @movieDate varchar(50), @movieHours varchar(50), @movieGenre varchar(50) 
AS
DELETE from movieShows WHERE movieId = @id