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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //middel           heading
            MessageBox.Show("Complain Submitted", "Success", MessageBoxButtons.OK);

            Form7 nextForm = new Form7();

            // Show the next form
            nextForm.label2.Text = "lets pick up where you left off";
            nextForm.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 nextForm = new Form7();

            // Show the next form
            nextForm.label2.Text = "lets pick up where you left off";
            nextForm.Show();

            this.Close();
        }
    }
}
