
namespace Bai60
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
            this.btKetNoi = new System.Windows.Forms.Button();
            this.btDongKetNoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btKetNoi
            // 
            this.btKetNoi.AutoSize = true;
            this.btKetNoi.Location = new System.Drawing.Point(222, 52);
            this.btKetNoi.Name = "btKetNoi";
            this.btKetNoi.Size = new System.Drawing.Size(255, 68);
            this.btKetNoi.TabIndex = 0;
            this.btKetNoi.Text = "Kết nối CSDL";
            this.btKetNoi.UseVisualStyleBackColor = true;
            this.btKetNoi.Click += new System.EventHandler(this.btKetNoi_Click);
            // 
            // btDongKetNoi
            // 
            this.btDongKetNoi.AutoSize = true;
            this.btDongKetNoi.Location = new System.Drawing.Point(222, 138);
            this.btDongKetNoi.Name = "btDongKetNoi";
            this.btDongKetNoi.Size = new System.Drawing.Size(255, 68);
            this.btDongKetNoi.TabIndex = 0;
            this.btDongKetNoi.Text = "Đóng kết nối";
            this.btDongKetNoi.UseVisualStyleBackColor = true;
            this.btDongKetNoi.Click += new System.EventHandler(this.btDongKetNoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 336);
            this.Controls.Add(this.btDongKetNoi);
            this.Controls.Add(this.btKetNoi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btKetNoi;
        private System.Windows.Forms.Button btDongKetNoi;
    }
}

