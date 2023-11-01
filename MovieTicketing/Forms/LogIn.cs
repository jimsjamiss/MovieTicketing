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
                if (userLogged.custPass.Equals(txtPassword.Text) && userLogged.custPass != "000" && userLogged.custName != "Jamis")
                {
                    new BookTicket().Show();
                    this.Hide();
                }
                else if (userLogged.custName.Equals("Jamis") && userLogged.custPass.Equals("000"))
                {
                    new ApprovedTicket().Show();    
                    this.Hide();
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
