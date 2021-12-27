
namespace Bai32
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
            this.leftCLB = new System.Windows.Forms.CheckedListBox();
            this.chuyenPhaiBt = new System.Windows.Forms.Button();
            this.chuyenTatCaPhaiBt = new System.Windows.Forms.Button();
            this.chuyenTraiBt = new System.Windows.Forms.Button();
            this.rightCLB = new System.Windows.Forms.CheckedListBox();
            this.chuyenTatCaTraiBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leftCLB
            // 
            this.leftCLB.FormattingEnabled = true;
            this.leftCLB.Location = new System.Drawing.Point(34, 16);
            this.leftCLB.Name = "leftCLB";
            this.leftCLB.Size = new System.Drawing.Size(181, 259);
            this.leftCLB.TabIndex = 0;
            // 
            // chuyenPhaiBt
            // 
            this.chuyenPhaiBt.AutoSize = true;
            this.chuyenPhaiBt.Location = new System.Drawing.Point(251, 40);
            this.chuyenPhaiBt.Name = "chuyenPhaiBt";
            this.chuyenPhaiBt.Size = new System.Drawing.Size(75, 27);
            this.chuyenPhaiBt.TabIndex = 1;
            this.chuyenPhaiBt.Text = ">";
            this.chuyenPhaiBt.UseVisualStyleBackColor = true;
            this.chuyenPhaiBt.Click += new System.EventHandler(this.chuyenPhaiBt_Click);
            // 
            // chuyenTatCaPhaiBt
            // 
            this.chuyenTatCaPhaiBt.AutoSize = true;
            this.chuyenTatCaPhaiBt.Location = new System.Drawing.Point(251, 91);
            this.chuyenTatCaPhaiBt.Name = "chuyenTatCaPhaiBt";
            this.chuyenTatCaPhaiBt.Size = new System.Drawing.Size(75, 27);
            this.chuyenTatCaPhaiBt.TabIndex = 1;
            this.chuyenTatCaPhaiBt.Text = ">>";
            this.chuyenTatCaPhaiBt.UseVisualStyleBackColor = true;
            this.chuyenTatCaPhaiBt.Click += new System.EventHandler(this.chuyenTatCaPhaiBt_Click);
            // 
            // chuyenTraiBt
            // 
            this.chuyenTraiBt.AutoSize = true;
            this.chuyenTraiBt.Location = new System.Drawing.Point(251, 167);
            this.chuyenTraiBt.Name = "chuyenTraiBt";
            this.chuyenTraiBt.Size = new System.Drawing.Size(75, 27);
            this.chuyenTraiBt.TabIndex = 1;
            this.chuyenTraiBt.Text = "<";
            this.chuyenTraiBt.UseVisualStyleBackColor = true;
            this.chuyenTraiBt.Click += new System.EventHandler(this.chuyenTraiBt_Click);
            // 
            // rightCLB
            // 
            this.rightCLB.FormattingEnabled = true;
            this.rightCLB.Location = new System.Drawing.Point(367, 16);
            this.rightCLB.Name = "rightCLB";
            this.rightCLB.Size = new System.Drawing.Size(181, 259);
            this.rightCLB.TabIndex = 0;
            // 
            // chuyenTatCaTraiBt
            // 
            this.chuyenTatCaTraiBt.AutoSize = true;
            this.chuyenTatCaTraiBt.Location = new System.Drawing.Point(251, 220);
            this.chuyenTatCaTraiBt.Name = "chuyenTatCaTraiBt";
            this.chuyenTatCaTraiBt.Size = new System.Drawing.Size(75, 27);
            this.chuyenTatCaTraiBt.TabIndex = 1;
            this.chuyenTatCaTraiBt.Text = "<<";
            this.chuyenTatCaTraiBt.UseVisualStyleBackColor = true;
            this.chuyenTatCaTraiBt.Click += new System.EventHandler(this.chuyenTatCaTraiBt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 294);
            this.Controls.Add(this.chuyenTatCaTraiBt);
            this.Controls.Add(this.chuyenTraiBt);
            this.Controls.Add(this.chuyenTatCaPhaiBt);
            this.Controls.Add(this.chuyenPhaiBt);
            this.Controls.Add(this.rightCLB);
            this.Controls.Add(this.leftCLB);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox leftCLB;
        private System.Windows.Forms.Button chuyenPhaiBt;
        private System.Windows.Forms.Button chuyenTatCaPhaiBt;
        private System.Windows.Forms.Button chuyenTraiBt;
        private System.Windows.Forms.CheckedListBox rightCLB;
        private System.Windows.Forms.Button chuyenTatCaTraiBt;
    }
}

