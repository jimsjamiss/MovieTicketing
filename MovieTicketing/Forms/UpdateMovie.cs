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
    public partial class UpdateMovie : Form
    {
        UserRepo userRepo;
        db_movie_ticketingEntities2 db;
        int? selectedMovieId = null;
        public UpdateMovie()
        {
            InitializeComponent();
        }

        private void UpdateMovie_Load(object sender, EventArgs e)
        {
            userRepo = new UserRepo();
            loadMovieShows();
        }
        private void loadMovieShows()
        {
            dgvMovieShows.DataSource = userRepo.AllMovieShows();
        }

        private void dgvMovieShows_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              
               
                txtTitle.Text = dgvMovieShows.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                txtGenre.Text = dgvMovieShows.Rows[e.RowIndex].Cells["Genre"].Value.ToString();
                dtpDate.Text = dgvMovieShows.Rows[e.RowIndex].Cells["Showing_Date"].Value.ToString();
                txtDuration.Text = dgvMovieShows.Rows[e.RowIndex].Cells["Duration"].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProviderCustom = new ErrorProvider();

            String title = txtTitle.Text;
            String genre = txtGenre.Text;
            String duration = txtDuration.Text;
            String date = dtpDate.Text;

            String strOutputMsg = "";
            // Validation not allow empty or null value

            // Validation not allow empty or null value
             if(String.IsNullOrEmpty(title))
            {
                errorProviderCustom.SetError(txtTitle, "Empty Field!");
                return;
            }
             if (String.IsNullOrEmpty(genre))
            {
                errorProviderCustom.SetError(txtGenre, "Empty Field!");
                return;
            }
             if (String.IsNullOrEmpty(duration))
            {
                errorProviderCustom.SetError(txtDuration, "Empty Field!");
                return;
            }
            var movies = userRepo.GetMoviesByMovieId(title);

            ErrorCode retValue = userRepo.UpdateUser(title, movies, ref strOutputMsg);
            if (retValue == ErrorCode.Success)
            {
                //Clear the errors
                errorProviderCustom.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadMovieShows();
                //reset the selected id
                selectedMovieId = null;


               
                txtTitle.Clear();
                txtGenre.Clear();
                txtDuration.Clear();
                dtpDate.ResetText();    
            }
            else
            {
                // error 
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
