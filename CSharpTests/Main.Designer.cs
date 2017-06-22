namespace CSharpTests
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enumerableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Silver;
            this.menuStrip.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultsToolStripMenuItem,
            this.performanceToolStripMenuItem,
            this.visualToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(633, 26);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertDateToolStripMenuItem});
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.resultsToolStripMenuItem.Text = "Resultados";
            this.resultsToolStripMenuItem.Click += new System.EventHandler(this.resultsToolStripMenuItem_Click);
            // 
            // convertDateToolStripMenuItem
            // 
            this.convertDateToolStripMenuItem.Name = "convertDateToolStripMenuItem";
            this.convertDateToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.convertDateToolStripMenuItem.Text = "Conversão Date";
            this.convertDateToolStripMenuItem.Click += new System.EventHandler(this.convertDateToolStripMenuItem_Click);
            // 
            // performanceToolStripMenuItem
            // 
            this.performanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loopsToolStripMenuItem,
            this.enumerableToolStripMenuItem});
            this.performanceToolStripMenuItem.Name = "performanceToolStripMenuItem";
            this.performanceToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.performanceToolStripMenuItem.Text = "Performance";
            // 
            // loopsToolStripMenuItem
            // 
            this.loopsToolStripMenuItem.Name = "loopsToolStripMenuItem";
            this.loopsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loopsToolStripMenuItem.Text = "Loops";
            this.loopsToolStripMenuItem.Click += new System.EventHandler(this.loopsToolStripMenuItem_Click);
            // 
            // enumerableToolStripMenuItem
            // 
            this.enumerableToolStripMenuItem.Name = "enumerableToolStripMenuItem";
            this.enumerableToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.enumerableToolStripMenuItem.Text = "Enumerable";
            this.enumerableToolStripMenuItem.Click += new System.EventHandler(this.enumerableToolStripMenuItem_Click);
            // 
            // visualToolStripMenuItem
            // 
            this.visualToolStripMenuItem.Name = "visualToolStripMenuItem";
            this.visualToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.visualToolStripMenuItem.Text = "Visual";
            this.visualToolStripMenuItem.Click += new System.EventHandler(this.visualToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Location = new System.Drawing.Point(0, 21);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(633, 307);
            this.pnlMain.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 329);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSharpTests";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performanceToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem loopsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enumerableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualToolStripMenuItem;
    }
}