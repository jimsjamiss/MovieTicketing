﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicketing.AppData;
using System.Windows.Forms;
using log4net.Core;
using System.Data.SqlClient;


namespace MovieTicketing
{
    internal class UserRepo
    { 
        db_movie_ticketingEntities3 db;
        movieShows movies = new movieShows();

        public static int userId = 0;
        public UserRepo()
        {
            db = new db_movie_ticketingEntities3();
        }
        public ErrorCode NewUser(customerInfo custInfo, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                db.customerInfo.Add(custInfo);
                db.SaveChanges();

                outMessage = "Account Successfully Created";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }
        public ErrorCode RemoveMovie(int? movieId, ref String outMessage)
        {
            db = new db_movie_ticketingEntities3();
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                //movieShows movie = 
                // Remove the user
                // db.movieShows.Remove(db.movieShows.Where(m => m.movieId ==  movieId).FirstOrDefault());
                movieShows movies = db.movieShows.Where(m => m.movieId == movieId).FirstOrDefault();
                db.sp_delete_movies(movies.movieId, movies.moviName, movies.movieDate, movies.movieHour, movies.movieType);
                db.SaveChanges();       // Execute the update

                outMessage = "Movie Deleted Successfully!";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Error;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }
        public ErrorCode UpdateMovie(int? id, movieShows moviesinfo,ref String outMessage)
        {
            db = new db_movie_ticketingEntities3();
                     
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                // Find the user with id
                movieShows movies = db.movieShows.Where(m => m.movieId == id).FirstOrDefault();
                db.sp_update_moviesInfo(movies.movieId,movies.moviName,movies.movieDate,movies.movieHour,movies.movieType);
                db.SaveChanges();       // Execute the update

                outMessage = "Updated";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Success;
                MessageBox.Show(ex.Message);
            }
            return retValue;

        }

        public customerInfo GetUserByUsername(String username, String password)
        {
            // re-initialize db object because sometimes data in the list not updated
            using (db = new db_movie_ticketingEntities3())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                return db.customerInfo.Where(s => s.custName == username && s.custPass == password).FirstOrDefault();
          
            }
        }

        public movieShows GetMoviesByMovieId(int movieId)
        {
            // re-initialize db object because sometimes data in the list not updated
            using (db = new db_movie_ticketingEntities3())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                return db.movieShows.Where(s => s.movieId == movieId).FirstOrDefault();
            }
        }

        public List<vw_list_movieShows> AllMovieShows()
        {
            using (db = new db_movie_ticketingEntities3())
            {
                return db.vw_list_movieShows.ToList();
            }
        }

    }
}
