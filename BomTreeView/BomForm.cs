using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aga.Controls.Tree;

namespace TestBomTreeView
{
    public partial class BomForm : Form
    {
        public BomForm()
        {
            InitializeComponent();
        }

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

            treeViewBom.InitTree();

			treeViewBom.Root.ExpandAll();
		}

		private void buttonLoad_Click(object sender, EventArgs e)
        {
        }

		private void buttonAssign_Click(object sender, EventArgs e)
		{
			foreach (TreeNodeAdv node in treeViewBom.SelectedNodes)
			{
				if (node.Tag is BomNode)
				{
					BomNode bNode = node.Tag as BomNode;
					bNode.Assign = true;

					AssignBomNode(bNode);
				}
			}
		}

		private void AssignBomNode(BomNode bNode)
		{
			foreach (BomNode node in bNode.Nodes)
			{
				node.Assign = true;
				AssignBomNode(node);
			}
		}
	}
}
