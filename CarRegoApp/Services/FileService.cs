using System.Windows.Forms;

namespace CarRegoApp.Services
{
    /// <summary>
    /// Handles file operations such as opening and saving registration plate data.
    /// </summary>
    public class FileService
    {
        /// <summary>
        /// Opens a text file and loads its content into the provided list.
        /// </summary>
        public static void OpenTextFile(List<string> regoList, ListBox listBoxRego, ToolStripStatusLabel statusLabel)
        {
            using (OpenFileDialog openTXTFile = new OpenFileDialog())
            {
                openTXTFile.InitialDirectory = AppContext.BaseDirectory;
                openTXTFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openTXTFile.FilterIndex = 2;
                openTXTFile.RestoreDirectory = true;

                if (openTXTFile.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openTXTFile.FileName;
                    using (StreamReader reader = new StreamReader(openTXTFile.OpenFile()))
                    {
                        string? line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            regoList.Add(line.Trim());
                            listBoxRego.Items.Add(line.Trim());
                        }
                    }
                    statusLabel.Text = $"Text file successfully loaded at: {filePath}";
                }
            }
        }

        /// <summary>
        /// Saves the registration plate data to a text file.
        /// </summary>
        public static void SaveData(ListBox listBoxRego)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Export Registration Plate Data";
                saveFileDialog.InitialDirectory = AppContext.BaseDirectory;
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
    }
}