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
    public partial class RegisterStaffAdmin : Form
    {
        public string username = String.Empty;
        db_movie_ticketingEntities3 db;
        public RegisterStaffAdmin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            errorProviderCustom = new System.Windows.Forms.ErrorProvider();

            if (String.IsNullOrEmpty(txtFName.Text))
            {
                errorProviderCustom.SetError(this.txtFName, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPass.Text))
            {
                errorProviderCustom.Clear();
                errorProviderCustom.SetError(txtPass, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                errorProviderCustom.SetError(txtPhone, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                errorProviderCustom.Clear();
                errorProviderCustom.SetError(txtEmail, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                errorProviderCustom.Clear();
                errorProviderCustom.SetError(txtAddress, "Empty field");
                return;
            }

            UserInfo nUserAccount = new UserInfo();
            nUserAccount.custName = txtFName.Text;
            nUserAccount.custPass = txtPass.Text;
            nUserAccount.custEmail = txtEmail.Text;
            nUserAccount.custPhone = txtPhone.Text;
            nUserAccount.custAddress = txtAddress.Text;
            nUserAccount.roles = cboxRoles.SelectedValue.ToString();


            username = txtFName.Text;
            db = new db_movie_ticketingEntities3();
            db.UserInfo.Add(nUserAccount);
            db.SaveChanges();

            txtFName.Clear();
            txtPass.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cboxRoles.ResetText();

            MessageBox.Show("Registered!");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void RegisterStaffAdmin_Load(object sender, EventArgs e)
        {
            cboxRoles.DataSource = Enum.GetValues(typeof(Role));
        }
    }
}
