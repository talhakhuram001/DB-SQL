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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            
            CheckBox changedCheckBox = sender as CheckBox;

            if (changedCheckBox.Checked)
            {
                // Uncheck all other checkboxes
                foreach (Control control in this.Controls)
                {
                    if (control is CheckBox && control != changedCheckBox)
                    {
                        ((CheckBox)control).Checked = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Review Submitted", "Success", MessageBoxButtons.OK);
            Form14 nextForm = new Form14();

            // Show the next form

            nextForm.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 nextForm = new Form14();

            // Show the next form

            nextForm.Show();

            this.Close();
        }
    }
}
