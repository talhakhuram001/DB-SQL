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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form11 nextForm = new Form11();

            // Show the next form

            nextForm.Show();
            this.Close();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the password visibility
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
