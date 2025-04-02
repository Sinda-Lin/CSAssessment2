using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAssessment2
{
    public partial class frmDragandDrop : Form
    {
        public frmDragandDrop()
        {
            InitializeComponent();

            //Enable the drop event
            this.AllowDrop = true;
            //Envent listener for drag enter and drop
            this.DragEnter += new DragEventHandler(picBox_DragEnter);
            this.DragDrop += new DragEventHandler(picBox_DragDrop);
        }


        private void FrmDragandDrop_DragDrop(object? sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void picBox_DragEnter(object sender, DragEventArgs e)
        { 
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
                //When file is dragged into the form, copy the file to e.Effect
                e.Effect = DragDropEffects.Copy;
            else 
                e.Effect = DragDropEffects.None;
        }

        private void picBox_DragDrop(object sender, DragEventArgs e)
        {
            // Get dropped file paths
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                try
                {
                    // Load and display the image
                    picBox.Image = Image.FromFile(files[0]);
                    picBox.SizeMode = PictureBoxSizeMode.Zoom; // Adjust image size
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) 
        { 
            this.Close();
        }
    }
}
