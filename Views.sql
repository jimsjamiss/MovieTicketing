use db_movie_ticketing

ALter VIEW vw_list_movieShows AS 
SELECT CONCAT('MV-',movieId,'-000')AS 'Movie ID', 
moviName  'Title',  
movieDate  'Showing Date', 
movieType  'Genre', 
movieHour  'Time Slot', 
CONCAT('Php ',moviePrice) AS 'Price'
FROM movieShows 

Alter VIEW vw_userList AS 
Select CONCAT ('CC-', custId,'-000') AS 'Id', 
custName 'Name',
custPass 'Password',
custAddress 'Address', 
custEmail 'Email Address', 
custPhone 'Phone Number'
from customerInfo

Alter view vw_browseMovies AS
SELECT CONCAT('(','MV-',movieId,'-000',')',moviName) AS 'Movie',
movieDate  'Showing Date', 
movieType  'Genre', 
movieHour  'Time Slot', 
CONCAT('Php ',moviePrice) AS 'Price'
from movieShows