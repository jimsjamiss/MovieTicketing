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
        db_movie_ticketingEntities db;
       UserRepo userRepo;
        int? selectedMovie = null;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSeachMovie.Text = dgvMovieShows.Rows[e.RowIndex].Cells["movieId"].Value.ToString();  
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
            int movieId = int.Parse(txtSeachMovie.Text);
          
            String strOutputMsg = "";

            if (selectedMovie == null)
            {
                MessageBox.Show("No Movie Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ErrorCode retValue = userRepo.RemoveMovie(int.Parse(txtSeachMovie.Text), ref strOutputMsg);
            if (retValue == ErrorCode.Success)
            {
                //Clear the errors
                errorProviderCustom.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadMovieShows();
                //reset the selected id
                selectedMovie = null;

                txtSeachMovie.Clear();
                
            }
            else
            {
                // error 
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
