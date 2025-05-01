using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dbprojforms
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 nextForm = new Form8();

            // Show the next form
           
            nextForm.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form9 nextForm = new Form9();

            // Show the next form

            nextForm.Show();
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form10 nextForm = new Form10();

            // Show the next form

            nextForm.Show();
            this.Close();


        }
    }
}
