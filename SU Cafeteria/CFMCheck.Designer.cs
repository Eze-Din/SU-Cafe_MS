namespace SU_Cafeteria
{
    partial class CFMCheck
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
            this.cbInp = new System.Windows.Forms.ComboBox();
            this.btnInpDelete = new System.Windows.Forms.Button();
            this.btnInpSearch = new System.Windows.Forms.Button();
            this.dgvInp = new System.Windows.Forms.DataGridView();
            this.lInpClear = new System.Windows.Forms.Label();
            this.btnInpCancel = new System.Windows.Forms.Button();
            this.btnInpAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInpDate = new System.Windows.Forms.TextBox();
            this.tbInpQuantity = new System.Windows.Forms.TextBox();
            this.tbInpName = new System.Windows.Forms.TextBox();
            this.tbInpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInp)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInp
            // 
            this.cbInp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbInp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInp.FormattingEnabled = true;
            this.cbInp.Location = new System.Drawing.Point(187, 238);
            this.cbInp.Name = "cbInp";
            this.cbInp.Size = new System.Drawing.Size(164, 21);
            this.cbInp.TabIndex = 0;
            this.cbInp.SelectedIndexChanged += new System.EventHandler(this.cbInp_SelectedIndexChanged);
            // 
            // btnInpDelete
            // 
            this.btnInpDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInpDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInpDelete.Location = new System.Drawing.Point(466, 151);
            this.btnInpDelete.Name = "btnInpDelete";
            this.btnInpDelete.Size = new System.Drawing.Size(87, 33);
            this.btnInpDelete.TabIndex = 52;
            this.btnInpDelete.Text = "Delete";
            this.btnInpDelete.UseVisualStyleBackColor = true;
            this.btnInpDelete.Click += new System.EventHandler(this.btnInpDelete_Click);
            // 
            // btnInpSearch
            // 
            this.btnInpSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInpSearch.Location = new System.Drawing.Point(466, 313);
            this.btnInpSearch.Name = "btnInpSearch";
            this.btnInpSearch.Size = new System.Drawing.Size(87, 60);
            this.btnInpSearch.TabIndex = 50;
            this.btnInpSearch.Text = "Search";
            this.btnInpSearch.UseVisualStyleBackColor = true;
            this.btnInpSearch.Click += new System.EventHandler(this.btnInpSearch_Click);
            // 
            // dgvInp
            // 
            this.dgvInp.BackgroundColor = System.Drawing.Color.White;
            this.dgvInp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInp.Location = new System.Drawing.Point(51, 313);
            this.dgvInp.Name = "dgvInp";
            this.dgvInp.Size = new System.Drawing.Size(397, 60);
            this.dgvInp.TabIndex = 49;
            // 
            // lInpClear
            // 
            this.lInpClear.AutoSize = true;
            this.lInpClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lInpClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInpClear.Location = new System.Drawing.Point(357, 228);
            this.lInpClear.Name = "lInpClear";
            this.lInpClear.Size = new System.Drawing.Size(91, 16);
            this.lInpClear.TabIndex = 48;
            this.lInpClear.Text = "Clear Fields";
            this.lInpClear.Click += new System.EventHandler(this.lInpClear_Click);
            // 
            // btnInpCancel
            // 
            this.btnInpCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInpCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInpCancel.Location = new System.Drawing.Point(466, 192);
            this.btnInpCancel.Name = "btnInpCancel";
            this.btnInpCancel.Size = new System.Drawing.Size(87, 33);
            this.btnInpCancel.TabIndex = 46;
            this.btnInpCancel.Text = "Cancel";
            this.btnInpCancel.UseVisualStyleBackColor = true;
            this.btnInpCancel.Click += new System.EventHandler(this.btnInpCancel_Click);
            // 
            // btnInpAccept
            // 
            this.btnInpAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInpAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInpAccept.Location = new System.Drawing.Point(466, 112);
            this.btnInpAccept.Name = "btnInpAccept";
            this.btnInpAccept.Size = new System.Drawing.Size(87, 33);
            this.btnInpAccept.TabIndex = 47;
            this.btnInpAccept.Text = "Accept";
            this.btnInpAccept.UseVisualStyleBackColor = true;
            this.btnInpAccept.Click += new System.EventHandler(this.btnInpAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Input Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Input Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Input Name";
            // 
            // tbInpDate
            // 
            this.tbInpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInpDate.Location = new System.Drawing.Point(187, 198);
            this.tbInpDate.Multiline = true;
            this.tbInpDate.Name = "tbInpDate";
            this.tbInpDate.Size = new System.Drawing.Size(261, 27);
            this.tbInpDate.TabIndex = 41;
            // 
            // tbInpQuantity
            // 
            this.tbInpQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInpQuantity.Location = new System.Drawing.Point(187, 165);
            this.tbInpQuantity.Multiline = true;
            this.tbInpQuantity.Name = "tbInpQuantity";
            this.tbInpQuantity.Size = new System.Drawing.Size(261, 27);
            this.tbInpQuantity.TabIndex = 43;
            // 
            // tbInpName
            // 
            this.tbInpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInpName.Location = new System.Drawing.Point(187, 132);
            this.tbInpName.Multiline = true;
            this.tbInpName.Name = "tbInpName";
            this.tbInpName.Size = new System.Drawing.Size(261, 27);
            this.tbInpName.TabIndex = 44;
            // 
            // tbInpID
            // 
            this.tbInpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInpID.Location = new System.Drawing.Point(187, 97);
            this.tbInpID.Multiline = true;
            this.tbInpID.Name = "tbInpID";
            this.tbInpID.Size = new System.Drawing.Size(261, 27);
            this.tbInpID.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Input ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(189, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 36);
            this.label7.TabIndex = 35;
            this.label7.Text = "Check Inputs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Input Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CFMCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.btnInpDelete);
            this.Controls.Add(this.btnInpSearch);
            this.Controls.Add(this.dgvInp);
            this.Controls.Add(this.lInpClear);
            this.Controls.Add(this.btnInpCancel);
            this.Controls.Add(this.btnInpAccept);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbInpDate);
            this.Controls.Add(this.tbInpQuantity);
            this.Controls.Add(this.tbInpName);
            this.Controls.Add(this.tbInpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbInp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CFMCheck";
            this.Text = "CFMCheck";
            this.Load += new System.EventHandler(this.CFMCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInp;
        private System.Windows.Forms.Button btnInpDelete;
        private System.Windows.Forms.Button btnInpSearch;
        private System.Windows.Forms.DataGridView dgvInp;
        private System.Windows.Forms.Label lInpClear;
        private System.Windows.Forms.Button btnInpCancel;
        private System.Windows.Forms.Button btnInpAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInpDate;
        private System.Windows.Forms.TextBox tbInpQuantity;
        private System.Windows.Forms.TextBox tbInpName;
        private System.Windows.Forms.TextBox tbInpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}