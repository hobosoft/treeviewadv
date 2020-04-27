namespace TestBomTreeView
{
    partial class SelectForm
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
			this.buttonBomTree = new System.Windows.Forms.Button();
			this.buttonPPRTree = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonBomTree
			// 
			this.buttonBomTree.Location = new System.Drawing.Point(189, 161);
			this.buttonBomTree.Name = "buttonBomTree";
			this.buttonBomTree.Size = new System.Drawing.Size(138, 23);
			this.buttonBomTree.TabIndex = 0;
			this.buttonBomTree.Text = "BomTree";
			this.buttonBomTree.UseVisualStyleBackColor = true;
			this.buttonBomTree.Click += new System.EventHandler(this.buttonBomTree_Click);
			// 
			// buttonPPRTree
			// 
			this.buttonPPRTree.Location = new System.Drawing.Point(189, 99);
			this.buttonPPRTree.Name = "buttonPPRTree";
			this.buttonPPRTree.Size = new System.Drawing.Size(138, 23);
			this.buttonPPRTree.TabIndex = 0;
			this.buttonPPRTree.Text = "PPRTree Form";
			this.buttonPPRTree.UseVisualStyleBackColor = true;
			this.buttonPPRTree.Click += new System.EventHandler(this.buttonPPRTree_Click);
			// 
			// SelectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(508, 307);
			this.Controls.Add(this.buttonPPRTree);
			this.Controls.Add(this.buttonBomTree);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SelectForm";
			this.Text = "SelectForm";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBomTree;
        private System.Windows.Forms.Button buttonPPRTree;
    }
}