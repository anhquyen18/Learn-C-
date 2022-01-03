
namespace Bai45
{
    partial class FormTimer
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.watchLb = new System.Windows.Forms.Label();
            this.stopBt = new System.Windows.Forms.Button();
            this.startBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // watchLb
            // 
            this.watchLb.AutoSize = true;
            this.watchLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchLb.Location = new System.Drawing.Point(331, 95);
            this.watchLb.Name = "watchLb";
            this.watchLb.Size = new System.Drawing.Size(81, 29);
            this.watchLb.TabIndex = 0;
            this.watchLb.Text = "label1";
            // 
            // stopBt
            // 
            this.stopBt.Location = new System.Drawing.Point(210, 196);
            this.stopBt.Name = "stopBt";
            this.stopBt.Size = new System.Drawing.Size(75, 23);
            this.stopBt.TabIndex = 1;
            this.stopBt.Text = "Stop";
            this.stopBt.UseVisualStyleBackColor = true;
            this.stopBt.Click += new System.EventHandler(this.stopBt_Click);
            // 
            // startBt
            // 
            this.startBt.Location = new System.Drawing.Point(493, 196);
            this.startBt.Name = "startBt";
            this.startBt.Size = new System.Drawing.Size(75, 23);
            this.startBt.TabIndex = 1;
            this.startBt.Text = "Start";
            this.startBt.UseVisualStyleBackColor = true;
            this.startBt.Click += new System.EventHandler(this.startBt_Click);
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startBt);
            this.Controls.Add(this.stopBt);
            this.Controls.Add(this.watchLb);
            this.Name = "FormTimer";
            this.Text = "FormTimer";
            this.Load += new System.EventHandler(this.FormTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label watchLb;
        private System.Windows.Forms.Button stopBt;
        private System.Windows.Forms.Button startBt;
    }
}