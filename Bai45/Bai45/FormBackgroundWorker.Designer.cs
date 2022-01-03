
namespace Bai45
{
    partial class FormBackgroundWorker
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
            this.nhapTB = new System.Windows.Forms.TextBox();
            this.veMangBt = new System.Windows.Forms.Button();
            this.sapXepBt = new System.Windows.Forms.Button();
            this.buttonPn = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập N:";
            // 
            // nhapTB
            // 
            this.nhapTB.Location = new System.Drawing.Point(93, 21);
            this.nhapTB.Name = "nhapTB";
            this.nhapTB.Size = new System.Drawing.Size(100, 22);
            this.nhapTB.TabIndex = 1;
            // 
            // veMangBt
            // 
            this.veMangBt.AutoSize = true;
            this.veMangBt.Location = new System.Drawing.Point(246, 19);
            this.veMangBt.Name = "veMangBt";
            this.veMangBt.Size = new System.Drawing.Size(75, 27);
            this.veMangBt.TabIndex = 2;
            this.veMangBt.Text = "Vẽ Mảng";
            this.veMangBt.UseVisualStyleBackColor = true;
            this.veMangBt.Click += new System.EventHandler(this.veMangBt_Click);
            // 
            // sapXepBt
            // 
            this.sapXepBt.AutoSize = true;
            this.sapXepBt.Location = new System.Drawing.Point(363, 20);
            this.sapXepBt.Name = "sapXepBt";
            this.sapXepBt.Size = new System.Drawing.Size(75, 27);
            this.sapXepBt.TabIndex = 2;
            this.sapXepBt.Text = "Sắp xếp";
            this.sapXepBt.UseVisualStyleBackColor = true;
            this.sapXepBt.Click += new System.EventHandler(this.sapXepBt_Click);
            // 
            // buttonPn
            // 
            this.buttonPn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPn.Location = new System.Drawing.Point(12, 89);
            this.buttonPn.Name = "buttonPn";
            this.buttonPn.Size = new System.Drawing.Size(776, 334);
            this.buttonPn.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FormBackgroundWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPn);
            this.Controls.Add(this.sapXepBt);
            this.Controls.Add(this.veMangBt);
            this.Controls.Add(this.nhapTB);
            this.Controls.Add(this.label1);
            this.Name = "FormBackgroundWorker";
            this.Text = "FormBackgroundWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nhapTB;
        private System.Windows.Forms.Button veMangBt;
        private System.Windows.Forms.Button sapXepBt;
        private System.Windows.Forms.Panel buttonPn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}