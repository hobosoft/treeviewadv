using System;
using System.Drawing;
using Aga.Controls.Tree;

namespace TestBomTreeView
{
    /// <summary>
    /// Inherits the node class to show how the class can be extended.
    /// </summary>
	public class ProductNode : Node
    {
	    /// <exception cref="ArgumentNullException">Argument is null.</exception>
	    public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentNullException();

				base.Text = value;
			}
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

        public override Image Image
        {
            get
            {
                return Properties.Resources.Product;
            }
            set => base.Image = value;
        }


        private bool _checked;
        /// <summary>
        /// Whether the box is checked or not.
        /// </summary>
		public bool Checked
		{
			get { return _checked; }
			set { _checked = value; }
		}

        /// <summary>
        /// Initializes a new MyNode class with a given Text property.
        /// </summary>
        /// <param name="text">String to set the text property with.</param>
		public ProductNode(string text)
			: base(text)
		{
		}
	}
}
