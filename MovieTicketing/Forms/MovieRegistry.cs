using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MovieTicketing.AppData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace MovieTicketing.Forms
{
    public partial class MovieRegistry : Form
    {
        public string movieName;
        db_movie_ticketingEntities3 db;
        public MovieRegistry()
        {
            InitializeComponent();
        }

        private void MovieRegistry_Load(object sender, EventArgs e)
        {
            //adding enum to cbox 
            cboxGenre.DataSource = Enum.GetValues(typeof(Genre));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
          

       
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProviderCustom = new System.Windows.Forms.ErrorProvider();

            //if (String.IsNullOrEmpty(txtMovieId.Text))
            //{
            //    errorProviderCustom.SetError(this.txtMovieId, "Empty field");
            //    return;
            //}
            if (String.IsNullOrEmpty(txtMovieTitle.Text))
            {
                errorProviderCustom.Clear();
                errorProviderCustom.SetError(txtMovieTitle, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtDuration.Text))
            {
                errorProviderCustom.SetError(txtDuration, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(cboxGenre.Text))
            {
                errorProviderCustom.Clear();
                errorProviderCustom.SetError(cboxGenre, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(dtpMovieDate.Text))
            {
                errorProviderCustom.Clear();
                errorProviderCustom.SetError(dtpMovieDate, "Empty field");
                return;
            }

            movieShows movieInfo = new movieShows();
           // movieInfo.movieId = txtMovieId.Text;
            movieInfo.moviName = txtMovieTitle.Text;
            movieInfo.movieType = cboxGenre.SelectedValue.ToString();
            movieInfo.movieHour = txtDuration.Text;
            movieInfo.movieDate = dtpMovieDate.Text;


            movieName = txtMovieTitle.Text;
            db = new db_movie_ticketingEntities3();
            db.movieShows.Add(movieInfo);
            db.SaveChanges();

            txtMovieTitle.Clear();
            //txtMovieId.Clear();
            txtDuration.Clear();
            cboxGenre.ResetText();
            dtpMovieDate.ResetText();
            
            MessageBox.Show("Registered!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dtpMovieDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
