
namespace Bai50
{
    partial class FormThemNut
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
            this.label1 = new System.Windows.Forms.Label();
            this.okBt = new System.Windows.Forms.Button();
            this.giaTriTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mời bạn nhập giá trị:";
            // 
            // okBt
            // 
            this.okBt.AutoSize = true;
            this.okBt.Location = new System.Drawing.Point(27, 52);
            this.okBt.Name = "okBt";
            this.okBt.Size = new System.Drawing.Size(316, 35);
            this.okBt.TabIndex = 1;
            this.okBt.Text = "OK";
            this.okBt.UseVisualStyleBackColor = true;
            this.okBt.Click += new System.EventHandler(this.okBt_Click);
            // 
            // giaTriTB
            // 
            this.giaTriTB.Location = new System.Drawing.Point(167, 21);
            this.giaTriTB.Name = "giaTriTB";
            this.giaTriTB.Size = new System.Drawing.Size(176, 22);
            this.giaTriTB.TabIndex = 2;
            // 
            // FormThemNut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 98);
            this.Controls.Add(this.giaTriTB);
            this.Controls.Add(this.okBt);
            this.Controls.Add(this.label1);
            this.Name = "FormThemNut";
            this.Text = "Thông tin Node";
            this.Load += new System.EventHandler(this.FormThemNut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okBt;
        public System.Windows.Forms.TextBox giaTriTB;
    }
}