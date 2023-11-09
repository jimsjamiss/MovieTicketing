use db_movie_ticketing

alter table movieShows
alter column movieId IDENTITY (1000,5);