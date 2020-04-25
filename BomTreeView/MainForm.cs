using Aga.Controls.Tree;
using Aga.Controls.Tree.NodeControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace TestBomTreeView
{
	public partial class MainForm : Form
	{
		private TreeModel _model;

		public MainForm()
		{
			InitializeComponent();
		}

		public void InitTree()
		{
			treeViewAdv1.NodeMouseClick += new EventHandler<TreeNodeAdvMouseEventArgs>(_tree_NodeMouseClick);

			//_nodeTextBox.ToolTipProvider = new ToolTipProvider();
			_nodeIntegerTextBox.DrawText += _nodeIntegerTextBox_DrawText;
			_nodeTextBox.DrawText += new EventHandler<DrawTextEventArgs>(_nodeTextBox_DrawText);
			_model = new TreeModel();
			//_childFont = new Font(treeViewAdv1.Font.FontFamily, 18, FontStyle.Bold);
			treeViewAdv1.Model = _model;
            //ChangeButtons();
            //treeViewAdv1.MouseWheel += TreeViewAdv1_MouseWheel;

			treeViewAdv1.BeginUpdate();
			for (int i = 0; i < 10; i++)
			{
				Node node = AddRoot();
                for (int n = 0; n < 500; n++)
				{
					Node child = AddChild(node);
					for (int k = 0; k < 5; k++)
						AddChild(child);
				}
			}
			treeViewAdv1.EndUpdate();
		}

	    private float sizef = 9;
        private void TreeViewAdv1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
                sizef--;
            if (e.Delta > 0)
                sizef++;
        }

        private void _nodeIntegerTextBox_DrawText(object sender, DrawTextEventArgs e)
		{
			if ((e.Node.Tag as PartNode).Text.StartsWith("Child"))
			{
				e.TextColor = Color.Green;
				//e.Font = new Font(this.Font.FontFamily,sizef,this.Font.Style);

			    //e.Context.Bounds=new Rectangle(e.Context.Bounds.X, e.Context.Bounds.Y, e.Context.Bounds.Width,60);
            }
		}

		void _nodeTextBox_DrawText(object sender, DrawTextEventArgs e)
		{
			if ((e.Node.Tag as PartNode).Text.StartsWith("Child"))
			{
				e.TextColor = Color.Red;
               // e.Font = new Font(this.Font.FontFamily, sizef, this.Font.Style);
            }
		}


		void _tree_NodeMouseClick(object sender, TreeNodeAdvMouseEventArgs e)
		{
			Console.WriteLine("NodeMouseClick at " + e.Node.Index.ToString());
		}

		private Node AddRoot()
		{
			Node node = new PartNode("Long Root Node Text" + _model.Nodes.Count.ToString());
			_model.Nodes.Add(node);
			return node;
		}

		private Node AddChild(Node parent)
		{
			Node node = new PartNode("Child Node " + parent.Nodes.Count.ToString());
			parent.Nodes.Add(node);
			return node;
		}

		private void buttonInit_Click(object sender, EventArgs e)
		{
			InitTree();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
