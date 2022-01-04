using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void themNutMn_Click(object sender, EventArgs e)
        {
            FormThemNut form = new FormThemNut();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (duLieuTV.SelectedNode == null) //Muốn tạo nút gốc
                {
                    TreeNode root = new TreeNode(form.giaTriTB.Text);
                    duLieuTV.Nodes.Add(root);
                }
                else// Tạo nút con của SelectedNode
                {
                    TreeNode node = new TreeNode(form.giaTriTB.Text);
                    duLieuTV.SelectedNode.Nodes.Add(node);
                }
            }
        }

        private void duLieuTV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            duLieuTV.SelectedNode = e.Node;
        }

        private void suaNutMn_Click(object sender, EventArgs e)
        {
            if (duLieuTV.SelectedNode == null)
            {
                return;
            }
            FormThemNut form = new FormThemNut();
            if (form.ShowDialog() == DialogResult.OK)
            {
                duLieuTV.SelectedNode.Text = form.giaTriTB.Text;

            }
        }

        private void xoaNutMn_Click(object sender, EventArgs e)
        {
            if (duLieuTV.SelectedNode != null)
            {
                duLieuTV.Nodes.Remove(duLieuTV.SelectedNode);
            }
        }

        private void moRongMn_Click(object sender, EventArgs e)
        {
            if (duLieuTV.SelectedNode != null)
            {
                duLieuTV.SelectedNode.ExpandAll();
            }
        }

        private void thuLaiMn_Click(object sender, EventArgs e)
        {
            if (duLieuTV.SelectedNode != null)
            {
                duLieuTV.SelectedNode.Collapse();
            }
        }

        private void duLieuTV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node!= null)
            {
                valueLb.Text = e.Node.Text;
            }
        }
    }
}
