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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Product removed from cart", "Success", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form14 nextForm = new Form14();

            // Show the next form

            nextForm.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form17 nextForm = new Form17();

            // Show the next form

            nextForm.Show();

            this.Close();
        }
    }
}
