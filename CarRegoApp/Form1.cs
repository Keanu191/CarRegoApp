using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRegoApp
{
    public partial class Form1 : Form
    {
        // 1. The prototype must use a List<> data structure of data type "string".
        List<string> regoList = new List<string>();

        /*
         * 2.
         * OPEN: When the OPEN button is clicked the user can select different text files from pre-saved text files.
         * The text files must be named for different scenarios where the file names are "demo_01.txt", "demo_02.txt", etc.
         */
        private void openTextFile()
        {
            // declare two variables for the file content and file path and set them as string.Empty as you cannot leave it blank
            var fileContent = string.Empty;
            var filePath = string.Empty;

            // In a using statement declare an instance of the OpenFileDialog class called "openTXTFile"
            using (OpenFileDialog openTXTFile = new OpenFileDialog())
            {
                // Set the initial directory for the window file dialog to be on the C Drive directory
                openTXTFile.InitialDirectory = @"C:\\";
                // Set the filter for only text files to be selected when the file dialog window opens
                openTXTFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openTXTFile.FilterIndex = 2;
                openTXTFile.RestoreDirectory = true;

                if (openTXTFile.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the specified file
                    filePath = openTXTFile.FileName;

                    // Read the contents of the file into a stream
                    var fileStream = openTXTFile.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string? line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            regoList.Add(line.Trim());
                            listBoxRego.Items.Add(line.Trim());
                        }

                    }
                }
            }

            // display the file content and the path of the file in the status strip
            toolStripStatusLabel1.Text = $"Text file successfully loaded at: {filePath}";
        }

        /*
         * 3.
         * ENTER: To add a rego plate to the List<> the user will type the data value (rego plate info)
         * into the TextBox and click the ENTER button. The data will be added to the List<> and the 
         * TextBox will be cleared, and the cursor will refocus back into the TextBox. If the TextBox
         * is empty the program should raise an error message. All data added to the List<> must be 
         * "real", your demonstration and submission must use data like: 1GTF-234, 1JNQ-123, 1QLP-989, etc.
         * Ensure all rego data is unique; test for duplicates before adding.
         */
        private void btnEnter_Click(object sender, EventArgs e)
        {
            /* 30/12/2024: Note to self: In the future instead of checking if the string in the textbox is null
             * we can create a regex that is designed to only accept input of a rego plate and then if the if/else statement
             * we will do like if regex is match then add to the list else the input you entered is not a license plate
             */
            // If the text in the textbox is not null...
            if (!string.IsNullOrWhiteSpace(regoInput.Text))
            {
                // Check if duplicate registration plates have been entered into the ListBox
                if (listBoxRego.Items.Contains(regoInput.Text))
                {
                    toolStripStatusLabel1.Text = "ERROR: Duplicate registration plate entered!";
                }
                else
                {
                    // If no duplicate registration plates are in the listbox then add the string from the textbox into the list<>
                    regoList.Add(regoInput.Text);

                    listBoxRego.Items.Add(regoInput.Text.Trim());

                    // Sort
                    sortList();

                    // After the registration plate has been added to the list we will clear the textbox then refocus
                    clearAndRefocus();
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "ERROR: The Input Textbox is empty, therefore nothing could be entered!";
            }
        }

        /*
         * 4. 
         * EXIT: To remove a rego plate: There are two options to remove a rego plate from the List<>.
         * Method One: double click a rego plate from the ListBox and click the OK button in the popup
         * dialog box. The rego plate will be removed from the List<>. Method Two: the user will select
         * a rego plate from the ListBox and click the EXIT button. The rego plate will be removed from
         * the List<> and the TextBox will be cleared, and the cursor will refocus in the TextBox.
         */

        private void listBoxRego_DoubleClick(object sender, EventArgs e)
        {
            // using the .GetItemText method for the selected item in the listbox to display the actual registration plate in the messages
            string? selectedRego = listBoxRego.GetItemText(listBoxRego.SelectedItem);

            // Confirmation
            string message = $"Are you sure that you would like to delete the following Registration Plate: {selectedRego}";
            const string caption = "Authorise Deletion";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the yes button was pressed then delete the selected registration plate
            if (result == DialogResult.Yes && selectedRego != null)
            {
                regoList.Remove(selectedRego);
                listBoxRego.Items.Remove(selectedRego);

                // Sort
                sortList();

                // clear and refocus the textbox
                clearAndRefocus();

                toolStripStatusLabel1.Text = $"{selectedRego} has been successfully deleted";
            }
            else if (result == DialogResult.No)
            {
                toolStripStatusLabel1.Text = $"The following registration plate: {selectedRego} was not deleted!";
            }
        }

        private void deleteRego()
        {
            string? selectedRego = listBoxRego.GetItemText(listBoxRego.SelectedItem);

            if (listBoxRego.SelectedItem != null)
            {
                // Confirmation
                string message = $"Are you sure that you would like to delete the following Registration Plate: {selectedRego}";
                const string caption = "Authorise Deletion";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the yes button was pressed then delete the selected registration plate from the listbox and the list<>
                if (result == DialogResult.Yes && selectedRego != null)
                {
                    regoList.Remove(selectedRego);
                    listBoxRego.Items.Remove(selectedRego);

                    // Sort
                    sortList();

                    // clear and refocus the registration plate input textbox
                    clearAndRefocus();
                    toolStripStatusLabel1.Text = $"{selectedRego} has been deleted!";
                }
                else if (result == DialogResult.No)
                {
                    toolStripStatusLabel1.Text = $"The following registration plate: {selectedRego} was not deleted!";
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "You need to select a registration plate in the listbox to delete!";
            }

        }

        /*
         * 5. 
         * EDIT: To edit a rego plate click (select) an item from the ListBox so that it appears in the TextBox.
         * Alter the information and click the EDIT button. The updated information is written back to the List<>
         * and the TextBox is cleared, and the cursor refocus in the TextBox.
         */
        private void editRego()
        {
            var selectedIndex = listBoxRego.SelectedIndex;

            // I created this string here so the actual registration plate can be displayed in the messagebox/toolstrip thanks to .GetItemText
            string? selectedRego = listBoxRego.GetItemText(listBoxRego.SelectedItem);

            // Confirmation
            string message = $"Are you sure that you would like to edit the following Registration Plate: {selectedRego}";
            const string caption = "Edit Registration Notice";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the yes button was pressed then delete the selected registration plate from the listbox and the list<>
            if (result == DialogResult.Yes)
            {
                // Remove the selectedIndex from the list
                listBoxRego.Items.RemoveAt(selectedIndex);
                regoList.RemoveAt(selectedIndex);

                // Insert the updated registration plate into the list
                regoList.Insert(selectedIndex, regoInput.Text);
                listBoxRego.Items.Insert(selectedIndex, regoInput.Text);

                // Sort
                sortList();

                // clear/refocus textbox after
                clearAndRefocus();
            }
            else
            {
                toolStripStatusLabel1.Text = $"{selectedRego} has not been edited!";
            }

        }

        /*
         * 6.
         * RESET: Add a RESET button to clear all the rego plates from the List<>. The ListBox and
         * TextBox should also be cleared.
         */
        private void reset()
        {
            // Clear all items in the listbox
            listBoxRego.Items.Clear();

            // Clear and refocus the textbox
            clearAndRefocus();
        }

        /*
         * 7. 
         * Single Data Display: Create a single click method to do the following:
         * when a rego plate is selected from the ListBox, the information is displayed
         * in the TextBox.
         */
        private void listBoxRego_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                /*
                 * To prevent an NullReferenceException you would want to make sure
                 * that first make sure that the selected item in the listbox is not null
                 * meaning that you have to make sure that an item is selected and then
                 * you would display the selected item as a string in the textbox
                 */
                if (listBoxRego.SelectedItem != null)
                {
                    regoInput.Text = listBoxRego.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = $"An unexpected error has occured {ex}";
            }

        }

        /*
         * 8.
         * Display and Sort: All the rego plates should be displayed in the ListBox
         * which is sorted alphabetically using the built-in List.Sort method.
         * The List<> must be sorted after every List<> process (add, edit, exit, etc).
         */
        private void sortList()
        {
            regoList.Sort();
            listBoxRego.Sorted = true;
        }

        /*
         * 9.
         * Binary Search: To find a specific rego plate the user will type the information
         * into the TextBox and click the BINARY SEARCH button. If the rego plate is found,
         * then a confirmation message should be displayed. If the rego plate is not found,
         * then a message should be displayed, and the TextBox cleared, and the cursor refocused.
         * The search code must use the built-in Binary Search.
         */
        private void binarySearch()
        {
            // First check if the textbox is not null
            if (regoInput != null)
            {
                var index = regoList.BinarySearch(regoInput.Text);

                if (regoList.Contains(regoInput.Text))
                {
                    toolStripStatusLabel1.Text = $"Registration plate successfully found! Index: {index}";
                    clearAndRefocus();
                }
                else
                {
                    toolStripStatusLabel1.Text = $"Binary Search unsuccessful, could not find the following Index: {index}";
                    clearAndRefocus();
                }
            }
        }

        /*
         * 10.
         * Linear Search: Add a second search button that implements a linear search algorithm.
         * To find a rego plate the user will type the information into the TextBox and click 
         * the LINEAR SEARCH button. If the rego plate is not found, then a message should be 
         * displayed, and the TextBox cleared, and the cursor refocused.
         */

        private void linearSearch(string target)
        {
            // First check if the textbox is not null
            if (regoInput != null)
            {
                // Perform linear search

                for (int i = 0; i < regoList.Count; i++)
                {
                    if (regoList[i] == target)
                    {
                        var index = regoList.LastIndexOf(target);

                        if (regoList.Contains(regoInput.Text))
                        {
                            toolStripStatusLabel1.Text = $"Registration plate successfully found! Plate: {target}, Index: {index}";
                            clearAndRefocus();
                        }
                        else
                        {
                            toolStripStatusLabel1.Text = $"Binary Search unsuccessful, could not find the following Registration Plate: {target}, Index: {index}";
                            clearAndRefocus();
                        }
                    }
                }
            }
        }


        /*
         * 11.
         * Save and Form Close: Create a method to save the data, this method will open a save dialog box and allow
         * the user to save all the rego plate data into a text file. The dialog box must have a filter to display
         * text files only. Create a SAVE button method that can utilise the save method. Create a FORM closing 
         * method using the save method so all data from the List<> will be written back to a single text file
         * called "demo_###.txt" file which is auto incremented (ie demo_01.txt, demo_02.txt, etc).
         */
        private void saveData()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string filePath = @"C:\\";
                int fileCount = 0;
                string fileName = "File_0" + $"{fileCount}";

                bool checkFileName = true;
                while (checkFileName)
                {
                    fileName = "File_0" + $"{fileCount}.txt";
                    fileCount++;

                    string checkName = filePath + @"\\" + fileName;
                    checkFileName = File.Exists(checkName);
                }

                saveFileDialog.FileName = fileName;
                saveFileDialog.Title = "Export Registration Plate Data";
                saveFileDialog.InitialDirectory = $"{filePath}";
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.Filter = "Text files |*.txt";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.OpenFile()))
                    {
                        foreach (string item in listBoxRego.Items)
                        {
                            sw.WriteLine(item);
                        }
                    }
                }
            }


        }

        /*
         * 12.
         * TAG: Create tag method and associated TAG button to mark a rego plate.
         * When a rego plate is selected from the ListBox and “tagged” an additional character value “z” will be prefixed to the rego plate.
         * If a ‘’tagged” plate is selected, then the “z” is removed. The List<> will be re-sorted and displayed after each action.
         */
        private void tagRego()
        {
            var selectedItem = listBoxRego.SelectedItem;
            if (selectedItem != null)
            {
                var i = listBoxRego.Items.Count - 1;  // crash bug if there is no line to append to
                listBoxRego.Items[i] = listBoxRego.Items[i] + "z";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Call the openTextFile() method when the open button is clicked
            openTextFile();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Call the deleteRego() method when the delete button is clicked
            deleteRego();
        }

        // A function to clear and refocus the registration input textbox
        private void clearAndRefocus()
        {
            regoInput.Clear();
            regoInput.Focus();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Call the editRego() method when the edit button is clicked
            editRego();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Call the reset() method when the reset button is clicked
            reset();
        }

        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            // Call the binary search method when the binary search button is clicked
            binarySearch();
        }

        private void btnLinearSearch_Click(object sender, EventArgs e)
        {
            // Call the linear search method when the linear search button is clicked and I have made sure to set the target parameter in that method as the textbox
            linearSearch(target: regoInput.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Call the save data method when the save text file button is clicked
            saveData();
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            // Call the tag rego function when the tag button is clicked
            tagRego();
        }
    }
}
