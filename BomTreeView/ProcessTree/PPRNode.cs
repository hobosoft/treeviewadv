using System;
using System.Drawing;
using Aga.Controls.Tree;

namespace TestBomTreeView
{
    /// <summary>
    /// Inherits the node class to show how the class can be extended.
    /// </summary>
	public class PPRNode : Node
    {
        /// <summary>
        /// Initializes a new MyNode class with a given Text property.
        /// </summary>
        /// <param name="text">String to set the text property with.</param>
		public PPRNode(PPRNodeType type)
			: base()
		{
            PPRType = type;
		}

        public PPRNodeType PPRType
        {
            get;
            set;
        }


        /// <exception cref="ArgumentNullException">Argument is null.</exception>
        public override string Text
		{
			get
			{
                switch (PPRType)
                {
                    case PPRNodeType.Product:
                        return "Product";
                    case PPRNodeType.Process:
                        return "Process";
                    case PPRNodeType.PartList:
                        return "PartNode List";
                    case PPRNodeType.Resource:
                        return "Resource";
                    default:
                        return base.Text;
                }
				//return base.Text;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentNullException();

				base.Text = value;
			}
		}

        public override Image Image
        {
            get
            {
                switch (PPRType)
                {
                    case PPRNodeType.Product:
                        return Properties.Resources.Product;
                    case PPRNodeType.Process:
                        return Properties.Resources.Process;
                    case PPRNodeType.PartList:
                        return Properties.Resources.PartList;
                    case PPRNodeType.Resource:
                        return Properties.Resources.ResourceList;
                    default:
                        return base.Image;
                }
            }
            set => base.Image = value;
        }

        private Image _imageState;
        public Image StateImage
        {
            get { return _imageState; }
            set
            {
                _imageState = value;
            }
        }


	}

    public enum PPRNodeType
    {
        Unknow,
        Product,
        PartList,
        Process,
        Resource,
    }
}
