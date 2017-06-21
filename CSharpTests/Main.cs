﻿using System;
using System.Windows.Forms;
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
    }
}
