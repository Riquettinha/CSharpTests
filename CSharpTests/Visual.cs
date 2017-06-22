using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpTests.Performance;

namespace CSharpTests
{
    public partial class Visual : Form
    {
        public Visual()
        {
            InitializeComponent();
        }

        private void Visual_Load(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Loops newFrm = new Loops
                {
                    MdiParent = this,
                    // This set the form parent as the tabClicked
                    Parent = tabControl1.TabPages[0]
                };
                newFrm.Show();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                Enumerables newFrm = new Enumerables
                {
                    MdiParent = this,
                    // This set the form parent as the tabClicked
                    Parent = tabControl1.TabPages[1]
                };
                newFrm.Show();
            }

        }
    }
}
