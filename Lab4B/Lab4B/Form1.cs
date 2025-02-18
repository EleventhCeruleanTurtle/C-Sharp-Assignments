using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

/*
  Class: Lab4B.cs
  Date: Novemeber 17 2024
  Purpose: To check html files for balanced tags

*/

namespace Lab4B
{
    /// <summary>
    /// Form1 class which handles the form opening and its operations
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes the forms components
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens an openFileDialog filtered to only allow html, and once a file has been selected, the list box is cleared, the check tags tool strip menu item is enabled
        /// and the file name is dispalyed.
        /// </summary>
        /// <param name="sender">unused information regarding sender of event</param>
        /// <param name="e">Unsed information regarding the event</param>
        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog(); // opens dialog to choose file
            string filePath = openFile.FileName; // file path
            HTMLTagsListBox.Items.Clear(); // empty list box
            if (filePath != "openFile") 
            {
                checkTagsToolStripMenuItem.Enabled = true; // enable check tags menu item
                fileNameLabel.Text = "Loaded: " + Path.GetFileName(filePath); // using file path, gets file name and puts it to the fileNameLabel
            }
            
        }

        /// <summary>
        /// Exits the program
        /// </summary>
        /// <param name="sender">unused information regarding sender of event</param>
        /// <param name="e">Unsed information regarding the event</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Checks the tags of the HTML file selected to ensure each opening tag has its required closing tag and then displays the tags in the list box.
        /// If the file in unbalanced, the listbox will only display up to the next closing tag that did not match
        /// </summary>
        /// <param name="sender">unused information regarding sender of event</param>
        /// <param name="e">Unsed information regarding the event</param>
        private void checkTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stack<string> stack = new Stack<string>();          // The stack the tags will be in
            Stack<string> displayStack = new Stack<string>();   // The stack used to display the tags
            string tag = string.Empty;                          // The tag
            bool inside = false;                                // A boolean for whether or not the current character is inside a tag
            string fileName = openFile.FileName;                // The filepath
            HTMLTagsListBox.Items.Clear();                      // Clear the list box

            // Create a selfClosingTags List and adds all the self closing tags to it
            List<string> selfClosingTags = new List<string>();
            selfClosingTags.Add("<area>");
            selfClosingTags.Add("<base>");
            selfClosingTags.Add("<br>");
            selfClosingTags.Add("<col>");
            selfClosingTags.Add("<embed>");
            selfClosingTags.Add("<hr>");
            selfClosingTags.Add("<img>");
            selfClosingTags.Add("<input>");
            selfClosingTags.Add("<link>");
            selfClosingTags.Add("<meta>");
            selfClosingTags.Add("<param>");
            selfClosingTags.Add("<source>");
            selfClosingTags.Add("<track>");
            selfClosingTags.Add("<wbr>");

            // Read from file
            FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader data = new StreamReader(file);

            // reading each line of the file, checking for opening and closing tag matches
            string line; // the current line being read
            bool fail = false; // the bool check for whether the HTML is balanced or not
            while ((line = data.ReadLine()) != null && fail == false)
            {
                // goes through each character in the line
                for (int i = 0; i < line.Length; i++)
                {
                    // Check for the start of an HTML tag by looking for the < char.
                    // After the first time though this if statement, inside will be true.
                    // As long as the char is not a > which would declare the end of a tag or a ' ' which would lead to tag attributes,
                    // the tag variable will keep getting added to.
                    if (line[i] == '<' || inside && line[i] != '>' && line[i] != ' ')
                    {
                        tag += Char.ToLower(line[i]); // adds the current char to the tag
                        inside = true; // used to know if the current iteration is still within the tag
                    }
                    // Check for the end of an HTML tag by looking for the > char.
                    // Inside becomes false when this if statement goes through.
                    else if (line[i] == '>' && inside)
                    {
                        tag += line[i]; // add the > to the tag
                        inside = false; // used to indicate that the tag has been finished
                        // Check if the tag is a self closing tag
                        if (!selfClosingTags.Contains(tag))
                        {
                            // Check if the tag is a closing tag by looking for /
                            if (tag.Contains("/"))
                            {
                                // remove the / from the tag to compare it with the top of the stack
                                string tagWithoutSlash = tag.Replace("/", string.Empty);
                                if (stack.Peek() == tagWithoutSlash)
                                {
                                    // tags match, balance remians
                                    stack.Pop(); // remove the top tag since it properly closes
                                    displayStack.Push(tag); // add the tag to the display for the listbox
                                } else
                                {
                                    // tags didn't match, unbalanced
                                    displayStack.Push(tag); // push the tag to displayed the failed tag
                                    fail = true; // stops the while loop to display only until the unbalanced tag
                                    fileNameLabel.Text = Path.GetFileName(openFile.FileName) + " does not have balanced tags"; // change label to indicate unbalanced tags
                                }
                            } else
                            {
                                // tag is an opening tag, push to stacks
                                stack.Push(tag);
                                displayStack.Push(tag);
                            }

                        }
                        // reset tag
                        tag = string.Empty;
                    }
                    // Check if char is ' ' and inside to indicate tag attributes
                    else if (line[i] == ' ' && inside)
                    {
                        tag += '>'; // change the ' ' to an > to show end of tag
                        inside = false; // used to indicate that the tag has been finished
                        // Check if the tag is a self closing tag
                        if (!selfClosingTags.Contains(tag))
                        {
                            // Check if the tag is a closing tag by looking for /
                            if (tag.Contains("/"))
                            {
                                // remove the / from the tag to compare it with the top of the stack
                                string tagWithoutSlash = tag.Replace("/", string.Empty);
                                if (stack.Peek() == tagWithoutSlash)
                                {
                                    // tags match, balance remains
                                    stack.Pop(); // remove the top tag since it properly closes
                                    displayStack.Push(tag); // add the tag to the display for the listbox
                                }
                                else
                                {
                                    // tags didn't match, unbalanced
                                    displayStack.Push(tag); // push the tag to displayed the failed tag
                                    fail = true; // stops the while loop to display only until the unbalanced tag
                                    fileNameLabel.Text = Path.GetFileName(openFile.FileName) + " does not have balanced tags"; // change label to indicate unbalanced tags
                                }
                            } else
                            {
                                // tag is an opening tag, push to stacks
                                stack.Push(tag);
                                displayStack.Push(tag);
                            }
                        }
                        // reset tag
                        tag = string.Empty;
                    }
                }
            }
            data.Close(); // close file

            
            // reorganize the stack so it displays top to bottom
            Stack<string> newStack = new Stack<string>();
            while (displayStack.Count > 0) 
            {
                newStack.Push(displayStack.Pop()); // add the top of the old stack to the top of the new stack
            }

            // display reorganized stack
            foreach (string item in newStack)
            {
                HTMLTagsListBox.Items.Add(item);
            }

            // change label to indicate balanced tags
            if (fail == false)
            {
                fileNameLabel.Text = Path.GetFileName(openFile.FileName) + " has balanced tags.";
            }
        }
    }
}
