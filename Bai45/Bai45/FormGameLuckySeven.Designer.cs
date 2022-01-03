
namespace Bai45
{
    partial class FormGameLuckySeven
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.so1Lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tienMayLb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tienNguoiChoiLb = new System.Windows.Forms.Label();
            this.quaySoBt = new System.Windows.Forms.Button();
            this.so2Lb = new System.Windows.Forms.Label();
            this.so3Lb = new System.Windows.Forms.Label();
            this.gameMoiBt = new System.Windows.Forms.Button();
            this.ketThucBt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.so3Lb);
            this.groupBox1.Controls.Add(this.so2Lb);
            this.groupBox1.Controls.Add(this.so1Lb);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // so1Lb
            // 
            this.so1Lb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.so1Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.so1Lb.Location = new System.Drawing.Point(0, 0);
            this.so1Lb.Name = "so1Lb";
            this.so1Lb.Size = new System.Drawing.Size(100, 213);
            this.so1Lb.TabIndex = 0;
            this.so1Lb.Text = "7";
            this.so1Lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tiền máy:";
            // 
            // tienMayLb
            // 
            this.tienMayLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tienMayLb.Location = new System.Drawing.Point(140, 239);
            this.tienMayLb.Name = "tienMayLb";
            this.tienMayLb.Size = new System.Drawing.Size(187, 17);
            this.tienMayLb.TabIndex = 1;
            this.tienMayLb.Text = "100";
            this.tienMayLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tiền người chơi:";
            // 
            // tienNguoiChoiLb
            // 
            this.tienNguoiChoiLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tienNguoiChoiLb.Location = new System.Drawing.Point(140, 268);
            this.tienNguoiChoiLb.Name = "tienNguoiChoiLb";
            this.tienNguoiChoiLb.Size = new System.Drawing.Size(187, 17);
            this.tienNguoiChoiLb.TabIndex = 1;
            this.tienNguoiChoiLb.Text = "100";
            this.tienNguoiChoiLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quaySoBt
            // 
            this.quaySoBt.AllowDrop = true;
            this.quaySoBt.AutoSize = true;
            this.quaySoBt.Location = new System.Drawing.Point(16, 304);
            this.quaySoBt.Name = "quaySoBt";
            this.quaySoBt.Size = new System.Drawing.Size(75, 27);
            this.quaySoBt.TabIndex = 2;
            this.quaySoBt.Text = "Quay Số";
            this.quaySoBt.UseVisualStyleBackColor = true;
            this.quaySoBt.Click += new System.EventHandler(this.quaySoBt_Click);
            // 
            // so2Lb
            // 
            this.so2Lb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.so2Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.so2Lb.Location = new System.Drawing.Point(101, 0);
            this.so2Lb.Name = "so2Lb";
            this.so2Lb.Size = new System.Drawing.Size(100, 213);
            this.so2Lb.TabIndex = 0;
            this.so2Lb.Text = "7";
            this.so2Lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // so3Lb
            // 
            this.so3Lb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.so3Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.so3Lb.Location = new System.Drawing.Point(203, 0);
            this.so3Lb.Name = "so3Lb";
            this.so3Lb.Size = new System.Drawing.Size(100, 213);
            this.so3Lb.TabIndex = 0;
            this.so3Lb.Text = "7";
            this.so3Lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameMoiBt
            // 
            this.gameMoiBt.AllowDrop = true;
            this.gameMoiBt.AutoSize = true;
            this.gameMoiBt.Location = new System.Drawing.Point(125, 304);
            this.gameMoiBt.Name = "gameMoiBt";
            this.gameMoiBt.Size = new System.Drawing.Size(82, 27);
            this.gameMoiBt.TabIndex = 2;
            this.gameMoiBt.Text = "Game mới";
            this.gameMoiBt.UseVisualStyleBackColor = true;
            this.gameMoiBt.Click += new System.EventHandler(this.gameMoiBt_Click);
            // 
            // ketThucBt
            // 
            this.ketThucBt.AllowDrop = true;
            this.ketThucBt.AutoSize = true;
            this.ketThucBt.Location = new System.Drawing.Point(252, 304);
            this.ketThucBt.Name = "ketThucBt";
            this.ketThucBt.Size = new System.Drawing.Size(75, 27);
            this.ketThucBt.TabIndex = 2;
            this.ketThucBt.Text = "Kết thúc";
            this.ketThucBt.UseVisualStyleBackColor = true;
            this.ketThucBt.Click += new System.EventHandler(this.ketThucBt_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormGameLuckySeven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 338);
            this.Controls.Add(this.ketThucBt);
            this.Controls.Add(this.gameMoiBt);
            this.Controls.Add(this.quaySoBt);
            this.Controls.Add(this.tienNguoiChoiLb);
            this.Controls.Add(this.tienMayLb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "FormGameLuckySeven";
            this.Text = "FormGameLuckySeven";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label so3Lb;
        private System.Windows.Forms.Label so2Lb;
        private System.Windows.Forms.Label so1Lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tienMayLb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tienNguoiChoiLb;
        private System.Windows.Forms.Button quaySoBt;
        private System.Windows.Forms.Button gameMoiBt;
        private System.Windows.Forms.Button ketThucBt;
        private System.Windows.Forms.Timer timer1;
    }
}