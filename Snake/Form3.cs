using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Back
        {
            Form2 Back = new Form2();
            this.Hide();
            Back.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
