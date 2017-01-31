using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HL7_Filter_Creator_V2
{
    public partial class FinalFilter : Form
    {
        public FinalFilter()
        {
            InitializeComponent();
        }

        private void FinalFilter_Load(object sender, EventArgs e)
        {
            filterRichTextBox.Clear();
            filterRichTextBox.Text = inputForm.finalFilterString;

            // clear the finalFilterString so there is nothing left over if the user
            // uses the "Go Back" button from the finalFilter form
            inputForm.finalFilterString = "";
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            inputForm InputForm = new inputForm();
            //hide the current StartScreen form, but do not close it
            this.Hide();

            //display the FilterText form
            InputForm.ShowDialog();

            //close the InputForm when GamePlayForm is exited so the entire program is terminated
            this.Close();
        }
    }
}
