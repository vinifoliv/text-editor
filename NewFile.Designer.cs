namespace text_editor
{
    partial class NewFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFile));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            turnOnAutosaveToolStripMenuItem = new ToolStripMenuItem();
            txtFileName = new TextBox();
            txtText = new RichTextBox();
            txtTextInformation = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(718, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, turnOnAutosaveToolStripMenuItem, openToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 19);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(237, 22);
            saveToolStripMenuItem.Text = "Save as";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click_1;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(237, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exitToolStripMenuItem.Size = new Size(237, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // turnOnAutosaveToolStripMenuItem
            // 
            turnOnAutosaveToolStripMenuItem.Name = "turnOnAutosaveToolStripMenuItem";
            turnOnAutosaveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            turnOnAutosaveToolStripMenuItem.Size = new Size(237, 22);
            turnOnAutosaveToolStripMenuItem.Text = "Turn on autosave";
            // 
            // txtFileName
            // 
            txtFileName.BackColor = SystemColors.WindowText;
            txtFileName.BorderStyle = BorderStyle.None;
            txtFileName.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFileName.ForeColor = Color.Silver;
            txtFileName.Location = new Point(0, 30);
            txtFileName.Margin = new Padding(5);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(718, 18);
            txtFileName.TabIndex = 2;
            txtFileName.Text = "File name";
            txtFileName.TextAlign = HorizontalAlignment.Center;
            txtFileName.Enter += txtFileName_Enter;
            txtFileName.KeyDown += txtFileName_KeyDown;
            txtFileName.Leave += txtFileName_Leave;
            // 
            // txtText
            // 
            txtText.BackColor = Color.FromArgb(64, 64, 64);
            txtText.BorderStyle = BorderStyle.None;
            txtText.Font = new Font("Arial", 11.25F);
            txtText.ForeColor = Color.White;
            txtText.Location = new Point(12, 60);
            txtText.Name = "txtText";
            txtText.Size = new Size(694, 291);
            txtText.TabIndex = 1;
            txtText.Text = "";
            txtText.KeyDown += txtText_KeyDown;
            // 
            // txtTextInformation
            // 
            txtTextInformation.BackColor = Color.Black;
            txtTextInformation.BorderStyle = BorderStyle.None;
            txtTextInformation.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTextInformation.ForeColor = Color.White;
            txtTextInformation.ImeMode = ImeMode.Disable;
            txtTextInformation.Location = new Point(12, 357);
            txtTextInformation.Name = "txtTextInformation";
            txtTextInformation.ReadOnly = true;
            txtTextInformation.Size = new Size(694, 18);
            txtTextInformation.TabIndex = 3;
            // 
            // NewFile
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(718, 396);
            Controls.Add(txtTextInformation);
            Controls.Add(txtText);
            Controls.Add(txtFileName);
            Controls.Add(menuStrip1);
            Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "NewFile";
            Text = " ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox txtFileName;
        private RichTextBox txtText;
        private TextBox txtTextInformation;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem turnOnAutosaveToolStripMenuItem;
    }
}