
namespace _1180505018
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
            this.Soru1 = new System.Windows.Forms.Button();
            this.Soru2 = new System.Windows.Forms.Button();
            this.Soru3 = new System.Windows.Forms.Button();
            this.Cevap = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Soru1
            // 
            this.Soru1.Location = new System.Drawing.Point(44, 69);
            this.Soru1.Name = "Soru1";
            this.Soru1.Size = new System.Drawing.Size(75, 29);
            this.Soru1.TabIndex = 0;
            this.Soru1.Text = "Soru-1";
            this.Soru1.UseVisualStyleBackColor = true;
            this.Soru1.Click += new System.EventHandler(this.Soru1_Click);
            // 
            // Soru2
            // 
            this.Soru2.Location = new System.Drawing.Point(44, 104);
            this.Soru2.Name = "Soru2";
            this.Soru2.Size = new System.Drawing.Size(75, 29);
            this.Soru2.TabIndex = 1;
            this.Soru2.Text = "Soru-2";
            this.Soru2.UseVisualStyleBackColor = true;
            this.Soru2.Click += new System.EventHandler(this.Soru2_Click);
            // 
            // Soru3
            // 
            this.Soru3.Location = new System.Drawing.Point(44, 139);
            this.Soru3.Name = "Soru3";
            this.Soru3.Size = new System.Drawing.Size(75, 29);
            this.Soru3.TabIndex = 2;
            this.Soru3.Text = "Soru-3";
            this.Soru3.UseVisualStyleBackColor = true;
            this.Soru3.Click += new System.EventHandler(this.Soru3_Click);
            // 
            // Cevap
            // 
            this.Cevap.AutoSize = true;
            this.Cevap.Location = new System.Drawing.Point(226, 77);
            this.Cevap.Name = "Cevap";
            this.Cevap.Size = new System.Drawing.Size(38, 13);
            this.Cevap.TabIndex = 3;
            this.Cevap.Text = "Cevap";
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(195, 113);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(100, 20);
            this.txtCevap.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 280);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.Cevap);
            this.Controls.Add(this.Soru3);
            this.Controls.Add(this.Soru2);
            this.Controls.Add(this.Soru1);
            this.Name = "Form1";
            this.Text = "1180505018";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Soru1;
        private System.Windows.Forms.Button Soru2;
        private System.Windows.Forms.Button Soru3;
        private System.Windows.Forms.Label Cevap;
        private System.Windows.Forms.TextBox txtCevap;
    }
}

