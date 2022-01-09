
namespace Bai53
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.khoaTV = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sinhVienLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maSVTB = new System.Windows.Forms.TextBox();
            this.tenSVTB = new System.Windows.Forms.TextBox();
            this.namRB = new System.Windows.Forms.RadioButton();
            this.nuRB = new System.Windows.Forms.RadioButton();
            this.luuBt = new System.Windows.Forms.Button();
            this.xoaBt = new System.Windows.Forms.Button();
            this.thoatBt = new System.Windows.Forms.Button();
            this.khoaCBB = new System.Windows.Forms.ComboBox();
            this.lopCBB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 79);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 779);
            this.splitContainer1.SplitterDistance = 354;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.khoaTV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 779);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa";
            // 
            // khoaTV
            // 
            this.khoaTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khoaTV.Location = new System.Drawing.Point(3, 22);
            this.khoaTV.Name = "khoaTV";
            this.khoaTV.Size = new System.Drawing.Size(348, 754);
            this.khoaTV.TabIndex = 0;
            this.khoaTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.khoaTV_AfterSelect);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(709, 779);
            this.splitContainer2.SplitterDistance = 397;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sinhVienLV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 397);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // sinhVienLV
            // 
            this.sinhVienLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.sinhVienLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sinhVienLV.FullRowSelect = true;
            this.sinhVienLV.GridLines = true;
            this.sinhVienLV.HideSelection = false;
            this.sinhVienLV.Location = new System.Drawing.Point(3, 22);
            this.sinhVienLV.Name = "sinhVienLV";
            this.sinhVienLV.Size = new System.Drawing.Size(703, 372);
            this.sinhVienLV.TabIndex = 0;
            this.sinhVienLV.UseCompatibleStateImageBehavior = false;
            this.sinhVienLV.View = System.Windows.Forms.View.Details;
            this.sinhVienLV.SelectedIndexChanged += new System.EventHandler(this.sinhVienLV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sinh Viên";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sinh Viên";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Năm sinh";
            this.columnHeader4.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lopCBB);
            this.groupBox3.Controls.Add(this.khoaCBB);
            this.groupBox3.Controls.Add(this.thoatBt);
            this.groupBox3.Controls.Add(this.xoaBt);
            this.groupBox3.Controls.Add(this.luuBt);
            this.groupBox3.Controls.Add(this.nuRB);
            this.groupBox3.Controls.Add(this.namRB);
            this.groupBox3.Controls.Add(this.tenSVTB);
            this.groupBox3.Controls.Add(this.maSVTB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(709, 378);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết của Sinh Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sinh viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khoa chủ quản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lớp học:";
            // 
            // maSVTB
            // 
            this.maSVTB.Location = new System.Drawing.Point(187, 31);
            this.maSVTB.Name = "maSVTB";
            this.maSVTB.Size = new System.Drawing.Size(455, 26);
            this.maSVTB.TabIndex = 1;
            // 
            // tenSVTB
            // 
            this.tenSVTB.Location = new System.Drawing.Point(187, 66);
            this.tenSVTB.Name = "tenSVTB";
            this.tenSVTB.Size = new System.Drawing.Size(455, 26);
            this.tenSVTB.TabIndex = 1;
            // 
            // namRB
            // 
            this.namRB.AutoSize = true;
            this.namRB.Location = new System.Drawing.Point(187, 102);
            this.namRB.Name = "namRB";
            this.namRB.Size = new System.Drawing.Size(65, 24);
            this.namRB.TabIndex = 2;
            this.namRB.TabStop = true;
            this.namRB.Text = "Nam";
            this.namRB.UseVisualStyleBackColor = true;
            // 
            // nuRB
            // 
            this.nuRB.AutoSize = true;
            this.nuRB.Location = new System.Drawing.Point(337, 102);
            this.nuRB.Name = "nuRB";
            this.nuRB.Size = new System.Drawing.Size(51, 24);
            this.nuRB.TabIndex = 2;
            this.nuRB.TabStop = true;
            this.nuRB.Text = "Nữ";
            this.nuRB.UseVisualStyleBackColor = true;
            // 
            // luuBt
            // 
            this.luuBt.AutoSize = true;
            this.luuBt.Location = new System.Drawing.Point(206, 215);
            this.luuBt.Name = "luuBt";
            this.luuBt.Size = new System.Drawing.Size(75, 30);
            this.luuBt.TabIndex = 3;
            this.luuBt.Text = "Lưu";
            this.luuBt.UseVisualStyleBackColor = true;
            this.luuBt.Click += new System.EventHandler(this.luuBt_Click);
            // 
            // xoaBt
            // 
            this.xoaBt.AutoSize = true;
            this.xoaBt.Location = new System.Drawing.Point(337, 215);
            this.xoaBt.Name = "xoaBt";
            this.xoaBt.Size = new System.Drawing.Size(75, 30);
            this.xoaBt.TabIndex = 3;
            this.xoaBt.Text = "Xóa";
            this.xoaBt.UseVisualStyleBackColor = true;
            this.xoaBt.Click += new System.EventHandler(this.xoaBt_Click);
            // 
            // thoatBt
            // 
            this.thoatBt.AutoSize = true;
            this.thoatBt.Location = new System.Drawing.Point(474, 215);
            this.thoatBt.Name = "thoatBt";
            this.thoatBt.Size = new System.Drawing.Size(75, 30);
            this.thoatBt.TabIndex = 3;
            this.thoatBt.Text = "Thoát";
            this.thoatBt.UseVisualStyleBackColor = true;
            // 
            // khoaCBB
            // 
            this.khoaCBB.FormattingEnabled = true;
            this.khoaCBB.Location = new System.Drawing.Point(187, 136);
            this.khoaCBB.Name = "khoaCBB";
            this.khoaCBB.Size = new System.Drawing.Size(455, 28);
            this.khoaCBB.TabIndex = 4;
            this.khoaCBB.SelectedIndexChanged += new System.EventHandler(this.khoaCBB_SelectedIndexChanged);
            // 
            // lopCBB
            // 
            this.lopCBB.FormattingEnabled = true;
            this.lopCBB.Location = new System.Drawing.Point(187, 171);
            this.lopCBB.Name = "lopCBB";
            this.lopCBB.Size = new System.Drawing.Size(455, 28);
            this.lopCBB.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1067, 858);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView khoaTV;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView sinhVienLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button thoatBt;
        private System.Windows.Forms.Button xoaBt;
        private System.Windows.Forms.Button luuBt;
        private System.Windows.Forms.RadioButton nuRB;
        private System.Windows.Forms.RadioButton namRB;
        private System.Windows.Forms.TextBox tenSVTB;
        private System.Windows.Forms.TextBox maSVTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lopCBB;
        private System.Windows.Forms.ComboBox khoaCBB;
    }
}

