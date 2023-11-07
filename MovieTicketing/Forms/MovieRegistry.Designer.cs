namespace MovieTicketing.Forms
{
    partial class MovieRegistry
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
            this.cboxGenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpMovieDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxGenre
            // 
            this.cboxGenre.FormattingEnabled = true;
            this.cboxGenre.Items.AddRange(new object[] {
            " Comedy,",
            " Action,",
            " Animation,",
            " Horror,",
            " Suspense,",
            " Thriller    "});
            this.cboxGenre.Location = new System.Drawing.Point(201, 251);
            this.cboxGenre.Name = "cboxGenre";
            this.cboxGenre.Size = new System.Drawing.Size(134, 24);
            this.cboxGenre.TabIndex = 2;
            this.cboxGenre.SelectedIndexChanged += new System.EventHandler(this.cboxGenre_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Movie Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Movie TItle";
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(36, 84);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(198, 22);
            this.txtMovieTitle.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Movie Duration";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(281, 174);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(198, 22);
            this.txtDuration.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Genre: ";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpMovieDate
            // 
            this.dtpMovieDate.Location = new System.Drawing.Point(36, 184);
            this.dtpMovieDate.MinDate = new System.DateTime(2023, 11, 6, 0, 0, 0, 0);
            this.dtpMovieDate.Name = "dtpMovieDate";
            this.dtpMovieDate.Size = new System.Drawing.Size(200, 22);
            this.dtpMovieDate.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(122, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(253, 37);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Movie";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MovieRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 403);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpMovieDate);
            this.Controls.Add(this.cboxGenre);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMovieTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "MovieRegistry";
            this.Text = "MovieRegistry";
            this.Load += new System.EventHandler(this.MovieRegistry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpMovieDate;
        private System.Windows.Forms.ErrorProvider errorProviderCustom;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ComboBox cboxGenre;
    }
}