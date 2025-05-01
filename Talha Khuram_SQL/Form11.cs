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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 nextForm = new Form12();

            // Show the next form

            nextForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form13 nextForm = new Form13();

            // Show the next form

            nextForm.Show();
            this.Close();
        }
    }
}
