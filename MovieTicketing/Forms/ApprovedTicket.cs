﻿using System;
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
using Dbsys;
using MovieTicketing.AppData;

namespace MovieTicketing.Forms
{
    public partial class ApprovedTicket : Form
    {
        private db_movie_ticketingEntities db;
        UserRepo userRepo;

        public ApprovedTicket()
        {
            InitializeComponent();
            
            
        }

        private void ApprovedTicket_Load(object sender, EventArgs e)
        {

        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {
            customerInfo customerInfo = new customerInfo();
            txtName.Text.Equals(customerInfo.custName);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
