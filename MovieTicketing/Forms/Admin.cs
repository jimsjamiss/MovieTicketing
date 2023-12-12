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
using System.Xml.Linq;

namespace MovieTicketing.Forms
{
    public partial class Admin : Form
    {
        private db_movie_ticketingEntities3 db;
        UserRepo userRepo;
        UserInfo customer;
        public Admin()
        {
            InitializeComponent();
            db = new db_movie_ticketingEntities3();
        }
        public Admin(UserInfo customerInfo)
        {
            InitializeComponent();
            //player.URL = "caloocan.mp3";
            db = new db_movie_ticketingEntities3();
            customer = customerInfo;
            customer = db.UserInfo.Where(m => m.custId == UserRepo.userId).FirstOrDefault();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = customer.custName;
            txtUserId.Text = customer.custId.ToString();

            userRepo = new UserRepo();
            loadCustList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
        private void loadCustList()
        {
            dtgCustInfo.DataSource = userRepo.custList();
         
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new DeleteEmp().Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new UpdateEmp().Show();
        }
    }
}
