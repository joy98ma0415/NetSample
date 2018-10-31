namespace _10202_CS_Project
{
    partial class Week01
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
            this.btnnew = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnreload = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.cborole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnew
            // 
            this.btnnew.AutoSize = true;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(351, 172);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(110, 28);
            this.btnnew.TabIndex = 61;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.AutoSize = true;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(351, 118);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(110, 28);
            this.btnupdate.TabIndex = 59;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnreload
            // 
            this.btnreload.AutoSize = true;
            this.btnreload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreload.Location = new System.Drawing.Point(351, 91);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(110, 28);
            this.btnreload.TabIndex = 60;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btndel
            // 
            this.btndel.AutoSize = true;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(351, 146);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(110, 28);
            this.btndel.TabIndex = 58;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click_1);
            // 
            // dtgList
            // 
            this.dtgList.AllowUserToAddRows = false;
            this.dtgList.AllowUserToDeleteRows = false;
            this.dtgList.AllowUserToResizeColumns = false;
            this.dtgList.AllowUserToResizeRows = false;
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgList.Location = new System.Drawing.Point(13, 203);
            this.dtgList.Name = "dtgList";
            this.dtgList.RowHeadersVisible = false;
            this.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgList.Size = new System.Drawing.Size(452, 138);
            this.dtgList.TabIndex = 57;
            this.dtgList.DoubleClick += new System.EventHandler(this.dtgList_DoubleClick);
            // 
            // btnsave
            // 
            this.btnsave.AutoSize = true;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(351, 63);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(110, 28);
            this.btnsave.TabIndex = 56;
            this.btnsave.Text = "Create";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // cborole
            // 
            this.cborole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cborole.FormattingEnabled = true;
            this.cborole.Items.AddRange(new object[] {
            "Administrator",
            "Staff",
            "Encoder"});
            this.cborole.Location = new System.Drawing.Point(97, 164);
            this.cborole.Name = "cborole";
            this.cborole.Size = new System.Drawing.Size(248, 28);
            this.cborole.TabIndex = 55;
            this.cborole.Text = "Select";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Role:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Password:";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(97, 134);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(248, 26);
            this.txtpass.TabIndex = 52;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Username:";
            // 
            // txtuname
            // 
            this.txtuname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuname.Location = new System.Drawing.Point(97, 105);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(248, 26);
            this.txtuname.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Name:";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(97, 75);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(248, 26);
            this.txtname.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 41);
            this.label1.TabIndex = 47;
            this.label1.Text = "User CRUD";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Week01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(472, 353);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cborole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Week01";
            this.Text = "第一周 CRUD";
            this.Load += new System.EventHandler(this.Week01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.DataGridView dtgList;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox cborole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}