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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialogRename = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
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
            this.btnRename.Location = new System.Drawing.Point(230, 74);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 7;
            this.btnRename.Text = "&Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(230, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(230, 131);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 9;
            this.btnUndo.Text = "Undo...";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(230, 160);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseForInput);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRename);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnUndo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtInputDirectory);
            this.groupBox1.Controls.Add(this.txtExtInclusions);
            this.groupBox1.Controls.Add(this.comboRenamingStrat);
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 197);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // RenamerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 241);
            this.Controls.Add(this.groupBox1);
            this.Name = "RenamerForm";
            this.Text = "Renamer";
            this.Load += new System.EventHandler(this.RenamerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialogRename;
    }
}