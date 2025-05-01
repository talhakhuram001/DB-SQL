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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration succesful", "Success", MessageBoxButtons.OK);
            Form4 nextForm = new Form4();

            // Show the next form

            nextForm.Show();
            this.Close();

           
        }
    }
}
