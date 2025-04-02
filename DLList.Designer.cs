namespace CSAssessment2
{
    partial class FrmDLList
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
            btnClose = new Button();
            txtBxSuburb = new TextBox();
            lblSuburb = new Label();
            btnBackward = new Button();
            btnForward = new Button();
            lblBackward = new Label();
            lblForward = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(341, 213);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(89, 47);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtBxSuburb
            // 
            txtBxSuburb.Location = new Point(40, 60);
            txtBxSuburb.Name = "txtBxSuburb";
            txtBxSuburb.Size = new Size(242, 23);
            txtBxSuburb.TabIndex = 1;
            txtBxSuburb.TextChanged += txtBxSuburb_TextChanged;
            // 
            // lblSuburb
            // 
            lblSuburb.AutoSize = true;
            lblSuburb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuburb.Location = new Point(40, 42);
            lblSuburb.Name = "lblSuburb";
            lblSuburb.Size = new Size(96, 15);
            lblSuburb.TabIndex = 2;
            lblSuburb.Text = "Name of suburb";
            // 
            // btnBackward
            // 
            btnBackward.Enabled = false;
            btnBackward.Location = new Point(40, 109);
            btnBackward.Name = "btnBackward";
            btnBackward.Size = new Size(75, 41);
            btnBackward.TabIndex = 3;
            btnBackward.Text = "Display Backward";
            btnBackward.UseVisualStyleBackColor = true;
            btnBackward.Click += btnBackward_Click;
            // 
            // btnForward
            // 
            btnForward.Enabled = false;
            btnForward.Location = new Point(40, 167);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(75, 41);
            btnForward.TabIndex = 4;
            btnForward.Text = "Display Forward";
            btnForward.UseVisualStyleBackColor = true;
            btnForward.Click += btnForward_Click;
            // 
            // lblBackward
            // 
            lblBackward.AutoSize = true;
            lblBackward.Location = new Point(133, 122);
            lblBackward.Name = "lblBackward";
            lblBackward.Size = new Size(251, 15);
            lblBackward.TabIndex = 5;
            lblBackward.Text = "Click button to transform the name of suburb.";
            // 
            // lblForward
            // 
            lblForward.AutoSize = true;
            lblForward.Location = new Point(133, 180);
            lblForward.Name = "lblForward";
            lblForward.Size = new Size(0, 15);
            lblForward.TabIndex = 6;
            // 
            // FrmDLList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 291);
            Controls.Add(lblForward);
            Controls.Add(lblBackward);
            Controls.Add(btnForward);
            Controls.Add(btnBackward);
            Controls.Add(lblSuburb);
            Controls.Add(txtBxSuburb);
            Controls.Add(btnClose);
            Name = "FrmDLList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doubly-linked List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private TextBox txtBxSuburb;
        private Label lblSuburb;
        private Button btnBackward;
        private Button btnForward;
        private Label lblBackward;
        private Label lblForward;
    }
}