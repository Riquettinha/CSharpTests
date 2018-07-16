using System;
using System.Windows.Forms;

namespace CSharpTests
{
    public partial class ConvertToDecimal : Form
    {
        public ConvertToDecimal()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var value = tbOriginalDecimal.Text;
            tbResult1.Text = ExtensionMethods.ConvertToDecimal(value, false).ToString();
            tbResult2.Text = value.ConvertToDecimal().ToString();
        }
    }
}
