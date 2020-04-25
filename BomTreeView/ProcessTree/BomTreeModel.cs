using Aga.Controls.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestBomTreeView
{
    public class BomTreeModel : TreeModel
    {
        public BomTreeModel() : base()
        {
        }


        private void OnBomTreeModel_StructureChanged(object sender, TreePathEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void OnBomTreeModel_NodesRemoved(object sender, TreeModelEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void OnBomTreeModel_NodesInserted(object sender, TreeModelEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void OnBomTreeModel_NodesChanged(object sender, TreeModelEventArgs e)
        {
            //throw new NotImplementedException();
        }

        public bool InitModel()
        {
            Node node = AddRoot(PPRNodeType.Product);
            for (int n = 0; n < 500; n++)
            {
                Node child = AddProductChild(node);
                for (int k = 0; k < 5; k++)
                    AddProductChild(child);
            }

            node = AddRoot(PPRNodeType.Product);
            for (int n = 0; n < 500; n++)
            {
                Node child = AddProductChild(node);
                for (int k = 0; k < 5; k++)
                    AddProductChild(child);
            }

            node = AddRoot(PPRNodeType.Product);
            for (int n = 0; n < 500; n++)
            {
                Node child = AddProductChild(node);
                for (int k = 0; k < 5; k++)
                    AddProductChild(child);
            }

            this.NodesChanged += OnBomTreeModel_NodesChanged;
            this.NodesInserted += OnBomTreeModel_NodesInserted;
            this.NodesRemoved += OnBomTreeModel_NodesRemoved;
            this.StructureChanged += OnBomTreeModel_StructureChanged;

            return true;
        }

        private Node AddRoot(PPRNodeType type)
        {
            Node node = new PPRNode(type);
            this.Nodes.Add(node);
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
