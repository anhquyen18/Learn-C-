
namespace Bai28
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
            this.label1 = new System.Windows.Forms.Label();
            this.tenTB = new System.Windows.Forms.TextBox();
            this.sadCatPB = new System.Windows.Forms.PictureBox();
            this.smileyCatPB = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.thoatBt = new System.Windows.Forms.Button();
            this.changeCatBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sadCatPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smileyCatPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên:";
            // 
            // tenTB
            // 
            this.tenTB.Location = new System.Drawing.Point(96, 10);
            this.tenTB.Name = "tenTB";
            this.tenTB.Size = new System.Drawing.Size(212, 22);
            this.tenTB.TabIndex = 1;
            this.tenTB.TextChanged += new System.EventHandler(this.tenTB_TextChanged);
            // 
            // sadCatPB
            // 
            this.sadCatPB.Image = global::Bai28.Properties.Resources._122225007_2103548803111416_4211120638506685716_n;
            this.sadCatPB.Location = new System.Drawing.Point(73, 52);
            this.sadCatPB.Name = "sadCatPB";
            this.sadCatPB.Size = new System.Drawing.Size(212, 197);
            this.sadCatPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sadCatPB.TabIndex = 2;
            this.sadCatPB.TabStop = false;
            // 
            // smileyCatPB
            // 
            this.smileyCatPB.Image = global::Bai28.Properties.Resources._236891965_2967234803535450_5355932966062571507_n;
            this.smileyCatPB.Location = new System.Drawing.Point(73, 52);
            this.smileyCatPB.Name = "smileyCatPB";
            this.smileyCatPB.Size = new System.Drawing.Size(212, 197);
            this.smileyCatPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.smileyCatPB.TabIndex = 2;
            this.smileyCatPB.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Designed by:";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Anh Quyền đẹp trai";
            // 
            // thoatBt
            // 
            this.thoatBt.Location = new System.Drawing.Point(266, 299);
            this.thoatBt.Name = "thoatBt";
            this.thoatBt.Size = new System.Drawing.Size(75, 23);
            this.thoatBt.TabIndex = 3;
            this.thoatBt.Text = "Thoát";
            this.thoatBt.UseVisualStyleBackColor = true;
            // 
            // changeCatBt
            // 
            this.changeCatBt.Location = new System.Drawing.Point(38, 264);
            this.changeCatBt.Name = "changeCatBt";
            this.changeCatBt.Size = new System.Drawing.Size(270, 32);
            this.changeCatBt.TabIndex = 3;
            this.changeCatBt.UseVisualStyleBackColor = true;
            this.changeCatBt.Click += new System.EventHandler(this.changeCatBt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 325);
            this.Controls.Add(this.changeCatBt);
            this.Controls.Add(this.thoatBt);
            this.Controls.Add(this.smileyCatPB);
            this.Controls.Add(this.sadCatPB);
            this.Controls.Add(this.tenTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The cat";
            ((System.ComponentModel.ISupportInitialize)(this.sadCatPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smileyCatPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenTB;
        private System.Windows.Forms.PictureBox smileyCatPB;
        private System.Windows.Forms.PictureBox sadCatPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button thoatBt;
        private System.Windows.Forms.Button changeCatBt;
    }
}

