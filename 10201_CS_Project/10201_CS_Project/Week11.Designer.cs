namespace _10201_CS_Project
{
    partial class Week11
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
            this.btnClose = new System.Windows.Forms.Button();
            this.stepTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resultTB = new System.Windows.Forms.TextBox();
            this.endTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(390, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // stepTB
            // 
            this.stepTB.Location = new System.Drawing.Point(181, 128);
            this.stepTB.Name = "stepTB";
            this.stepTB.Size = new System.Drawing.Size(100, 22);
            this.stepTB.TabIndex = 24;
            this.stepTB.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(30, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "溫度增量：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 78);
            this.button1.TabIndex = 22;
            this.button1.Text = "開始轉換";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultTB
            // 
            this.resultTB.Location = new System.Drawing.Point(33, 166);
            this.resultTB.Multiline = true;
            this.resultTB.Name = "resultTB";
            this.resultTB.ReadOnly = true;
            this.resultTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTB.Size = new System.Drawing.Size(392, 161);
            this.resultTB.TabIndex = 21;
            // 
            // endTB
            // 
            this.endTB.Location = new System.Drawing.Point(181, 100);
            this.endTB.Name = "endTB";
            this.endTB.Size = new System.Drawing.Size(100, 22);
            this.endTB.TabIndex = 20;
            this.endTB.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "攝氏溫度（止）：";
            // 
            // startTB
            // 
            this.startTB.Location = new System.Drawing.Point(181, 72);
            this.startTB.Name = "startTB";
            this.startTB.Size = new System.Drawing.Size(100, 22);
            this.startTB.TabIndex = 18;
            this.startTB.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(30, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "攝氏溫度（起）：";
            // 
            // Week11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(454, 361);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.stepTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultTB);
            this.Controls.Add(this.endTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startTB);
            this.Controls.Add(this.label1);
            this.Name = "Week11";
            this.Text = "第十一周 while迴圈 -- 攝氏華氏轉換";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox stepTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox resultTB;
        private System.Windows.Forms.TextBox endTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startTB;
        private System.Windows.Forms.Label label1;
    }
}