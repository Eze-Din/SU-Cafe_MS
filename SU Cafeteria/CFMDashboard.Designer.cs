namespace SU_Cafeteria
{
    partial class CFMDashboard
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
            this.btnInputs = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.dgvDashboard = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInputs
            // 
            this.btnInputs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputs.Location = new System.Drawing.Point(111, 379);
            this.btnInputs.Name = "btnInputs";
            this.btnInputs.Size = new System.Drawing.Size(93, 31);
            this.btnInputs.TabIndex = 31;
            this.btnInputs.Text = "Inputs";
            this.btnInputs.Click += new System.EventHandler(this.btnInputs_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.Location = new System.Drawing.Point(12, 379);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(93, 31);
            this.btnMembers.TabIndex = 33;
            this.btnMembers.Text = "Members";
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // dgvDashboard
            // 
            this.dgvDashboard.BackgroundColor = System.Drawing.Color.White;
            this.dgvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashboard.Location = new System.Drawing.Point(12, 50);
            this.dgvDashboard.Name = "dgvDashboard";
            this.dgvDashboard.Size = new System.Drawing.Size(576, 323);
            this.dgvDashboard.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 36);
            this.label7.TabIndex = 34;
            this.label7.Text = "Dashboard";
            // 
            // CFMDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.btnInputs);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.dgvDashboard);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CFMDashboard";
            this.Text = "CFMDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInputs;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.DataGridView dgvDashboard;
        private System.Windows.Forms.Label label7;
    }
}