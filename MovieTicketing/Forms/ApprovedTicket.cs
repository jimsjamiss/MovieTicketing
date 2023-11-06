using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using Dbsys;
using MovieTicketing.AppData;

namespace MovieTicketing.Forms
{
    public partial class ApprovedTicket : Form
    {
        private db_movie_ticketingEntities db;
        UserRepo userRepo;

        public ApprovedTicket()
        {
            InitializeComponent();
            db = new db_movie_ticketingEntities();
            
        }

        private void ApprovedTicket_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNameChanged()
        {
            string name = "";
            txtName.Text = GetUserByUsername(name).ToString();
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
