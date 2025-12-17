using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1  // <--- CHECK THIS: Must match your Project Name
{
    public partial class FeeTableWidget : UserControl
    {
        // This is the Constructor. The Designer NEEDS this to exist.
        public FeeTableWidget()
        {
            InitializeComponent();
        }

        
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // This removes the widget from the parent panel
            this.Parent.Controls.Remove(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // This triggers an event to tell the main form to add another table
            // (For simplicity, you can just add logic here or pass it to parent)
            MessageBox.Show("To add a new table, click the main Add button.");
        }


        // -----------------------------------------------------------------
        // PASTE YOUR LOGIC HERE (INSIDE the class, BELOW the constructor)
        // -----------------------------------------------------------------

        public void SetYear(string year)
        {
            // We will fix the label name in a moment
            if (this.Controls.ContainsKey("lblYear"))
                this.Controls["lblYear"].Text = year + " Year";
        }
    }
}