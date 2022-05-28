using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrwaRactangle
{
    public partial class RactangleForm : Form
    {
        public RactangleForm()
        {
            InitializeComponent();
        }

        private void btnRanctangle_Click(object sender, EventArgs e)
        {
            //Validate the Width
            bool isValid = ValidateEntry(txtwidth);

        }

        private bool ValidateEntry(TextBox tb)
        {
            bool isValid = false;
            double value;
            try
            {
                if(tb.Text.Trim() == "")
                {
                    lblInfo.Text = "Please enter a value.";
                    lblInfo.ForeColor = Color.Red;
                }
                else
                {
                    value = double.Parse(tb.Text.Trim());
                    isValid = true;
                }
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Invalid input";
                lblInfo.ForeColor = Color.Red;
            }
            return isValid;
        }

    }
}
