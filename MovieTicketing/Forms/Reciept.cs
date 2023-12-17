using Dbsys;
using MovieTicketing.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketing.Forms
{
    public partial class Reciept : Form
    {
        UserLogged user;
        movieTicketing movie;
        db_movie_ticketingEntities3 db;
        UserRepo userRepo;
        movieShows mv;
        
        public Reciept()
        {
            InitializeComponent();
        }
        public Reciept(movieShows movies,movieTicketing mvTickets)
        {
            InitializeComponent();
            db = new db_movie_ticketingEntities3();
            mv = movies;
            movie = mvTickets;
            mv = db.movieShows.Where(m => m.movieId == UserRepo.mvId).FirstOrDefault();
            movie = db.movieTicketing.Where(s => s.tckId == UserRepo.tckId).FirstOrDefault();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblUser_Load(object sender, EventArgs e)
        {
            using (db = new db_movie_ticketingEntities3())
            {
                

                lblUsername.Text = UserLogged.GetInstance().UserAccount.custName;
                lblId.Text = UserLogged.GetInstance().UserAccount.custId.ToString();
                lblAddress.Text = UserLogged.GetInstance().UserAccount.custAddress.ToString();  
                lblEmail.Text = UserLogged.GetInstance().UserAccount.custEmail.ToString();
                lblPhone.Text = UserLogged.GetInstance().UserAccount.custPhone.ToString();

                lblMvId.Text = MovieLogged.GetInstance().movieAccount.movieId.ToString();
                lblTitle.Text = MovieLogged.GetInstance().movieAccount.moviName.ToString(); 
                lblGenre.Text = MovieLogged.GetInstance().movieAccount.movieType.ToString();
                lblDuration.Text = MovieLogged.GetInstance().movieAccount.movieHour.ToString(); 
                lblPrice.Text = MovieLogged.GetInstance().movieAccount.moviePrice.ToString();

                lblTicketID.Text = TicketLogged.GetInstance().movieTickets.tckId.ToString();
                
            }
                
        }
    }
}
