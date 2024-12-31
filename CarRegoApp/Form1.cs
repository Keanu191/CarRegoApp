using System.Windows.Forms;

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
                openTXTFile.InitialDirectory = "C:\\";
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
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            // display the file content and the path of the file in the status strip
            toolStripStatusLabel1.Text = $"{fileContent}, File Content at path: {filePath}";
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

                    listBoxRego.Items.Add(regoInput.Text);

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
            if (result == DialogResult.Yes)
            {
                regoList.Remove(selectedRego);
                listBoxRego.Items.Remove(selectedRego);
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
                if (result == DialogResult.Yes)
                {
                    regoList.Remove(selectedRego);
                    listBoxRego.Items.Remove(selectedRego);

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
            regoInput.Text = listBoxRego.SelectedItem.ToString();
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

        private void listBoxRego_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            try
            {
                regoInput.Text = listBoxRego.SelectedItem.ToString();
            }
            catch (Exception ex) 
            {
                toolStripStatusLabel1.Text = $"An unexpected error has occured {ex}";
            }
            */
        }
    }
}
