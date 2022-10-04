namespace SU_Cafeteria
{
    partial class LoginAs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAs));
            this.lLoginAs = new System.Windows.Forms.Label();
            this.suMoto = new System.Windows.Forms.Label();
            this.btnAsFFM = new System.Windows.Forms.Button();
            this.btnAsCFM = new System.Windows.Forms.Button();
            this.lAsExit = new System.Windows.Forms.Label();
            this.pLoginAs = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.suLogo = new System.Windows.Forms.PictureBox();
            this.pLoginAs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lLoginAs
            // 
            this.lLoginAs.AutoSize = true;
            this.lLoginAs.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLoginAs.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lLoginAs.Location = new System.Drawing.Point(70, 197);
            this.lLoginAs.Name = "lLoginAs";
            this.lLoginAs.Size = new System.Drawing.Size(148, 36);
            this.lLoginAs.TabIndex = 1;
            this.lLoginAs.Text = "LOGIN AS";
            // 
            // suMoto
            // 
            this.suMoto.AutoSize = true;
            this.suMoto.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suMoto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.suMoto.Location = new System.Drawing.Point(45, 162);
            this.suMoto.Name = "suMoto";
            this.suMoto.Size = new System.Drawing.Size(204, 20);
            this.suMoto.TabIndex = 3;
            this.suMoto.Text = "We Serve the Community!";
            // 
            // btnAsFFM
            // 
            this.btnAsFFM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAsFFM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsFFM.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsFFM.ForeColor = System.Drawing.Color.LightGray;
            this.btnAsFFM.Location = new System.Drawing.Point(3, 27);
            this.btnAsFFM.Name = "btnAsFFM";
            this.btnAsFFM.Size = new System.Drawing.Size(194, 45);
            this.btnAsFFM.TabIndex = 0;
            this.btnAsFFM.Text = "FFM";
            this.btnAsFFM.UseVisualStyleBackColor = false;
            this.btnAsFFM.Click += new System.EventHandler(this.btnAsFFM_Click);
            // 
            // btnAsCFM
            // 
            this.btnAsCFM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAsCFM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsCFM.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsCFM.ForeColor = System.Drawing.Color.LightGray;
            this.btnAsCFM.Location = new System.Drawing.Point(3, 78);
            this.btnAsCFM.Name = "btnAsCFM";
            this.btnAsCFM.Size = new System.Drawing.Size(194, 45);
            this.btnAsCFM.TabIndex = 0;
            this.btnAsCFM.Text = "CFM";
            this.btnAsCFM.UseVisualStyleBackColor = false;
            this.btnAsCFM.Click += new System.EventHandler(this.btnAsCFM_Click);
            // 
            // lAsExit
            // 
            this.lAsExit.AutoSize = true;
            this.lAsExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lAsExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAsExit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lAsExit.Location = new System.Drawing.Point(82, 176);
            this.lAsExit.Name = "lAsExit";
            this.lAsExit.Size = new System.Drawing.Size(32, 16);
            this.lAsExit.TabIndex = 1;
            this.lAsExit.Text = "Exit";
            this.lAsExit.Click += new System.EventHandler(this.label1_Click);
            // 
            // pLoginAs
            // 
            this.pLoginAs.Controls.Add(this.lAsExit);
            this.pLoginAs.Controls.Add(this.btnAsCFM);
            this.pLoginAs.Controls.Add(this.btnAsFFM);
            this.pLoginAs.Location = new System.Drawing.Point(46, 236);
            this.pLoginAs.Name = "pLoginAs";
            this.pLoginAs.Size = new System.Drawing.Size(200, 201);
            this.pLoginAs.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(255, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // suLogo
            // 
            this.suLogo.Image = global::SU_Cafeteria.Properties.Resources.Icon;
            this.suLogo.Location = new System.Drawing.Point(46, 12);
            this.suLogo.Name = "suLogo";
            this.suLogo.Size = new System.Drawing.Size(203, 144);
            this.suLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.suLogo.TabIndex = 0;
            this.suLogo.TabStop = false;
            // 
            // LoginAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 447);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.suMoto);
            this.Controls.Add(this.pLoginAs);
            this.Controls.Add(this.lLoginAs);
            this.Controls.Add(this.suLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginAs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SU Cafeteria - Login As";
            this.Load += new System.EventHandler(this.LoginAs_Load);
            this.pLoginAs.ResumeLayout(false);
            this.pLoginAs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox suLogo;
        private System.Windows.Forms.Label lLoginAs;
        private System.Windows.Forms.Label suMoto;
        private System.Windows.Forms.Button btnAsFFM;
        private System.Windows.Forms.Button btnAsCFM;
        private System.Windows.Forms.Label lAsExit;
        private System.Windows.Forms.Panel pLoginAs;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

