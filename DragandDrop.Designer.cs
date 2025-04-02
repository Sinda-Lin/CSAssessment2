namespace CSAssessment2
{
    partial class frmDragandDrop
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
            picBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(478, 387);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(89, 44);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // picBox
            // 
            picBox.Location = new Point(12, 12);
            picBox.Name = "picBox";
            picBox.Size = new Size(460, 419);
            picBox.TabIndex = 1;
            picBox.TabStop = false;
            picBox.DragDrop += this.picBox_DragDrop;
            picBox.DragEnter += picBox_DragEnter;
            // 
            // frmDragandDrop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 443);
            Controls.Add(picBox);
            Controls.Add(btnClose);
            Name = "frmDragandDrop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DragandDrop";
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private PictureBox picBox;
    }
}