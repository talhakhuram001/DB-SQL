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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complain Submitted", "Success", MessageBoxButtons.OK);
            
            Form14 nextForm = new Form14();

            nextForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form14 nextForm = new Form14();

            nextForm.Show();
            this.Close();
        }
    }
}
