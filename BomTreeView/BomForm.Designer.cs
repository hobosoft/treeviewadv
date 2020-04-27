namespace TestBomTreeView
{
    partial class BomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.buttonLoad = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.treeViewBom = new TestBomTreeView.BomTreeView();
			this.buttonAssign = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonLoad
			// 
			this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLoad.Location = new System.Drawing.Point(451, 502);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(75, 23);
			this.buttonLoad.TabIndex = 4;
			this.buttonLoad.Text = "Load";
			this.buttonLoad.UseVisualStyleBackColor = true;
			this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonClose.Location = new System.Drawing.Point(532, 502);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 3;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			// 
			// treeViewBom
			// 
			this.treeViewBom.AllowDrop = true;
			this.treeViewBom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeViewBom.BackColor = System.Drawing.SystemColors.Window;
			this.treeViewBom.ColumnHeaderHeight = 0;
			this.treeViewBom.DefaultToolTipProvider = null;
			this.treeViewBom.DisplayDraggingNodes = true;
			this.treeViewBom.DragDropMarkColor = System.Drawing.Color.Black;
			this.treeViewBom.FullRowSelectActiveColor = System.Drawing.Color.Empty;
			this.treeViewBom.FullRowSelectInactiveColor = System.Drawing.Color.Empty;
			this.treeViewBom.LineColor = System.Drawing.SystemColors.ControlDark;
			this.treeViewBom.LoadOnDemand = true;
			this.treeViewBom.Location = new System.Drawing.Point(12, 12);
			this.treeViewBom.Model = null;
			this.treeViewBom.Name = "treeViewBom";
			this.treeViewBom.NodeFilter = null;
			this.treeViewBom.SelectedNode = null;
			this.treeViewBom.SelectionMode = Aga.Controls.Tree.TreeSelectionMode.MultiSameParent;
			this.treeViewBom.ShowNodeToolTips = true;
			this.treeViewBom.Size = new System.Drawing.Size(595, 484);
			this.treeViewBom.TabIndex = 2;
			this.treeViewBom.Text = "treeViewAdv1";
			// 
			// buttonAssign
			// 
			this.buttonAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAssign.Location = new System.Drawing.Point(370, 502);
			this.buttonAssign.Name = "buttonAssign";
			this.buttonAssign.Size = new System.Drawing.Size(75, 23);
			this.buttonAssign.TabIndex = 4;
			this.buttonAssign.Text = "分配";
			this.buttonAssign.UseVisualStyleBackColor = true;
			this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
			// 
			// BomForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 537);
			this.Controls.Add(this.buttonAssign);
			this.Controls.Add(this.buttonLoad);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.treeViewBom);
			this.Name = "BomForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BomForm";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonClose;
        private BomTreeView treeViewBom;
		private System.Windows.Forms.Button buttonAssign;
	}
}