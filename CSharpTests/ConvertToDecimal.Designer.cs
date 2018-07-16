namespace CSharpTests
{
    partial class ConvertToDecimal
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
            this.tbOriginalDecimal = new System.Windows.Forms.TextBox();
            this.tbResult1 = new System.Windows.Forms.TextBox();
            this.lbResult1 = new System.Windows.Forms.Label();
            this.lbOriginalDate = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.lbHeader1 = new System.Windows.Forms.Label();
            this.lbHeader2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbResult2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbOriginalDecimal
            // 
            this.tbOriginalDecimal.Location = new System.Drawing.Point(100, 9);
            this.tbOriginalDecimal.Name = "tbOriginalDecimal";
            this.tbOriginalDecimal.Size = new System.Drawing.Size(179, 22);
            this.tbOriginalDecimal.TabIndex = 0;
            // 
            // tbResult1
            // 
            this.tbResult1.Location = new System.Drawing.Point(293, 62);
            this.tbResult1.Name = "tbResult1";
            this.tbResult1.Size = new System.Drawing.Size(94, 22);
            this.tbResult1.TabIndex = 1;
            // 
            // lbResult1
            // 
            this.lbResult1.AutoSize = true;
            this.lbResult1.Location = new System.Drawing.Point(6, 66);
            this.lbResult1.Name = "lbResult1";
            this.lbResult1.Size = new System.Drawing.Size(45, 14);
            this.lbResult1.TabIndex = 10;
            this.lbResult1.Text = "Helper:";
            // 
            // lbOriginalDate
            // 
            this.lbOriginalDate.AutoSize = true;
            this.lbOriginalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOriginalDate.Location = new System.Drawing.Point(6, 12);
            this.lbOriginalDate.Name = "lbOriginalDate";
            this.lbOriginalDate.Size = new System.Drawing.Size(56, 13);
            this.lbOriginalDate.TabIndex = 19;
            this.lbOriginalDate.Text = "Decimal:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "Método de Extensão:";
            // 
            // tbResult2
            // 
            this.tbResult2.Location = new System.Drawing.Point(293, 90);
            this.tbResult2.Name = "tbResult2";
            this.tbResult2.Size = new System.Drawing.Size(94, 22);
            this.tbResult2.TabIndex = 23;
            // 
            // ConvertToDecimal
            // 
            this.AcceptButton = this.btnTest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResult2);
            this.Controls.Add(this.lbHeader2);
            this.Controls.Add(this.lbHeader1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lbOriginalDate);
            this.Controls.Add(this.lbResult1);
            this.Controls.Add(this.tbResult1);
            this.Controls.Add(this.tbOriginalDecimal);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConvertToDecimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConvertDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox tbOriginalDecimal;
        private System.Windows.Forms.TextBox tbResult1;
        private System.Windows.Forms.Label lbResult1;
        private System.Windows.Forms.Label lbOriginalDate;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lbHeader1;
        private System.Windows.Forms.Label lbHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbResult2;
    }
}