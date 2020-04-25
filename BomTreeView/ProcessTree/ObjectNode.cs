using System;
using System.Drawing;
using Aga.Controls.Tree;

namespace TestBomTreeView
{
    /// <summary>
    /// Inherits the node class to show how the class can be extended.
    /// </summary>
	public class ObjectNode : Node
	{
		private Object _obj = null;
	    /// <exception cref="ArgumentNullException">Argument is null.</exception>
	    public virtual object Object
		{
			get
			{
				return _obj;
			}
			set
			{
				if (_obj != value)
                {
                    _obj = value;
                    NotifyModel();
                }
			}
		}


        /// <summary>
        /// Initializes a new MyNode class with a given Text property.
        /// </summary>
        /// <param name="text">String to set the text property with.</param>
		public ObjectNode(string text)
			: base(text)
		{
            //_obj = obj;
		}
	}
}
