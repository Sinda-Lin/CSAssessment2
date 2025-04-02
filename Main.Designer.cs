namespace CSAssessment2
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            dGrapicToolStripMenuItem = new ToolStripMenuItem();
            dragAndDropDisplayToolStripMenuItem = new ToolStripMenuItem();
            doublyLinkedListToolStripMenuItem = new ToolStripMenuItem();
            nestedClassesToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(516, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dGrapicToolStripMenuItem, dragAndDropDisplayToolStripMenuItem, doublyLinkedListToolStripMenuItem, nestedClassesToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // dGrapicToolStripMenuItem
            // 
            dGrapicToolStripMenuItem.Name = "dGrapicToolStripMenuItem";
            dGrapicToolStripMenuItem.Size = new Size(191, 22);
            dGrapicToolStripMenuItem.Text = "2D grapic";
            dGrapicToolStripMenuItem.Click += dGrapicToolStripMenuItem_Click;
            // 
            // dragAndDropDisplayToolStripMenuItem
            // 
            dragAndDropDisplayToolStripMenuItem.Name = "dragAndDropDisplayToolStripMenuItem";
            dragAndDropDisplayToolStripMenuItem.Size = new Size(191, 22);
            dragAndDropDisplayToolStripMenuItem.Text = "Drag and Drop display";
            dragAndDropDisplayToolStripMenuItem.Click += dragAndDropDisplayToolStripMenuItem_Click;
            // 
            // doublyLinkedListToolStripMenuItem
            // 
            doublyLinkedListToolStripMenuItem.Name = "doublyLinkedListToolStripMenuItem";
            doublyLinkedListToolStripMenuItem.Size = new Size(191, 22);
            doublyLinkedListToolStripMenuItem.Text = "Doubly Linked list";
            doublyLinkedListToolStripMenuItem.Click += doublyLinkedListToolStripMenuItem_Click;
            // 
            // nestedClassesToolStripMenuItem
            // 
            nestedClassesToolStripMenuItem.Name = "nestedClassesToolStripMenuItem";
            nestedClassesToolStripMenuItem.Size = new Size(191, 22);
            nestedClassesToolStripMenuItem.Text = "Nested classes";
            nestedClassesToolStripMenuItem.Click += nestedClassesToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(191, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 336);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem dGrapicToolStripMenuItem;
        private ToolStripMenuItem dragAndDropDisplayToolStripMenuItem;
        private ToolStripMenuItem doublyLinkedListToolStripMenuItem;
        private ToolStripMenuItem nestedClassesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
