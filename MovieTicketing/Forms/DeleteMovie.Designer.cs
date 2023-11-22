namespace MovieTicketing.Forms
{
    partial class DeleteMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeachMovie = new System.Windows.Forms.TextBox();
            this.dgvMovieShows = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMvID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMvTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMvHrs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMvGenre = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieShows)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Movie by Movie ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSeachMovie
            // 
            this.txtSeachMovie.Location = new System.Drawing.Point(28, 88);
            this.txtSeachMovie.Name = "txtSeachMovie";
            this.txtSeachMovie.Size = new System.Drawing.Size(212, 22);
            this.txtSeachMovie.TabIndex = 1;
            this.txtSeachMovie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvMovieShows
            // 
            this.dgvMovieShows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieShows.Location = new System.Drawing.Point(12, 122);
            this.dgvMovieShows.Name = "dgvMovieShows";
            this.dgvMovieShows.RowHeadersWidth = 51;
            this.dgvMovieShows.RowTemplate.Height = 24;
            this.dgvMovieShows.Size = new System.Drawing.Size(814, 183);
            this.dgvMovieShows.TabIndex = 2;
            this.dgvMovieShows.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(552, 423);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(203, 36);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Movie";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Movie ID";
            // 
            // txtMvID
            // 
            this.txtMvID.Location = new System.Drawing.Point(12, 362);
            this.txtMvID.Name = "txtMvID";
            this.txtMvID.Size = new System.Drawing.Size(216, 22);
            this.txtMvID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Movie Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Movie Title";
            // 
            // txtMvTitle
            // 
            this.txtMvTitle.Location = new System.Drawing.Point(290, 362);
            this.txtMvTitle.Name = "txtMvTitle";
            this.txtMvTitle.Size = new System.Drawing.Size(216, 22);
            this.txtMvTitle.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Movie Duration";
            // 
            // txtMvHrs
            // 
            this.txtMvHrs.Location = new System.Drawing.Point(290, 437);
            this.txtMvHrs.Name = "txtMvHrs";
            this.txtMvHrs.Size = new System.Drawing.Size(216, 22);
            this.txtMvHrs.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Movie Genre";
            // 
            // txtMvGenre
            // 
            this.txtMvGenre.Location = new System.Drawing.Point(552, 362);
            this.txtMvGenre.Name = "txtMvGenre";
            this.txtMvGenre.Size = new System.Drawing.Size(216, 22);
            this.txtMvGenre.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(12, 437);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(246, 22);
            this.dtpDate.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(290, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(203, 36);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 480);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtMvGenre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMvHrs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMvTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMvID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvMovieShows);
            this.Controls.Add(this.txtSeachMovie);
            this.Controls.Add(this.label1);
            this.Name = "DeleteMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Movie";
            this.Load += new System.EventHandler(this.DeleteMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieShows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeachMovie;
        private System.Windows.Forms.DataGridView dgvMovieShows;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ErrorProvider errorProviderCustom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMvID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMvTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMvHrs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMvGenre;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSearch;
    }
}