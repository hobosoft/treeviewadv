using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Aga.Controls.Tree;

namespace TestBomTreeView
{
	public class BomNode : Node
	{
		BomLink _link = null;
		//int m_iCount = 0;
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

		public BomLink Link
		{
			get { return _link; }
			set
			{
				if (_link != value)
				{
					_link = value;
					NotifyModel();
				}
			}
		}

		public double Quantity
		{
			get
			{
				if (_link != null)
					return _link.Quantity;

				return 0.0;
			}
			//set
			//{
			//	m_iCount = value;
			//}
		}


		private bool _assign = false;
		public bool Assign
		{
			get
			{
				return _assign;
			}
			set
			{
				if (_assign != value)
				{
					_assign = value;
					NotifyModel();
				}
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

		/// <summary>
		/// Initializes a new MyNode class with a given Text property.
		/// </summary>
		/// <param name="text">String to set the text property with.</param>
		public BomNode(string text, BomLink link)
			: base(text)
		{
			_link = link;
		}
	}

	public class BomLink
	{
		public BomLink(object part, double qty)
		{
			ToPart = part;
			Quantity = qty;
		}

		public object ToPart
		{
			get;set;
		}

		public double Quantity
		{
			get;set;
		}
	}
}
