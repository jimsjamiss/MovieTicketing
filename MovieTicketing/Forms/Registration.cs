using Dbsys.AppData;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace MovieTicketing.Forms
{
    public partial class frmRegistration : Form
    {
        public string username = String.Empty;
        db_movie_ticketingEntities db;
       
        public frmRegistration()
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
           
            customerInfo nUserAccount = new customerInfo();
            nUserAccount.custName = txtFName.Text;
            nUserAccount.custPass = txtPass.Text;
            nUserAccount.custEmail = txtEmail.Text; 
            nUserAccount.custPhone = txtPhone.Text; 
            nUserAccount.custAddress = txtAddress.Text; 
           
            username = txtFName.Text;
            db = new db_movie_ticketingEntities();
            db.customerInfo.Add(nUserAccount);
            db.SaveChanges();

            txtFName.Clear();
            txtPass.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            MessageBox.Show("Registered!");
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
