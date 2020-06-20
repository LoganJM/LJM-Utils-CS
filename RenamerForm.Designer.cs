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
            this.groupRandomOptions = new System.Windows.Forms.GroupBox();
            this.groupRegExOptions = new System.Windows.Forms.GroupBox();
            this.groupBaseControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Extension Inclusions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Renaming Strategy:";
            // 
            // txtInputDirectory
            // 
            this.txtInputDirectory.Location = new System.Drawing.Point(24, 37);
            this.txtInputDirectory.Name = "txtInputDirectory";
            this.txtInputDirectory.Size = new System.Drawing.Size(200, 20);
            this.txtInputDirectory.TabIndex = 3;
            // 
            // txtExtInclusions
            // 
            this.txtExtInclusions.Location = new System.Drawing.Point(24, 93);
            this.txtExtInclusions.Name = "txtExtInclusions";
            this.txtExtInclusions.Size = new System.Drawing.Size(146, 20);
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
            this.comboRenamingStrat.Location = new System.Drawing.Point(24, 150);
            this.comboRenamingStrat.Name = "comboRenamingStrat";
            this.comboRenamingStrat.Size = new System.Drawing.Size(146, 21);
            this.comboRenamingStrat.TabIndex = 5;
            this.comboRenamingStrat.SelectedIndexChanged += new System.EventHandler(this.comboRenamingStrat_SelectedIndexChanged);
            // 
            // btnBrowseForInput
            // 
            this.btnBrowseForInput.Location = new System.Drawing.Point(230, 36);
            this.btnBrowseForInput.Name = "btnBrowseForInput";
            this.btnBrowseForInput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseForInput.TabIndex = 6;
            this.btnBrowseForInput.Text = "Browse...";
            this.btnBrowseForInput.UseVisualStyleBackColor = true;
            this.btnBrowseForInput.Click += new System.EventHandler(this.btnBrowseForInput_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(177, 358);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 7;
            this.btnRename.Text = "&Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(240, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(240, 158);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 9;
            this.btnUndo.Text = "Undo...";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(258, 358);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
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
            this.groupBaseControls.Location = new System.Drawing.Point(11, 6);
            this.groupBaseControls.Name = "groupBaseControls";
            this.groupBaseControls.Size = new System.Drawing.Size(321, 197);
            this.groupBaseControls.TabIndex = 11;
            this.groupBaseControls.TabStop = false;
            // 
            // groupLinearOptions
            // 
            this.groupLinearOptions.Location = new System.Drawing.Point(11, 209);
            this.groupLinearOptions.Name = "groupLinearOptions";
            this.groupLinearOptions.Size = new System.Drawing.Size(321, 141);
            this.groupLinearOptions.TabIndex = 12;
            this.groupLinearOptions.TabStop = false;
            this.groupLinearOptions.Text = "Linear Options";
            // 
            // groupRandomOptions
            // 
            this.groupRandomOptions.Location = new System.Drawing.Point(360, 42);
            this.groupRandomOptions.Name = "groupRandomOptions";
            this.groupRandomOptions.Size = new System.Drawing.Size(321, 141);
            this.groupRandomOptions.TabIndex = 13;
            this.groupRandomOptions.TabStop = false;
            this.groupRandomOptions.Text = "Random Options";
            // 
            // groupRegExOptions
            // 
            this.groupRegExOptions.Location = new System.Drawing.Point(360, 194);
            this.groupRegExOptions.Name = "groupRegExOptions";
            this.groupRegExOptions.Size = new System.Drawing.Size(321, 141);
            this.groupRegExOptions.TabIndex = 14;
            this.groupRegExOptions.TabStop = false;
            this.groupRegExOptions.Text = "RegEx Options";
            // 
            // RenamerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 391);
            this.Controls.Add(this.groupRegExOptions);
            this.Controls.Add(this.groupRandomOptions);
            this.Controls.Add(this.groupLinearOptions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBaseControls);
            this.Controls.Add(this.btnRename);
            this.Name = "RenamerForm";
            this.Text = "Renamer";
            this.Load += new System.EventHandler(this.RenamerForm_Load);
            this.groupBaseControls.ResumeLayout(false);
            this.groupBaseControls.PerformLayout();
            this.ResumeLayout(false);

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
    }
}