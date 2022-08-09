using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numeric_dropdown
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0";
            numericUpDown2.Text = "1";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal d = numericUpDown1.Value / numericUpDown2.Value;
                label1.Text = d.ToString();

            }
            catch(Exception ex)
            {
                label1.Text = "Can Not Divide By Zero!!";
            }
        }
    }
}
