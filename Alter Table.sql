use db_movie_ticketing

alter table movieShows
alter column moviName varchar(50) NOT NULL;

Alter table empInfo
Add  empRole varchar(50) NOT NULL;

Alter table UserInfo
add roles varchar(50);

Alter table movieTicketing
add custId int NOT NULL;
