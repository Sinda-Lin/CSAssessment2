//****************************************************************
// Programmer: Shanda Lin
// Date: 2025-04-01
// Software: Microsoft Visual Studio 2022 Community Edition
// Platform: Microsoft Windows 11 Professional 64-bit
// Purpose: Assessment 2 for a multi-form to task A-D
//****************************************************************

namespace CSAssessment2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Link to the form 2D graphic - Part A
        //This form draw a house with garage by SkiaSharp
        private void dGrapicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraphic my2DCanvas = new frmGraphic();
            my2DCanvas.ShowDialog();
        }
        // Link to the form drag and drop display - Part B
        //This form is a tool to display image. Once the image is drag and drop to the form, the image will be shown on the form.
        private void dragAndDropDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDragandDrop myDADform = new frmDragandDrop();
            myDADform.ShowDialog();
        }
        //Link to the form doubly linked list tool - Part C
        //This form shows how doubly linked list work to display a suburb name backward and forward.
        //Just input the suburb name and click button to get the result.
        private void doublyLinkedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDLList myDLList = new FrmDLList();
            myDLList.ShowDialog();
        }
        //Link to the form nested class - Part D
        //This form shows how nested classes work to store and display car's details.
        private void nestedClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNestedClasses myNestedClasses = new frmNestedClasses();
            myNestedClasses.ShowDialog();
        }
   
        //Show my details in a message box.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shanda Lin; CIT301720; Assessment 2 for C#: Multi-form for multi-tasks", "About me", MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
