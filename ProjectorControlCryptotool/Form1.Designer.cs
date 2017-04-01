namespace ProjectorControlCryptotool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.computerNameLabel = new System.Windows.Forms.Label();
            this.computerNameTextBox = new System.Windows.Forms.TextBox();
            this.projectorIPLabel = new System.Windows.Forms.Label();
            this.projectorIPTextBox = new System.Windows.Forms.TextBox();
            this.addProjectorGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.loadSaveGroupBox = new System.Windows.Forms.GroupBox();
            this.xmlFileBrowseButton = new System.Windows.Forms.Button();
            this.xmlFileLabel = new System.Windows.Forms.Label();
            this.xmlFileTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.xmlNodesListBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.saveEncryptedButton = new System.Windows.Forms.Button();
            this.addProjectorGroupBox.SuspendLayout();
            this.loadSaveGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // computerNameLabel
            // 
            this.computerNameLabel.AutoSize = true;
            this.computerNameLabel.Location = new System.Drawing.Point(13, 30);
            this.computerNameLabel.Name = "computerNameLabel";
            this.computerNameLabel.Size = new System.Drawing.Size(86, 13);
            this.computerNameLabel.TabIndex = 0;
            this.computerNameLabel.Text = "Computer Name:";
            // 
            // computerNameTextBox
            // 
            this.computerNameTextBox.Location = new System.Drawing.Point(136, 27);
            this.computerNameTextBox.Name = "computerNameTextBox";
            this.computerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.computerNameTextBox.TabIndex = 1;
            // 
            // projectorIPLabel
            // 
            this.projectorIPLabel.AutoSize = true;
            this.projectorIPLabel.Location = new System.Drawing.Point(13, 56);
            this.projectorIPLabel.Name = "projectorIPLabel";
            this.projectorIPLabel.Size = new System.Drawing.Size(65, 13);
            this.projectorIPLabel.TabIndex = 2;
            this.projectorIPLabel.Text = "Projector IP:";
            // 
            // projectorIPTextBox
            // 
            this.projectorIPTextBox.Location = new System.Drawing.Point(136, 53);
            this.projectorIPTextBox.Name = "projectorIPTextBox";
            this.projectorIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.projectorIPTextBox.TabIndex = 3;
            // 
            // addProjectorGroupBox
            // 
            this.addProjectorGroupBox.Controls.Add(this.addButton);
            this.addProjectorGroupBox.Controls.Add(this.projectorIPTextBox);
            this.addProjectorGroupBox.Controls.Add(this.computerNameLabel);
            this.addProjectorGroupBox.Controls.Add(this.computerNameTextBox);
            this.addProjectorGroupBox.Controls.Add(this.projectorIPLabel);
            this.addProjectorGroupBox.Location = new System.Drawing.Point(12, 81);
            this.addProjectorGroupBox.Name = "addProjectorGroupBox";
            this.addProjectorGroupBox.Size = new System.Drawing.Size(257, 134);
            this.addProjectorGroupBox.TabIndex = 5;
            this.addProjectorGroupBox.TabStop = false;
            this.addProjectorGroupBox.Text = "Add Projector";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(161, 90);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // loadSaveGroupBox
            // 
            this.loadSaveGroupBox.Controls.Add(this.xmlFileBrowseButton);
            this.loadSaveGroupBox.Controls.Add(this.xmlFileLabel);
            this.loadSaveGroupBox.Controls.Add(this.xmlFileTextBox);
            this.loadSaveGroupBox.Location = new System.Drawing.Point(12, 12);
            this.loadSaveGroupBox.Name = "loadSaveGroupBox";
            this.loadSaveGroupBox.Size = new System.Drawing.Size(257, 63);
            this.loadSaveGroupBox.TabIndex = 8;
            this.loadSaveGroupBox.TabStop = false;
            this.loadSaveGroupBox.Text = "Load";
            // 
            // xmlFileBrowseButton
            // 
            this.xmlFileBrowseButton.Location = new System.Drawing.Point(167, 25);
            this.xmlFileBrowseButton.Name = "xmlFileBrowseButton";
            this.xmlFileBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.xmlFileBrowseButton.TabIndex = 5;
            this.xmlFileBrowseButton.Text = "Browse...";
            this.xmlFileBrowseButton.UseVisualStyleBackColor = true;
            this.xmlFileBrowseButton.Click += new System.EventHandler(this.xmlFileBrowseButton_Click);
            // 
            // xmlFileLabel
            // 
            this.xmlFileLabel.AutoSize = true;
            this.xmlFileLabel.Location = new System.Drawing.Point(13, 30);
            this.xmlFileLabel.Name = "xmlFileLabel";
            this.xmlFileLabel.Size = new System.Drawing.Size(34, 13);
            this.xmlFileLabel.TabIndex = 0;
            this.xmlFileLabel.Text = "Load:";
            // 
            // xmlFileTextBox
            // 
            this.xmlFileTextBox.Location = new System.Drawing.Point(53, 27);
            this.xmlFileTextBox.Name = "xmlFileTextBox";
            this.xmlFileTextBox.Size = new System.Drawing.Size(108, 20);
            this.xmlFileTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(387, 373);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // xmlNodesListBox
            // 
            this.xmlNodesListBox.FormattingEnabled = true;
            this.xmlNodesListBox.Location = new System.Drawing.Point(275, 12);
            this.xmlNodesListBox.Name = "xmlNodesListBox";
            this.xmlNodesListBox.Size = new System.Drawing.Size(288, 355);
            this.xmlNodesListBox.TabIndex = 9;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(275, 373);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // saveEncryptedButton
            // 
            this.saveEncryptedButton.Location = new System.Drawing.Point(468, 373);
            this.saveEncryptedButton.Name = "saveEncryptedButton";
            this.saveEncryptedButton.Size = new System.Drawing.Size(95, 23);
            this.saveEncryptedButton.TabIndex = 12;
            this.saveEncryptedButton.Text = "Save Encrypted";
            this.saveEncryptedButton.UseVisualStyleBackColor = true;
            this.saveEncryptedButton.Click += new System.EventHandler(this.saveEncryptedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 405);
            this.Controls.Add(this.saveEncryptedButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.xmlNodesListBox);
            this.Controls.Add(this.loadSaveGroupBox);
            this.Controls.Add(this.addProjectorGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Projector Control Cryptotool";
            this.addProjectorGroupBox.ResumeLayout(false);
            this.addProjectorGroupBox.PerformLayout();
            this.loadSaveGroupBox.ResumeLayout(false);
            this.loadSaveGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label computerNameLabel;
        private System.Windows.Forms.TextBox computerNameTextBox;
        private System.Windows.Forms.Label projectorIPLabel;
        private System.Windows.Forms.TextBox projectorIPTextBox;
        private System.Windows.Forms.GroupBox addProjectorGroupBox;
        private System.Windows.Forms.GroupBox loadSaveGroupBox;
        private System.Windows.Forms.Label xmlFileLabel;
        private System.Windows.Forms.TextBox xmlFileTextBox;
        private System.Windows.Forms.Button xmlFileBrowseButton;
        private System.Windows.Forms.ListBox xmlNodesListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveEncryptedButton;
    }
}

