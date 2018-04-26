using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace simpleWizard
{
    public partial class Form1 : Form
    {
        //variable that will help display and clear informations on screen
        bool dataDisplayed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowDataButtonPage6_Click(object sender, EventArgs e)
        {
            Person activePerson = new Person(NameTextBoxPage2.Text, SurnameTextBoxPage3.Text,
                AddressTextBoxPage4.Text, PhoneTextBoxPage5.Text);

            //Checking if user specified all data and these data were't allready displayed
            if(activePerson.areAllDataSpecified() && !dataDisplayed)
            {
                var itemToView = DataListViewPage6.Items.Add("Name: ");
                itemToView.SubItems.Add(activePerson.name);

                itemToView = DataListViewPage6.Items.Add("Surname: ");
                itemToView.SubItems.Add(activePerson.surname);

                itemToView = DataListViewPage6.Items.Add("Address: ");
                itemToView.SubItems.Add(activePerson.address);

                itemToView = DataListViewPage6.Items.Add("Phone: ");
                itemToView.SubItems.Add(activePerson.phone);

                dataDisplayed = true;
            }
            //If data are allready displayed on the screen then do nothing
            else if (!dataDisplayed)
            {
                WarningLabelPage6.Text = "Specify all personal data!";
            }
        }

        private void ClearDataButtonPage6_Click(object sender, EventArgs e)
        {
            DataListViewPage6.Items.Clear();
            dataDisplayed = false;
        }

        private void FinishButtonSimpleWizardEvent(object sender, EventArgs e)
        {
            Close();
        }

        /*
         * This Event occurs always before 'LastPageEventSimpleWizard'
         * when user switch to the last page of wizard
         */
        private void PageChangedSimpleWizardEvent(object sender, AdvancedWizardControl.EventArguments.WizardPageChangedEventArgs e)
        {
            SimpleWizard.FinishButton = false;
            WarningLabelPage6.Text = "";
            DataListViewPage6.Items.Clear();
            dataDisplayed = false;
        }

        private void CancelButtonSimpleWizardEvent(object sender, EventArgs e)
        {
            Close();
        }

        private void LastPageSimpleWizardEvent(object sender, EventArgs e)
        {
            SimpleWizard.FinishButton = true;
            SimpleWizard.NextButtonEnabled = false;
        }
    }
}
