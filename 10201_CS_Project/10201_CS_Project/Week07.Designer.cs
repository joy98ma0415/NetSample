namespace _10201_CS_Project
{
    partial class Week07
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
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.lblOperand2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDivide = new System.Windows.Forms.RadioButton();
            this.rdbMultiply = new System.Windows.Forms.RadioButton();
            this.rdbSubtract = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.lblOperand1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(736, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(52, 23);
            this.btn_back.TabIndex = 67;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("華康文徵明體W4", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(291, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 50);
            this.label1.TabIndex = 66;
            this.label1.Text = "基本運算";
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutput.Location = new System.Drawing.Point(150, 364);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(501, 42);
            this.txtOutput.TabIndex = 65;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(150, 268);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 34);
            this.btnClear.TabIndex = 64;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(551, 267);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(100, 34);
            this.btnCalculator.TabIndex = 63;
            this.btnCalculator.Text = "計算";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(551, 184);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 22);
            this.txtOperand2.TabIndex = 62;
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(150, 185);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 22);
            this.txtOperand1.TabIndex = 61;
            // 
            // lblOperand2
            // 
            this.lblOperand2.AutoSize = true;
            this.lblOperand2.Location = new System.Drawing.Point(578, 153);
            this.lblOperand2.Name = "lblOperand2";
            this.lblOperand2.Size = new System.Drawing.Size(47, 12);
            this.lblOperand2.TabIndex = 60;
            this.lblOperand2.Text = "運算元2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDivide);
            this.groupBox1.Controls.Add(this.rdbMultiply);
            this.groupBox1.Controls.Add(this.rdbSubtract);
            this.groupBox1.Controls.Add(this.rdbAdd);
            this.groupBox1.Location = new System.Drawing.Point(349, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 149);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "運算子";
            // 
            // rdbDivide
            // 
            this.rdbDivide.AutoSize = true;
            this.rdbDivide.Location = new System.Drawing.Point(15, 114);
            this.rdbDivide.Name = "rdbDivide";
            this.rdbDivide.Size = new System.Drawing.Size(26, 16);
            this.rdbDivide.TabIndex = 3;
            this.rdbDivide.TabStop = true;
            this.rdbDivide.Text = "/";
            this.rdbDivide.UseVisualStyleBackColor = true;
            // 
            // rdbMultiply
            // 
            this.rdbMultiply.AutoSize = true;
            this.rdbMultiply.Location = new System.Drawing.Point(14, 83);
            this.rdbMultiply.Name = "rdbMultiply";
            this.rdbMultiply.Size = new System.Drawing.Size(29, 16);
            this.rdbMultiply.TabIndex = 2;
            this.rdbMultiply.TabStop = true;
            this.rdbMultiply.Text = "*";
            this.rdbMultiply.UseVisualStyleBackColor = true;
            // 
            // rdbSubtract
            // 
            this.rdbSubtract.AutoSize = true;
            this.rdbSubtract.Location = new System.Drawing.Point(15, 52);
            this.rdbSubtract.Name = "rdbSubtract";
            this.rdbSubtract.Size = new System.Drawing.Size(27, 16);
            this.rdbSubtract.TabIndex = 1;
            this.rdbSubtract.TabStop = true;
            this.rdbSubtract.Text = "-";
            this.rdbSubtract.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(14, 21);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(29, 16);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "+";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // lblOperand1
            // 
            this.lblOperand1.AutoSize = true;
            this.lblOperand1.Location = new System.Drawing.Point(177, 153);
            this.lblOperand1.Name = "lblOperand1";
            this.lblOperand1.Size = new System.Drawing.Size(47, 12);
            this.lblOperand1.TabIndex = 58;
            this.lblOperand1.Text = "運算元1";
            // 
            // Week07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.lblOperand2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOperand1);
            this.Name = "Week07";
            this.Text = "Week07";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.Label lblOperand2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDivide;
        private System.Windows.Forms.RadioButton rdbMultiply;
        private System.Windows.Forms.RadioButton rdbSubtract;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.Label lblOperand1;
    }
}