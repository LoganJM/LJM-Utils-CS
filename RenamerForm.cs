using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Collections.Generic;
using System.Drawing;

namespace LJM_Utils
{
    public partial class RenamerForm : Form
    {
        Point OptionGroupLocation = new Point(11, 209);
        int PreviousStrategySelection = -1;

        public RenamerForm()
        {
            InitializeComponent();

            // Resize form and move option groups to overlay one another.
            // Reasoning: keeping everything separated allows for easy design of the controls
            //            when they are intended to all be on top of one another during runtime.
            RenamerForm.ActiveForm.Width = 360;
            groupRandomOptions.Location = OptionGroupLocation;
            groupRegExOptions.Location = OptionGroupLocation;
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

        public enum StrategySelection
        {
            Default = 0,
            Linear = 1,
            Random = 2,
            RegEx = 3
        }

        private void comboRenamingStrat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PreviousStrategySelection == -1 && comboRenamingStrat.SelectedIndex == 0)
            {
                PreviousStrategySelection = 0;
            }
            else
            {
                // hide previous group
                switch (PreviousStrategySelection)
                {
                    case (int)StrategySelection.Default:
                        break;
                    case (int)StrategySelection.Linear:
                        groupLinearOptions.Visible = false;
                        break;
                    case (int)StrategySelection.Random:
                        groupRandomOptions.Visible = false;
                        break;
                    case (int)StrategySelection.RegEx:
                        groupRegExOptions.Visible = false;
                        break;
                    default:
                        break;
                }

                // show selected group
                switch (comboRenamingStrat.SelectedIndex)
                {
                    case (int)StrategySelection.Default:
                        break;
                    case (int)StrategySelection.Linear:
                        groupLinearOptions.Visible = true;
                        break;
                    case (int)StrategySelection.Random:
                        groupRandomOptions.Visible = true;
                        break;
                    case (int)StrategySelection.RegEx:
                        groupRegExOptions.Visible = true;
                        break;
                    default:
                        break;
                }
            }

            PreviousStrategySelection = comboRenamingStrat.SelectedIndex;
        }
    }
}
