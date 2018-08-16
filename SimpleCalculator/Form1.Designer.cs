namespace SimpleCalculator
{
    partial class Form1
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
            this.lbl_result = new System.Windows.Forms.Label();
            this.txt_numOne = new System.Windows.Forms.TextBox();
            this.txt_numTwo = new System.Windows.Forms.TextBox();
            this.lbl_operation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(441, 122);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 18);
            this.lbl_result.TabIndex = 0;
            // 
            // txt_numOne
            // 
            this.txt_numOne.Location = new System.Drawing.Point(136, 119);
            this.txt_numOne.Name = "txt_numOne";
            this.txt_numOne.Size = new System.Drawing.Size(100, 28);
            this.txt_numOne.TabIndex = 1;
            // 
            // txt_numTwo
            // 
            this.txt_numTwo.Location = new System.Drawing.Point(307, 118);
            this.txt_numTwo.Name = "txt_numTwo";
            this.txt_numTwo.Size = new System.Drawing.Size(100, 28);
            this.txt_numTwo.TabIndex = 2;
            // 
            // lbl_operation
            // 
            this.lbl_operation.AutoSize = true;
            this.lbl_operation.Location = new System.Drawing.Point(242, 122);
            this.lbl_operation.Name = "lbl_operation";
            this.lbl_operation.Size = new System.Drawing.Size(0, 18);
            this.lbl_operation.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_operation);
            this.Controls.Add(this.txt_numTwo);
            this.Controls.Add(this.txt_numOne);
            this.Controls.Add(this.lbl_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox txt_numOne;
        private System.Windows.Forms.TextBox txt_numTwo;
        private System.Windows.Forms.Label lbl_operation;
    }
}

