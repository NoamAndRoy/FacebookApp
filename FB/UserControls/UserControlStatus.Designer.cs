namespace FB.UserControls
{
    public partial class UserControlStatus
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
            this.RichTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.ButtonSubmitStatus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // RichTextBoxStatus
            // 
            this.RichTextBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RichTextBoxStatus.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.RichTextBoxStatus.Location = new System.Drawing.Point(81, 15);
            this.RichTextBoxStatus.Margin = new System.Windows.Forms.Padding(0);
            this.RichTextBoxStatus.Name = "RichTextBoxStatus";
            this.RichTextBoxStatus.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextBoxStatus.Size = new System.Drawing.Size(646, 36);
            this.RichTextBoxStatus.TabIndex = 0;
            this.RichTextBoxStatus.Text = "What\'s on your mind?";
            this.RichTextBoxStatus.Enter += new System.EventHandler(this.richTextBoxStatus_Enter);
            this.RichTextBoxStatus.Leave += new System.EventHandler(this.richTextBoxStatus_Leave);
            // 
            // PictureBoxProfile
            // 
            this.PictureBoxProfile.Location = new System.Drawing.Point(20, 11);
            this.PictureBoxProfile.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxProfile.Name = "PictureBoxProfile";
            this.PictureBoxProfile.Size = new System.Drawing.Size(40, 40);
            this.PictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxProfile.TabIndex = 1;
            this.PictureBoxProfile.TabStop = false;
            // 
            // ButtonSubmitStatus
            // 
            this.ButtonSubmitStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ButtonSubmitStatus.FlatAppearance.BorderSize = 0;
            this.ButtonSubmitStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSubmitStatus.ForeColor = System.Drawing.Color.White;
            this.ButtonSubmitStatus.Location = new System.Drawing.Point(667, 85);
            this.ButtonSubmitStatus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.ButtonSubmitStatus.Name = "ButtonSubmitStatus";
            this.ButtonSubmitStatus.Size = new System.Drawing.Size(60, 24);
            this.ButtonSubmitStatus.TabIndex = 2;
            this.ButtonSubmitStatus.Text = "Post";
            this.ButtonSubmitStatus.UseVisualStyleBackColor = false;
            this.ButtonSubmitStatus.Click += new System.EventHandler(this.ButtonSubmitStatus_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 1);
            this.panel1.TabIndex = 3;
            // 
            // UserControlStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonSubmitStatus);
            this.Controls.Add(this.PictureBoxProfile);
            this.Controls.Add(this.RichTextBoxStatus);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlStatus";
            this.Size = new System.Drawing.Size(751, 117);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox PictureBoxProfile;
        public System.Windows.Forms.Button ButtonSubmitStatus;
        public System.Windows.Forms.RichTextBox RichTextBoxStatus;
    }
}
