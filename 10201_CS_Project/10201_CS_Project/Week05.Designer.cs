namespace _10201_CS_Project
{
    partial class Week05
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.menuCombo = new System.Windows.Forms.ComboBox();
            this.orderList = new System.Windows.Forms.ListBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(211, 117);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(53, 12);
            this.resultLabel.TabIndex = 28;
            this.resultLabel.Text = "尚未統計";
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(211, 91);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(75, 23);
            this.resultButton.TabIndex = 27;
            this.resultButton.Text = "開始統計";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(130, 184);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 26;
            this.clearButton.Text = "清空訂單";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(49, 184);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 25;
            this.removeButton.Text = "移除";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(211, 62);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "訂購";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // menuCombo
            // 
            this.menuCombo.FormattingEnabled = true;
            this.menuCombo.Items.AddRange(new object[] {
            "排骨飯",
            "雞腿飯",
            "焢肉飯",
            "鱈魚飯",
            "豬腳飯"});
            this.menuCombo.Location = new System.Drawing.Point(49, 64);
            this.menuCombo.Name = "menuCombo";
            this.menuCombo.Size = new System.Drawing.Size(156, 20);
            this.menuCombo.TabIndex = 23;
            this.menuCombo.Text = "排骨飯";
            // 
            // orderList
            // 
            this.orderList.FormattingEnabled = true;
            this.orderList.ItemHeight = 12;
            this.orderList.Location = new System.Drawing.Point(49, 90);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(156, 88);
            this.orderList.TabIndex = 22;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(270, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(52, 23);
            this.btn_Close.TabIndex = 21;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Week05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 269);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.menuCombo);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.btn_Close);
            this.Name = "Week05";
            this.Text = "第五周 ComboBox -- 訂便當程式";
            this.Load += new System.EventHandler(this.Week05_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox menuCombo;
        private System.Windows.Forms.ListBox orderList;
        private System.Windows.Forms.Button btn_Close;
    }
}