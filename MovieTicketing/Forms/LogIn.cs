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
            var custInfo = userRepo.GetUserByUsername(txtUserName.Text,txtPassword.Text);
            //var userPass = userRepo.GetUserByPassword(txtPassword.Text);

            if (custInfo != null )
            {
                if (custInfo.custPass != "admin" && custInfo.custName != "Admin")
                {
                    new Dashboard().Show();
                    this.Hide();
                }
                else if (custInfo.custPass == ("admin") && custInfo.custName.Equals("Admin"))
                {
                    UserRepo.userId = custInfo.custId;
                    new AdminDashboard(custInfo).Show();    
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
