using Dbsys;
using MovieTicketing.AppData;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MovieTicketing.Forms
{
    public partial class Dashboard_1 : Form
    {
        db_movie_ticketingEntities3 db;
        movieShows movies;
        UserRepo userRepo;
        UserInfo userInfo;
        MovieLogged movie;
        movieTicketing mvTickets;
       

        public Dashboard_1()
        {
            InitializeComponent();
            
            loadDataToCBox();

        }
        public Dashboard_1(UserInfo user)
        {
            InitializeComponent();
           
            loadDataToCBox();
            db = new db_movie_ticketingEntities3();
            movieShows movie = new movieShows();

            userInfo = user;
            userInfo = db.UserInfo.Where(m => m.custId == UserRepo.userId).FirstOrDefault();
            movies = movie;
            movies = db.movieShows.Where(m => m.movieId == UserRepo.mvId).FirstOrDefault();
        }

        private void Dashboard_1_Load(object sender, EventArgs e)
        {
            movies = new movieShows();
            cboxCinema.DataSource = Enum.GetValues(typeof(cinema));
            cboxTitle.Text = "--------------Select--------------";
            cboxCinema.Text = "--------------Select--------------";
            userRepo = new UserRepo();
            loadMovies();
            txtName.Text = userInfo.custName;
            txtID.Text = userInfo.custId.ToString();
        }
        private void cboxTitle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (db = new db_movie_ticketingEntities3())
            {
                movieShows movie = new movieShows();
                var title = db.movieShows.Where(m => m.moviName == cboxTitle.Text).FirstOrDefault();

                if (title != null)
                {
                    txtMvID.Text = title.movieId.ToString();
                    txtGenre.Text = title.movieType.ToString();
                    txtDuration.Text = title.movieHour.ToString();
                    txtPrice.Text = title.moviePrice.ToString();

                }
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadDataToCBox()
        {
            try
            {
                db = new db_movie_ticketingEntities3();
                var title = db.movieShows.Select(m => m.moviName).ToList();
                cboxTitle.DataSource = title;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadMovies()
        {
            dtgBrowseMovie.DataSource = userRepo.browseMovies();
        }
        private void cboxTitle_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            db = new db_movie_ticketingEntities3();
            userRepo = new UserRepo();
            userInfo = new UserInfo();
            mvTickets = new movieTicketing();
            errorProviderCustom = new ErrorProvider();
            
           

            if (String.IsNullOrEmpty(txtMvID.Text))
            {
                errorProviderCustom.Clear();
                errorProviderCustom.SetError(txtMvID, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtDuration.Text))
            {
                errorProviderCustom.SetError(txtDuration, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtGenre.Text))
            {
                errorProviderCustom.Clear();
                errorProviderCustom.SetError(txtGenre, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                errorProviderCustom.Clear();
                errorProviderCustom.SetError(txtPrice, "Empty field");
                return;
            }
            int createdBy = UserLogged.GetInstance().UserAccount.custId;
            int mvs = MovieLogged.GetInstance().movieAccount.movieId;

            //var user = db.UserInfo.Where(m => m.custId == id).FirstOrDefault();
            var movie = db.movieShows.Where(c => c.movieId == mvs).FirstOrDefault();
            var ticks = db.movieTicketing.Where(s => s.tckId == mvTickets.tckId).FirstOrDefault();

            mvTickets.custId = userInfo.custId;
            mvTickets.movieId = movie.movieId;
            mvTickets.Venue = cboxCinema.SelectedValue.ToString();
            mvTickets.Date = DateTime.Now;

            MovieLogged.GetInstance().movieAccount = movie;
            TicketLogged.GetInstance().movieTickets = mvTickets;
            UserRepo.mvId = MovieLogged.GetInstance().movieAccount.movieId;

            TicketLogged.GetInstance().movieTickets = ticks;
            db = new db_movie_ticketingEntities3();
            db.sp_ticketing(mvs, createdBy, mvTickets.Venue,mvTickets.Date,Convert.ToInt32(nupNumPerson.Value));
            db.SaveChanges();

            UserRepo.tckId = mvTickets.tckId;
            new Reciept(movie,ticks).Show();
        }
    }
}
