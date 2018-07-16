namespace CSharpTests.Performance
{
    partial class Loops
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loops));
            this.lbWhileResult = new System.Windows.Forms.Label();
            this.tbWhileResult = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbForResult = new System.Windows.Forms.TextBox();
            this.lbForResult = new System.Windows.Forms.Label();
            this.tbForeachResult = new System.Windows.Forms.TextBox();
            this.lbForeachResult = new System.Windows.Forms.Label();
            this.tbExecute = new System.Windows.Forms.TextBox();
            this.lbMedium = new System.Windows.Forms.Label();
            this.tbLambdaResult = new System.Windows.Forms.TextBox();
            this.lbLambdaResult = new System.Windows.Forms.Label();
            this.tbFromResult = new System.Windows.Forms.TextBox();
            this.lbExceptResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWhileResult
            // 
            this.lbWhileResult.AutoSize = true;
            this.lbWhileResult.Location = new System.Drawing.Point(11, 42);
            this.lbWhileResult.Name = "lbWhileResult";
            this.lbWhileResult.Size = new System.Drawing.Size(40, 14);
            this.lbWhileResult.TabIndex = 0;
            this.lbWhileResult.Text = "While:";
            // 
            // tbWhileResult
            // 
            this.tbWhileResult.Location = new System.Drawing.Point(90, 39);
            this.tbWhileResult.Name = "tbWhileResult";
            this.tbWhileResult.Size = new System.Drawing.Size(115, 22);
            this.tbWhileResult.TabIndex = 1;
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
            // tbForResult
            // 
            this.tbForResult.Location = new System.Drawing.Point(90, 67);
            this.tbForResult.Name = "tbForResult";
            this.tbForResult.Size = new System.Drawing.Size(115, 22);
            this.tbForResult.TabIndex = 4;
            // 
            // lbForResult
            // 
            this.lbForResult.AutoSize = true;
            this.lbForResult.Location = new System.Drawing.Point(11, 70);
            this.lbForResult.Name = "lbForResult";
            this.lbForResult.Size = new System.Drawing.Size(27, 14);
            this.lbForResult.TabIndex = 3;
            this.lbForResult.Text = "For:";
            // 
            // tbForeachResult
            // 
            this.tbForeachResult.Location = new System.Drawing.Point(90, 95);
            this.tbForeachResult.Name = "tbForeachResult";
            this.tbForeachResult.Size = new System.Drawing.Size(115, 22);
            this.tbForeachResult.TabIndex = 6;
            // 
            // lbForeachResult
            // 
            this.lbForeachResult.AutoSize = true;
            this.lbForeachResult.Location = new System.Drawing.Point(11, 98);
            this.lbForeachResult.Name = "lbForeachResult";
            this.lbForeachResult.Size = new System.Drawing.Size(51, 14);
            this.lbForeachResult.TabIndex = 5;
            this.lbForeachResult.Text = "Foreach:";
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
            // tbLambdaResult
            // 
            this.tbLambdaResult.Location = new System.Drawing.Point(90, 123);
            this.tbLambdaResult.Name = "tbLambdaResult";
            this.tbLambdaResult.Size = new System.Drawing.Size(115, 22);
            this.tbLambdaResult.TabIndex = 10;
            // 
            // lbLambdaResult
            // 
            this.lbLambdaResult.AutoSize = true;
            this.lbLambdaResult.Location = new System.Drawing.Point(11, 126);
            this.lbLambdaResult.Name = "lbLambdaResult";
            this.lbLambdaResult.Size = new System.Drawing.Size(52, 14);
            this.lbLambdaResult.TabIndex = 9;
            this.lbLambdaResult.Text = "Lambda:";
            // 
            // tbFromResult
            // 
            this.tbFromResult.Location = new System.Drawing.Point(90, 151);
            this.tbFromResult.Name = "tbFromResult";
            this.tbFromResult.Size = new System.Drawing.Size(115, 22);
            this.tbFromResult.TabIndex = 12;
            // 
            // lbExceptResult
            // 
            this.lbExceptResult.AutoSize = true;
            this.lbExceptResult.Location = new System.Drawing.Point(11, 154);
            this.lbExceptResult.Name = "lbExceptResult";
            this.lbExceptResult.Size = new System.Drawing.Size(37, 14);
            this.lbExceptResult.TabIndex = 11;
            this.lbExceptResult.Text = "From:";
            // 
            // Loops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(218, 183);
            this.Controls.Add(this.tbFromResult);
            this.Controls.Add(this.lbExceptResult);
            this.Controls.Add(this.tbLambdaResult);
            this.Controls.Add(this.lbLambdaResult);
            this.Controls.Add(this.lbMedium);
            this.Controls.Add(this.tbExecute);
            this.Controls.Add(this.tbForeachResult);
            this.Controls.Add(this.lbForeachResult);
            this.Controls.Add(this.tbForResult);
            this.Controls.Add(this.lbForResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbWhileResult);
            this.Controls.Add(this.lbWhileResult);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loops";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConvertDate";
            this.Load += new System.EventHandler(this.Loops_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Loops_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWhileResult;
        private System.Windows.Forms.TextBox tbWhileResult;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbForResult;
        private System.Windows.Forms.Label lbForResult;
        private System.Windows.Forms.TextBox tbForeachResult;
        private System.Windows.Forms.Label lbForeachResult;
        private System.Windows.Forms.TextBox tbExecute;
        private System.Windows.Forms.Label lbMedium;
        private System.Windows.Forms.TextBox tbLambdaResult;
        private System.Windows.Forms.Label lbLambdaResult;
        private System.Windows.Forms.TextBox tbFromResult;
        private System.Windows.Forms.Label lbExceptResult;
    }
}