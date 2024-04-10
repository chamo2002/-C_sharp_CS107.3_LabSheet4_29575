using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public int  fnum, snum, answer;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToInt32(txtfnum.Text);
            snum = Convert.ToInt32(txtsnum.Text);

            answer = fnum + snum;

            lblanswer.Text = answer.ToString();
        }
    }
}
