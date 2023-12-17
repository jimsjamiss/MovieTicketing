namespace MovieTicketing.Forms
{
    partial class Tickets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tickets));
            this.db_movie_ticketingDataSet = new MovieTicketing.db_movie_ticketingDataSet();
            this.vwticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_ticketsTableAdapter = new MovieTicketing.db_movie_ticketingDataSetTableAdapters.vw_ticketsTableAdapter();
            this.dtgTicketList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.db_movie_ticketingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTicketList)).BeginInit();
            this.SuspendLayout();
            // 
            // db_movie_ticketingDataSet
            // 
            this.db_movie_ticketingDataSet.DataSetName = "db_movie_ticketingDataSet";
            this.db_movie_ticketingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwticketsBindingSource
            // 
            this.vwticketsBindingSource.DataMember = "vw_tickets";
            this.vwticketsBindingSource.DataSource = this.db_movie_ticketingDataSet;
            // 
            // vw_ticketsTableAdapter
            // 
            this.vw_ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // dtgTicketList
            // 
            this.dtgTicketList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTicketList.Location = new System.Drawing.Point(-2, -1);
            this.dtgTicketList.Name = "dtgTicketList";
            this.dtgTicketList.RowHeadersWidth = 51;
            this.dtgTicketList.RowTemplate.Height = 24;
            this.dtgTicketList.Size = new System.Drawing.Size(1432, 451);
            this.dtgTicketList.TabIndex = 0;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1429, 451);
            this.Controls.Add(this.dtgTicketList);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_movie_ticketingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTicketList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private db_movie_ticketingDataSet db_movie_ticketingDataSet;
        private System.Windows.Forms.BindingSource vwticketsBindingSource;
        private db_movie_ticketingDataSetTableAdapters.vw_ticketsTableAdapter vw_ticketsTableAdapter;
        private System.Windows.Forms.DataGridView dtgTicketList;
    }
}