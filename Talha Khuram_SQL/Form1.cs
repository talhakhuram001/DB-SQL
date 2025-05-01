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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            // The checkbox that triggered this event
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
            // Check which checkbox is selected and open the corresponding form
            Form selectedForm = null;

            if (checkBox1.Checked)
            {
                selectedForm = new Form2();
            }
            else if (checkBox2.Checked)
            {
                selectedForm = new Form3();
            }
            else if (checkBox3.Checked)
            {
                selectedForm = new Form4();
            }


            if (selectedForm != null)
            {
                selectedForm.Show(); // Opens the selected form
                this.Hide();        // Closes the current form (Form1)
            }
            else
            {
                MessageBox.Show("Please select a form to open", "No Form Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
