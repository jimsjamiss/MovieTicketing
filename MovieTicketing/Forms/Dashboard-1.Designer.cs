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
            this.cboxTitle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxCinema = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nupNumPerson = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxTitle
            // 
            this.cboxTitle.FormattingEnabled = true;
            this.cboxTitle.Location = new System.Drawing.Point(41, 94);
            this.cboxTitle.Name = "cboxTitle";
            this.cboxTitle.Size = new System.Drawing.Size(182, 24);
            this.cboxTitle.TabIndex = 0;
            this.cboxTitle.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie Title";
            // 
            // cboxCinema
            // 
            this.cboxCinema.FormattingEnabled = true;
            this.cboxCinema.Location = new System.Drawing.Point(41, 165);
            this.cboxCinema.Name = "cboxCinema";
            this.cboxCinema.Size = new System.Drawing.Size(182, 24);
            this.cboxCinema.TabIndex = 0;
            this.cboxCinema.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cinema: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of Person:\r\n";
            // 
            // nupNumPerson
            // 
            this.nupNumPerson.Location = new System.Drawing.Point(162, 219);
            this.nupNumPerson.Name = "nupNumPerson";
            this.nupNumPerson.Size = new System.Drawing.Size(61, 22);
            this.nupNumPerson.TabIndex = 2;
            // 
            // Dashboard_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 545);
            this.Controls.Add(this.nupNumPerson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxCinema);
            this.Controls.Add(this.cboxTitle);
            this.Name = "Dashboard_1";
            this.Text = "Dashboard_1";
            this.Load += new System.EventHandler(this.Dashboard_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupNumPerson)).EndInit();
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
    }
}