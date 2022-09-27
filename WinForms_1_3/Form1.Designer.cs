namespace WinForms_1_3
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
            this.london_btn = new System.Windows.Forms.Button();
            this.baku_btn = new System.Windows.Forms.Button();
            this.time_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // london_btn
            // 
            this.london_btn.Location = new System.Drawing.Point(532, 396);
            this.london_btn.Name = "london_btn";
            this.london_btn.Size = new System.Drawing.Size(75, 23);
            this.london_btn.TabIndex = 0;
            this.london_btn.Text = "LONDON";
            this.london_btn.UseVisualStyleBackColor = true;
            this.london_btn.Click += new System.EventHandler(this.london_btn_Click);
            // 
            // baku_btn
            // 
            this.baku_btn.Location = new System.Drawing.Point(156, 396);
            this.baku_btn.Name = "baku_btn";
            this.baku_btn.Size = new System.Drawing.Size(75, 23);
            this.baku_btn.TabIndex = 0;
            this.baku_btn.Text = "BAKU";
            this.baku_btn.UseVisualStyleBackColor = true;
            this.baku_btn.Click += new System.EventHandler(this.baku_btn_Click);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.BackColor = System.Drawing.Color.Lime;
            this.time_label.Location = new System.Drawing.Point(365, 400);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(33, 15);
            this.time_label.TabIndex = 1;
            this.time_label.Text = "TIME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForms_1_3.Properties.Resources.baku;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.baku_btn);
            this.Controls.Add(this.london_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button london_btn;
        private Button baku_btn;
        private Label time_label;
    }
}