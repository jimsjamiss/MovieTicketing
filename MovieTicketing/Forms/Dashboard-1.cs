using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieTicketing.AppData;

namespace MovieTicketing.Forms
{
    public partial class Dashboard_1 : Form
    {
        db_movie_ticketingEntities3 db;
        movieShows movies = new movieShows();
        public Dashboard_1()
        {
            InitializeComponent();
            loadDataToCBox();
            
        }

        private void Dashboard_1_Load(object sender, EventArgs e)
        {
           
            cboxCinema.DataSource = Enum.GetValues(typeof(cinema));
            cboxTitle.Text = "--------------Select--------------";
            cboxCinema.Text = "--------------Select--------------";

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
    }
}
