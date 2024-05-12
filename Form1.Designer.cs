namespace text_editor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            newToolStripMenuItem1 = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            lblGreeting = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem1, openToolStripMenuItem1, toolStripSeparator, exitToolStripMenuItem1 });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(37, 20);
            fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem1
            // 
            newToolStripMenuItem1.Image = (Image)resources.GetObject("newToolStripMenuItem1.Image");
            newToolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            newToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem1.Size = new Size(146, 22);
            newToolStripMenuItem1.Text = "&New";
            newToolStripMenuItem1.Click += newToolStripMenuItem1_Click;
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Image = (Image)resources.GetObject("openToolStripMenuItem1.Image");
            openToolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem1.Size = new Size(146, 22);
            openToolStripMenuItem1.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(143, 6);
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.E;
            exitToolStripMenuItem1.Size = new Size(146, 22);
            exitToolStripMenuItem1.Text = "E&xit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "&About";
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Lucida Console", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreeting.ForeColor = Color.FromArgb(0, 192, 0);
            lblGreeting.Location = new Point(285, 209);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(201, 37);
            lblGreeting.TabIndex = 1;
            lblGreeting.Text = "Welcome!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGreeting);
            Controls.Add(menuStrip1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor";
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label lblGreeting;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
