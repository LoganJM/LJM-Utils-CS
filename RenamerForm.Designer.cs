namespace LJM_Utils
{
    partial class RenamerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputDirectory = new System.Windows.Forms.TextBox();
            this.txtExtInclusions = new System.Windows.Forms.TextBox();
            this.comboRenamingStrat = new System.Windows.Forms.ComboBox();
            this.btnBrowseForInput = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBaseControls = new System.Windows.Forms.GroupBox();
            this.openFileDialogRename = new System.Windows.Forms.OpenFileDialog();
            this.groupLinearOptions = new System.Windows.Forms.GroupBox();
            this.txtLinearExample = new System.Windows.Forms.TextBox();
            this.txtSuffixOption = new System.Windows.Forms.TextBox();
            this.txtPrefixOption = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupRandomOptions = new System.Windows.Forms.GroupBox();
            this.numRandomCharsOption = new System.Windows.Forms.NumericUpDown();
            this.txtRandomExample = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupRegExOptions = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBaseControls.SuspendLayout();
            this.groupLinearOptions.SuspendLayout();
            this.groupRandomOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomCharsOption)).BeginInit();
            this.groupRegExOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Extension Inclusions:      (Separated by spaces)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Renaming Strategy:";
            // 
            // txtInputDirectory
            // 
            this.txtInputDirectory.Location = new System.Drawing.Point(32, 46);
            this.txtInputDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputDirectory.Name = "txtInputDirectory";
            this.txtInputDirectory.Size = new System.Drawing.Size(265, 22);
            this.txtInputDirectory.TabIndex = 3;
            // 
            // txtExtInclusions
            // 
            this.txtExtInclusions.Location = new System.Drawing.Point(32, 114);
            this.txtExtInclusions.Margin = new System.Windows.Forms.Padding(4);
            this.txtExtInclusions.Name = "txtExtInclusions";
            this.txtExtInclusions.Size = new System.Drawing.Size(212, 22);
            this.txtExtInclusions.TabIndex = 4;
            // 
            // comboRenamingStrat
            // 
            this.comboRenamingStrat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRenamingStrat.Items.AddRange(new object[] {
            "Select a strategy...",
            "Linear (\"prefix 01 suffix.ext\")",
            "Random (\"547216792.ext\")",
            "RegEx"});
            this.comboRenamingStrat.Location = new System.Drawing.Point(32, 185);
            this.comboRenamingStrat.Margin = new System.Windows.Forms.Padding(4);
            this.comboRenamingStrat.Name = "comboRenamingStrat";
            this.comboRenamingStrat.Size = new System.Drawing.Size(212, 24);
            this.comboRenamingStrat.TabIndex = 5;
            this.comboRenamingStrat.SelectedIndexChanged += new System.EventHandler(this.comboRenamingStrat_SelectedIndexChanged);
            // 
            // btnBrowseForInput
            // 
            this.btnBrowseForInput.Location = new System.Drawing.Point(307, 44);
            this.btnBrowseForInput.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseForInput.Name = "btnBrowseForInput";
            this.btnBrowseForInput.Size = new System.Drawing.Size(100, 28);
            this.btnBrowseForInput.TabIndex = 6;
            this.btnBrowseForInput.Text = "Browse...";
            this.btnBrowseForInput.UseVisualStyleBackColor = true;
            this.btnBrowseForInput.Click += new System.EventHandler(this.btnBrowseForInput_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(236, 441);
            this.btnRename.Margin = new System.Windows.Forms.Padding(4);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(100, 28);
            this.btnRename.TabIndex = 7;
            this.btnRename.Text = "&Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(307, 148);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(307, 183);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(100, 28);
            this.btnUndo.TabIndex = 9;
            this.btnUndo.Text = "Undo...";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(344, 441);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBaseControls
            // 
            this.groupBaseControls.Controls.Add(this.btnBrowseForInput);
            this.groupBaseControls.Controls.Add(this.label1);
            this.groupBaseControls.Controls.Add(this.btnClear);
            this.groupBaseControls.Controls.Add(this.btnUndo);
            this.groupBaseControls.Controls.Add(this.label2);
            this.groupBaseControls.Controls.Add(this.label3);
            this.groupBaseControls.Controls.Add(this.txtInputDirectory);
            this.groupBaseControls.Controls.Add(this.txtExtInclusions);
            this.groupBaseControls.Controls.Add(this.comboRenamingStrat);
            this.groupBaseControls.Location = new System.Drawing.Point(15, 7);
            this.groupBaseControls.Margin = new System.Windows.Forms.Padding(4);
            this.groupBaseControls.Name = "groupBaseControls";
            this.groupBaseControls.Padding = new System.Windows.Forms.Padding(4);
            this.groupBaseControls.Size = new System.Drawing.Size(428, 230);
            this.groupBaseControls.TabIndex = 11;
            this.groupBaseControls.TabStop = false;
            // 
            // groupLinearOptions
            // 
            this.groupLinearOptions.Controls.Add(this.txtLinearExample);
            this.groupLinearOptions.Controls.Add(this.txtSuffixOption);
            this.groupLinearOptions.Controls.Add(this.txtPrefixOption);
            this.groupLinearOptions.Controls.Add(this.label6);
            this.groupLinearOptions.Controls.Add(this.label5);
            this.groupLinearOptions.Controls.Add(this.label4);
            this.groupLinearOptions.Location = new System.Drawing.Point(15, 259);
            this.groupLinearOptions.Margin = new System.Windows.Forms.Padding(4);
            this.groupLinearOptions.Name = "groupLinearOptions";
            this.groupLinearOptions.Padding = new System.Windows.Forms.Padding(4);
            this.groupLinearOptions.Size = new System.Drawing.Size(428, 174);
            this.groupLinearOptions.TabIndex = 12;
            this.groupLinearOptions.TabStop = false;
            this.groupLinearOptions.Text = "Linear Options";
            this.groupLinearOptions.Visible = false;
            // 
            // txtLinearExample
            // 
            this.txtLinearExample.Location = new System.Drawing.Point(100, 133);
            this.txtLinearExample.Name = "txtLinearExample";
            this.txtLinearExample.ReadOnly = true;
            this.txtLinearExample.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtLinearExample.Size = new System.Drawing.Size(303, 22);
            this.txtLinearExample.TabIndex = 5;
            this.txtLinearExample.Text = "Prefix 05 Suffix.mkv";
            this.txtLinearExample.WordWrap = false;
            // 
            // txtSuffixOption
            // 
            this.txtSuffixOption.Location = new System.Drawing.Point(100, 82);
            this.txtSuffixOption.Name = "txtSuffixOption";
            this.txtSuffixOption.Size = new System.Drawing.Size(248, 22);
            this.txtSuffixOption.TabIndex = 4;
            this.txtSuffixOption.Text = "Suffix";
            this.txtSuffixOption.TextChanged += new System.EventHandler(this.txtSuffixOption_TextChanged);
            // 
            // txtPrefixOption
            // 
            this.txtPrefixOption.Location = new System.Drawing.Point(100, 33);
            this.txtPrefixOption.Name = "txtPrefixOption";
            this.txtPrefixOption.Size = new System.Drawing.Size(248, 22);
            this.txtPrefixOption.TabIndex = 3;
            this.txtPrefixOption.Text = "Prefix";
            this.txtPrefixOption.TextChanged += new System.EventHandler(this.txtPrefixOption_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Example:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Suffix:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prefix:";
            // 
            // groupRandomOptions
            // 
            this.groupRandomOptions.Controls.Add(this.numRandomCharsOption);
            this.groupRandomOptions.Controls.Add(this.txtRandomExample);
            this.groupRandomOptions.Controls.Add(this.label8);
            this.groupRandomOptions.Controls.Add(this.label7);
            this.groupRandomOptions.Location = new System.Drawing.Point(480, 52);
            this.groupRandomOptions.Margin = new System.Windows.Forms.Padding(4);
            this.groupRandomOptions.Name = "groupRandomOptions";
            this.groupRandomOptions.Padding = new System.Windows.Forms.Padding(4);
            this.groupRandomOptions.Size = new System.Drawing.Size(428, 174);
            this.groupRandomOptions.TabIndex = 13;
            this.groupRandomOptions.TabStop = false;
            this.groupRandomOptions.Text = "Random Options";
            this.groupRandomOptions.Visible = false;
            // 
            // numRandomCharsOption
            // 
            this.numRandomCharsOption.Location = new System.Drawing.Point(42, 58);
            this.numRandomCharsOption.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numRandomCharsOption.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numRandomCharsOption.Name = "numRandomCharsOption";
            this.numRandomCharsOption.Size = new System.Drawing.Size(87, 22);
            this.numRandomCharsOption.TabIndex = 7;
            this.numRandomCharsOption.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRandomCharsOption.ValueChanged += new System.EventHandler(this.numRandomCharsOption_ValueChanged);
            // 
            // txtRandomExample
            // 
            this.txtRandomExample.Location = new System.Drawing.Point(42, 114);
            this.txtRandomExample.Name = "txtRandomExample";
            this.txtRandomExample.ReadOnly = true;
            this.txtRandomExample.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtRandomExample.Size = new System.Drawing.Size(303, 22);
            this.txtRandomExample.TabIndex = 6;
            this.txtRandomExample.Text = "4385174069.mkv";
            this.txtRandomExample.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Example:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Characters:";
            // 
            // groupRegExOptions
            // 
            this.groupRegExOptions.Controls.Add(this.label10);
            this.groupRegExOptions.Location = new System.Drawing.Point(480, 239);
            this.groupRegExOptions.Margin = new System.Windows.Forms.Padding(4);
            this.groupRegExOptions.Name = "groupRegExOptions";
            this.groupRegExOptions.Padding = new System.Windows.Forms.Padding(4);
            this.groupRegExOptions.Size = new System.Drawing.Size(428, 174);
            this.groupRegExOptions.TabIndex = 14;
            this.groupRegExOptions.TabStop = false;
            this.groupRegExOptions.Text = "RegEx Options";
            this.groupRegExOptions.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "WIP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 34);
            this.label9.TabIndex = 15;
            this.label9.Text = "Select a renaming strategy\r\nto start.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RenamerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 481);
            this.Controls.Add(this.groupRegExOptions);
            this.Controls.Add(this.groupRandomOptions);
            this.Controls.Add(this.groupLinearOptions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBaseControls);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RenamerForm";
            this.Text = "Renamer";
            this.Load += new System.EventHandler(this.RenamerForm_Load);
            this.groupBaseControls.ResumeLayout(false);
            this.groupBaseControls.PerformLayout();
            this.groupLinearOptions.ResumeLayout(false);
            this.groupLinearOptions.PerformLayout();
            this.groupRandomOptions.ResumeLayout(false);
            this.groupRandomOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomCharsOption)).EndInit();
            this.groupRegExOptions.ResumeLayout(false);
            this.groupRegExOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputDirectory;
        private System.Windows.Forms.TextBox txtExtInclusions;
        private System.Windows.Forms.ComboBox comboRenamingStrat;
        private System.Windows.Forms.Button btnBrowseForInput;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBaseControls;
        private System.Windows.Forms.OpenFileDialog openFileDialogRename;
        private System.Windows.Forms.GroupBox groupLinearOptions;
        private System.Windows.Forms.GroupBox groupRandomOptions;
        private System.Windows.Forms.GroupBox groupRegExOptions;
        private System.Windows.Forms.TextBox txtLinearExample;
        private System.Windows.Forms.TextBox txtSuffixOption;
        private System.Windows.Forms.TextBox txtPrefixOption;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numRandomCharsOption;
        private System.Windows.Forms.TextBox txtRandomExample;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}