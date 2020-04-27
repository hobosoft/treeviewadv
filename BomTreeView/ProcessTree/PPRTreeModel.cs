using Aga.Controls.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestBomTreeView
{
    public class PPRTreeModel : TreeModel
    {
        public PPRTreeModel() : base()
        {

        }

        private void OnPPRTreeModel_StructureChanged(object sender, TreePathEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void OnPPRTreeModel_NodesRemoved(object sender, TreeModelEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void OnPPRTreeModel_NodesInserted(object sender, TreeModelEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void OnPPRTreeModel_NodesChanged(object sender, TreeModelEventArgs e)
        {
            //throw new NotImplementedException();
        }

        public bool InitModel()
        {
			WorkOrderNode woNode = new WorkOrderNode("AO-0001-0000", WorkOrderType.AO);
			this.Nodes.Add(woNode);

			Node node = AddPPRNode(woNode, PPRNodeType.Product);
            for (int n = 0; n < 500; n++)
            {
                Node child = AddProductChild(node);
                for (int k = 0; k < 5; k++)
                    AddProductChild(child);
            }

            node = AddPPRNode(woNode, PPRNodeType.Process);
            for (int n = 0; n < 500; n++)
            {
                Node child = AddProcessChild(node, ActivityType.Procedure);
                for (int k = 0; k < 5; k++)
                    AddProcessChild(child, ActivityType.WorkStep);
            }

            node = AddPPRNode(woNode, PPRNodeType.Resource);
            for (int n = 0; n < 500; n++)
            {
                Node child = AddResourceChild(node);
                for (int k = 0; k < 5; k++)
                    AddResourceChild(child);
            }

            this.NodesChanged += OnPPRTreeModel_NodesChanged;
            this.NodesInserted += OnPPRTreeModel_NodesInserted;
            this.NodesRemoved += OnPPRTreeModel_NodesRemoved;
            this.StructureChanged += OnPPRTreeModel_StructureChanged;

            return true;
        }

        private Node AddPPRNode(Node woNode, PPRNodeType type)
        {
            Node node = new PPRNode(type);
			woNode.Nodes.Add(node);
            return node;
        }

        private Node AddProductChild(Node parent)
        {
            Node node = new PartNode("Child Node " + parent.Nodes.Count.ToString());
            parent.Nodes.Add(node);
            return node;
        }
        private Node AddProcessChild(Node parent, ActivityType type)
        {
            int index = 0;
            string text = "Process Node";
            if (type == ActivityType.Procedure)
            {
                text = "Procedure Node";
                index = (parent.Nodes.Count + 1) * 10;
            }
            else if (type == ActivityType.WorkStep)
            {
                text = "Work Step Node";
                index = (parent.Nodes.Count + 1) * 5;
            }
            Node node = new ProcessNode(text, type, index);
            parent.Nodes.Add(node);
            return node;
        }

        private Node AddResourceChild(Node parent)
        {
            Node node = new ResourceNode("Resource Node " + parent.Nodes.Count.ToString());
            parent.Nodes.Add(node);
            return node;
        }
    }
}
