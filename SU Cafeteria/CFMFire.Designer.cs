namespace SU_Cafeteria
{
    partial class CFMFire
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
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvMem = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lClear = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMemID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(471, 126);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(79, 28);
            this.btnShow.TabIndex = 31;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvMem
            // 
            this.dgvMem.BackgroundColor = System.Drawing.Color.White;
            this.dgvMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMem.Location = new System.Drawing.Point(56, 157);
            this.dgvMem.Name = "dgvMem";
            this.dgvMem.Size = new System.Drawing.Size(397, 237);
            this.dgvMem.TabIndex = 30;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(471, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 28);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFire
            // 
            this.btnFire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.Location = new System.Drawing.Point(471, 332);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(79, 28);
            this.btnFire.TabIndex = 29;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(471, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 28);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lClear
            // 
            this.lClear.AutoSize = true;
            this.lClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClear.Location = new System.Drawing.Point(370, 123);
            this.lClear.Name = "lClear";
            this.lClear.Size = new System.Drawing.Size(83, 16);
            this.lClear.TabIndex = 26;
            this.lClear.Text = "Clear Field";
            this.lClear.Click += new System.EventHandler(this.lClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 36);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fire Members";
            // 
            // tbMemID
            // 
            this.tbMemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemID.Location = new System.Drawing.Point(192, 93);
            this.tbMemID.Multiline = true;
            this.tbMemID.Name = "tbMemID";
            this.tbMemID.Size = new System.Drawing.Size(261, 27);
            this.tbMemID.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Member ID";
            // 
            // CFMFire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgvMem);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMemID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CFMFire";
            this.Text = "CFMFire";
            this.Load += new System.EventHandler(this.CFMFire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvMem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMemID;
        private System.Windows.Forms.Label label2;
    }
}