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
        db_movie_ticketingEntities3 db;
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
                selectedMovieId = (Int32)dgvMovieShows.Rows[e.RowIndex].Cells[0].Value;
                txtID.Text = dgvMovieShows.Rows[e.RowIndex].Cells["Movie_ID"].Value.ToString();
                txtTitle.Text = dgvMovieShows.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                txtGenre.Text = dgvMovieShows.Rows[e.RowIndex].Cells["Genre"].Value.ToString();
                dtpDate.Text = dgvMovieShows.Rows[e.RowIndex].Cells["Showing_Date"].Value.ToString();
                txtDuration.Text = dgvMovieShows.Rows[e.RowIndex].Cells["Duration"].Value.ToString();
                txtPrice.Text = dgvMovieShows.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorProviderCustom = new ErrorProvider();
            try
            {
                int movieId = int.Parse(txtID.Text);
                String strOutputMsg = "";

                if (selectedMovieId == null)
                {
                    MessageBox.Show("No Movie Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var movieInfo = userRepo.GetMoviesByMovieId(movieId);
                ErrorCode retValue = userRepo.UpdateMovie(movieId, txtTitle.Text, dtpDate.Text, txtDuration.Text, txtGenre.Text, Convert.ToDecimal(txtPrice.Text), ref strOutputMsg);
                if (retValue == ErrorCode.Success)
                {
                    //Clear the errors
                    errorProviderCustom.Clear();
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadMovieShows();
                    //reset the selected id
                    selectedMovieId = null;


                    txtID.Clear();
                    txtTitle.Clear();
                    txtGenre.Clear();
                    dtpDate.ResetText();
                    txtDuration.Clear();

                }
                else
                {
                    // error 
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exception : {ex.Message}");
            }
        }
    }
}
