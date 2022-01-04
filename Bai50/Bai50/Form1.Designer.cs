
namespace Bai50
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Khoa xây dựng dân dụng và công nghiệp");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Khoa Xây dựng Công trình thủy", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Đại học Bách Khoa - Đại học Đà Nẵng", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("19T1");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Khoa Công nghệ thông tin", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Đại học Duy Tân", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node7");
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themNutMn = new System.Windows.Forms.ToolStripMenuItem();
            this.suaNutMn = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaNutMn = new System.Windows.Forms.ToolStripMenuItem();
            this.moRongMn = new System.Windows.Forms.ToolStripMenuItem();
            this.thuLaiMn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.duLieuTV = new System.Windows.Forms.TreeView();
            this.valueLb = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themNutMn,
            this.suaNutMn,
            this.xoaNutMn,
            this.toolStripSeparator1,
            this.moRongMn,
            this.thuLaiMn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 130);
            // 
            // themNutMn
            // 
            this.themNutMn.Name = "themNutMn";
            this.themNutMn.Size = new System.Drawing.Size(140, 24);
            this.themNutMn.Text = "Thêm nút";
            this.themNutMn.Click += new System.EventHandler(this.themNutMn_Click);
            // 
            // suaNutMn
            // 
            this.suaNutMn.Name = "suaNutMn";
            this.suaNutMn.Size = new System.Drawing.Size(140, 24);
            this.suaNutMn.Text = "Sửa nút";
            this.suaNutMn.Click += new System.EventHandler(this.suaNutMn_Click);
            // 
            // xoaNutMn
            // 
            this.xoaNutMn.Name = "xoaNutMn";
            this.xoaNutMn.Size = new System.Drawing.Size(140, 24);
            this.xoaNutMn.Text = "Xóa nút";
            this.xoaNutMn.Click += new System.EventHandler(this.xoaNutMn_Click);
            // 
            // moRongMn
            // 
            this.moRongMn.Name = "moRongMn";
            this.moRongMn.Size = new System.Drawing.Size(140, 24);
            this.moRongMn.Text = "Mở rộng";
            this.moRongMn.Click += new System.EventHandler(this.moRongMn_Click);
            // 
            // thuLaiMn
            // 
            this.thuLaiMn.Name = "thuLaiMn";
            this.thuLaiMn.Size = new System.Drawing.Size(140, 24);
            this.thuLaiMn.Text = "Thu lại";
            this.thuLaiMn.Click += new System.EventHandler(this.thuLaiMn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // duLieuTV
            // 
            this.duLieuTV.ContextMenuStrip = this.contextMenuStrip1;
            this.duLieuTV.Location = new System.Drawing.Point(44, 28);
            this.duLieuTV.Name = "duLieuTV";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Khoa xây dựng dân dụng và công nghiệp";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Khoa Xây dựng Công trình thủy";
            treeNode3.Name = "Node8";
            treeNode3.Text = "Node8";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Đại học Bách Khoa - Đại học Đà Nẵng";
            treeNode5.Name = "Node5";
            treeNode5.Text = "19T1";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Khoa Công nghệ thông tin";
            treeNode7.Name = "Node3";
            treeNode7.Text = "Đại học Duy Tân";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Node6";
            treeNode9.Name = "Node7";
            treeNode9.Text = "Node7";
            this.duLieuTV.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode8,
            treeNode9});
            this.duLieuTV.Size = new System.Drawing.Size(664, 386);
            this.duLieuTV.TabIndex = 1;
            this.duLieuTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.duLieuTV_AfterSelect);
            this.duLieuTV.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.duLieuTV_NodeMouseClick);
            // 
            // valueLb
            // 
            this.valueLb.AutoSize = true;
            this.valueLb.Location = new System.Drawing.Point(747, 50);
            this.valueLb.Name = "valueLb";
            this.valueLb.Size = new System.Drawing.Size(81, 29);
            this.valueLb.TabIndex = 2;
            this.valueLb.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 539);
            this.Controls.Add(this.valueLb);
            this.Controls.Add(this.duLieuTV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themNutMn;
        private System.Windows.Forms.ToolStripMenuItem suaNutMn;
        private System.Windows.Forms.ToolStripMenuItem xoaNutMn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem moRongMn;
        private System.Windows.Forms.ToolStripMenuItem thuLaiMn;
        private System.Windows.Forms.TreeView duLieuTV;
        private System.Windows.Forms.Label valueLb;
    }
}

