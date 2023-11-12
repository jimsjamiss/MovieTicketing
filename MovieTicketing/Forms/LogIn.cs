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
            var userName = userRepo.GetUserByUsername(txtUserName.Text);
            var userPass = userRepo.GetUserByPassword(txtPassword.Text);

            if (userName != null && userPass != null)
            {
                if (userName.custPass.Equals(txtPassword.Text) && userName.custName.Equals(txtUserName))
                {
                    new BookTicket().Show();
                    this.Hide();
                }
                else if (userPass.custPass == ("admin") && userName.custName.Equals("Admin"))
                {
                    new AdminDashboard().Show();    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Password","Incorrect",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
