namespace WinForms_1_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.run_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // run_label
            // 
            this.run_label.AutoSize = true;
            this.run_label.BackColor = System.Drawing.Color.Yellow;
            this.run_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.run_label.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.run_label.Location = new System.Drawing.Point(286, 211);
            this.run_label.Name = "run_label";
            this.run_label.Size = new System.Drawing.Size(228, 29);
            this.run_label.TabIndex = 0;
            this.run_label.Text = "Catch Me If You Can";
            this.run_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.run_label.MouseHover += new System.EventHandler(this.run_label_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.run_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label run_label;
    }
}