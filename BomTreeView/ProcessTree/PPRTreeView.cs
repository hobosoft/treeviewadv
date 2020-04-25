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
    public class PPRTreeView : TreeViewAdv
    {
        public PPRTreeView() : base()
        {

        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            InitTree();
        }

        private void InitTree()
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
            ctrlNum.ToType = typeof(PartNode);
            this.NodeControls.Add(ctrlNum);

            NodeIntegerTextBox ctrlInt = new NodeIntegerTextBox();
            //ctrlInt.LeftMargin = 1;
            ctrlInt.DataPropertyName = "Sequence";
            ctrlInt.ToType = typeof(ProcessNode);
            this.NodeControls.Add(ctrlInt);
            //treeViewAdv1.NodeMouseClick += new EventHandler<TreeNodeAdvMouseEventArgs>(_tree_NodeMouseClick);

            PPRTreeModel model = new PPRTreeModel();
            model.InitModel();

            //_childFont = new Font(treeViewAdv1.Font.FontFamily, 18, FontStyle.Bold);
            this.Model = model;
        }

        //protected override void OnRowDraw(PaintEventArgs e, TreeNodeAdv node, DrawContext context, int row, Rectangle rowRect)
        //{
        //    base.OnRowDraw(e, node, context, row, rowRect);

        //    if (node.Tag != null)
        //    {
        //        if (node.Tag.GetType() == typeof(PartNode))
        //        {
        //            PartNode pnode = node.Tag as PartNode;
        //            if (pnode.Nodes.Count > 0 && pnode.Index % 2 == 0)
        //                context.ForeColor = Color.Red;
        //        }
        //    }
        //}

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
