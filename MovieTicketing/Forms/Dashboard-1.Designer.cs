namespace MovieTicketing.Forms
{
    partial class Dashboard_1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_1));
            this.cboxTitle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxCinema = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nupNumPerson = new System.Windows.Forms.NumericUpDown();
            this.dtgBrowseMovie = new System.Windows.Forms.DataGridView();
            this.txtMvID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBrowseMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxTitle
            // 
            this.cboxTitle.FormattingEnabled = true;
            this.cboxTitle.Location = new System.Drawing.Point(233, 41);
            this.cboxTitle.Name = "cboxTitle";
            this.cboxTitle.Size = new System.Drawing.Size(182, 24);
            this.cboxTitle.TabIndex = 0;
            this.cboxTitle.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cboxTitle.SelectionChangeCommitted += new System.EventHandler(this.cboxTitle_SelectionChangeCommitted);
            this.cboxTitle.SelectedValueChanged += new System.EventHandler(this.cboxTitle_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(120, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie Title:";
            // 
            // cboxCinema
            // 
            this.cboxCinema.FormattingEnabled = true;
            this.cboxCinema.Location = new System.Drawing.Point(233, 112);
            this.cboxCinema.Name = "cboxCinema";
            this.cboxCinema.Size = new System.Drawing.Size(182, 24);
            this.cboxCinema.TabIndex = 0;
            this.cboxCinema.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.label3.Location = new System.Drawing.Point(136, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cinema: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.label4.Location = new System.Drawing.Point(52, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of Person:\r\n";
            // 
            // nupNumPerson
            // 
            this.nupNumPerson.Location = new System.Drawing.Point(233, 179);
            this.nupNumPerson.Name = "nupNumPerson";
            this.nupNumPerson.Size = new System.Drawing.Size(114, 22);
            this.nupNumPerson.TabIndex = 2;
            // 
            // dtgBrowseMovie
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.dtgBrowseMovie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBrowseMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgBrowseMovie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(97)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBrowseMovie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgBrowseMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBrowseMovie.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgBrowseMovie.Location = new System.Drawing.Point(470, 12);
            this.dtgBrowseMovie.Name = "dtgBrowseMovie";
            this.dtgBrowseMovie.RowHeadersWidth = 51;
            this.dtgBrowseMovie.RowTemplate.Height = 24;
            this.dtgBrowseMovie.Size = new System.Drawing.Size(605, 207);
            this.dtgBrowseMovie.TabIndex = 3;
            // 
            // txtMvID
            // 
            this.txtMvID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMvID.Location = new System.Drawing.Point(125, 281);
            this.txtMvID.Name = "txtMvID";
            this.txtMvID.Size = new System.Drawing.Size(170, 30);
            this.txtMvID.TabIndex = 4;
            this.txtMvID.Visible = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(415, 281);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(290, 30);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Visible = false;
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(806, 281);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(170, 30);
            this.txtGenre.TabIndex = 4;
            this.txtGenre.Visible = false;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(415, 382);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(290, 30);
            this.txtDate.TabIndex = 4;
            this.txtDate.Visible = false;
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(125, 382);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(170, 30);
            this.txtDuration.TabIndex = 4;
            this.txtDuration.Visible = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(806, 382);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(170, 30);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.Visible = false;
            // 
            // Dashboard_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1087, 527);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtMvID);
            this.Controls.Add(this.dtgBrowseMovie);
            this.Controls.Add(this.nupNumPerson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxCinema);
            this.Controls.Add(this.cboxTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard_1";
            this.Load += new System.EventHandler(this.Dashboard_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupNumPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBrowseMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxCinema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupNumPerson;
        private System.Windows.Forms.DataGridView dtgBrowseMovie;
        private System.Windows.Forms.TextBox txtMvID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtPrice;
    }
}