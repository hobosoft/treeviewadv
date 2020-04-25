using Aga.Controls.Tree;
using Aga.Controls.Tree.NodeControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestBomTreeView
{
    public class BomTreeView : TreeViewAdv
    {
        public BomTreeView() : base()
        {
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

        }

        public void InitTree()
        {
            NodeIcon ctrlIcon = new NodeIcon();
            ctrlIcon.DataPropertyName = "Image";
            ctrlIcon.ToType = null;
            this.NodeControls.Add(ctrlIcon);

            NodeTextBox ctrlTB = new NodeTextBox();
            ctrlTB.DataPropertyName = "Text";
            ctrlTB.ToType = null;
            this.NodeControls.Add(ctrlTB);

            NodeNumericUpDown ctrlNum = new NodeNumericUpDown();
            //ctrlNum.LeftMargin = 1;
            ctrlNum.DataPropertyName = "Count";
            this.NodeControls.Add(ctrlNum);

            BomTreeModel model = new BomTreeModel();
            model.InitModel();

            //_childFont = new Font(treeViewAdv1.Font.FontFamily, 18, FontStyle.Bold);
            this.Model = model;

            this.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this._tree_ItemDrag);
            this.NodeMouseDoubleClick += new System.EventHandler<Aga.Controls.Tree.TreeNodeAdvMouseEventArgs>(this._tree_NodeMouseDoubleClick);
            this.SelectionChanged += new System.EventHandler(this._tree_SelectionChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this._tree_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this._tree_DragOver);
        }


        private void _tree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            this.DoDragDropSelectedNodes(DragDropEffects.Move);
        }

        private void _tree_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNodeAdv[])) && this.DropPosition.Node != null)
            {
                TreeNodeAdv[] nodes = e.Data.GetData(typeof(TreeNodeAdv[])) as TreeNodeAdv[];
                TreeNodeAdv parent = this.DropPosition.Node;
                if (this.DropPosition.Position != NodePosition.Inside)
                    parent = parent.Parent;

                foreach (TreeNodeAdv node in nodes)
                    if (!CheckNodeParent(parent, node))
                    {
                        e.Effect = DragDropEffects.None;
                        return;
                    }

                e.Effect = e.AllowedEffect;
            }
        }

        private bool CheckNodeParent(TreeNodeAdv parent, TreeNodeAdv node)
        {
            while (parent != null)
            {
                if (node == parent)
                    return false;
                else
                    parent = parent.Parent;
            }
            return true;
        }


        private void _tree_DragDrop(object sender, DragEventArgs e)
        {
            this.BeginUpdate();

            TreeNodeAdv[] nodes = (TreeNodeAdv[])e.Data.GetData(typeof(TreeNodeAdv[]));
            Node dropNode = this.DropPosition.Node.Tag as Node;
            if (this.DropPosition.Position == NodePosition.Inside)
            {
                foreach (TreeNodeAdv n in nodes)
                {
                    (n.Tag as Node).Parent = dropNode;
                }
                this.DropPosition.Node.IsExpanded = true;
            }
            else
            {
                Node parent = dropNode.Parent;
                Node nextItem = dropNode;
                if (this.DropPosition.Position == NodePosition.After)
                    nextItem = dropNode.NextNode;

                foreach (TreeNodeAdv node in nodes)
                    (node.Tag as Node).Parent = null;

                int index = -1;
                index = parent.Nodes.IndexOf(nextItem);
                foreach (TreeNodeAdv node in nodes)
                {
                    Node item = node.Tag as Node;
                    if (index == -1)
                        parent.Nodes.Add(item);
                    else
                    {
                        parent.Nodes.Insert(index, item);
                        index++;
                    }
                }
            }

            this.EndUpdate();
        }

        private void _tree_NodeMouseDoubleClick(object sender, TreeNodeAdvMouseEventArgs e)
        {
            if (e.Control is NodeTextBox)
                MessageBox.Show(e.Node.Tag.ToString());
        }

        private void _tree_SelectionChanged(object sender, EventArgs e)
        {
            //ChangeButtons();
        }

        protected override void CheckNodeState(TreeNodeAdv node, ref DrawContext context)
        {
            if (node.Tag != null)
            {
                if (node.Tag.GetType() == typeof(PartNode))
                {
                    PartNode pnode = node.Tag as PartNode;
                    if (pnode.Nodes.Count > 0 && pnode.Index % 2 == 0)
                        context.ForeColor = Color.Red;
                }
            }
        }
    }
}
