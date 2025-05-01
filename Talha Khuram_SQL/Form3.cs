using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbprojforms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 nextForm = new Form7();

            // Show the next form
            nextForm.label2.Text = textBox1.Text;
            nextForm.Show();
            this.Close();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the next form
            Form5 nextForm = new Form5();

            // Show the next form
            nextForm.Show();

            // Close the current form
            this.Close();
        }
    }
}
