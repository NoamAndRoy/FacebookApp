namespace FB
{
    public partial class TodayEventsForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTodayEvents = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.textBoxCurrentLocation = new System.Windows.Forms.TextBox();
            this.gMapControlEvents = new GMap.NET.WindowsForms.GMapControl();
            this.panelMain.SuspendLayout();
            this.panelTodayEvents.SuspendLayout();
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
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.panelTodayEvents);
            this.panelMain.Controls.Add(this.gMapControlEvents);
            this.panelMain.Location = new System.Drawing.Point(277, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(875, 772);
            this.panelMain.TabIndex = 0;
            // 
            // panelTodayEvents
            // 
            this.panelTodayEvents.BackColor = System.Drawing.Color.White;
            this.panelTodayEvents.Controls.Add(this.label1);
            this.panelTodayEvents.Controls.Add(this.buttonSearch);
            this.panelTodayEvents.Controls.Add(this.listBoxEvents);
            this.panelTodayEvents.Controls.Add(this.textBoxCurrentLocation);
            this.panelTodayEvents.Location = new System.Drawing.Point(50, 35);
            this.panelTodayEvents.Name = "panelTodayEvents";
            this.panelTodayEvents.Size = new System.Drawing.Size(766, 331);
            this.panelTodayEvents.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your current location:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(619, 35);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(114, 28);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(32, 100);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(701, 196);
            this.listBoxEvents.TabIndex = 2;
            // 
            // textBoxCurrentLocation
            // 
            this.textBoxCurrentLocation.Location = new System.Drawing.Point(217, 38);
            this.textBoxCurrentLocation.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCurrentLocation.Name = "textBoxCurrentLocation";
            this.textBoxCurrentLocation.Size = new System.Drawing.Size(394, 22);
            this.textBoxCurrentLocation.TabIndex = 3;
            // 
            // gMapControlEvents
            // 
            this.gMapControlEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControlEvents.Bearing = 0F;
            this.gMapControlEvents.CanDragMap = true;
            this.gMapControlEvents.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControlEvents.GrayScaleMode = false;
            this.gMapControlEvents.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControlEvents.LevelsKeepInMemmory = 5;
            this.gMapControlEvents.Location = new System.Drawing.Point(0, 398);
            this.gMapControlEvents.Margin = new System.Windows.Forms.Padding(4);
            this.gMapControlEvents.MarkersEnabled = true;
            this.gMapControlEvents.MaxZoom = 20;
            this.gMapControlEvents.MinZoom = 1;
            this.gMapControlEvents.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControlEvents.Name = "gMapControlEvents";
            this.gMapControlEvents.NegativeMode = false;
            this.gMapControlEvents.PolygonsEnabled = false;
            this.gMapControlEvents.RetryLoadTile = 0;
            this.gMapControlEvents.RoutesEnabled = true;
            this.gMapControlEvents.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControlEvents.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControlEvents.ShowTileGridLines = false;
            this.gMapControlEvents.Size = new System.Drawing.Size(585, 370);
            this.gMapControlEvents.TabIndex = 1;
            this.gMapControlEvents.Zoom = 2D;
            // 
            // TodayEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 772);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(882, 1091);
            this.MinimumSize = new System.Drawing.Size(882, 664);
            this.Name = "TodayEventsForm";
            this.Text = "MosaicCreatorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TodayEventsForm_FormClosing);
            this.Load += new System.EventHandler(this.TodayEventsForm_Load);
            this.Controls.SetChildIndex(this.panelMain, 0);
            this.panelMain.ResumeLayout(false);
            this.panelTodayEvents.ResumeLayout(false);
            this.panelTodayEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private GMap.NET.WindowsForms.GMapControl gMapControlEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCurrentLocation;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panelTodayEvents;
    }
}