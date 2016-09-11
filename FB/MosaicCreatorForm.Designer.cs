namespace FB
{
    public partial class MosaicCreatorForm
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
            this.ProfileImageOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSubmitMosiac = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonUploadProfileImage = new System.Windows.Forms.Button();
            this.panelSelectImages = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSelectImages = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPixelSize = new System.Windows.Forms.TextBox();
            this.buttonCreateMosaic = new System.Windows.Forms.Button();
            this.panelImgeSelection = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImage = new System.Windows.Forms.TextBox();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.pictureBoxMosaic = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelSubmitMosiac.SuspendLayout();
            this.panelSelectImages.SuspendLayout();
            this.panelImgeSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMosaic)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewsFeed
            // 
            this.buttonNewsFeed.FlatAppearance.BorderSize = 0;
            this.buttonNewsFeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(170)))));
            // 
            // buttonProfile
            // 
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(170)))));
            this.buttonProfile.Text = "Desig Patter";
            // 
            // buttonTodayEvents
            // 
            this.buttonTodayEvents.FlatAppearance.BorderSize = 0;
            this.buttonTodayEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(170)))));
            // 
            // buttonMosiac
            // 
            this.buttonMosiac.FlatAppearance.BorderSize = 0;
            this.buttonMosiac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(170)))));
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(170)))));
            // 
            // ProfileImageOpenFileDialog
            // 
            this.ProfileImageOpenFileDialog.Filter = "Images|*.jpg;*.png;*.jpeg";
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.panelSubmitMosiac);
            this.panelMain.Controls.Add(this.panelSelectImages);
            this.panelMain.Controls.Add(this.panelImgeSelection);
            this.panelMain.Controls.Add(this.pictureBoxMosaic);
            this.panelMain.Location = new System.Drawing.Point(278, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(874, 619);
            this.panelMain.TabIndex = 0;
            // 
            // panelSubmitMosiac
            // 
            this.panelSubmitMosiac.BackColor = System.Drawing.Color.White;
            this.panelSubmitMosiac.Controls.Add(this.label4);
            this.panelSubmitMosiac.Controls.Add(this.textBoxTitle);
            this.panelSubmitMosiac.Controls.Add(this.buttonUploadProfileImage);
            this.panelSubmitMosiac.Location = new System.Drawing.Point(49, 359);
            this.panelSubmitMosiac.Name = "panelSubmitMosiac";
            this.panelSubmitMosiac.Size = new System.Drawing.Size(751, 91);
            this.panelSubmitMosiac.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Title:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(118, 37);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(447, 22);
            this.textBoxTitle.TabIndex = 7;
            this.textBoxTitle.Click += new System.EventHandler(this.textBoxTitle_Click);
            // 
            // buttonUploadProfileImage
            // 
            this.buttonUploadProfileImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonUploadProfileImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUploadProfileImage.ForeColor = System.Drawing.Color.White;
            this.buttonUploadProfileImage.Location = new System.Drawing.Point(573, 32);
            this.buttonUploadProfileImage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUploadProfileImage.Name = "buttonUploadProfileImage";
            this.buttonUploadProfileImage.Size = new System.Drawing.Size(133, 28);
            this.buttonUploadProfileImage.TabIndex = 6;
            this.buttonUploadProfileImage.Text = "Post on profile";
            this.buttonUploadProfileImage.UseVisualStyleBackColor = false;
            this.buttonUploadProfileImage.Click += new System.EventHandler(this.buttonUploadProfileImage_Click);
            // 
            // panelSelectImages
            // 
            this.panelSelectImages.BackColor = System.Drawing.Color.White;
            this.panelSelectImages.Controls.Add(this.label3);
            this.panelSelectImages.Controls.Add(this.buttonSelectImages);
            this.panelSelectImages.Controls.Add(this.label2);
            this.panelSelectImages.Controls.Add(this.textBoxPixelSize);
            this.panelSelectImages.Controls.Add(this.buttonCreateMosaic);
            this.panelSelectImages.Location = new System.Drawing.Point(49, 224);
            this.panelSelectImages.Name = "panelSelectImages";
            this.panelSelectImages.Size = new System.Drawing.Size(751, 112);
            this.panelSelectImages.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select images:";
            // 
            // buttonSelectImages
            // 
            this.buttonSelectImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonSelectImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectImages.ForeColor = System.Drawing.Color.White;
            this.buttonSelectImages.Location = new System.Drawing.Point(573, 24);
            this.buttonSelectImages.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectImages.Name = "buttonSelectImages";
            this.buttonSelectImages.Size = new System.Drawing.Size(133, 28);
            this.buttonSelectImages.TabIndex = 3;
            this.buttonSelectImages.Text = "Browse..";
            this.buttonSelectImages.UseVisualStyleBackColor = false;
            this.buttonSelectImages.Click += new System.EventHandler(this.buttonSelectImages_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pixel size:";
            // 
            // textBoxPixelSize
            // 
            this.textBoxPixelSize.Location = new System.Drawing.Point(118, 72);
            this.textBoxPixelSize.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPixelSize.Name = "textBoxPixelSize";
            this.textBoxPixelSize.Size = new System.Drawing.Size(447, 22);
            this.textBoxPixelSize.TabIndex = 9;
            // 
            // buttonCreateMosaic
            // 
            this.buttonCreateMosaic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonCreateMosaic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateMosaic.ForeColor = System.Drawing.Color.White;
            this.buttonCreateMosaic.Location = new System.Drawing.Point(573, 68);
            this.buttonCreateMosaic.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateMosaic.Name = "buttonCreateMosaic";
            this.buttonCreateMosaic.Size = new System.Drawing.Size(133, 28);
            this.buttonCreateMosaic.TabIndex = 5;
            this.buttonCreateMosaic.Text = "Create Mosaic";
            this.buttonCreateMosaic.UseVisualStyleBackColor = false;
            this.buttonCreateMosaic.Click += new System.EventHandler(this.buttonCreateMosaic_Click);
            // 
            // panelImgeSelection
            // 
            this.panelImgeSelection.BackColor = System.Drawing.Color.White;
            this.panelImgeSelection.Controls.Add(this.label1);
            this.panelImgeSelection.Controls.Add(this.textBoxImage);
            this.panelImgeSelection.Controls.Add(this.buttonOpenImage);
            this.panelImgeSelection.Location = new System.Drawing.Point(49, 41);
            this.panelImgeSelection.Margin = new System.Windows.Forms.Padding(0);
            this.panelImgeSelection.Name = "panelImgeSelection";
            this.panelImgeSelection.Size = new System.Drawing.Size(751, 161);
            this.panelImgeSelection.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select image:";
            // 
            // textBoxImage
            // 
            this.textBoxImage.Enabled = false;
            this.textBoxImage.Location = new System.Drawing.Point(29, 52);
            this.textBoxImage.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxImage.Multiline = true;
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.Size = new System.Drawing.Size(677, 34);
            this.textBoxImage.TabIndex = 2;
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonOpenImage.FlatAppearance.BorderSize = 0;
            this.buttonOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenImage.ForeColor = System.Drawing.Color.White;
            this.buttonOpenImage.Location = new System.Drawing.Point(606, 111);
            this.buttonOpenImage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(100, 28);
            this.buttonOpenImage.TabIndex = 0;
            this.buttonOpenImage.Text = "Browse";
            this.buttonOpenImage.UseVisualStyleBackColor = false;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttonOpenImage_Click);
            // 
            // pictureBoxMosaic
            // 
            this.pictureBoxMosaic.Location = new System.Drawing.Point(49, 479);
            this.pictureBoxMosaic.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxMosaic.Name = "pictureBoxMosaic";
            this.pictureBoxMosaic.Size = new System.Drawing.Size(751, 333);
            this.pictureBoxMosaic.TabIndex = 4;
            this.pictureBoxMosaic.TabStop = false;
            // 
            // MosaicCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 619);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(882, 1092);
            this.MinimumSize = new System.Drawing.Size(882, 666);
            this.Name = "MosaicCreatorForm";
            this.Text = "MosaicCreatorForm";
            this.Load += new System.EventHandler(this.mosaicCreatorForm_Load);
            this.Controls.SetChildIndex(this.panelMain, 0);
            this.panelMain.ResumeLayout(false);
            this.panelSubmitMosiac.ResumeLayout(false);
            this.panelSubmitMosiac.PerformLayout();
            this.panelSelectImages.ResumeLayout(false);
            this.panelSelectImages.PerformLayout();
            this.panelImgeSelection.ResumeLayout(false);
            this.panelImgeSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMosaic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ProfileImageOpenFileDialog;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox textBoxImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenImage;
        private System.Windows.Forms.Button buttonSelectImages;
        private System.Windows.Forms.Button buttonCreateMosaic;
        private System.Windows.Forms.PictureBox pictureBoxMosaic;
        private System.Windows.Forms.Button buttonUploadProfileImage;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPixelSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelImgeSelection;
        private System.Windows.Forms.Panel panelSelectImages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSubmitMosiac;
        private System.Windows.Forms.Label label4;
    }
}