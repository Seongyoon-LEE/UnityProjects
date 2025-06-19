using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clear();

        }

        private void Clear()
        {
            this.num1_text.Text = "";
            this.num2_text.Text = "";
            this.num3_text.Text = "";
            this.num3_lb.Text = "Ready!!------------------------------------";
        }
        double Calculator(string sx, string sy,string op)
        {
            if (string.IsNullOrEmpty(sx) || string.IsNullOrEmpty(sy))
            {
                MessageBox.Show("공백이 입력 되었습니다. 다시 입력 해주세요.");
                this.Clear();
                throw new Exception("공백이 입력 되었습니다. 다시 입력 해주세요."); // 예외를 던진다 Catch에게
            }
            try
            {
                double x = double.Parse(sx.Trim());
                double y = double.Parse(sy.Trim());
                double result = 0.0;
                switch (op)
                {
                    case "+":
                        result = x + y;
                        break;
                    case "-":
                        result = x - y;
                        break;
                    case "/":
                        result = x / y;
                        break;
                    case "*":
                        result = x * y;
                        break;
                }
                return result;
            }
            catch 
            {
                MessageBox.Show("숫자 형식이 잘못되었습니다. 다시 입력 해주세요.");
                this.Clear();
                throw new Exception("숫자 형식이 잘못되었습니다. 다시 입력 해주세요."); // 예외를 던진다 Catch에게
            }
            

        }

        private void num1_btn_Click(object sender, EventArgs e)
        {
            //double num1 = double.Parse(this.num1_text.Text);
            //double num2 = double.Parse(this.num2_text.Text);

            try
            {
                double cal = Calculator(this.num1_text.Text, this.num2_text.Text, "+");
                this.num3_text.Text = cal.ToString();
                this.num3_lb.Text = "+";
            }
            catch
            { }
        }

        private void num2_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double cal = Calculator(this.num1_text.Text, this.num2_text.Text, "-");
                this.num3_text.Text = cal.ToString();
                this.num3_lb.Text = "-";
            }
            catch
            { }
        }

        private void num3_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double cal = Calculator(this.num1_text.Text, this.num2_text.Text, "/");
                this.num3_text.Text = cal.ToString();
                this.num3_lb.Text = "/";
            }
            catch
            { }
        }

        private void num4_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double cal = Calculator(this.num1_text.Text, this.num2_text.Text, "*");
                this.num3_text.Text = cal.ToString();
                this.num3_lb.Text = "*";
            }
            catch
            { }
        }

        private void num5_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void num1_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
