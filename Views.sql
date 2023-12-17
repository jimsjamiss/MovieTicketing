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

Alter view vw_empList AS
Select 
custId 'ID',
custName 'Username',
custAddress 'Address',
custEmail 'Email',
custPhone 'Phone',
roles 'Roles'
From UserInfo


Alter view vw_tickets AS
Select 
m.tckId 'TicketId',
m.custId 'UserId',
u.custName 'Name',
u.custAddress 'Address',
u.custEmail 'Email',
m.movieId 'MovieId',
mv.moviName 'Title',
mv.movieType 'Genre',
mv.movieHour 'Duration',
mv.moviePrice 'Price',
m.Venue 'Cinema',
m.Date 'Date',
m.numOfPerson 'Quantity',
mv.moviePrice * m.numOfPerson AS 'Total'
From movieTicketing m
INNER JOIN UserInfo u ON u.custId = m.custId
INNER JOIN movieShows mv ON mv.movieId = m.movieId 
