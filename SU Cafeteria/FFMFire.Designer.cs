namespace SU_Cafeteria
{
    partial class FFMFire
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
            this.tbFireID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lEmpClear = new System.Windows.Forms.Label();
            this.btnEmpSearch = new System.Windows.Forms.Button();
            this.btnEmpFire = new System.Windows.Forms.Button();
            this.btnEmpCancel = new System.Windows.Forms.Button();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.btnEmpShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFireID
            // 
            this.tbFireID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFireID.Location = new System.Drawing.Point(188, 97);
            this.tbFireID.Multiline = true;
            this.tbFireID.Name = "tbFireID";
            this.tbFireID.Size = new System.Drawing.Size(261, 27);
            this.tbFireID.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(184, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 36);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fire Employee";
            // 
            // lEmpClear
            // 
            this.lEmpClear.AutoSize = true;
            this.lEmpClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lEmpClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmpClear.Location = new System.Drawing.Point(366, 127);
            this.lEmpClear.Name = "lEmpClear";
            this.lEmpClear.Size = new System.Drawing.Size(83, 16);
            this.lEmpClear.TabIndex = 17;
            this.lEmpClear.Text = "Clear Field";
            this.lEmpClear.Click += new System.EventHandler(this.lEmpClear_Click);
            // 
            // btnEmpSearch
            // 
            this.btnEmpSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpSearch.Location = new System.Drawing.Point(467, 96);
            this.btnEmpSearch.Name = "btnEmpSearch";
            this.btnEmpSearch.Size = new System.Drawing.Size(79, 28);
            this.btnEmpSearch.TabIndex = 19;
            this.btnEmpSearch.Text = "Search";
            this.btnEmpSearch.UseVisualStyleBackColor = true;
            this.btnEmpSearch.Click += new System.EventHandler(this.btnEmpSearch_Click);
            // 
            // btnEmpFire
            // 
            this.btnEmpFire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpFire.Location = new System.Drawing.Point(467, 336);
            this.btnEmpFire.Name = "btnEmpFire";
            this.btnEmpFire.Size = new System.Drawing.Size(79, 28);
            this.btnEmpFire.TabIndex = 20;
            this.btnEmpFire.Text = "Fire";
            this.btnEmpFire.UseVisualStyleBackColor = true;
            this.btnEmpFire.Click += new System.EventHandler(this.btnEmpFire_Click);
            // 
            // btnEmpCancel
            // 
            this.btnEmpCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpCancel.Location = new System.Drawing.Point(467, 370);
            this.btnEmpCancel.Name = "btnEmpCancel";
            this.btnEmpCancel.Size = new System.Drawing.Size(79, 28);
            this.btnEmpCancel.TabIndex = 20;
            this.btnEmpCancel.Text = "Cancel";
            this.btnEmpCancel.UseVisualStyleBackColor = true;
            this.btnEmpCancel.Click += new System.EventHandler(this.btnEmpCancel_Click);
            // 
            // dgvEmp
            // 
            this.dgvEmp.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(52, 161);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.Size = new System.Drawing.Size(397, 237);
            this.dgvEmp.TabIndex = 21;
            // 
            // btnEmpShow
            // 
            this.btnEmpShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpShow.Location = new System.Drawing.Point(467, 130);
            this.btnEmpShow.Name = "btnEmpShow";
            this.btnEmpShow.Size = new System.Drawing.Size(79, 28);
            this.btnEmpShow.TabIndex = 22;
            this.btnEmpShow.Text = "Show";
            this.btnEmpShow.UseVisualStyleBackColor = true;
            this.btnEmpShow.Click += new System.EventHandler(this.btnEmpShow_Click);
            // 
            // FFMFire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.btnEmpShow);
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.btnEmpCancel);
            this.Controls.Add(this.btnEmpFire);
            this.Controls.Add(this.btnEmpSearch);
            this.Controls.Add(this.lEmpClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbFireID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FFMFire";
            this.Text = "FFMFire";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFireID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lEmpClear;
        private System.Windows.Forms.Button btnEmpSearch;
        private System.Windows.Forms.Button btnEmpFire;
        private System.Windows.Forms.Button btnEmpCancel;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.Button btnEmpShow;
    }
}