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
   
    public partial class StaffAdminLogIn : Form
    {
        UserRepo userRepo;
        public StaffAdminLogIn()
        {
            InitializeComponent();
            userRepo = new UserRepo();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            ErrorProvider errorProviderCustom = new ErrorProvider();

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
            var userInfo = userRepo.GetUserByUsername(txtUserName.Text, txtPassword.Text);
            //var userPass = userRepo.GetUserByPassword(txtPassword.Text);

            if (userInfo != null)
            {
                if (userInfo.roles == "Staff")
                {
                    UserRepo.userId = userInfo.custId;
                    new staffDashboard(userInfo).Show();
                    this.Hide();
                }
                else if (userInfo.roles == "Admin")
                {
                    UserRepo.userId = userInfo.custId;
                    new Admin(userInfo).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Password", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Username not found");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegisterStaffAdmin().Show();
        }
    }
}
