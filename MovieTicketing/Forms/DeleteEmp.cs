﻿using MovieTicketing.AppData;
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
    public partial class DeleteEmp : Form
    {
        db_movie_ticketingEntities3 db;
        UserRepo userRepo;
        int? selectedMovieId = null;
        public DeleteEmp()
        {
            InitializeComponent();
        }

        private void DeleteEmp_Load(object sender, EventArgs e)
        {
            userRepo = new UserRepo();
            loadEmpList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                errorProviderCustom = new ErrorProvider();
                int movieId = int.Parse(txtEmpId.Text);


                String strOutputMsg = "";

                if (selectedMovieId == null)
                {
                    MessageBox.Show("No Movie Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                ErrorCode retValue = userRepo.RemoveEmp(movieId, ref strOutputMsg);
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
                    txtEmail.Clear();
                    txtEmpAddress.Clear();
                    txtPhone.ResetText();
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

        private void dtgEmpList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
    }
}
