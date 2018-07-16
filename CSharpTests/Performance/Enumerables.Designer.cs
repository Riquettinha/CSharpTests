namespace CSharpTests.Performance
{
    partial class Enumerables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enumerables));
            this.lbListResult = new System.Windows.Forms.Label();
            this.tbListResult = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbHashSetResult = new System.Windows.Forms.TextBox();
            this.lbHashSetResult = new System.Windows.Forms.Label();
            this.tbExecute = new System.Windows.Forms.TextBox();
            this.lbMedium = new System.Windows.Forms.Label();
            this.tbEnumerableResult = new System.Windows.Forms.TextBox();
            this.lbEnumerableResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbListResult
            // 
            this.lbListResult.AutoSize = true;
            this.lbListResult.Location = new System.Drawing.Point(11, 42);
            this.lbListResult.Name = "lbListResult";
            this.lbListResult.Size = new System.Drawing.Size(28, 14);
            this.lbListResult.TabIndex = 0;
            this.lbListResult.Text = "List:";
            // 
            // tbListResult
            // 
            this.tbListResult.Location = new System.Drawing.Point(90, 39);
            this.tbListResult.Name = "tbListResult";
            this.tbListResult.Size = new System.Drawing.Size(115, 22);
            this.tbListResult.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(138, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(67, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbHashSetResult
            // 
            this.tbHashSetResult.Location = new System.Drawing.Point(90, 67);
            this.tbHashSetResult.Name = "tbHashSetResult";
            this.tbHashSetResult.Size = new System.Drawing.Size(115, 22);
            this.tbHashSetResult.TabIndex = 6;
            // 
            // lbHashSetResult
            // 
            this.lbHashSetResult.AutoSize = true;
            this.lbHashSetResult.Location = new System.Drawing.Point(11, 70);
            this.lbHashSetResult.Name = "lbHashSetResult";
            this.lbHashSetResult.Size = new System.Drawing.Size(52, 14);
            this.lbHashSetResult.TabIndex = 5;
            this.lbHashSetResult.Text = "HashSet:";
            // 
            // tbExecute
            // 
            this.tbExecute.Location = new System.Drawing.Point(90, 11);
            this.tbExecute.Name = "tbExecute";
            this.tbExecute.Size = new System.Drawing.Size(42, 22);
            this.tbExecute.TabIndex = 7;
            // 
            // lbMedium
            // 
            this.lbMedium.AutoSize = true;
            this.lbMedium.Location = new System.Drawing.Point(11, 14);
            this.lbMedium.Name = "lbMedium";
            this.lbMedium.Size = new System.Drawing.Size(58, 14);
            this.lbMedium.TabIndex = 8;
            this.lbMedium.Text = "Média de:";
            // 
            // tbEnumerableResult
            // 
            this.tbEnumerableResult.Location = new System.Drawing.Point(90, 95);
            this.tbEnumerableResult.Name = "tbEnumerableResult";
            this.tbEnumerableResult.Size = new System.Drawing.Size(115, 22);
            this.tbEnumerableResult.TabIndex = 10;
            // 
            // lbEnumerableResult
            // 
            this.lbEnumerableResult.AutoSize = true;
            this.lbEnumerableResult.Location = new System.Drawing.Point(11, 98);
            this.lbEnumerableResult.Name = "lbEnumerableResult";
            this.lbEnumerableResult.Size = new System.Drawing.Size(74, 14);
            this.lbEnumerableResult.TabIndex = 9;
            this.lbEnumerableResult.Text = "Enumerable:";
            // 
            // Enumerables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(218, 154);
            this.Controls.Add(this.tbEnumerableResult);
            this.Controls.Add(this.lbEnumerableResult);
            this.Controls.Add(this.lbMedium);
            this.Controls.Add(this.tbExecute);
            this.Controls.Add(this.tbHashSetResult);
            this.Controls.Add(this.lbHashSetResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbListResult);
            this.Controls.Add(this.lbListResult);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Enumerables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConvertDate";
            this.Load += new System.EventHandler(this.Loops_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Loops_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbListResult;
        private System.Windows.Forms.TextBox tbListResult;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbHashSetResult;
        private System.Windows.Forms.Label lbHashSetResult;
        private System.Windows.Forms.TextBox tbExecute;
        private System.Windows.Forms.Label lbMedium;
        private System.Windows.Forms.TextBox tbEnumerableResult;
        private System.Windows.Forms.Label lbEnumerableResult;
    }
}