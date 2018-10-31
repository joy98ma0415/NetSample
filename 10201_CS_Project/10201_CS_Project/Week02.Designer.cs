namespace _10201_CS_Project
{
    partial class Week02
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dTP_CurrentDate = new System.Windows.Forms.DateTimePicker();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.dTP_DOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(470, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(52, 23);
            this.btn_Close.TabIndex = 13;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAge.Location = new System.Drawing.Point(45, 286);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(113, 24);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Your Age : 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcuate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dTP_CurrentDate
            // 
            this.dTP_CurrentDate.Location = new System.Drawing.Point(197, 189);
            this.dTP_CurrentDate.Name = "dTP_CurrentDate";
            this.dTP_CurrentDate.Size = new System.Drawing.Size(200, 22);
            this.dTP_CurrentDate.TabIndex = 10;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCurrentDate.Location = new System.Drawing.Point(45, 187);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(119, 24);
            this.lblCurrentDate.TabIndex = 9;
            this.lblCurrentDate.Text = "Current Date";
            // 
            // dTP_DOB
            // 
            this.dTP_DOB.Location = new System.Drawing.Point(197, 103);
            this.dTP_DOB.Name = "dTP_DOB";
            this.dTP_DOB.Size = new System.Drawing.Size(200, 22);
            this.dTP_DOB.TabIndex = 8;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDOB.Location = new System.Drawing.Point(45, 101);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(49, 24);
            this.lblDOB.TabIndex = 7;
            this.lblDOB.Text = "DOB";
            // 
            // Week02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dTP_CurrentDate);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.dTP_DOB);
            this.Controls.Add(this.lblDOB);
            this.Name = "Week02";
            this.Text = "第二周 資料型態 -- 年齡計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dTP_CurrentDate;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.DateTimePicker dTP_DOB;
        private System.Windows.Forms.Label lblDOB;
    }
}