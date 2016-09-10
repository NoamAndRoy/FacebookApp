namespace FB.UserControls
{
    public partial class UserControlAlbum
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AlbumNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImagesPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // AlbumNameLabel
            // 
            this.AlbumNameLabel.AutoSize = true;
            this.AlbumNameLabel.Location = new System.Drawing.Point(14, 15);
            this.AlbumNameLabel.Name = "AlbumNameLabel";
            this.AlbumNameLabel.Size = new System.Drawing.Size(35, 13);
            this.AlbumNameLabel.TabIndex = 0;
            this.AlbumNameLabel.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 1);
            this.panel1.TabIndex = 1;
            // 
            // ImagesPanel
            // 
            this.ImagesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagesPanel.AutoSize = true;
            this.ImagesPanel.Location = new System.Drawing.Point(0, 40);
            this.ImagesPanel.Name = "ImagesPanel";
            this.ImagesPanel.Size = new System.Drawing.Size(852, 110);
            this.ImagesPanel.TabIndex = 2;
            // 
            // UserControlAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.ImagesPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AlbumNameLabel);
            this.Name = "UserControlAlbum";
            this.Size = new System.Drawing.Size(852, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label AlbumNameLabel;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel ImagesPanel;
    }
}
