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
    public partial class inputForm : Form
    {
        // create bools for checking if an item is checked in each checkedListBox
        bool PV1Checked = false;
        bool resultTypeChecked = false;
        bool locationChecked = false;

        // create strings for creating the conversion functions
        string PV1CodesString;
        string resultTypeCodeString;
        string locationCodeString;

        // create a string for the entire filter
        public static string finalFilterString;

        public inputForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            
            // call function to see if boxes are checked in the checkedListBoxes
            checkForChecks();

            // Call functions to create string of codes only if an item is checked 
            // in the checkedListBox

            if (PV1Checked == true)
            {
                PV1Conversion();
            }

            if (resultTypeChecked == true)
            {
                resultTypeConversion();
            }

            if (locationChecked == true)
            {
                locationConversion();
            }

            // call the function to build the entire filter string
            finalStringBuilder();

            // open the form with the code to copy and paste

            FinalFilter FinalFilter = new FinalFilter();
            //hide the current Input form, but do not close it
            this.Hide();

            //display the FilterText form
            FinalFilter.ShowDialog();

            //close the InputForm when Form 1 is exited so the entire program is terminated
            this.Close();

        }

        private void checkForChecks()
        {
            // check to see if anything is checked in the checked list boxes
            // and switch checked to "yes" if anything is checked

            foreach (int PV1IndexChecked in PV1CheckedListBox.CheckedIndices)
            {
                PV1Checked = true;
            }

            foreach (int resultTypeIndexChecked in resultTypeCheckedListBox.CheckedIndices)
            {
                resultTypeChecked = true;
            }

            foreach (int locationIndexChecked in locationCheckedListBox.CheckedIndices)
            {
                locationChecked = true;
            }
        }

        private void PV1Conversion()
        {

            // create a bool to determine whether or not a comma should be added
            bool PV1AddComma = false;
            // convert all checked boxes to code and build a string of just codes and commas
            if (PV1CheckedListBox.GetItemCheckState(0) == CheckState.Checked)
            {
                PV1CodesString += "'I'";

                for (int i = 1; i < PV1CheckedListBox.Items.Count; i++)
                {
                    if (PV1CheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                    {
                        PV1AddComma = true;
                    }
                }
                    if (PV1AddComma == true)
                    {
                        PV1CodesString += ",";
                        // switch PV1AddComma back to false so next item can be tested
                        PV1AddComma = false;
                    }
                
            }
            if (PV1CheckedListBox.GetItemCheckState(1) == CheckState.Checked)
            {
                PV1CodesString += "'O'";
                for (int i = 2; i < PV1CheckedListBox.Items.Count; i++)
                {
                    if (PV1CheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                    {
                        PV1AddComma = true;
                    }
                }
                    if (PV1AddComma == true)
                    {
                        PV1CodesString += ",";
                        // switch PV1AddComma back to false so next item can be tested
                        PV1AddComma = false;
                    }
                
            }
            if (PV1CheckedListBox.GetItemCheckState(2) == CheckState.Checked)
            {
                PV1CodesString += "'P'";
                for (int i = 3; i < PV1CheckedListBox.Items.Count; i++)
                {
                    if (PV1CheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                    {
                        PV1AddComma = true;
                    }
                }
                    if (PV1AddComma == true)
                    {
                        PV1CodesString += ",";
                        // switch PV1AddComma back to false so next item can be tested
                        PV1AddComma = false;
                    }
                
            }
            if (PV1CheckedListBox.GetItemCheckState(3) == CheckState.Checked)
            {
                PV1CodesString += "'R'";
                for (int i = 4; i < PV1CheckedListBox.Items.Count; i++)
                {
                    if (PV1CheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                    {
                        PV1AddComma = true;
                    }
                }
                    if (PV1AddComma == true)
                    {
                        PV1CodesString += ",";
                        // switch PV1AddComma back to false so next item can be tested
                        PV1AddComma = false;
                    }
                
            }
            if (PV1CheckedListBox.GetItemCheckState(4) == CheckState.Checked)
            {
                PV1CodesString += "'B'";
                for (int i = 5; i < PV1CheckedListBox.Items.Count; i++)
                {
                    if (PV1CheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                    {
                        PV1AddComma = true;
                    }
                }
                    if (PV1AddComma == true)
                    {
                        PV1CodesString += ",";
                        // switch PV1AddComma back to false so next item can be tested
                        PV1AddComma = false;
                    }
                
            }
            if (PV1CheckedListBox.GetItemCheckState(5) == CheckState.Checked)
            {
                PV1CodesString += "'N'";
                for (int i = 6; i < PV1CheckedListBox.Items.Count; i++)
                {
                    if (PV1CheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                    {
                        PV1AddComma = true;
                    }
                }
                    if (PV1AddComma == true)
                    {
                        PV1CodesString += ",";
                        // switch PV1AddComma back to false so next item can be tested
                        PV1AddComma = false;
                    }
                
            }
            if (PV1CheckedListBox.GetItemCheckState(6) == CheckState.Checked)
            {
                PV1CodesString += "'U'";
                for (int i = 7; i < PV1CheckedListBox.Items.Count; i++)
                {
                    if (PV1CheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                    {
                        PV1AddComma = true;
                    }
                }
                    if (PV1AddComma == true)
                    {
                        PV1CodesString += ",";
                        // switch PV1AddComma back to false so next item can be tested
                        PV1AddComma = false;
                    }
                    
                
            }
            if (PV1CheckedListBox.GetItemCheckState(7) == CheckState.Checked)
            {
                PV1CodesString += "'E'";

            }
        }

        private void resultTypeConversion()
        {
            // convert all checked boxes to code and build a string of just codes and commas

            // create a bool to determine whether or not a comma should be added
            bool resultTypeAddComma = false;
            // convert all checked boxes to code and build a string of just codes and commas
            if (resultTypeCheckedListBox.GetItemCheckState(0) == CheckState.Checked)
            {
                resultTypeCodeString += "ADT'";

                for (int i = 1; i < resultTypeCheckedListBox.Items.Count; i++)
                {
                    if (resultTypeCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                    {
                        resultTypeAddComma = true;
                    }
                }
                if (resultTypeAddComma == true)
                {
                    resultTypeCodeString += ",";
                    // switch PV1AddComma back to false so next item can be tested
                    resultTypeAddComma = false;
                }

            }
            if (resultTypeCheckedListBox.GetItemCheckState(1) == CheckState.Checked)
            {
                resultTypeCodeString += "'LAB'";
                for (int i = 2; i < resultTypeCheckedListBox.Items.Count; i++)
                {
                    if (resultTypeCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                    {
                        resultTypeAddComma = true;
                    }
                }
                if (resultTypeAddComma == true)
                {
                    resultTypeCodeString += ",";
                    // switch PV1AddComma back to false so next item can be tested
                    resultTypeAddComma = false;
                }

            }
            if (resultTypeCheckedListBox.GetItemCheckState(2) == CheckState.Checked)
            {
                resultTypeCodeString += "'RAD'";
            }
        }
        private void locationConversion()
        {
            // convert all checked boxes to code and build a string of just codes and commas

            // create a bool to determine whether or not a comma should be added
            bool locationAddComma = false;

            if (locationCheckedListBox.GetItemCheckState(0) == CheckState.Checked)
            {
                locationCodeString += "'QDS'";
                for (int i = 1; i < locationCheckedListBox.Items.Count; i++)
                {
                    if (locationCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                    {
                        locationAddComma = true;
                    }
                }
                if (locationAddComma == true)
                {
                    locationCodeString += ",";
                    // switch locationAddComma back to false so next item can be tested
                    locationAddComma = false;
                }
            }
            if (locationCheckedListBox.GetItemCheckState(1) == CheckState.Checked)
            {
                locationCodeString += "'MHP'";
                    for (int i = 2; i < locationCheckedListBox.Items.Count; i++)
                    {
                        if (locationCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                        {
                            locationAddComma = true;
                        }
                    }
                if (locationAddComma == true)
                {
                    locationCodeString += ",";

                    locationAddComma = false;
                }
            }
            if (locationCheckedListBox.GetItemCheckState(2) == CheckState.Checked)
            {
                locationCodeString += "'TRI'";
                for (int i = 3; i < locationCheckedListBox.Items.Count; i++)
                {
                    if (locationCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                    {
                        locationAddComma = true;
                    }
                }
                if (locationAddComma == true)
                {
                    locationCodeString += ",";
                    locationAddComma = false;
                }
            }
            if (locationCheckedListBox.GetItemCheckState(3) == CheckState.Checked)
            {
                locationCodeString += "'LCA'";
                for (int i = 4; i < locationCheckedListBox.Items.Count; i++)
                {
                    if (locationCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                    {
                        locationAddComma = true;
                    }
                }
                if (locationAddComma == true)
                {
                    locationCodeString += ",";

                    locationAddComma = false;
                }
            }
            if (locationCheckedListBox.GetItemCheckState(4) == CheckState.Checked)
            {
                locationCodeString += "'CHM'";
            }

        }

        private void finalStringBuilder()
        {
            string PV1StringBuilder;
            string resultTypeStringBuilder;
            string locationStringBuilder;

            // create PV1 portion of final filter
            if (PV1Checked == true)
            {
                PV1StringBuilder = "not(containsAny({HL7:PV1.2-1}, list(" + PV1CodesString + "))";
                finalFilterString = PV1StringBuilder;
            }
            else
            {
                PV1StringBuilder = "";
            }
            // create and append result type portion to final filter
            if (resultTypeChecked == true)
            {
                if (PV1StringBuilder != "")
                {
                    resultTypeStringBuilder = Environment.NewLine + "and" + Environment.NewLine +
                           "not(containsAny({HL7:MSH.21-1}, list(" + resultTypeCodeString + "))";
                }
                else
                {
                    resultTypeStringBuilder = "not(containsAny({HL7:MSH.21-1}, list(" + resultTypeCodeString + "))";
                }
                finalFilterString += resultTypeStringBuilder;
            }
            else
            {
                resultTypeStringBuilder = "";
            }
            //create and append location portion to final filter
            if (locationChecked == true)
            {
                if (PV1StringBuilder != "" && resultTypeStringBuilder != "")
                {
                    locationStringBuilder = Environment.NewLine + "and" + Environment.NewLine +
                           "not(containsAny({HL7:MSH.4-1}, list(" + locationCodeString + "))";
                }
                else
                {
                    locationStringBuilder = "not(containsAny({HL7:MSH.4-1}, list(" + locationCodeString + "))";
                }
                finalFilterString += locationStringBuilder;
            }
        }

        private void locationCodeButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.locationLabel.Text = openFileDialog1.FileName;
            }
        }
    }
}
