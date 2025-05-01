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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration succesful", "Success", MessageBoxButtons.OK);
            Form3 nextForm = new Form3();

            // Show the next form

            nextForm.Show();
            this.Close();

            
        }
    }
}
