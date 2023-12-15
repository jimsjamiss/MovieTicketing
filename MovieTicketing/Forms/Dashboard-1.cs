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
            userInfo = user;
            userInfo = db.UserInfo.Where(m => m.custId == UserRepo.userId).FirstOrDefault();
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
            errorProviderCustom = new ErrorProvider();
            userInfo = new UserInfo();
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
                    
            
        }
    }
}
