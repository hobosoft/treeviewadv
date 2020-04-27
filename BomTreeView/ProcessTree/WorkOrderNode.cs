using System;
using System.Drawing;
using Aga.Controls.Tree;

namespace TestBomTreeView
{
    /// <summary>
    /// Inherits the node class to show how the class can be extended.
    /// </summary>
	public class WorkOrderNode : Node
    {
        private WorkOrderType _woType = WorkOrderType.AO;

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


        public WorkOrderType WOType
		{
            get
            {
                return _woType;
            }
            set
            {
                if (_woType != value)
                {
					_woType = value;
                    NotifyModel();
                }
            }
        }

        public override Image Image
        {
            get
            {
                switch (_woType)
                {
                    case WorkOrderType.AO:
                        return Properties.Resources.AO;
                    case WorkOrderType.FO:
                        return Properties.Resources.FO;
					case WorkOrderType.TO:
						return Properties.Resources.TO;
					default:
                        return base.Image;
                }
            }
            set => base.Image = value;
        }

        //public override Image Image
        //{
        //    get
        //    {

        //    }
        //    set
        //    {
        //    }
        //}

        private Image _imageState;
        public Image StateImage
        {
            get { return _imageState; }
            set
            {
                _imageState = value;
            }
        }


        /// <summary>
        /// Initializes a new MyNode class with a given Text property.
        /// </summary>
        /// <param name="text">String to set the text property with.</param>
		public WorkOrderNode(string text, WorkOrderType type)
			: base(text)
		{
            _woType = type;
        }
	}

    public enum WorkOrderType
    {
        AO,
        FO,
		TO,
    }
}
