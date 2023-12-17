using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieTicketing.AppData;

namespace MovieTicketing.Forms
{
    public partial class Tickets : Form
    {
        db_movie_ticketingEntities3 db;
        UserRepo userRepo;
        public Tickets()
        {
            InitializeComponent();
            
            db = new db_movie_ticketingEntities3();
        }
        private void loadTickets()
        {          
            dtgTicketList.DataSource = userRepo.ticketList();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            userRepo = new UserRepo();
            loadTickets();
        }
    }
}
