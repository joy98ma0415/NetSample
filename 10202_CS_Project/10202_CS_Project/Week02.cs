﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10202_CS_Project
{
    public partial class Week02 : Form
    {
        decimal num1;
        decimal num2;
        string operation;
        public Week02()
        {
            InitializeComponent();
        }
        private void input(string a)
        {
            if (textBox1.Text == "0")
                textBox1.Text = a;
            else
                textBox1.Text += a;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(0, 1);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sqrt(double.Parse(textBox1.Text))).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            long f = 1;
            for (long i = 1; i <= long.Parse(textBox1.Text); i++)
            {
                f = f * i;
            }
            textBox1.Text = f.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input("3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input("6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input("8");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            input("9");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(textBox1.Text);
            ////////////////////////////////
            switch (operation)
            {
                case "+":
                    textBox1.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    textBox1.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    textBox1.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    textBox1.Text = (num1 / num2).ToString();
                    break;
                case "^":
                    textBox1.Text = (int.Parse(num1.ToString()) ^ int.Parse(num2.ToString())).ToString();
                    break;
                case "%":
                    textBox1.Text = (num1 % num2).ToString();
                    break;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox1.Text);
            operation = "/";
            textBox1.Text = "0";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox1.Text);
            operation = "+";
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox1.Text);
            operation = "-";
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(textBox1.Text);
            operation = "*";
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Visible = false;
            home.Visible = true;
        }

        private void Week02_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            double baseNumber = Convert.ToDouble(textBox1.Text);
            double a = 2;
            double result = Math.Pow(baseNumber, a);
            textBox1.Text = result.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-"))
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else
                textBox1.Text = "-" + textBox1.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double baseNumber = Convert.ToDouble(textBox1.Text);
            double a = 1.0;
            double result = a / baseNumber;
            textBox1.Text = result.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double baseNumber = Convert.ToDouble(textBox1.Text);
            double a = 3;
            double result = Math.Pow(baseNumber, a);
            textBox1.Text = result.ToString();

        }
    }
}
