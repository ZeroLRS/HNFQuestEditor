namespace HNFQuestEditor
{
    partial class frmHNFQE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHNFQE));
            this.imgLevelPicture = new System.Windows.Forms.PictureBox();
            this.lblQuestName = new System.Windows.Forms.Label();
            this.txtQuestName = new System.Windows.Forms.TextBox();
            this.lblQuestDescription = new System.Windows.Forms.Label();
            this.txtQuestDescription = new System.Windows.Forms.TextBox();
            this.lblLevelSelect = new System.Windows.Forms.Label();
            this.drpLevelSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLevelPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLevelPicture
            // 
            this.imgLevelPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLevelPicture.BackgroundImage")));
            this.imgLevelPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgLevelPicture.Location = new System.Drawing.Point(13, 13);
            this.imgLevelPicture.Name = "imgLevelPicture";
            this.imgLevelPicture.Size = new System.Drawing.Size(359, 169);
            this.imgLevelPicture.TabIndex = 0;
            this.imgLevelPicture.TabStop = false;
            // 
            // lblQuestName
            // 
            this.lblQuestName.AutoSize = true;
            this.lblQuestName.Location = new System.Drawing.Point(14, 192);
            this.lblQuestName.Name = "lblQuestName";
            this.lblQuestName.Size = new System.Drawing.Size(69, 13);
            this.lblQuestName.TabIndex = 1;
            this.lblQuestName.Text = "Quest Name:";
            // 
            // txtQuestName
            // 
            this.txtQuestName.Location = new System.Drawing.Point(89, 189);
            this.txtQuestName.Name = "txtQuestName";
            this.txtQuestName.Size = new System.Drawing.Size(283, 20);
            this.txtQuestName.TabIndex = 2;
            // 
            // lblQuestDescription
            // 
            this.lblQuestDescription.AutoSize = true;
            this.lblQuestDescription.Location = new System.Drawing.Point(14, 212);
            this.lblQuestDescription.Name = "lblQuestDescription";
            this.lblQuestDescription.Size = new System.Drawing.Size(94, 13);
            this.lblQuestDescription.TabIndex = 3;
            this.lblQuestDescription.Text = "Quest Description:";
            // 
            // txtQuestDescription
            // 
            this.txtQuestDescription.Location = new System.Drawing.Point(17, 228);
            this.txtQuestDescription.Multiline = true;
            this.txtQuestDescription.Name = "txtQuestDescription";
            this.txtQuestDescription.Size = new System.Drawing.Size(355, 100);
            this.txtQuestDescription.TabIndex = 4;
            // 
            // lblLevelSelect
            // 
            this.lblLevelSelect.AutoSize = true;
            this.lblLevelSelect.Location = new System.Drawing.Point(14, 337);
            this.lblLevelSelect.Name = "lblLevelSelect";
            this.lblLevelSelect.Size = new System.Drawing.Size(36, 13);
            this.lblLevelSelect.TabIndex = 5;
            this.lblLevelSelect.Text = "Level:";
            // 
            // drpLevelSelect
            // 
            this.drpLevelSelect.FormattingEnabled = true;
            this.drpLevelSelect.Items.AddRange(new object[] {
            "-----------------",
            "Abyssal Depths",
            "Coral Reefs",
            "Deep Ocean",
            "Ship Wreck"});
            this.drpLevelSelect.Location = new System.Drawing.Point(57, 335);
            this.drpLevelSelect.Name = "drpLevelSelect";
            this.drpLevelSelect.Size = new System.Drawing.Size(160, 21);
            this.drpLevelSelect.TabIndex = 6;
            this.drpLevelSelect.SelectedIndexChanged += new System.EventHandler(this.drpLevelSelect_SelectedIndexChanged);
            // 
            // frmHNFQE
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 562);
            this.Controls.Add(this.drpLevelSelect);
            this.Controls.Add(this.lblLevelSelect);
            this.Controls.Add(this.txtQuestDescription);
            this.Controls.Add(this.lblQuestDescription);
            this.Controls.Add(this.txtQuestName);
            this.Controls.Add(this.lblQuestName);
            this.Controls.Add(this.imgLevelPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "frmHNFQE";
            this.Text = "HNF Quest Editor";
            this.Load += new System.EventHandler(this.frmHNFQE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLevelPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLevelPicture;
        private System.Windows.Forms.Label lblQuestName;
        private System.Windows.Forms.TextBox txtQuestName;
        private System.Windows.Forms.Label lblQuestDescription;
        private System.Windows.Forms.TextBox txtQuestDescription;
        private System.Windows.Forms.Label lblLevelSelect;
        private System.Windows.Forms.ComboBox drpLevelSelect;
    }
}

