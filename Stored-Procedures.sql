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

Alter Procedure sp_delete_user 
@empId int,
@empName varchar(50),
@empAddress varchar(50),
@empEmail varchar(50),
@empPhone varchar(50),
@empRole varchar(50)
AS
Delete from UserInfo WHERE custId = @empId

Alter Procedure sp_updateUser
@empId int,
@empName varchar(50),
@empAddress varchar(50),
@empEmail varchar(50),
@empPhone varchar(50),
@empRole varchar(50)
AS
Update UserInfo
Set
custName = @empName,
custAddress = @empAddress,
custPhone = @empPhone,
custEmail = @empEmail,
roles = @empRole
WHERE custId = @empId

Alter Procedure sp_ticketing 
@movieId int,
@custId int,
@venue varchar(50),
@date date,
@numPerson int
AS
INSERT INTO vw_tickets(movieId,UserId,Cinema,Date,Quantity)
VALUES (@movieId,@custId,@venue,@date,@numPerson)

