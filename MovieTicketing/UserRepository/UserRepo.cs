using System;
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
        private db_movie_ticketingEntities db;

        public UserRepo()
        {
            db = new db_movie_ticketingEntities();
        }
        public ErrorCode NewUser(customerInfo custInfo, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                db.customerInfo.Add(custInfo);
                db.SaveChanges();

                outMessage = "Inserted";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }
        public customerInfo GetUserByUsername(String username)
        {
            // re-initialize db object because sometimes data in the list not updated
            using (db = new db_movie_ticketingEntities())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                return db.customerInfo.Where(s => s.custName == username).FirstOrDefault();
            }
        }
    }
}
