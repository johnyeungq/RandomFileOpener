
// This class represents a Windows Form application that allows users to browse and open random files or folders.
// The user can select a directory, and based on the contents of that directory, they can choose to open a random file or a random subfolder.
// The application provides feedback on the selected folder's status and enables or disables the open button accordingly.
// This program mostly generate by ChatGPT, with some modifications to fit the requirements. Even This Comment lol ffs

using System.Diagnostics;

namespace RandomFileOpener
{
    public partial class RandomFileOpener : Form
    {
        // Constructor to initialize the form components
        public RandomFileOpener()
        {
            InitializeComponent();
        }

        // Event handler for the browse button click event
        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                // Show the folder browser dialog and check if the user selected a folder
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    // Set the selected folder path in the text box
                    FolderPathTB.Text = folderBrowser.SelectedPath;
                }
            }
        }

        // Event handler for when the text in the folder path text box changes
        private void FolderPathTB_TextChanged(object sender, EventArgs e)
        {
            // Check if the folder path is valid and exists
            if (!string.IsNullOrWhiteSpace(FolderPathTB.Text) && Directory.Exists(FolderPathTB.Text))
            {
                // Get all files in the selected directory
                string[] files = Directory.GetFiles(FolderPathTB.Text);
                openBtn.Enabled = true; // Always enable openBtn

                // Check if there are files in the folder
                if (files.Length > 0)
                {
                    // Update label to indicate that the folder contains files
                    FileGetLabel.ForeColor = Color.Blue;
                    FileGetLabel.Text = "Folder Contains Files. Set to File Mode";
                    FileGetLabel.Visible = true;
                    TypeCB.SelectedIndex = 0; // Set to File Mode
                }
                else
                {
                    // Update label to indicate that the folder is empty
                    FileGetLabel.Text = "The Folder is Empty. Set to Folder Mode";
                    FileGetLabel.ForeColor = Color.Blue;
                    FileGetLabel.Visible = true;
                    TypeCB.SelectedIndex = 1; // Set to Folder Mode
                }
            }
            else
            {
                // Disable the open button and show an error message if the folder path is invalid
                openBtn.Enabled = false;
                FileGetLabel.Text = "Please select a valid folder containing files.";
                FileGetLabel.ForeColor = Color.Red;
                FileGetLabel.Visible = true;
            }
        }

        // Event handler for form load event
        private void Form1_Load(object sender, EventArgs e)
        {
            TypeCB.SelectedIndex = 0; // Set default to File Mode
            openBtn.Enabled = false; // Disable open button initially
        }

        // Event handler for the open button click event
        private void openBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get all files in the selected directory
                string[] files = Directory.GetFiles(FolderPathTB.Text);
                if (TypeCB.SelectedIndex == 1) // Check if Folder Mode is selected
                {
                    // Open a random folder from the selected directory
                    string[] folders = Directory.GetDirectories(FolderPathTB.Text);
                    if (folders.Length > 0)
                    {
                        Random random = new Random();
                        int index = random.Next(folders.Length); // Get a random index
                        string randomFolder = folders[index]; // Select a random folder
                        Process.Start("explorer.exe", randomFolder); // Open the folder in Explorer
                    }
                    else
                    {
                        // Show a message if no subfolders are found
                        MessageBox.Show("No subfolders found in the selected directory.");
                    }
                }
                else if (files.Length > 0)
                {
                    // Open a random file from the selected directory
                    Random random = new Random();
                    int index = random.Next(files.Length); // Get a random index
                    string randomFile = files[index]; // Select a random file
                    openBtn.Tag = randomFile; // Store the random file in the button's Tag
                    Process.Start("explorer.exe", randomFile); // Open the file in Explorer
                }
                else
                {
                    openBtn.Enabled = false; // Disable the button if no files are found
                }
            }
            catch (Exception ex)
            {
                // Show an error message if there is an issue accessing the folder
                MessageBox.Show("Error accessing folder: " + ex.Message);
                openBtn.Enabled = false; // Disable the button on error
            }
        }
    }
}
