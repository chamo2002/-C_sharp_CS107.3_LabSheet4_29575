using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4_Question2
{
    

    public partial class Form1 : Form
    {
        public int fnum;
        public int snum;
        public int answer;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToInt32(txtfnum.Text);
            snum = Convert.ToInt32(txtsnum.Text);

            answer = fnum + snum;

            lblanswer.Text = answer.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToInt32(txtfnum.Text);
            snum = Convert.ToInt32(txtsnum.Text);

            answer = fnum - snum;

            lblanswer.Text = answer.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToInt32(txtfnum.Text);
            snum = Convert.ToInt32(txtsnum.Text);

            answer = fnum * snum;

            lblanswer.Text = answer.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToInt32(txtfnum.Text);
            snum = Convert.ToInt32(txtsnum.Text);

            answer = fnum / snum;

            lblanswer.Text = answer.ToString();
        }
    }
}
