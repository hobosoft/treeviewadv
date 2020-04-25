using System;
using System.Drawing;
using Aga.Controls.Tree;

namespace TestBomTreeView
{
    /// <summary>
    /// Inherits the node class to show how the class can be extended.
    /// </summary>
	public class ProcessNode : Node
    {
        private int m_iSeq = 0;

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

        public ActivityType  AType
        {
            get;set;
        }

        public int Sequence
        {
            get
            {
                return m_iSeq;
            }
            set
            {
                if (m_iSeq != value)
                {
                    m_iSeq = value;
                    NotifyModel();
                }
            }
        }

        public override Image Image
        {
            get
            {
                switch (AType)
                {
                    case ActivityType.Procedure:
                        return Properties.Resources.Procedure;
                    case ActivityType.WorkStep:
                        return Properties.Resources.WorkStep;
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
		public ProcessNode(string text, ActivityType type, int seq)
			: base(text)
		{
            AType = type;
            m_iSeq = seq;
        }
	}

    public enum ActivityType
    {
        Procedure,
        WorkStep,
    }
}
