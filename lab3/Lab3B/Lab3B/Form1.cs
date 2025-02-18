using System;
using System.Windows.Forms;

/*
  Class: Form1.cs
  Date: Novemeber 3 2024
  Purpose: To cleanly display and calculate costs for a hairdressing company depending on chosen hairdresser and services.

*/

namespace Lab3B
{
    /// <summary>
    /// The class responsible for the calculations and controls of the form
    /// </summary>
    public partial class form1 : Form
    {
        /// <summary>
        /// Starts the form and sets the hairdresser combo box to be Jane so the default isnt blank
        /// </summary>
        public form1()
        {
            InitializeComponent();
            hairdresserComboBox.SelectedItem = "Jane";
        }

        // variable to hold
        private double total = 0;
        // boolean to determine if a hair dressser has already been chosen. Used to prevent adding multiple hair dressers or the same one multiple times.
        private bool hairdresserChosen = false;
        
        /// <summary>
        /// Adds up the total of all the services and the hair dresser selected, adds them to the charged items and price listbox.
        /// Also enables the total price button and disables the hair dresser combobox.
        /// </summary>
        /// <param name="sender">reference to the addServiceButton</param>
        /// <param name="e">contains event data</param>
        private void addServiceButton_Click(object sender, EventArgs e)
        {
            // enable calculate total price button
            calculateTotalPriceButton.Enabled = true;
            // disable hairdresser combobox
            hairdresserComboBox.Enabled = false;
            // hairdresser
            if(hairdresserComboBox.Text == "Jane" && hairdresserChosen == false)
            {
                total += 30;
                hairdresserChosen = true;
                chargedItemsListBox.Items.Add(hairdresserComboBox.Text);
                priceListBox.Items.Add("$30.00");
            } else if (hairdresserComboBox.Text == "Pat")
            {
                total += 45;
                hairdresserChosen = true;
                chargedItemsListBox.Items.Add(hairdresserComboBox.Text);
                priceListBox.Items.Add("$45.00");
            }
            else if (hairdresserComboBox.Text == "Ron" && hairdresserChosen == false)
            {
                total += 40;
                hairdresserChosen = true;
                chargedItemsListBox.Items.Add(hairdresserComboBox.Text);
                priceListBox.Items.Add("$40.00");
            }
            else if (hairdresserComboBox.Text == "Sue" && hairdresserChosen == false)
            {
                total += 50;
                hairdresserChosen = true;
                chargedItemsListBox.Items.Add(hairdresserComboBox.Text);
                priceListBox.Items.Add("$50.00");
            }
            else if (hairdresserComboBox.Text == "Laurie" && hairdresserChosen == false)
            {
                total += 55;
                hairdresserChosen = true;
                chargedItemsListBox.Items.Add(hairdresserComboBox.Text);
                priceListBox.Items.Add("$55.00");
            }

            // services listbox
            if (serviceListBox.SelectedItems.Contains("Cut"))
            {
                total += 30;
                chargedItemsListBox.Items.Add("Cut");
                priceListBox.Items.Add("$30.00");
            }
            if (serviceListBox.SelectedItems.Contains("Wash, Blow-dry and style"))
            {
                total += 20;
                chargedItemsListBox.Items.Add("Wash, Blow-dry and style");
                priceListBox.Items.Add("$20.00");
            }
            if (serviceListBox.SelectedItems.Contains("Colour"))
            {
                total += 40;
                chargedItemsListBox.Items.Add("Colour");
                priceListBox.Items.Add("$40.00");
            }
            if (serviceListBox.SelectedItems.Contains("Highlights"))
            {
                total += 50;
                chargedItemsListBox.Items.Add("Highlights");
                priceListBox.Items.Add("$50.00");
            }
            if (serviceListBox.SelectedItems.Contains("Extensions"))
            {
                total += 200;
                chargedItemsListBox.Items.Add("Extensions");
                priceListBox.Items.Add("$200.00");
            }
            if (serviceListBox.SelectedItems.Contains("Up-do"))
            {
                total += 60;
                chargedItemsListBox.Items.Add("Up-do");
                priceListBox.Items.Add("$60.00");
            }

        }

        /// <summary>
        /// Sets the total price textBox to the calcualted total price, formatted to currency.
        /// </summary>
        /// <param name="sender">reference to the calculateTotalPriceButton</param>
        /// <param name="e">contains event data</param>
        private void calculateTotalPriceButton_Click(object sender, EventArgs e)
        {
            totalPriceTextBox.Text = $"{total:C}";
        }

        /// <summary>
        /// resets controls, clears text, sets default values and resets internal variables
        /// </summary>
        /// <param name="sender">reference to the resetButton</param>
        /// <param name="e">contains event data</param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            hairdresserComboBox.SelectedIndex = hairdresserComboBox.Items.IndexOf("Jane");
            chargedItemsListBox.Items.Clear();
            priceListBox.Items.Clear();
            totalPriceTextBox.Text = string.Empty;
            addServiceButton.Enabled = false;
            calculateTotalPriceButton.Enabled = false;
            hairdresserComboBox.Enabled = true;
            hairdresserChosen = false;
            serviceListBox.ClearSelected();
            total = 0;
            hairdresserComboBox.Focus();
        }

        /// <summary>
        /// Exits the form
        /// </summary>
        /// <param name="sender">reference to the exitButton</param>
        /// <param name="e">contains event data</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Detects when an item has been selected for the first time to enable the add service button
        /// </summary>
        /// <param name="sender">reference to the serviceListBox</param>
        /// <param name="e">contains event data</param>
        private void serviceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // enable add service button
            addServiceButton.Enabled = true;
        }
    }
}
