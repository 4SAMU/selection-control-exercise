//programmer name: Prathyusha Pinnintti
//project number: ch6 Exercise
//Description:selection control exercise

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace selection_control_exercise
{
    public partial class selection_control_exercise : Form
    {
        public selection_control_exercise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();

            txtDisplay.AppendText(Environment.NewLine);
            txtDisplay.AppendText("\tNAME:\t\t" + txtname.Text + Environment.NewLine);
            //check events
            txtDisplay.AppendText("\tEVENTS:\t\t" + Environment.NewLine);
            foreach (string item in checkedListBox1.CheckedItems)
            {
                txtDisplay.AppendText("\t\t\t"+item + Environment.NewLine);
            }
           
            // status
            if (txtnew.Checked)
            {
                txtDisplay.AppendText("\tSTATUS:\t\t" + txtnew.Text + Environment.NewLine);
            }
            else if (txtExperienced.Checked)
            {
                txtDisplay.AppendText("\tSTATUS:\t\t" + txtExperienced.Text + Environment.NewLine);

            }
            //where you heard us from
            if (txtFlyers.Checked)
            {
                txtDisplay.AppendText("\twhere you heard us from:\t" + txtFlyers.Text + Environment.NewLine);
            }
            else if (txtFamilyFriends.Checked)
            {
                txtDisplay.AppendText("\twhere you heard us from:\t" + txtFamilyFriends.Text + Environment.NewLine);
            }
            else if (txtEmail.Checked)
            {
                txtDisplay.AppendText("\twhere you heard us from:\t" + txtEmail.Text + Environment.NewLine);
            }
            else if (txtWebsite.Checked)
            {
                txtDisplay.AppendText("\twhere you heard us from:\t" + txtWebsite.Text + Environment.NewLine);
            }
        }
    }
}
