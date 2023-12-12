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
        public ErrorCode NewUser(UserInfo custInfo, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                db.UserInfo.Add(custInfo);
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

                movieShows movies = db.movieShows.Where(m => m.movieId == movieId).FirstOrDefault();
                db.sp_delete_movies(movies.movieId, movies.moviName, movies.movieDate, movies.movieHour, movies.movieType,movies.moviePrice);
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
        public ErrorCode UpdateMovie(int? id, string title, string date, string hrs, string genre,decimal price,ref String outMessage)
        {
            using (db = new db_movie_ticketingEntities3())
            {
                try
                {
                    db.sp_update_moviesInfo(id,title,date,hrs,genre,price);
                    outMessage = "Movie Updated!";
                    return ErrorCode.Success;   
                }
                catch (Exception ex)
                {

                    outMessage = ex.Message;
                    return ErrorCode.Error;
                }
            }
           
        }
        public ErrorCode RemoveEmp(int? empId, ref String outMessage)
        {
            db = new db_movie_ticketingEntities3();
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                empInfo emp = db.empInfo.Where(m => m.empId == empId).FirstOrDefault();
                db.sp_delete_user(emp.empId,emp.empName, emp.empAddress, emp.empRole);
                db.SaveChanges();
                outMessage = "Employee Deleted Successfully!";
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
        public ErrorCode UpdateEmp(int? id, string name, string address, string role, ref String outMessage)
        {
            using (db = new db_movie_ticketingEntities3())
            {
                try
                {
                    db.sp_updateUser(id, name, address, role);
                    outMessage = "Employee Updated!";
                    return ErrorCode.Success;
                }
                catch (Exception ex)
                {

                    outMessage = ex.Message;
                    return ErrorCode.Error;
                }
            }

        }
        public UserInfo GetUserByUsername(String username, String password)
        {
            // re-initialize db object because sometimes data in the list not updated
            using (db = new db_movie_ticketingEntities3())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                return db.UserInfo.Where(s => s.custName == username && s.custPass == password).FirstOrDefault();
          
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
        public movieShows GetMoviesByTitle(string title)
        {
            // re-initialize db object because sometimes data in the list not updated
            using (db = new db_movie_ticketingEntities3())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                return db.movieShows.Where(s => s.moviName == title).FirstOrDefault();
            }
        }

        public List<vw_list_movieShows> AllMovieShows()
        {
            using (db = new db_movie_ticketingEntities3())
            {
                return db.vw_list_movieShows.ToList();
            }
        }
       public List<vw_userList> custList()
        {
            using (db =new db_movie_ticketingEntities3())
            {
                return db.vw_userList.ToList();
            }
        }
        public List<vw_browseMovies> browseMovies()
        {
            using (db = new db_movie_ticketingEntities3())
            {
                return db.vw_browseMovies.ToList(); 
            }
        }
        public List<vw_empList> empList()
        {
            using (db = new db_movie_ticketingEntities3())
            {
                return db.vw_empList.ToList();
            }
        }
    }
}
