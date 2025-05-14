using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pluse_btn_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.num1_txt.Text);
            int num2 = int.Parse(this.num2_txt.Text);
            int result = num1 + num2;
            this.Result_txt.Text = result.ToString();
            this.Ready_lb.Text = "Calculator!";
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            this.num1_txt.Text = "";

            this.num2_txt.Text = "";

            this.Result_txt.Text = "";
            this.Ready_lb.Text = "Ready";
        }

        private void Divide_btn_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.num1_txt.Text);
            int num2 = int.Parse(this.num2_txt.Text);
            int result = num1 / num2;
            this.Result_txt.Text = result.ToString();
            this.Ready_lb.Text = "Calculator!";
        }

        private void Minus_btn_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.num1_txt.Text);
            int num2 = int.Parse(this.num2_txt.Text);
            int result = num1 - num2;
            this.Result_txt.Text = result.ToString();
            this.Ready_lb.Text = "Calculator!";
        }

        private void Hexa_btn_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.num1_txt.Text);
            int num2 = int.Parse(this.num2_txt.Text);
            int result = num1 * num2;
            this.Result_txt.Text = result.ToString();
            this.Ready_lb.Text = "Calculator!";
        }
    }
}
