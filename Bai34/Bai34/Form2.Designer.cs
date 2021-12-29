
namespace Bai34
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnButton = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCot = new System.Windows.Forms.TextBox();
            this.btVe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btVe);
            this.panel1.Controls.Add(this.tbCot);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbDong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 57);
            this.panel1.TabIndex = 0;
            // 
            // pnButton
            // 
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnButton.Location = new System.Drawing.Point(0, 57);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(654, 442);
            this.pnButton.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số dòng:";
            // 
            // tbDong
            // 
            this.tbDong.Location = new System.Drawing.Point(119, 15);
            this.tbDong.Name = "tbDong";
            this.tbDong.Size = new System.Drawing.Size(100, 22);
            this.tbDong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập số cột:";
            // 
            // tbCot
            // 
            this.tbCot.Location = new System.Drawing.Point(354, 15);
            this.tbCot.Name = "tbCot";
            this.tbCot.Size = new System.Drawing.Size(100, 22);
            this.tbCot.TabIndex = 1;
            // 
            // btVe
            // 
            this.btVe.Location = new System.Drawing.Point(509, 15);
            this.btVe.Name = "btVe";
            this.btVe.Size = new System.Drawing.Size(75, 23);
            this.btVe.TabIndex = 2;
            this.btVe.Text = "Vẽ";
            this.btVe.UseVisualStyleBackColor = true;
            this.btVe.Click += new System.EventHandler(this.btVe_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 499);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btVe;
        private System.Windows.Forms.TextBox tbCot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnButton;
    }
}