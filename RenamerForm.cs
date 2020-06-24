using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace LJM_Utils
{
    public partial class RenamerForm : Form
    {
        System.Drawing.Point OptionGroupLocation = new System.Drawing.Point(11, 202);
        int PreviousStrategySelection = -1;

        public RenamerForm()
        {
            InitializeComponent();

            // Resize form and move option groups to overlay one another.
            // Reasoning: keeping everything separated allows for easy design of the controls
            //            when they are intended to all be on top of one another during runtime.
            this.Width = 360;
            groupRandomOptions.Location = OptionGroupLocation;
            groupRegExOptions.Location = OptionGroupLocation;
            groupLinearOptions.Location = OptionGroupLocation;   
        }

        private void ValidateRenameProcess(ref bool NoErrorsFound)
        {
            // validate given path
            if (!Directory.Exists(txtInputDirectory.Text))
            {
                NoErrorsFound = false;
                MessageBox.Show($"The given path \"{txtInputDirectory.Text}\" does not exist.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // validate options for selected strategy
            switch (comboRenamingStrat.SelectedIndex)
            {
                case (int)StrategySelection.Linear:
                    if (txtLinearExample.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                    {
                        NoErrorsFound = false;
                    }
                    break;
                case (int)StrategySelection.Random:
                    if (numRandomCharsOption.Value < 1)
                    {
                        NoErrorsFound = false;
                    }
                    break;
                case (int)StrategySelection.RegEx:
                    // TODO: given pattern containins a capture group
                    NoErrorsFound = false; // not implemented
                    break;
                default:
                    NoErrorsFound = false;
                    break;
            }

            // validate given extensions
            if (!true)
            {
                
            }

            // validate combo box selection
            if (comboRenamingStrat.SelectedItem.ToString() == Vocab.Renaming.ComboDefault)
            {
                NoErrorsFound = false;
                MessageBox.Show($"You must select a renaming strategy.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            bool NoErrorsFound = true;

            ValidateRenameProcess(ref NoErrorsFound);

            if (NoErrorsFound)
            {
                try
                {
                    switch (comboRenamingStrat.SelectedItem.ToString())
                    {
                        case Vocab.Renaming.ComboLinear:
                            executeLinearRename();
                            MessageBox.Show("Success!", "Notice",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case Vocab.Renaming.ComboRandom:
                            executeRandomRename();
                            MessageBox.Show("Success!", "Notice",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case Vocab.Renaming.ComboRegEx:
                            MessageBox.Show("RegEx strategy is WIP and not available.", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception thrownException)
                {
                    MessageBox.Show($"An unhandled exception has occurred: {thrownException.Message}", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInputDirectory.Text = "";
            txtExtInclusions.Text = "";
            txtPrefixOption.Text = "";
            txtSuffixOption.Text = "";
            numRandomCharsOption.Value = 10;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            // TODO: write support for logging of renames and functionality to undo logged "runs"
            //       Idea 1: logging folder in temp folder with all rename jobs as separate text
            //               files, timestamped with time since epoch as "job number"
            //       Idea 2: SQLite database thats lists everything
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
            LinearRenamer renamerInstance = new LinearRenamer(txtInputDirectory.Text, getExtInclusions(),
                                                              txtPrefixOption.Text, txtSuffixOption.Text);
            renamerInstance.Execute();
        }
        private void executeRandomRename()
        {

            RandomRenamer renamerInstance = new RandomRenamer(txtInputDirectory.Text, getExtInclusions());
            renamerInstance.Execute();
        }

        private string[] getExtInclusions()
        {
            if (txtExtInclusions.Text.Trim() != "")
            {
                return txtExtInclusions.Text.Split(' ');
            }
            else
            {
                return null;
            }
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

        private void txtPrefixOption_TextChanged(object sender, EventArgs e){UpdateLinearExample();}

        private void txtSuffixOption_TextChanged(object sender, EventArgs e){UpdateLinearExample();}

        private void UpdateLinearExample()
        {
            txtLinearExample.Text = LinearRenamer.ExampleFilename(txtPrefixOption.Text, txtSuffixOption.Text);
        }

        private void numRandomCharsOption_ValueChanged(object sender, EventArgs e)
        {
            txtRandomExample.Text = RandomRenamer.ExampleFilename((int)numRandomCharsOption.Value);
        }
    }
}
