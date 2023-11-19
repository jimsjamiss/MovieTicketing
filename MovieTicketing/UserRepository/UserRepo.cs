using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicketing.AppData;
using System.Windows.Forms;
using log4net.Core;
using System.Data.SqlClient;
using MovieTicketing.AppData;


namespace MovieTicketing
{
    internal class UserRepo
    {
        public static int userId = 0;

         db_movie_ticketingEntities2 db;
        movieShows movies = new movieShows();
        public UserRepo()
        {
            db = new db_movie_ticketingEntities2();
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
            db = new db_movie_ticketingEntities2();
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                 //movieShows movie = 
                // Remove the user
                db.movieShows.Remove(db.movieShows.Where(m => m.movieId ==  movieId).FirstOrDefault());
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
        public ErrorCode UpdateUser(String title, movieShows cust, ref String outMessage)
        {
            db = new db_movie_ticketingEntities2();
            cust = new movieShows();
            movies = new movieShows();

            ErrorCode retValue = ErrorCode.Error;
            try
            {
                // Find the user with id
                movieShows movies = db.movieShows.Where(m => m.moviName == title).FirstOrDefault();
                // Update the value of the retrieved user
               // movies.movieId = cust.movieId;
                movies.moviName = cust.moviName;
                movies.movieDate = cust.movieDate;
                movies.movieHour = cust.movieHour;
                movies.movieType = cust.movieType;

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
            using (db = new db_movie_ticketingEntities2())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                return db.customerInfo.Where(s => s.custName == username).FirstOrDefault();db.customerInfo.Where(s => s.custPass == password).FirstOrDefault();
            }
        }
        //public customerInfo GetUserByPassword (String pass)
        //{
        //    // re-initialize db object because sometimes data in the list not updated
        //    using (db = new db_movie_ticketingEntities2())
        //    {
        //        // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
        //        return db.customerInfo.Where(s => s.custPass == pass).FirstOrDefault();
        //    }
        //}
        public movieShows GetMoviesByMovieId(String title)
        {
            // re-initialize db object because sometimes data in the list not updated
            using (db = new db_movie_ticketingEntities2())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                return db.movieShows.Where(s => s.moviName == title).FirstOrDefault();
            }
        }

        public List<vw_list_movieShows> AllMovieShows()
        {
            using (db = new db_movie_ticketingEntities2())
            {
                return db.vw_list_movieShows.ToList();
            }
        }
    }
}
