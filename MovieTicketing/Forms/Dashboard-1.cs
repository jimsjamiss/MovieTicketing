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

        public Dashboard_1()
        {
            InitializeComponent();
            loadDataToCBox();

        }

        private void Dashboard_1_Load(object sender, EventArgs e)
        {
            movies = new movieShows();
            cboxCinema.DataSource = Enum.GetValues(typeof(cinema));
            cboxTitle.Text = "--------------Select--------------";
            cboxCinema.Text = "--------------Select--------------";
            userRepo = new UserRepo();
            loadMovies();

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
                    txtTitle.Text = title.moviName.ToString();
                    txtGenre.Text = title.movieType.ToString();
                    txtDate.Text = title.movieDate.ToString();
                    txtDuration.Text = title.movieHour.ToString();
                    txtPrice.Text = title.moviePrice.ToString();
                    txtMvID.Visible = true;
                    txtTitle.Visible = true;
                    txtGenre.Visible = true;
                    txtDate.Visible = true;
                    txtDuration.Visible = true;
                    txtPrice.Visible = true;
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
     
    }
}
