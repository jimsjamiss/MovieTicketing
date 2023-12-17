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
    public partial class UpdateEmp : Form
    {
        db_movie_ticketingEntities3 db;
        UserRepo userRepo;
        int? selectedMovieId = null;
        public UpdateEmp()
        {
            InitializeComponent();
        }

        private void UpdateEmp_Load(object sender, EventArgs e)
        {
            userRepo = new UserRepo();
            loadEmpList();
        }

        private void dtgEmpList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedMovieId = (Int32)dtgEmpList.Rows[e.RowIndex].Cells[0].Value;
                txtEmpId.Text = dtgEmpList.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtEmpName.Text = dtgEmpList.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtEmpAddress.Text = dtgEmpList.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtEmpRole.Text = dtgEmpList.Rows[e.RowIndex].Cells["Role"].Value.ToString();
                txtEmail.Text = dtgEmpList.Rows[e.RowIndex].Cells["Email_Address"].Value.ToString();
                txtPhone.Text = dtgEmpList.Rows[e.RowIndex].Cells["Phone_Number"].Value.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            errorProviderCustom = new ErrorProvider();
            try
            {
                int empId = Convert.ToInt32(txtEmpId.Text);
                String strOutputMsg = "";

                if (selectedMovieId == null)
                {
                    MessageBox.Show("No Movie Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var movieInfo = userRepo.GetMoviesByMovieId(empId);
                ErrorCode retValue = userRepo.UpdateEmp(empId,txtEmpName.Text,txtEmpAddress.Text,txtEmail.Text,txtPhone.Text,txtEmpRole.Text, ref strOutputMsg);
                if (retValue == ErrorCode.Success)
                {
                    //Clear the errors
                    errorProviderCustom.Clear();
                    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadEmpList();
                    //reset the selected id
                    selectedMovieId = null;

                    txtEmpId.Clear();
                    txtEmpName.Clear();
                    txtEmpAddress.Clear();
                    txtEmpRole.Clear();
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
        private void loadEmpList()
        {
            dtgEmpList.DataSource = userRepo.custList();
        }
    }
}
