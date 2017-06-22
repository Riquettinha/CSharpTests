using System;
using System.Windows.Forms;
using CSharpTests.Performance;
using CSharpTests.Results;

namespace CSharpTests
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: Save results in this form to remember
        }

        private void convertDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertDate frm = new ConvertDate
            {
                MdiParent = this,
                Parent = pnlMain
            };
            frm.Show();
        }

        private void loopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loops frm = new Loops
            {
                MdiParent = this,
                Parent = pnlMain
            };
            frm.Show();
        }

        private void enumerableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enumerables frm = new Enumerables
            {
                MdiParent = this,
                Parent = pnlMain
            };
            frm.Show();
        }

        private void visualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Visual();
            frm.Show();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
