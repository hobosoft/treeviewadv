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
			Node nodeProduct = new ProductNode("S-001");
			this.Nodes.Add(nodeProduct);

			Random random = new Random();
			Node node = AddBomNode(nodeProduct, new BomLink(null, 1.0));
            for (int n = 0; n < 500; n++)
            {

                Node child = AddBomNode(node, new BomLink(null, random.NextDouble() * 20));
                for (int k = 0; k < 5; k++)
					AddBomNode(child, new BomLink(null, random.NextDouble() * 20));
            }

            node = node = AddBomNode(nodeProduct, new BomLink(null, 5.0));
			for (int n = 0; n < 500; n++)
            {
                Node child = AddBomNode(node, new BomLink(null, random.NextDouble() * 20));
                for (int k = 0; k < 5; k++)
					AddBomNode(child, new BomLink(null, random.NextDouble() * 20));
            }

            node = node = AddBomNode(nodeProduct, new BomLink(null, 12.0));
			for (int n = 0; n < 500; n++)
            {
                Node child = AddBomNode(node, new BomLink(null, random.NextDouble() * 20));
                for (int k = 0; k < 5; k++)
					AddBomNode(child, new BomLink(null, random.NextDouble() * 20));
            }

            this.NodesChanged += OnBomTreeModel_NodesChanged;
            this.NodesInserted += OnBomTreeModel_NodesInserted;
            this.NodesRemoved += OnBomTreeModel_NodesRemoved;
            this.StructureChanged += OnBomTreeModel_StructureChanged;

            return true;
        }

        private Node AddBomNode(Node parent, BomLink link)
        {
            Node node = new BomNode("Child Node " + parent.Nodes.Count.ToString(), link);
            parent.Nodes.Add(node);
            return node;
        }

    }


}
