namespace _10201_CS_Project
{
    partial class Week12
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
            this.resultTB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rateTB = new System.Windows.Forms.TextBox();
            this.endyearTB = new System.Windows.Forms.TextBox();
            this.principalTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultTB
            // 
            this.resultTB.BackColor = System.Drawing.Color.Red;
            this.resultTB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultTB.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultTB.ForeColor = System.Drawing.Color.Yellow;
            this.resultTB.Location = new System.Drawing.Point(26, 187);
            this.resultTB.Name = "resultTB";
            this.resultTB.Size = new System.Drawing.Size(420, 44);
            this.resultTB.TabIndex = 6;
            this.resultTB.Text = "計算結果";
            this.resultTB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rateTB);
            this.groupBox1.Controls.Add(this.endyearTB);
            this.groupBox1.Controls.Add(this.principalTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(26, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "複利計算";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rateTB
            // 
            this.rateTB.Location = new System.Drawing.Point(104, 75);
            this.rateTB.Name = "rateTB";
            this.rateTB.Size = new System.Drawing.Size(73, 27);
            this.rateTB.TabIndex = 5;
            this.rateTB.Text = "2";
            // 
            // endyearTB
            // 
            this.endyearTB.Location = new System.Drawing.Point(293, 33);
            this.endyearTB.Name = "endyearTB";
            this.endyearTB.Size = new System.Drawing.Size(73, 27);
            this.endyearTB.TabIndex = 4;
            this.endyearTB.Text = "6";
            // 
            // principalTB
            // 
            this.principalTB.Location = new System.Drawing.Point(104, 33);
            this.principalTB.Name = "principalTB";
            this.principalTB.Size = new System.Drawing.Size(73, 27);
            this.principalTB.TabIndex = 3;
            this.principalTB.Text = "100000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "年限：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "利率％：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "本金：";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(408, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(52, 23);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Week12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(472, 247);
            this.Controls.Add(this.resultTB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Close);
            this.Name = "Week12";
            this.Text = "第十二周 do/while迴圈 -- 複利計算";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label resultTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox rateTB;
        private System.Windows.Forms.TextBox endyearTB;
        private System.Windows.Forms.TextBox principalTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
    }
}