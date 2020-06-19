using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace LJM_Utils
{
    public partial class RenamerForm : Form
    {
        public RenamerForm()
        {
            InitializeComponent();
        }

        private bool ValidateRenameProcess(ref bool NoErrorsFound)
        {
            // validate given path
            if (!Directory.Exists(txtInputDirectory.Text))
            {
                NoErrorsFound = true;
                MessageBox.Show($"The given path \"{txtInputDirectory.Text}\" does not exist.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // validate given extensions
            if (!true)
            {
                
            }

            // validate combo box selection
            if (comboRenamingStrat.SelectedItem.ToString() == Vocab.Renaming.ComboDefault)
            {
                NoErrorsFound = true;
                MessageBox.Show($"You must set a renaming strategy.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            bool NoErrorsFound = true;

            ValidateRenameProcess(ref NoErrorsFound);

            if (NoErrorsFound)
            {
                switch (comboRenamingStrat.SelectedItem.ToString())
                {
                    case Vocab.Renaming.ComboLinear:
                        break;
                    case Vocab.Renaming.ComboRandom:
                        break;
                    case Vocab.Renaming.ComboRegEx:
                        MessageBox.Show("", "Unimplemented Feature")
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void RenamerForm_Load(object sender, EventArgs e)
        {
            comboRenamingStrat.SelectedItem = "Select a strategy...";
        }

        private void btnBrowseForInput_Click(object sender, EventArgs e)
        {
            // Folder browser improved dialog source: https://stackoverflow.com/a/41511598
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.EnsurePathExists = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtInputDirectory.Text = dialog.FileName;
            }
        }
    }
}
