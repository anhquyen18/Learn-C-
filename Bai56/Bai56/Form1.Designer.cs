
namespace Bai56
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
            this.label1 = new System.Windows.Forms.Label();
            this.noiDungRTB = new System.Windows.Forms.RichTextBox();
            this.luuBt = new System.Windows.Forms.Button();
            this.docBt = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập nội dung:";
            // 
            // noiDungRTB
            // 
            this.noiDungRTB.Location = new System.Drawing.Point(61, 64);
            this.noiDungRTB.Name = "noiDungRTB";
            this.noiDungRTB.Size = new System.Drawing.Size(436, 191);
            this.noiDungRTB.TabIndex = 1;
            this.noiDungRTB.Text = "";
            // 
            // luuBt
            // 
            this.luuBt.AutoSize = true;
            this.luuBt.Location = new System.Drawing.Point(123, 277);
            this.luuBt.Name = "luuBt";
            this.luuBt.Size = new System.Drawing.Size(75, 30);
            this.luuBt.TabIndex = 2;
            this.luuBt.Text = "Lưu";
            this.luuBt.UseVisualStyleBackColor = true;
            this.luuBt.Click += new System.EventHandler(this.luuBt_Click);
            // 
            // docBt
            // 
            this.docBt.AutoSize = true;
            this.docBt.Location = new System.Drawing.Point(326, 277);
            this.docBt.Name = "docBt";
            this.docBt.Size = new System.Drawing.Size(75, 30);
            this.docBt.TabIndex = 2;
            this.docBt.Text = "Đọc";
            this.docBt.UseVisualStyleBackColor = true;
            this.docBt.Click += new System.EventHandler(this.docBt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 355);
            this.Controls.Add(this.docBt);
            this.Controls.Add(this.luuBt);
            this.Controls.Add(this.noiDungRTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox noiDungRTB;
        private System.Windows.Forms.Button luuBt;
        private System.Windows.Forms.Button docBt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

