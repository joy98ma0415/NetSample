namespace _10202_CS_Project
{
    partial class Week03
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
            this.lcmText = new System.Windows.Forms.TextBox();
            this.lcmLabel = new System.Windows.Forms.Label();
            this.gcdText = new System.Windows.Forms.TextBox();
            this.gcdLabel = new System.Windows.Forms.Label();
            this.integerText2 = new System.Windows.Forms.TextBox();
            this.integerLabel2 = new System.Windows.Forms.Label();
            this.integerText1 = new System.Windows.Forms.TextBox();
            this.integerLabel1 = new System.Windows.Forms.Label();
            this.computeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lcmText
            // 
            this.lcmText.Location = new System.Drawing.Point(266, 63);
            this.lcmText.Name = "lcmText";
            this.lcmText.Size = new System.Drawing.Size(100, 22);
            this.lcmText.TabIndex = 17;
            // 
            // lcmLabel
            // 
            this.lcmLabel.AutoSize = true;
            this.lcmLabel.Location = new System.Drawing.Point(195, 66);
            this.lcmLabel.Name = "lcmLabel";
            this.lcmLabel.Size = new System.Drawing.Size(65, 12);
            this.lcmLabel.TabIndex = 16;
            this.lcmLabel.Text = "最小公倍數";
            // 
            // gcdText
            // 
            this.gcdText.Location = new System.Drawing.Point(89, 63);
            this.gcdText.Name = "gcdText";
            this.gcdText.Size = new System.Drawing.Size(100, 22);
            this.gcdText.TabIndex = 15;
            // 
            // gcdLabel
            // 
            this.gcdLabel.AutoSize = true;
            this.gcdLabel.Location = new System.Drawing.Point(18, 66);
            this.gcdLabel.Name = "gcdLabel";
            this.gcdLabel.Size = new System.Drawing.Size(65, 12);
            this.gcdLabel.TabIndex = 14;
            this.gcdLabel.Text = "最大公因數";
            // 
            // integerText2
            // 
            this.integerText2.Location = new System.Drawing.Point(266, 6);
            this.integerText2.Name = "integerText2";
            this.integerText2.Size = new System.Drawing.Size(100, 22);
            this.integerText2.TabIndex = 13;
            // 
            // integerLabel2
            // 
            this.integerLabel2.AutoSize = true;
            this.integerLabel2.Location = new System.Drawing.Point(213, 9);
            this.integerLabel2.Name = "integerLabel2";
            this.integerLabel2.Size = new System.Drawing.Size(47, 12);
            this.integerLabel2.TabIndex = 12;
            this.integerLabel2.Text = "正整數2";
            // 
            // integerText1
            // 
            this.integerText1.Location = new System.Drawing.Point(89, 6);
            this.integerText1.Name = "integerText1";
            this.integerText1.Size = new System.Drawing.Size(100, 22);
            this.integerText1.TabIndex = 11;
            // 
            // integerLabel1
            // 
            this.integerLabel1.AutoSize = true;
            this.integerLabel1.Location = new System.Drawing.Point(36, 9);
            this.integerLabel1.Name = "integerLabel1";
            this.integerLabel1.Size = new System.Drawing.Size(47, 12);
            this.integerLabel1.TabIndex = 10;
            this.integerLabel1.Text = "正整數1";
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(18, 34);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(348, 23);
            this.computeButton.TabIndex = 9;
            this.computeButton.Text = "計算結果";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // Week03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 91);
            this.Controls.Add(this.lcmText);
            this.Controls.Add(this.lcmLabel);
            this.Controls.Add(this.gcdText);
            this.Controls.Add(this.gcdLabel);
            this.Controls.Add(this.integerText2);
            this.Controls.Add(this.integerLabel2);
            this.Controls.Add(this.integerText1);
            this.Controls.Add(this.integerLabel1);
            this.Controls.Add(this.computeButton);
            this.Name = "Week03";
            this.Text = "第三周 最大公因數&最小公倍數";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lcmText;
        private System.Windows.Forms.Label lcmLabel;
        private System.Windows.Forms.TextBox gcdText;
        private System.Windows.Forms.Label gcdLabel;
        private System.Windows.Forms.TextBox integerText2;
        private System.Windows.Forms.Label integerLabel2;
        private System.Windows.Forms.TextBox integerText1;
        private System.Windows.Forms.Label integerLabel1;
        private System.Windows.Forms.Button computeButton;
    }
}