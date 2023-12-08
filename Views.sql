use db_movie_ticketing

ALter VIEW vw_list_movieShows AS 
SELECT movieId 'Movie ID', moviName  'Title',  movieDate  'Showing Date', movieType  'Genre', movieHour  'Time Slot'
FROM movieShows 

Create VIEW vs_userList AS 
Select custName 'Fullname', 
custAddress 'Address', 
custEmail 'Email Address', 
custPhone 'Phone Number', 
custPass 'Password'
from customerInfo