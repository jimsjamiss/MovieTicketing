using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dbsys;
using MovieTicketing.AppData;
using MovieTicketing.Forms;



namespace MovieTicketing.Forms
{
    public partial class frmLogIn : Form
    {
        UserRepo userRepo;
        public frmLogIn()
        {
            InitializeComponent();

            userRepo = new UserRepo();
            
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                errorProviderCustom.SetError(txtUserName, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProviderCustom.SetError(txtPassword, "Empty Field!");
                return;
            }
            var userLogged = userRepo.GetUserByUsername(txtUserName.Text);

            if (userLogged != null)
            {
                if (userLogged.custPass.Equals(txtPassword.Text))
                {
                    new BookTicket().Show();
                    this.Hide();
                    // Assigned to a singleton
                    //UserLogged.GetInstance().UserAccount = userLogged;

                    //switch ((Role)userLogged.roleId)
                    //{
                    //    case Role.Customer:
                    //        // Load student Dashboard
                    //        new BookTicket().Show();
                    //        this.Hide();
                    //        break;
                    //    case Role.Staff:
                    //        // Load Teacher Dashboard
                    //        new ApprovedTicket().Show();
                    //        this.Hide();
                    //        break;
                    //    case Role.Admin:
                    //        // Load Admin Dashboard
                    //        new ApprovedTicket().Show();
                    //        this.Hide();
                    //        break;
                    //    default:
                    //        MessageBox.Show("User has no role!");
                    //        break;
                    //}
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Username not found");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new frmRegistration().Show();
            this.Hide();
        }
    }
}
