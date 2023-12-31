﻿    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using Dbsys;
using MovieTicketing.AppData;
using WMPLib;

namespace MovieTicketing.Forms
{
    public partial class staffDashboard : Form
    {
       // WindowsMediaPlayer player = new WindowsMediaPlayer();   
        private db_movie_ticketingEntities3 db;
        UserRepo userRepo;
        UserInfo customer;
        public staffDashboard()
        {
            InitializeComponent();
            //player.URL = "caloocan.mp3";
            db = new db_movie_ticketingEntities3();         
        }
        public staffDashboard(UserInfo customerInfo)
        {
            InitializeComponent();
            //player.URL = "caloocan.mp3";
            db = new db_movie_ticketingEntities3();
            customer = customerInfo;
            customer = db.UserInfo.Where(m => m.custId == UserRepo.userId).FirstOrDefault();
        }

        private void ApprovedTicket_Load(object sender, EventArgs e)
        {
             
            txtName.Text = customer.custName;
            txtUserID.Text = customer.custId.ToString();
            

            //player.controls.play();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MovieRegistry().Show();                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DeleteMovie().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new UpdateMovie().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
    }
}
