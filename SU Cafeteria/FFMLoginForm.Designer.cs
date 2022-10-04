namespace SU_Cafeteria
{
    partial class FFMLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFMLoginForm));
            this.suMoto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lLogin = new System.Windows.Forms.Label();
            this.btnFFMLogin = new System.Windows.Forms.Button();
            this.lFFMClear = new System.Windows.Forms.Label();
            this.lFFMExit = new System.Windows.Forms.Label();
            this.tbFFMUsername = new System.Windows.Forms.TextBox();
            this.tbFFMPassword = new System.Windows.Forms.TextBox();
            this.llFFMChangePassword = new System.Windows.Forms.LinkLabel();
            this.picFFMBack = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.suLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFFMBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // suMoto
            // 
            this.suMoto.AutoSize = true;
            this.suMoto.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suMoto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.suMoto.Location = new System.Drawing.Point(44, 144);
            this.suMoto.Name = "suMoto";
            this.suMoto.Size = new System.Drawing.Size(204, 20);
            this.suMoto.TabIndex = 5;
            this.suMoto.Text = "We Serve the Community!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(28, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(28, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lLogin.Location = new System.Drawing.Point(92, 197);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(105, 36);
            this.lLogin.TabIndex = 8;
            this.lLogin.Text = "LOGIN";
            this.lLogin.Click += new System.EventHandler(this.lLogin_Click);
            // 
            // btnFFMLogin
            // 
            this.btnFFMLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFFMLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFFMLogin.FlatAppearance.BorderSize = 0;
            this.btnFFMLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFFMLogin.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFFMLogin.ForeColor = System.Drawing.Color.White;
            this.btnFFMLogin.Location = new System.Drawing.Point(28, 387);
            this.btnFFMLogin.Name = "btnFFMLogin";
            this.btnFFMLogin.Size = new System.Drawing.Size(236, 32);
            this.btnFFMLogin.TabIndex = 9;
            this.btnFFMLogin.Text = "LOG IN";
            this.btnFFMLogin.UseVisualStyleBackColor = false;
            this.btnFFMLogin.Click += new System.EventHandler(this.btnFFMLogin_Click);
            // 
            // lFFMClear
            // 
            this.lFFMClear.AutoSize = true;
            this.lFFMClear.BackColor = System.Drawing.Color.White;
            this.lFFMClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lFFMClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFFMClear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lFFMClear.Location = new System.Drawing.Point(12, 368);
            this.lFFMClear.Name = "lFFMClear";
            this.lFFMClear.Size = new System.Drawing.Size(91, 16);
            this.lFFMClear.TabIndex = 10;
            this.lFFMClear.Text = "Clear Fields";
            this.lFFMClear.Click += new System.EventHandler(this.lFFMClear_Click);
            // 
            // lFFMExit
            // 
            this.lFFMExit.AutoSize = true;
            this.lFFMExit.BackColor = System.Drawing.Color.White;
            this.lFFMExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lFFMExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFFMExit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lFFMExit.Location = new System.Drawing.Point(130, 422);
            this.lFFMExit.Name = "lFFMExit";
            this.lFFMExit.Size = new System.Drawing.Size(32, 16);
            this.lFFMExit.TabIndex = 10;
            this.lFFMExit.Text = "Exit";
            this.lFFMExit.Click += new System.EventHandler(this.lFFMExit_Click);
            // 
            // tbFFMUsername
            // 
            this.tbFFMUsername.BackColor = System.Drawing.Color.White;
            this.tbFFMUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFFMUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFFMUsername.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbFFMUsername.Location = new System.Drawing.Point(65, 266);
            this.tbFFMUsername.Multiline = true;
            this.tbFFMUsername.Name = "tbFFMUsername";
            this.tbFFMUsername.Size = new System.Drawing.Size(199, 24);
            this.tbFFMUsername.TabIndex = 12;
            this.tbFFMUsername.TextChanged += new System.EventHandler(this.tbFFMUsername_TextChanged);
            // 
            // tbFFMPassword
            // 
            this.tbFFMPassword.BackColor = System.Drawing.Color.White;
            this.tbFFMPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFFMPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFFMPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbFFMPassword.Location = new System.Drawing.Point(65, 314);
            this.tbFFMPassword.Multiline = true;
            this.tbFFMPassword.Name = "tbFFMPassword";
            this.tbFFMPassword.PasswordChar = '*';
            this.tbFFMPassword.Size = new System.Drawing.Size(199, 24);
            this.tbFFMPassword.TabIndex = 13;
            // 
            // llFFMChangePassword
            // 
            this.llFFMChangePassword.AutoSize = true;
            this.llFFMChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llFFMChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llFFMChangePassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.llFFMChangePassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llFFMChangePassword.LinkColor = System.Drawing.Color.DodgerBlue;
            this.llFFMChangePassword.Location = new System.Drawing.Point(148, 368);
            this.llFFMChangePassword.Name = "llFFMChangePassword";
            this.llFFMChangePassword.Size = new System.Drawing.Size(132, 16);
            this.llFFMChangePassword.TabIndex = 14;
            this.llFFMChangePassword.TabStop = true;
            this.llFFMChangePassword.Text = "Change Password";
            this.llFFMChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llFFMChangePassword_LinkClicked);
            // 
            // picFFMBack
            // 
            this.picFFMBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFFMBack.Image = global::SU_Cafeteria.Properties.Resources.arrow47;
            this.picFFMBack.Location = new System.Drawing.Point(12, 12);
            this.picFFMBack.Name = "picFFMBack";
            this.picFFMBack.Size = new System.Drawing.Size(28, 25);
            this.picFFMBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFFMBack.TabIndex = 11;
            this.picFFMBack.TabStop = false;
            this.picFFMBack.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SU_Cafeteria.Properties.Resources.pass;
            this.pictureBox2.Location = new System.Drawing.Point(28, 303);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SU_Cafeteria.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(28, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // suLogo
            // 
            this.suLogo.Image = global::SU_Cafeteria.Properties.Resources.Icon;
            this.suLogo.Location = new System.Drawing.Point(28, 12);
            this.suLogo.Name = "suLogo";
            this.suLogo.Size = new System.Drawing.Size(236, 126);
            this.suLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.suLogo.TabIndex = 4;
            this.suLogo.TabStop = false;
            // 
            // FFMLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 447);
            this.Controls.Add(this.llFFMChangePassword);
            this.Controls.Add(this.tbFFMPassword);
            this.Controls.Add(this.tbFFMUsername);
            this.Controls.Add(this.picFFMBack);
            this.Controls.Add(this.lFFMExit);
            this.Controls.Add(this.lFFMClear);
            this.Controls.Add(this.btnFFMLogin);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.suMoto);
            this.Controls.Add(this.suLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FFMLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFM Login Form";
            this.Load += new System.EventHandler(this.FFMLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFFMBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label suMoto;
        private System.Windows.Forms.PictureBox suLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Button btnFFMLogin;
        private System.Windows.Forms.Label lFFMClear;
        private System.Windows.Forms.Label lFFMExit;
        private System.Windows.Forms.PictureBox picFFMBack;
        private System.Windows.Forms.TextBox tbFFMUsername;
        private System.Windows.Forms.TextBox tbFFMPassword;
        private System.Windows.Forms.LinkLabel llFFMChangePassword;
    }
}