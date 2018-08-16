namespace Simulator
{
    partial class MainForm
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
            this.btn_cashier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cashier
            // 
            this.btn_cashier.Location = new System.Drawing.Point(554, 316);
            this.btn_cashier.Name = "btn_cashier";
            this.btn_cashier.Size = new System.Drawing.Size(105, 44);
            this.btn_cashier.TabIndex = 0;
            this.btn_cashier.Text = "Cashier";
            this.btn_cashier.UseVisualStyleBackColor = true;
            this.btn_cashier.Click += new System.EventHandler(this.btn_cashier_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cashier);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cashier;
    }
}

