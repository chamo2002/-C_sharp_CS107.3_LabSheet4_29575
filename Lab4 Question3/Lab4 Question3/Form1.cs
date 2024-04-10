using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4_Question3
{
    public partial class Form1 : Form
    {
        public int fnum;
        public int snum;
        public int answer;
        public string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           fnum = Convert.ToInt32(txtnum.Text);

            txtnum.Text = "";

            operation = "+";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToInt32(txtnum.Text);

            txtnum.Text = "";

            operation = "-";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToInt32(txtnum.Text);

            txtnum.Text = "";

            operation = "*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToInt32(txtnum.Text);

            txtnum.Text = "";

            operation = "/";
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            snum = Convert.ToInt32(txtnum.Text);

            switch (operation)
            {
                case "+":
                    answer = fnum + snum;
                    break;
                case "-":
                    answer = fnum - snum;
                    break;
                case "*":
                    answer = fnum * snum;
                    break;
                case "/":
                    answer = fnum / snum;
                    break;
            }

            txtnum.Text = answer.ToString();
        }

    }
}

