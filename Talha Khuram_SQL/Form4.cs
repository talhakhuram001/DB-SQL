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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Create an instance of the next form
            Form14 nextForm = new Form14();

            // Show the next form
            nextForm.Show();

            // Close the current form
          
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the next form
            Form6 nextForm = new Form6();

            // Show the next form
            nextForm.Show();

            // Close the current form
            this.Close();
        }
    }
}
