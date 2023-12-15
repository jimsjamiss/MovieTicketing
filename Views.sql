use db_movie_ticketing

ALter VIEW vw_list_movieShows AS 
SELECT CONCAT('MV-',movieId,'-000')AS 'Movie ID', 
moviName  'Title',  
movieDate  'Showing Date', 
movieType  'Genre', 
CONCAT(movieHour,'mins') AS 'Duration', 
CONCAT('Php ',moviePrice) AS 'Price'
FROM movieShows 

Alter VIEW vw_userList AS 
Select CONCAT ('CC-', custId,'-000') AS 'Id', 
custName 'Name',
custPass 'Password',
custAddress 'Address', 
custEmail 'Email Address', 
custPhone 'Phone Number'
from UserInfo

Alter view vw_browseMovies AS
SELECT CONCAT('MV-',movieId,'000') AS 'Movie Id',
moviName 'Title',
movieType  'Genre', 
CONCAT('Php ',moviePrice) AS 'Price'
from movieShows

Create view vw_empList AS
Select 
empId 'Employee ID',
empName 'Employee Name',
empAddress 'Employee Address',
empRole 'Role'
From empInfo

Create view vw_tickets AS
Select 
m.tckId 'TicketId',
m.custId 'UserId',
m.movieId 'MovieId',
m.Venue 'Cinema',
m.Date 'Date'
From movieTicketing m