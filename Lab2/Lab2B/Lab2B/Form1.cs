using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///
/// Date:    October 6, 2024
/// Purpose: Calculate the total cost for hairdressing services
///
namespace Lab2B
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        private double total; // total cost calculated
        private double discount; // total discount calculated
        private uint visits; // number of client visits

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculates the total cost considering selected hairdresser, services, client type and number of client visits
        /// </summary>
        /// <param name="sender"> default parameter </param>
        /// <param name="e"> defualt parameter </param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Check if all services are unchecked
            if (cutCheckbox.Checked == false && 
                colourCheckbox.Checked == false && 
                highlightsCheckbox.Checked == false && 
                extensionsCheckbox.Checked == false)
            {
                cutCheckbox.Focus();
                DialogResult result = MessageBox.Show("You must select at least one service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            } 
            // check if client visits textbox is a positive integer greater than 0
            else if (!uint.TryParse(clientVisitsTextbox.Text, out visits) || visits == 0) 
            {
                DialogResult result = MessageBox.Show("Client visits must be an integer greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                clientVisitsTextbox.Focus(); 
            }
            else
            {
                total = 0; // reset total
                discount = 0; // reset discount

                // check which radio button in the hairdresser groupbox is checked
                if (janeSamleyRadioButton.Checked == true) { total += 30; }
                else if (patJohnsonRadioButton.Checked == true) { total += 45; }
                else if (ronChambersRadioButton.Checked == true) { total += 40; }
                else if (suePallonRadioButton.Checked == true) { total += 50; }
                else if (lauraRenkinsRadioButton.Checked == true) { total += 55; }

                // Check which checkbox in the services groupbox are checked
                if (cutCheckbox.Checked == true) { total += 30; }
                if (colourCheckbox.Checked == true) { total += 40; }
                if (highlightsCheckbox.Checked == true) { total += 50; }
                if (extensionsCheckbox.Checked == true) { total += 200; }

                // Check which radio button in the client type groupbox is checked
                if (standardAdultRadioButton.Checked == true) { discount += 0; }
                else if (childRadioButton.Checked == true) { discount += 0.10; }
                else if (studentRadioButton.Checked == true) { discount += 0.05; }
                else if (seniorRadioButton.Checked == true) { discount += 0.15; }

                // calculate discount based on entered number of visits
                if (visits >= 1 && visits <= 3) { discount += 0; }
                else if (visits >= 4 && visits <= 8) { discount += 0.05; }
                else if (visits >= 9 && visits <= 13) { discount += 0.1; }
                else if (visits >= 14) { discount += 0.15; }

                // calculate and display total
                total = total - (total * discount);
                totalPriceLabel.Text = $"Total Price: {total:C}";
            }
        }

        /// <summary>
        /// resets the radio buttons to the first radio button, unchecks all checkboxes, sets the textbox to an empty string and resets all internal variables.
        /// </summary>
        /// <param name="sender"> default parameter </param>
        /// <param name="e"> default parameter </param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            total = 0;
            discount = 0;
            visits = 0;
            totalPriceLabel.Text = "Total Price:";
            janeSamleyRadioButton.Checked = true;
            standardAdultRadioButton.Checked = true;
            cutCheckbox.Checked = false;
            colourCheckbox.Checked = false;
            highlightsCheckbox.Checked = false;
            extensionsCheckbox.Checked = false;
            clientVisitsTextbox.Text = string.Empty;
            janeSamleyRadioButton.Focus();
        }

        /// <summary>
        /// Closes the Form
        /// </summary>
        /// <param name="sender"> default parameter </param>
        /// <param name="e"> default parameter </param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
