using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Collections.Generic;

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
                        executeLinearRename();
                        break;
                    case Vocab.Renaming.ComboRandom:
                        executeRandomRename();
                        break;
                    case Vocab.Renaming.ComboRegEx:
                        MessageBox.Show("", "Unimplemented Feature");
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
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                EnsurePathExists = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtInputDirectory.Text = dialog.FileName;
            }
        }
        
        private void executeLinearRename()
        {
            string prefix= "", suffix = "";

            getLinearAffixes(ref prefix, ref suffix);
            LinearRenamer renamerInstance = new LinearRenamer(txtInputDirectory.Text, getExtInclusions(),
                                                              prefix, suffix);
        }
        private void executeRandomRename()
        {

            RandomRenamer renamerInstance = new RandomRenamer(txtInputDirectory.Text, getExtInclusions());
        }

        private string[] getExtInclusions()
        {
            if (txtExtInclusions.Text.Trim() != "")
            {
                List<string> extenstions = new List<string>();

                return extenstions.ToArray();
            }
            else
            {
                return null;
            }
        }

        private void getLinearAffixes(ref string givenPrefix, ref string givenSuffix)
        {
            // TODO: display dialog (create new one) to prompt user for prefix and suffix. Show user what those mean as they type.
        }

        private void comboRenamingStrat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: based on selection, change the tab of the options group.

            // TODO: (Consider) Instead of using a tab page control group, show options relevant only
            //       to the current selected renaming strategy. This means hiding and showing in this function
            //       on the event of comboRenamingStrat changing.
        }
    }
}
