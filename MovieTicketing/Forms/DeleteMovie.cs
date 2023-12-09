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
    public partial class DeleteMovie : Form
    {
        db_movie_ticketingEntities3 db;
        UserRepo userRepo;
        int? selectedMovieId = null;
        public DeleteMovie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public movieShows searchMovie(string movies)
        {
            using (db = new db_movie_ticketingEntities3())
            {
                return db.movieShows.Where(m => m.moviName == movies).FirstOrDefault();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {
                selectedMovieId = (Int32)dgvMovieShows.Rows[e.RowIndex].Cells[0].Value;
                txtMvID.Text = dgvMovieShows.Rows[e.RowIndex].Cells["Movie_ID"].Value.ToString();
                txtMvTitle.Text = dgvMovieShows.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                txtMvGenre.Text = dgvMovieShows.Rows[e.RowIndex].Cells["Genre"].Value.ToString();
                dtpDate.Text = dgvMovieShows.Rows[e.RowIndex].Cells["Showing_Date"].Value.ToString();
                txtMvHrs.Text = dgvMovieShows.Rows[e.RowIndex].Cells["Time_Slot"].Value.ToString();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }


        }

        private void DeleteMovie_Load(object sender, EventArgs e)
        {
            userRepo = new UserRepo();
            loadMovieShows();
        }
        private void loadMovieShows()
        {
            dgvMovieShows.DataSource = userRepo.AllMovieShows();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                errorProviderCustom = new ErrorProvider();
                int movieId = int.Parse(txtMvID.Text);


                String strOutputMsg = "";

                if (selectedMovieId == null)
                {
                    MessageBox.Show("No Movie Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                ErrorCode retValue = userRepo.RemoveMovie(movieId, ref strOutputMsg);
                if (retValue == ErrorCode.Success)
                {
                    //Clear the errors
                    errorProviderCustom.Clear();
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadMovieShows();
                    //reset the selected id
                    selectedMovieId = null;


                    txtMvID.Clear();
                    txtMvTitle.Clear();
                    txtPrice.Clear();
                    txtMvGenre.Clear();
                    dtpDate.ResetText();
                    txtMvHrs.Clear();
                   

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
