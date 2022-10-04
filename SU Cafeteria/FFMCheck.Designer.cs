namespace SU_Cafeteria
{
    partial class FFMCheck
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
            this.lInpClear = new System.Windows.Forms.Label();
            this.btnInpCancel = new System.Windows.Forms.Button();
            this.btnInpAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInpDate = new System.Windows.Forms.TextBox();
            this.tbInpSupplier = new System.Windows.Forms.TextBox();
            this.tbInpQuantity = new System.Windows.Forms.TextBox();
            this.tbInpName = new System.Windows.Forms.TextBox();
            this.tbInpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvInp = new System.Windows.Forms.DataGridView();
            this.btnInpSearch = new System.Windows.Forms.Button();
            this.btnInpUpdate = new System.Windows.Forms.Button();
            this.btnInpDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInp)).BeginInit();
            this.SuspendLayout();
            // 
            // lInpClear
            // 
            this.lInpClear.AutoSize = true;
            this.lInpClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lInpClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInpClear.Location = new System.Drawing.Point(361, 245);
            this.lInpClear.Name = "lInpClear";
            this.lInpClear.Size = new System.Drawing.Size(91, 16);
            this.lInpClear.TabIndex = 30;
            this.lInpClear.Text = "Clear Fields";
            this.lInpClear.Click += new System.EventHandler(this.lInpClear_Click);
            // 
            // btnInpCancel
            // 
            this.btnInpCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInpCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInpCancel.Location = new System.Drawing.Point(470, 213);
            this.btnInpCancel.Name = "btnInpCancel";
            this.btnInpCancel.Size = new System.Drawing.Size(87, 33);
            this.btnInpCancel.TabIndex = 28;
            this.btnInpCancel.Text = "Cancel";
            this.btnInpCancel.UseVisualStyleBackColor = true;
            this.btnInpCancel.Click += new System.EventHandler(this.btnInpCancel_Click);
            // 
            // btnInpAccept
            // 
            this.btnInpAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInpAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInpAccept.Location = new System.Drawing.Point(470, 172);
            this.btnInpAccept.Name = "btnInpAccept";
            this.btnInpAccept.Size = new System.Drawing.Size(87, 33);
            this.btnInpAccept.TabIndex = 29;
            this.btnInpAccept.Text = "Accept";
            this.btnInpAccept.UseVisualStyleBackColor = true;
            this.btnInpAccept.Click += new System.EventHandler(this.btnInpAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Input Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Input Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Input Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Input Name";
            // 
            // tbInpDate
            // 
            this.tbInpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInpDate.Location = new System.Drawing.Point(191, 215);
            this.tbInpDate.Multiline = true;
            this.tbInpDate.Name = "tbInpDate";
            this.tbInpDate.Size = new System.Drawing.Size(261, 27);
            this.tbInpDate.TabIndex = 23;
            // 
            // tbInpSupplier
            // 
            this.tbInpSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInpSupplier.Location = new System.Drawing.Point(191, 182);
            this.tbInpSupplier.Multiline = true;
            this.tbInpSupplier.Name = "tbInpSupplier";
            this.tbInpSupplier.Size = new System.Drawing.Size(261, 27);
            this.tbInpSupplier.TabIndex = 24;
            // 
            // tbInpQuantity
            // 
            this.tbInpQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInpQuantity.Location = new System.Drawing.Point(191, 149);
            this.tbInpQuantity.Multiline = true;
            this.tbInpQuantity.Name = "tbInpQuantity";
            this.tbInpQuantity.Size = new System.Drawing.Size(261, 27);
            this.tbInpQuantity.TabIndex = 25;
            // 
            // tbInpName
            // 
            this.tbInpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInpName.Location = new System.Drawing.Point(191, 116);
            this.tbInpName.Multiline = true;
            this.tbInpName.Name = "tbInpName";
            this.tbInpName.Size = new System.Drawing.Size(261, 27);
            this.tbInpName.TabIndex = 26;
            // 
            // tbInpID
            // 
            this.tbInpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInpID.Location = new System.Drawing.Point(191, 81);
            this.tbInpID.Multiline = true;
            this.tbInpID.Name = "tbInpID";
            this.tbInpID.Size = new System.Drawing.Size(261, 27);
            this.tbInpID.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Input ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "Check Inputs";
            // 
            // dgvInp
            // 
            this.dgvInp.BackgroundColor = System.Drawing.Color.White;
            this.dgvInp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInp.Location = new System.Drawing.Point(55, 297);
            this.dgvInp.Name = "dgvInp";
            this.dgvInp.Size = new System.Drawing.Size(397, 60);
            this.dgvInp.TabIndex = 31;
            // 
            // btnInpSearch
            // 
            this.btnInpSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInpSearch.Location = new System.Drawing.Point(470, 297);
            this.btnInpSearch.Name = "btnInpSearch";
            this.btnInpSearch.Size = new System.Drawing.Size(87, 60);
            this.btnInpSearch.TabIndex = 32;
            this.btnInpSearch.Text = "Search";
            this.btnInpSearch.UseVisualStyleBackColor = true;
            this.btnInpSearch.Click += new System.EventHandler(this.btnInpSearch_Click);
            // 
            // btnInpUpdate
            // 
            this.btnInpUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInpUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInpUpdate.Location = new System.Drawing.Point(55, 363);
            this.btnInpUpdate.Name = "btnInpUpdate";
            this.btnInpUpdate.Size = new System.Drawing.Size(194, 33);
            this.btnInpUpdate.TabIndex = 33;
            this.btnInpUpdate.Text = "Update";
            this.btnInpUpdate.UseVisualStyleBackColor = true;
            this.btnInpUpdate.Click += new System.EventHandler(this.btnInpUpdate_Click);
            // 
            // btnInpDelete
            // 
            this.btnInpDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInpDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInpDelete.Location = new System.Drawing.Point(255, 363);
            this.btnInpDelete.Name = "btnInpDelete";
            this.btnInpDelete.Size = new System.Drawing.Size(197, 33);
            this.btnInpDelete.TabIndex = 34;
            this.btnInpDelete.Text = "Delete";
            this.btnInpDelete.UseVisualStyleBackColor = true;
            this.btnInpDelete.Click += new System.EventHandler(this.btnInpDelete_Click);
            // 
            // FFMCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.btnInpDelete);
            this.Controls.Add(this.btnInpUpdate);
            this.Controls.Add(this.btnInpSearch);
            this.Controls.Add(this.dgvInp);
            this.Controls.Add(this.lInpClear);
            this.Controls.Add(this.btnInpCancel);
            this.Controls.Add(this.btnInpAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbInpDate);
            this.Controls.Add(this.tbInpSupplier);
            this.Controls.Add(this.tbInpQuantity);
            this.Controls.Add(this.tbInpName);
            this.Controls.Add(this.tbInpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FFMCheck";
            this.Text = "FFMCheck";
            this.Load += new System.EventHandler(this.FFMCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lInpClear;
        private System.Windows.Forms.Button btnInpCancel;
        private System.Windows.Forms.Button btnInpAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInpDate;
        private System.Windows.Forms.TextBox tbInpSupplier;
        private System.Windows.Forms.TextBox tbInpQuantity;
        private System.Windows.Forms.TextBox tbInpName;
        private System.Windows.Forms.TextBox tbInpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvInp;
        private System.Windows.Forms.Button btnInpSearch;
        private System.Windows.Forms.Button btnInpUpdate;
        private System.Windows.Forms.Button btnInpDelete;
    }
}