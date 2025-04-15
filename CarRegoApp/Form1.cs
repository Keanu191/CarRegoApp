using CarRegoApp.Services;
using System.Text.RegularExpressions;

namespace CarRegoApp
{
    public partial class Form1 : Form
    {
        private List<string> regoList = new List<string>();

        /// <summary>
        /// Initializes the form and its components.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the "Open" button click event to load registration plates from a file.
        /// </summary>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            FileService.OpenTextFile(regoList, listBoxRego, toolStripStatusLabel1);
        }

        /// <summary>
        /// Handles the "Save" button click event to save registration plates to a file.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            FileService.SaveData(listBoxRego);
        }

        /// <summary>
        /// Handles the "Binary Search" button click event to search for a registration plate using binary search.
        /// </summary>
        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            PerformSearch(SearchService.BinarySearch);
        }

        /// <summary>
        /// Handles the "Linear Search" button click event to search for a registration plate using linear search.
        /// </summary>
        private void btnLinearSearch_Click(object sender, EventArgs e)
        {
            PerformSearch(SearchService.LinearSearch);
        }

        /// <summary>
        /// Handles the "Enter" button click event to add a new registration plate to the list.
        /// </summary>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!IsValidRegoPlate(regoInput.Text))
            {
                toolStripStatusLabel1.Text = "Invalid registration plate format.";
                return;
            }

            if (regoList.Contains(regoInput.Text))
            {
                toolStripStatusLabel1.Text = "Duplicate registration plate.";
                return;
            }

            AddRegistrationPlate(regoInput.Text);
        }

        /// <summary>
        /// Handles the "Delete" button click event to remove the selected registration plate.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRego.SelectedItem is string selectedItem)
            {
                regoList.Remove(selectedItem);
                listBoxRego.Items.Remove(selectedItem);
                toolStripStatusLabel1.Text = "Registration plate deleted.";
            }
            else
            {
                toolStripStatusLabel1.Text = "No registration plate selected.";
            }
        }

        /// <summary>
        /// Handles the "Tag" button click event to toggle the [TAGGED] label on a selected registration plate.
        /// </summary>
        private void btnTag_Click(object sender, EventArgs e)
        {
            if (listBoxRego.SelectedItem is string selectedItem)
            {
                int selectedIndex = listBoxRego.SelectedIndex;

                // Check if the item is already tagged
                if (selectedItem.EndsWith(" [TAGGED]"))
                {
                    // Remove the [TAGGED] label
                    string untaggedItem = selectedItem.Replace(" [TAGGED]", "");
                    regoList[selectedIndex] = untaggedItem;
                    listBoxRego.Items[selectedIndex] = untaggedItem;
                    toolStripStatusLabel1.Text = "Tag removed from the registration plate.";
                }
                else
                {
                    // Add the [TAGGED] label
                    string taggedItem = $"{selectedItem} [TAGGED]";
                    regoList[selectedIndex] = taggedItem;
                    listBoxRego.Items[selectedIndex] = taggedItem;
                    toolStripStatusLabel1.Text = "Registration plate tagged successfully.";
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "No registration plate selected for tagging.";
            }
        }

        /// <summary>
        /// Handles the "Reset" button click event to clear all data.
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            regoList.Clear();
            listBoxRego.Items.Clear();
            regoInput.Clear();
            toolStripStatusLabel1.Text = "Form reset successfully.";
        }

        /// <summary>
        /// Handles the "Edit" button click event to load the selected registration plate for editing.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxRego.SelectedItem is string selectedItem)
            {
                regoList.Remove(selectedItem);
                listBoxRego.Items.Remove(selectedItem);
                regoInput.Text = selectedItem;
                toolStripStatusLabel1.Text = "Registration plate ready for editing.";
            }
            else
            {
                toolStripStatusLabel1.Text = "No registration plate selected for editing.";
            }
        }

        /// <summary>
        /// Handles the form load event.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Form loaded successfully.";
        }

        /// <summary>
        /// Handles the "SelectedIndexChanged" event for the list box.
        /// </summary>
        private void listBoxRego_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRego.SelectedItem is string selectedItem)
            {
                toolStripStatusLabel1.Text = $"Selected: {selectedItem}";
            }
        }

        /// <summary>
        /// Handles the "DoubleClick" event for the list box.
        /// </summary>
        private void listBoxRego_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxRego.SelectedItem is string selectedItem)
            {
                regoInput.Text = selectedItem;
                toolStripStatusLabel1.Text = "Registration plate loaded for editing.";
            }
        }

        /// <summary>
        /// Validates the format of a registration plate.
        /// </summary>
        /// <param name="regoPlate">The registration plate to validate.</param>
        /// <returns>True if the format is valid, otherwise false.</returns>
        private bool IsValidRegoPlate(string regoPlate)
        {
            Regex regex = new Regex(@"^[0-9]{1}[A-Z]{3}-[0-9]{3}$");
            return regex.IsMatch(regoPlate);
        }

        /// <summary>
        /// Adds a new registration plate to the list and updates the UI.
        /// </summary>
        /// <param name="regoPlate">The registration plate to add.</param>
        private void AddRegistrationPlate(string regoPlate)
        {
            regoList.Add(regoPlate);
            listBoxRego.Items.Add(regoPlate);
            regoList.Sort();
            toolStripStatusLabel1.Text = "Registration plate added successfully.";
            regoInput.Clear();
            regoInput.Focus();
        }

        /// <summary>
        /// Performs a search using the specified search method.
        /// </summary>
        /// <param name="searchMethod">The search method to use.</param>
        private void PerformSearch(Func<List<string>, string, int> searchMethod)
        {
            var index = searchMethod(regoList, regoInput.Text);
            toolStripStatusLabel1.Text = index >= 0
                ? $"Registration plate found at index {index}."
                : "Registration plate not found.";
        }
    }
}