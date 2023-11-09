use db_movie_ticketing

ALTER VIEW vw_list_movieShows AS 
SELECT movieId AS 'Movie ID', moviName AS 'Title', movieType AS 'Genre', movieDate AS 'Showing Date', movieHour AS 'Time Slot'
FROM movieShows 