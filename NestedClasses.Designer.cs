namespace CSAssessment2
{
    partial class frmNestedClasses
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
            lblInformatin = new Label();
            txtModel = new TextBox();
            lblModel = new Label();
            lblEngine = new Label();
            txtEngine = new TextBox();
            lblDetail = new Label();
            lblResult = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(323, 207);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(97, 46);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblInformatin
            // 
            lblInformatin.AutoSize = true;
            lblInformatin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInformatin.Location = new Point(40, 40);
            lblInformatin.Name = "lblInformatin";
            lblInformatin.Size = new Size(239, 15);
            lblInformatin.TabIndex = 1;
            lblInformatin.Text = "Please provide the new car's detail below:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(147, 70);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(132, 23);
            txtModel.TabIndex = 2;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(40, 73);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(68, 15);
            lblModel.TabIndex = 3;
            lblModel.Text = "Car Model: ";
            // 
            // lblEngine
            // 
            lblEngine.AutoSize = true;
            lblEngine.Location = new Point(40, 107);
            lblEngine.Name = "lblEngine";
            lblEngine.Size = new Size(94, 15);
            lblEngine.TabIndex = 4;
            lblEngine.Text = "Car Engine Type:";
            // 
            // txtEngine
            // 
            txtEngine.Location = new Point(147, 107);
            txtEngine.Name = "txtEngine";
            txtEngine.Size = new Size(132, 23);
            txtEngine.TabIndex = 5;
            // 
            // lblDetail
            // 
            lblDetail.AutoSize = true;
            lblDetail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetail.Location = new Point(40, 154);
            lblDetail.Name = "lblDetail";
            lblDetail.Size = new Size(172, 15);
            lblDetail.TabIndex = 6;
            lblDetail.Text = "Above, we get the car details:";
            // 
            // lblResult
            // 
            lblResult.AutoEllipsis = true;
            lblResult.AutoSize = true;
            lblResult.Location = new Point(70, 182);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(323, 84);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(97, 46);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // frmNestedClasses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 270);
            Controls.Add(btnSubmit);
            Controls.Add(lblResult);
            Controls.Add(lblDetail);
            Controls.Add(txtEngine);
            Controls.Add(lblEngine);
            Controls.Add(lblModel);
            Controls.Add(txtModel);
            Controls.Add(lblInformatin);
            Controls.Add(btnClose);
            Name = "frmNestedClasses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nested Classes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label lblInformatin;
        private TextBox txtModel;
        private Label lblModel;
        private Label lblEngine;
        private TextBox txtEngine;
        private Label lblDetail;
        private Label lblResult;
        private Button btnSubmit;
    }
}