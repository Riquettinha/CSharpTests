namespace CSharpTests
{
    partial class ConvertDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertDate));
            this.tbOriginalDate = new System.Windows.Forms.TextBox();
            this.tbResult1 = new System.Windows.Forms.TextBox();
            this.tbResult2 = new System.Windows.Forms.TextBox();
            this.tbResult3 = new System.Windows.Forms.TextBox();
            this.tbResult4 = new System.Windows.Forms.TextBox();
            this.tbResult5 = new System.Windows.Forms.TextBox();
            this.tbResult6 = new System.Windows.Forms.TextBox();
            this.tbResult7 = new System.Windows.Forms.TextBox();
            this.tbResult8 = new System.Windows.Forms.TextBox();
            this.tbResult9 = new System.Windows.Forms.TextBox();
            this.lbResult1 = new System.Windows.Forms.Label();
            this.lbResult2 = new System.Windows.Forms.Label();
            this.lbResult3 = new System.Windows.Forms.Label();
            this.lbResult4 = new System.Windows.Forms.Label();
            this.lbResult5 = new System.Windows.Forms.Label();
            this.lbResult6 = new System.Windows.Forms.Label();
            this.lbResult7 = new System.Windows.Forms.Label();
            this.lbResult8 = new System.Windows.Forms.Label();
            this.lbResult9 = new System.Windows.Forms.Label();
            this.lbOriginalDate = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.lbHeader1 = new System.Windows.Forms.Label();
            this.lbHeader2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbOriginalDate
            // 
            this.tbOriginalDate.Location = new System.Drawing.Point(100, 9);
            this.tbOriginalDate.Name = "tbOriginalDate";
            this.tbOriginalDate.Size = new System.Drawing.Size(179, 22);
            this.tbOriginalDate.TabIndex = 0;
            // 
            // tbResult1
            // 
            this.tbResult1.Location = new System.Drawing.Point(293, 62);
            this.tbResult1.Name = "tbResult1";
            this.tbResult1.Size = new System.Drawing.Size(94, 22);
            this.tbResult1.TabIndex = 1;
            // 
            // tbResult2
            // 
            this.tbResult2.Location = new System.Drawing.Point(293, 90);
            this.tbResult2.Name = "tbResult2";
            this.tbResult2.Size = new System.Drawing.Size(94, 22);
            this.tbResult2.TabIndex = 2;
            // 
            // tbResult3
            // 
            this.tbResult3.Location = new System.Drawing.Point(293, 118);
            this.tbResult3.Name = "tbResult3";
            this.tbResult3.Size = new System.Drawing.Size(94, 22);
            this.tbResult3.TabIndex = 3;
            // 
            // tbResult4
            // 
            this.tbResult4.Location = new System.Drawing.Point(293, 146);
            this.tbResult4.Name = "tbResult4";
            this.tbResult4.Size = new System.Drawing.Size(94, 22);
            this.tbResult4.TabIndex = 4;
            // 
            // tbResult5
            // 
            this.tbResult5.Location = new System.Drawing.Point(293, 174);
            this.tbResult5.Name = "tbResult5";
            this.tbResult5.Size = new System.Drawing.Size(94, 22);
            this.tbResult5.TabIndex = 5;
            // 
            // tbResult6
            // 
            this.tbResult6.Location = new System.Drawing.Point(293, 201);
            this.tbResult6.Name = "tbResult6";
            this.tbResult6.Size = new System.Drawing.Size(94, 22);
            this.tbResult6.TabIndex = 6;
            // 
            // tbResult7
            // 
            this.tbResult7.Location = new System.Drawing.Point(293, 229);
            this.tbResult7.Name = "tbResult7";
            this.tbResult7.Size = new System.Drawing.Size(94, 22);
            this.tbResult7.TabIndex = 7;
            // 
            // tbResult8
            // 
            this.tbResult8.Location = new System.Drawing.Point(293, 257);
            this.tbResult8.Name = "tbResult8";
            this.tbResult8.Size = new System.Drawing.Size(94, 22);
            this.tbResult8.TabIndex = 8;
            // 
            // tbResult9
            // 
            this.tbResult9.Location = new System.Drawing.Point(293, 285);
            this.tbResult9.Name = "tbResult9";
            this.tbResult9.Size = new System.Drawing.Size(94, 22);
            this.tbResult9.TabIndex = 9;
            // 
            // lbResult1
            // 
            this.lbResult1.AutoSize = true;
            this.lbResult1.Location = new System.Drawing.Point(6, 66);
            this.lbResult1.Name = "lbResult1";
            this.lbResult1.Size = new System.Drawing.Size(112, 14);
            this.lbResult1.TabIndex = 10;
            this.lbResult1.Text = "Convert.ToDateTime";
            // 
            // lbResult2
            // 
            this.lbResult2.AutoSize = true;
            this.lbResult2.Location = new System.Drawing.Point(6, 94);
            this.lbResult2.Name = "lbResult2";
            this.lbResult2.Size = new System.Drawing.Size(71, 14);
            this.lbResult2.TabIndex = 11;
            this.lbResult2.Text = ".Parse(date)";
            // 
            // lbResult3
            // 
            this.lbResult3.AutoSize = true;
            this.lbResult3.Location = new System.Drawing.Point(6, 122);
            this.lbResult3.Name = "lbResult3";
            this.lbResult3.Size = new System.Drawing.Size(113, 14);
            this.lbResult3.TabIndex = 12;
            this.lbResult3.Text = ".Parse(date, culture)";
            // 
            // lbResult4
            // 
            this.lbResult4.AutoSize = true;
            this.lbResult4.Location = new System.Drawing.Point(6, 150);
            this.lbResult4.Name = "lbResult4";
            this.lbResult4.Size = new System.Drawing.Size(142, 14);
            this.lbResult4.TabIndex = 13;
            this.lbResult4.Text = ".Parse(date, culture, style)";
            // 
            // lbResult5
            // 
            this.lbResult5.AutoSize = true;
            this.lbResult5.Location = new System.Drawing.Point(6, 178);
            this.lbResult5.Name = "lbResult5";
            this.lbResult5.Size = new System.Drawing.Size(193, 14);
            this.lbResult5.TabIndex = 14;
            this.lbResult5.Text = ".ParseExact(date, sFormart, culture)";
            // 
            // lbResult6
            // 
            this.lbResult6.AutoSize = true;
            this.lbResult6.Location = new System.Drawing.Point(6, 204);
            this.lbResult6.Name = "lbResult6";
            this.lbResult6.Size = new System.Drawing.Size(217, 14);
            this.lbResult6.TabIndex = 15;
            this.lbResult6.Text = ".ParseExact(date, sFormat, culture, style)";
            // 
            // lbResult7
            // 
            this.lbResult7.AutoSize = true;
            this.lbResult7.Location = new System.Drawing.Point(6, 232);
            this.lbResult7.Name = "lbResult7";
            this.lbResult7.Size = new System.Drawing.Size(111, 14);
            this.lbResult7.TabIndex = 16;
            this.lbResult7.Text = ".TryParse(date, out)";
            // 
            // lbResult8
            // 
            this.lbResult8.AutoSize = true;
            this.lbResult8.Location = new System.Drawing.Point(6, 260);
            this.lbResult8.Name = "lbResult8";
            this.lbResult8.Size = new System.Drawing.Size(182, 14);
            this.lbResult8.TabIndex = 17;
            this.lbResult8.Text = ".TryParse(date, culture, style, out)";
            // 
            // lbResult9
            // 
            this.lbResult9.AutoSize = true;
            this.lbResult9.Location = new System.Drawing.Point(6, 288);
            this.lbResult9.Name = "lbResult9";
            this.lbResult9.Size = new System.Drawing.Size(257, 14);
            this.lbResult9.TabIndex = 18;
            this.lbResult9.Text = ".TryParseExact(date, sFormat, culture, style, out)";
            // 
            // lbOriginalDate
            // 
            this.lbOriginalDate.AutoSize = true;
            this.lbOriginalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOriginalDate.Location = new System.Drawing.Point(6, 12);
            this.lbOriginalDate.Name = "lbOriginalDate";
            this.lbOriginalDate.Size = new System.Drawing.Size(38, 13);
            this.lbOriginalDate.TabIndex = 19;
            this.lbOriginalDate.Text = "Data:";
            // 
            // btnTest
            // 
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.ForeColor = System.Drawing.Color.Black;
            this.btnTest.Location = new System.Drawing.Point(293, 6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(94, 24);
            this.btnTest.TabIndex = 20;
            this.btnTest.Text = "Testar";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lbHeader1
            // 
            this.lbHeader1.AutoSize = true;
            this.lbHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader1.Location = new System.Drawing.Point(6, 40);
            this.lbHeader1.Name = "lbHeader1";
            this.lbHeader1.Size = new System.Drawing.Size(49, 13);
            this.lbHeader1.TabIndex = 21;
            this.lbHeader1.Text = "Método";
            // 
            // lbHeader2
            // 
            this.lbHeader2.AutoSize = true;
            this.lbHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader2.Location = new System.Drawing.Point(289, 40);
            this.lbHeader2.Name = "lbHeader2";
            this.lbHeader2.Size = new System.Drawing.Size(64, 13);
            this.lbHeader2.TabIndex = 22;
            this.lbHeader2.Text = "Resultado";
            // 
            // ConvertDate
            // 
            this.AcceptButton = this.btnTest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 313);
            this.Controls.Add(this.lbHeader2);
            this.Controls.Add(this.lbHeader1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lbOriginalDate);
            this.Controls.Add(this.lbResult9);
            this.Controls.Add(this.lbResult8);
            this.Controls.Add(this.lbResult7);
            this.Controls.Add(this.lbResult6);
            this.Controls.Add(this.lbResult5);
            this.Controls.Add(this.lbResult4);
            this.Controls.Add(this.lbResult3);
            this.Controls.Add(this.lbResult2);
            this.Controls.Add(this.lbResult1);
            this.Controls.Add(this.tbResult9);
            this.Controls.Add(this.tbResult8);
            this.Controls.Add(this.tbResult7);
            this.Controls.Add(this.tbResult6);
            this.Controls.Add(this.tbResult5);
            this.Controls.Add(this.tbResult4);
            this.Controls.Add(this.tbResult3);
            this.Controls.Add(this.tbResult2);
            this.Controls.Add(this.tbResult1);
            this.Controls.Add(this.tbOriginalDate);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConvertDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConvertDate";
            this.Load += new System.EventHandler(this.ConvertDate_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ConvertDate_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOriginalDate;
        private System.Windows.Forms.TextBox tbResult1;
        private System.Windows.Forms.TextBox tbResult2;
        private System.Windows.Forms.TextBox tbResult3;
        private System.Windows.Forms.TextBox tbResult4;
        private System.Windows.Forms.TextBox tbResult5;
        private System.Windows.Forms.TextBox tbResult6;
        private System.Windows.Forms.TextBox tbResult7;
        private System.Windows.Forms.TextBox tbResult8;
        private System.Windows.Forms.TextBox tbResult9;
        private System.Windows.Forms.Label lbResult1;
        private System.Windows.Forms.Label lbResult2;
        private System.Windows.Forms.Label lbResult3;
        private System.Windows.Forms.Label lbResult4;
        private System.Windows.Forms.Label lbResult5;
        private System.Windows.Forms.Label lbResult6;
        private System.Windows.Forms.Label lbResult7;
        private System.Windows.Forms.Label lbResult8;
        private System.Windows.Forms.Label lbResult9;
        private System.Windows.Forms.Label lbOriginalDate;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lbHeader1;
        private System.Windows.Forms.Label lbHeader2;
    }
}

