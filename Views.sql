use db_movie_ticketing

ALter VIEW vw_list_movieShows AS 
SELECT moviName  'Title',  movieDate  'Showing Date', movieType  'Genre', movieHour  'Time Slot'
FROM movieShows 