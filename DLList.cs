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
    public partial class FrmDLList : Form
    {
        public FrmDLList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string suburbName;
        LinkedList<char> llSuburb;
        
        private void txtBxSuburb_TextChanged(object sender, EventArgs e)
        {
            suburbName = txtBxSuburb.Text;
            if (suburbName.Length > 0)
            {
                //When the suburb name change, reset all the buttons and labels
                btnBackward.Enabled = true;
                btnForward.Enabled = false;
                lblBackward.Text = "Click button to transform the name of suburb.";
                lblForward.Text = "";

                llSuburb = new LinkedList<char>();
                // transform the suburb name string to chars array
                char[] charsSuburb = suburbName.ToCharArray();
                //input each character backward into the link list
                foreach (char c in charsSuburb)
                {
                    llSuburb.AddLast(c);
                }
            }
            else
            {
                btnBackward.Enabled = false;
                btnForward.Enabled = false;
                lblBackward.Text = "Click button to transform the name of suburb.";
                lblForward.Text = "";
            }
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            //output the character from the link list to the label
            string result = "";
            for (LinkedListNode<char> node = llSuburb.First; node != null; node = node.Next)
            {
                char c = node.Value;
                result = result + c.ToString();
            }
            lblBackward.Text = result;
            btnBackward.Enabled = false;
            btnForward.Enabled = true;
            lblForward.Text = "Click button to transform the name of suburb.";
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            //output the character from the link list to the label
            string result = "";
            for (LinkedListNode<char> node = llSuburb.Last; node != null; node = node.Previous)
            {
                char c = node.Value;
                result = result + c.ToString();
            }
            lblForward.Text = result;
            btnBackward.Enabled = false;
            btnForward.Enabled = false;
        }
    }
}
