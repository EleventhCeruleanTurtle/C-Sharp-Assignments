namespace Lab3B
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.hairdresserComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chargedItemsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.calculateTotalPriceButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select A Hairdresser:";
            // 
            // hairdresserComboBox
            // 
            this.hairdresserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hairdresserComboBox.FormattingEnabled = true;
            this.hairdresserComboBox.Items.AddRange(new object[] {
            "Jane",
            "Pat",
            "Ron",
            "Sue",
            "Laurie"});
            this.hairdresserComboBox.Location = new System.Drawing.Point(11, 59);
            this.hairdresserComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.hairdresserComboBox.Name = "hairdresserComboBox";
            this.hairdresserComboBox.Size = new System.Drawing.Size(180, 26);
            this.hairdresserComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select A Service:";
            // 
            // serviceListBox
            // 
            this.serviceListBox.FormattingEnabled = true;
            this.serviceListBox.ItemHeight = 18;
            this.serviceListBox.Items.AddRange(new object[] {
            "Cut",
            "Wash, Blow-dry and style",
            "Colour",
            "Highlights",
            "Extensions",
            "Up-do"});
            this.serviceListBox.Location = new System.Drawing.Point(257, 60);
            this.serviceListBox.Margin = new System.Windows.Forms.Padding(4);
            this.serviceListBox.Name = "serviceListBox";
            this.serviceListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.serviceListBox.Size = new System.Drawing.Size(178, 202);
            this.serviceListBox.TabIndex = 3;
            this.serviceListBox.SelectedIndexChanged += new System.EventHandler(this.serviceListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Charged Items:";
            // 
            // chargedItemsListBox
            // 
            this.chargedItemsListBox.FormattingEnabled = true;
            this.chargedItemsListBox.ItemHeight = 18;
            this.chargedItemsListBox.Location = new System.Drawing.Point(464, 59);
            this.chargedItemsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.chargedItemsListBox.Name = "chargedItemsListBox";
            this.chargedItemsListBox.Size = new System.Drawing.Size(178, 202);
            this.chargedItemsListBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(666, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // priceListBox
            // 
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.ItemHeight = 18;
            this.priceListBox.Location = new System.Drawing.Point(669, 59);
            this.priceListBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(178, 202);
            this.priceListBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Price:";
            // 
            // addServiceButton
            // 
            this.addServiceButton.Enabled = false;
            this.addServiceButton.Location = new System.Drawing.Point(214, 339);
            this.addServiceButton.Margin = new System.Windows.Forms.Padding(4);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(154, 32);
            this.addServiceButton.TabIndex = 9;
            this.addServiceButton.Text = "Add service";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // calculateTotalPriceButton
            // 
            this.calculateTotalPriceButton.Enabled = false;
            this.calculateTotalPriceButton.Location = new System.Drawing.Point(376, 339);
            this.calculateTotalPriceButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateTotalPriceButton.Name = "calculateTotalPriceButton";
            this.calculateTotalPriceButton.Size = new System.Drawing.Size(154, 32);
            this.calculateTotalPriceButton.TabIndex = 10;
            this.calculateTotalPriceButton.Text = "Calculate Total Price";
            this.calculateTotalPriceButton.UseVisualStyleBackColor = true;
            this.calculateTotalPriceButton.Click += new System.EventHandler(this.calculateTotalPriceButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(538, 339);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(154, 32);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(700, 339);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(154, 32);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(700, 295);
            this.totalPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(148, 24);
            this.totalPriceTextBox.TabIndex = 13;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 457);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateTotalPriceButton);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chargedItemsListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serviceListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hairdresserComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form1";
            this.Text = "Perfect Cut Hair Salon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hairdresserComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox serviceListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox chargedItemsListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox priceListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Button calculateTotalPriceButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox totalPriceTextBox;
    }
}

