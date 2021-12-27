
namespace Bai27
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
            this.nhapTenTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blackRB = new System.Windows.Forms.RadioButton();
            this.blueRB = new System.Windows.Forms.RadioButton();
            this.greenRB = new System.Windows.Forms.RadioButton();
            this.redRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.underlineCB = new System.Windows.Forms.CheckBox();
            this.italicCB = new System.Windows.Forms.CheckBox();
            this.boldCB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tenLapTrinhLb = new System.Windows.Forms.Label();
            this.ThoatBt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên:";
            // 
            // nhapTenTB
            // 
            this.nhapTenTB.Location = new System.Drawing.Point(88, 6);
            this.nhapTenTB.Name = "nhapTenTB";
            this.nhapTenTB.Size = new System.Drawing.Size(336, 22);
            this.nhapTenTB.TabIndex = 1;
            this.nhapTenTB.TextChanged += new System.EventHandler(this.nhapTenTB_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(this.blackRB);
            this.groupBox1.Controls.Add(this.blueRB);
            this.groupBox1.Controls.Add(this.greenRB);
            this.groupBox1.Controls.Add(this.redRB);
            this.groupBox1.Location = new System.Drawing.Point(15, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // blackRB
            // 
            this.blackRB.AutoSize = true;
            this.blackRB.Location = new System.Drawing.Point(7, 165);
            this.blackRB.Name = "blackRB";
            this.blackRB.Size = new System.Drawing.Size(63, 21);
            this.blackRB.TabIndex = 3;
            this.blackRB.Text = "Black";
            this.blackRB.UseVisualStyleBackColor = true;
            this.blackRB.CheckedChanged += new System.EventHandler(this.blackRB_CheckedChanged);
            // 
            // blueRB
            // 
            this.blueRB.AutoSize = true;
            this.blueRB.ForeColor = System.Drawing.Color.Aqua;
            this.blueRB.Location = new System.Drawing.Point(7, 117);
            this.blueRB.Name = "blueRB";
            this.blueRB.Size = new System.Drawing.Size(57, 21);
            this.blueRB.TabIndex = 2;
            this.blueRB.Text = "Blue";
            this.blueRB.UseVisualStyleBackColor = true;
            this.blueRB.CheckedChanged += new System.EventHandler(this.blueRB_CheckedChanged);
            // 
            // greenRB
            // 
            this.greenRB.AutoSize = true;
            this.greenRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenRB.Location = new System.Drawing.Point(7, 68);
            this.greenRB.Name = "greenRB";
            this.greenRB.Size = new System.Drawing.Size(69, 21);
            this.greenRB.TabIndex = 1;
            this.greenRB.Text = "Green";
            this.greenRB.UseVisualStyleBackColor = true;
            this.greenRB.CheckedChanged += new System.EventHandler(this.greenRB_CheckedChanged);
            // 
            // redRB
            // 
            this.redRB.AutoSize = true;
            this.redRB.ForeColor = System.Drawing.Color.Red;
            this.redRB.Location = new System.Drawing.Point(7, 22);
            this.redRB.Name = "redRB";
            this.redRB.Size = new System.Drawing.Size(55, 21);
            this.redRB.TabIndex = 0;
            this.redRB.Text = "Red";
            this.redRB.UseVisualStyleBackColor = true;
            this.redRB.CheckedChanged += new System.EventHandler(this.redRB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Violet;
            this.groupBox2.Controls.Add(this.underlineCB);
            this.groupBox2.Controls.Add(this.italicCB);
            this.groupBox2.Controls.Add(this.boldCB);
            this.groupBox2.Location = new System.Drawing.Point(240, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 192);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font chữ";
            // 
            // underlineCB
            // 
            this.underlineCB.AutoSize = true;
            this.underlineCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineCB.Location = new System.Drawing.Point(7, 165);
            this.underlineCB.Name = "underlineCB";
            this.underlineCB.Size = new System.Drawing.Size(174, 21);
            this.underlineCB.TabIndex = 2;
            this.underlineCB.Text = "Gạch chân (Underline)";
            this.underlineCB.UseVisualStyleBackColor = true;
            this.underlineCB.CheckedChanged += new System.EventHandler(this.underlineCB_CheckedChanged);
            // 
            // italicCB
            // 
            this.italicCB.AutoSize = true;
            this.italicCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicCB.Location = new System.Drawing.Point(6, 91);
            this.italicCB.Name = "italicCB";
            this.italicCB.Size = new System.Drawing.Size(138, 21);
            this.italicCB.TabIndex = 1;
            this.italicCB.Text = "In nghiêng (Italic)";
            this.italicCB.UseVisualStyleBackColor = true;
            this.italicCB.CheckedChanged += new System.EventHandler(this.italicCB_CheckedChanged);
            // 
            // boldCB
            // 
            this.boldCB.AutoSize = true;
            this.boldCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldCB.Location = new System.Drawing.Point(7, 22);
            this.boldCB.Name = "boldCB";
            this.boldCB.Size = new System.Drawing.Size(127, 21);
            this.boldCB.TabIndex = 0;
            this.boldCB.Text = "In đậm (Bold)";
            this.boldCB.UseVisualStyleBackColor = true;
            this.boldCB.CheckedChanged += new System.EventHandler(this.boldCB_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(19, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lập trình bởi:";
            // 
            // tenLapTrinhLb
            // 
            this.tenLapTrinhLb.AllowDrop = true;
            this.tenLapTrinhLb.Location = new System.Drawing.Point(130, 250);
            this.tenLapTrinhLb.Name = "tenLapTrinhLb";
            this.tenLapTrinhLb.Size = new System.Drawing.Size(178, 37);
            this.tenLapTrinhLb.TabIndex = 5;
            this.tenLapTrinhLb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ThoatBt
            // 
            this.ThoatBt.Location = new System.Drawing.Point(346, 268);
            this.ThoatBt.Name = "ThoatBt";
            this.ThoatBt.Size = new System.Drawing.Size(75, 23);
            this.ThoatBt.TabIndex = 4;
            this.ThoatBt.Text = "Thoát";
            this.ThoatBt.UseVisualStyleBackColor = true;
            this.ThoatBt.Click += new System.EventHandler(this.thoatBt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(452, 296);
            this.Controls.Add(this.ThoatBt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nhapTenTB);
            this.Controls.Add(this.tenLapTrinhLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định dạng";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nhapTenTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton blackRB;
        private System.Windows.Forms.RadioButton blueRB;
        private System.Windows.Forms.RadioButton greenRB;
        private System.Windows.Forms.RadioButton redRB;
        private System.Windows.Forms.CheckBox underlineCB;
        private System.Windows.Forms.CheckBox italicCB;
        private System.Windows.Forms.CheckBox boldCB;
        private System.Windows.Forms.Label tenLapTrinhLb;
        private System.Windows.Forms.Button ThoatBt;
    }
}

