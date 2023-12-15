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
    public partial class Dashboard : Form
    {
        UserInfo userInfo;
        UserRepo userRepo;
        db_movie_ticketingEntities3 db;
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(UserInfo user)
        {
            InitializeComponent();
            db = new db_movie_ticketingEntities3();
            userInfo = user;
            userInfo = db.UserInfo.Where(m => m.custId == UserRepo.userId).FirstOrDefault();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pbox1.Visible == true)
            {
                pbox1.Visible = false;  
                pbox2.Visible = true;
                pbox3.Visible = false;
                pbox4.Visible = false;
                pbox5.Visible = false;
            }
            else if (pbox2.Visible == true)
            {
                pbox2.Visible = false;
                pbox3.Visible = true;
                pbox4.Visible = false;
                pbox5.Visible = false;
                pbox1.Visible = false;
            }
            else if (pbox3.Visible == true)
            {
                pbox3.Visible = false;
                pbox4.Visible = true;
                pbox5.Visible = false;
                pbox1.Visible = false;
                pbox2.Visible = false;
            }
            else if (pbox4.Visible == true)
            {
                pbox4.Visible = false;
                pbox5.Visible = true;
                pbox1.Visible = false;
                pbox2.Visible = false;
                pbox3.Visible = false;
            }
            else if (pbox5.Visible == true)
            {
                pbox5.Visible = false;
                pbox1.Visible = true;
                pbox2.Visible = false;
                pbox3.Visible = false;
                pbox4.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pboxd1.Visible == true)
            {
                pboxd1.Visible = false;
                pboxd2.Visible = true;
                pboxd3.Visible = false;
                pboxd4.Visible = false;
                pboxd5.Visible = false;
            }
            else if (pboxd2.Visible == true)
            {
                pboxd2.Visible = false;
                pboxd3.Visible = true;
                pboxd4.Visible = false;
                pboxd5.Visible = false;
                pboxd1.Visible = false;
            }
            else if (pboxd3.Visible == true)
            {
                pboxd3.Visible = false;
                pboxd4.Visible = true;
                pboxd5.Visible = false;
                pboxd1.Visible = false;
                pboxd2.Visible = false;
            }
            else if (pboxd4.Visible == true)
            {
                pboxd4.Visible = false;
                pboxd5.Visible = true;
                pboxd1.Visible = false;
                pboxd2.Visible = false;
                pboxd3.Visible = false;
            }
            else if (pboxd5.Visible == true)
            {
                pboxd5.Visible = false;
                pboxd1.Visible = true;
                pboxd2.Visible = false;
                pboxd3.Visible = false;
                pboxd4.Visible = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pboxp1.Visible == true)
            {
                pboxp1.Visible = false;
                pboxp2.Visible = true;
                pboxp3.Visible = false;
                pboxp4.Visible = false;
                pboxp5.Visible = false;
            }
            else if (pboxp2.Visible == true)
            {
                pboxp2.Visible = false;
                pboxp3.Visible = true;
                pboxp4.Visible = false;
                pboxp5.Visible = false;
                pboxp1.Visible = false;
            }
            else if (pboxp3.Visible == true)
            {
                pboxp3.Visible = false;
                pboxp4.Visible = true;
                pboxp5.Visible = false;
                pboxp1.Visible = false;
                pboxp2.Visible = false;
            }
            else if (pboxp4.Visible == true)
            {
                pboxp4.Visible = false;
                pboxp5.Visible = true;
                pboxp1.Visible = false;
                pboxp2.Visible = false;
                pboxp3.Visible = false;
            }
            else if (pboxp5.Visible == true)
            {
                pboxp5.Visible = false;
                pboxp1.Visible = true;
                pboxp2.Visible = false;
                pboxp3.Visible = false;
                pboxp4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRepo.userId = userInfo.custId;
            new Dashboard_1(userInfo).Show();
            this.Hide();
        }
    }
}
