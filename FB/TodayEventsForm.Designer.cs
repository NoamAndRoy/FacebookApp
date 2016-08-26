﻿namespace FB
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCurrentLocation = new System.Windows.Forms.TextBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.gMapControlEvents = new GMap.NET.WindowsForms.GMapControl();
            this.panelMain.SuspendLayout();
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
            this.panelMain.Controls.Add(this.buttonSearch);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.textBoxCurrentLocation);
            this.panelMain.Controls.Add(this.listBoxEvents);
            this.panelMain.Controls.Add(this.gMapControlEvents);
            this.panelMain.Location = new System.Drawing.Point(208, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(656, 627);
            this.panelMain.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(355, 106);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your current location:";
            // 
            // textBoxCurrentLocation
            // 
            this.textBoxCurrentLocation.Location = new System.Drawing.Point(304, 74);
            this.textBoxCurrentLocation.Name = "textBoxCurrentLocation";
            this.textBoxCurrentLocation.Size = new System.Drawing.Size(126, 20);
            this.textBoxCurrentLocation.TabIndex = 3;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(26, 45);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(120, 95);
            this.listBoxEvents.TabIndex = 2;
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
            this.gMapControlEvents.Location = new System.Drawing.Point(0, 323);
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
            this.gMapControlEvents.Size = new System.Drawing.Size(439, 301);
            this.gMapControlEvents.TabIndex = 1;
            this.gMapControlEvents.Zoom = 2D;
            // 
            // TodayEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 627);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(666, 895);
            this.MinimumSize = new System.Drawing.Size(666, 548);
            this.Name = "TodayEventsForm";
            this.Text = "MosaicCreatorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TodayEventsForm_FormClosing);
            this.Load += new System.EventHandler(this.TodayEventsForm_Load);
            this.Controls.SetChildIndex(this.panelMain, 0);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private GMap.NET.WindowsForms.GMapControl gMapControlEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCurrentLocation;
        private System.Windows.Forms.Button buttonSearch;
    }
}