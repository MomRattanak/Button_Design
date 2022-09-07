using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked)
            {
                this.BackColor = Color.Black;
                rjToggleButton1.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                rjToggleButton2.ForeColor = Color.Black;
            }
        }
        

        private void rjToggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(rjToggleButton2.Checked)
            {
                rjToggleButton1.Hide();
            }
            else
            {
                rjToggleButton1.Show();
            }
        }

        private void rjToggleButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(rjToggleButton3.Checked)
            {
                
            }
        }
    }
}
