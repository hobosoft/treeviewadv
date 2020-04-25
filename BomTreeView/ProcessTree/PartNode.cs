using System;
using System.Drawing;
using Aga.Controls.Tree;

namespace TestBomTreeView
{
    /// <summary>
    /// Inherits the node class to show how the class can be extended.
    /// </summary>
	public class PartNode : Node
    {
		int m_iCount = 0;
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

		public int Count
		{
			get
			{
				return m_iCount;
			}
			set
			{
				m_iCount = value;
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
                if (this.Nodes.Count > 0)
                    return Properties.Resources.Assembly;
                else
                    return Properties.Resources.Part;
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
		public PartNode(string text)
			: base(text)
		{
		}
	}
}
