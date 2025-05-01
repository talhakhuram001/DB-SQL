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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product added to cart", "Success", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product added to Wishlist", "Success", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form15 nextForm = new Form15();

            // Show the next form
            
            nextForm.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form16 nextForm = new Form16();

            // Show the next form

            nextForm.Show();

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form20 newForm = new Form20();
            newForm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form21 newForm = new Form21();
            newForm.Show();
            this.Close();
        }
    }
}
