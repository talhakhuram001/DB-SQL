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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form16 nextForm = new Form16();

            // Show the next form

            nextForm.Show();

            this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                // Open the new form
                Form18 newForm = new Form18(); 
                newForm.Show();
                this.Close();
            }
            else
            {
                Form19 newForm = new Form19(); 
                newForm.Show();
                this.Close();

            }
        }
    }
}
