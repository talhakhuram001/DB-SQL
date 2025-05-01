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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complain status resolved", "Success", MessageBoxButtons.OK);
            Form11 nextForm = new Form11();

            // Show the next form

            nextForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 nextForm = new Form11();

            // Show the next form

            nextForm.Show();
            this.Close();
        }
    }
}
