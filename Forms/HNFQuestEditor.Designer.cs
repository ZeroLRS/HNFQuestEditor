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
            this.lblLevelSelect = new System.Windows.Forms.Label();
            this.drpLevelSelect = new System.Windows.Forms.ComboBox();
            this.lblSpawner0 = new System.Windows.Forms.Label();
            this.drpSpawner0 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSpawner1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblSpawner2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblSpawner3 = new System.Windows.Forms.Label();
            this.txtQuestDescription = new System.Windows.Forms.TextBox();
            this.lblCurrencyReward = new System.Windows.Forms.Label();
            this.numCurrencyReward = new System.Windows.Forms.NumericUpDown();
            this.drpQuestType = new System.Windows.Forms.ComboBox();
            this.drpTarget = new System.Windows.Forms.ComboBox();
            this.lblQuestType = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.numTargetCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.imgLevelPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrencyReward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetCount)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLevelPicture
            // 
            this.imgLevelPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLevelPicture.BackgroundImage")));
            this.imgLevelPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgLevelPicture.Location = new System.Drawing.Point(17, 12);
            this.imgLevelPicture.Name = "imgLevelPicture";
            this.imgLevelPicture.Size = new System.Drawing.Size(355, 171);
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
            // lblLevelSelect
            // 
            this.lblLevelSelect.AutoSize = true;
            this.lblLevelSelect.Location = new System.Drawing.Point(14, 417);
            this.lblLevelSelect.Name = "lblLevelSelect";
            this.lblLevelSelect.Size = new System.Drawing.Size(36, 13);
            this.lblLevelSelect.TabIndex = 5;
            this.lblLevelSelect.Text = "Level:";
            // 
            // drpLevelSelect
            // 
            this.drpLevelSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpLevelSelect.FormattingEnabled = true;
            this.drpLevelSelect.Items.AddRange(new object[] {
            "-----------------",
            "Abyssal Depths",
            "Coral Reefs",
            "Deep Ocean",
            "Ship Wreck"});
            this.drpLevelSelect.Location = new System.Drawing.Point(112, 414);
            this.drpLevelSelect.Name = "drpLevelSelect";
            this.drpLevelSelect.Size = new System.Drawing.Size(260, 21);
            this.drpLevelSelect.TabIndex = 6;
            this.drpLevelSelect.SelectedIndexChanged += new System.EventHandler(this.drpLevelSelect_SelectedIndexChanged);
            // 
            // lblSpawner0
            // 
            this.lblSpawner0.AutoSize = true;
            this.lblSpawner0.Location = new System.Drawing.Point(14, 444);
            this.lblSpawner0.Name = "lblSpawner0";
            this.lblSpawner0.Size = new System.Drawing.Size(80, 13);
            this.lblSpawner0.TabIndex = 7;
            this.lblSpawner0.Text = "Cave Spawner:";
            // 
            // drpSpawner0
            // 
            this.drpSpawner0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpSpawner0.FormattingEnabled = true;
            this.drpSpawner0.Items.AddRange(new object[] {
            "-----------------",
            "Rainbow Fish",
            "Barracuda",
            "Juice Box Hero",
            "Humuhumunukunukuapua\'a"});
            this.drpSpawner0.Location = new System.Drawing.Point(112, 441);
            this.drpSpawner0.Name = "drpSpawner0";
            this.drpSpawner0.Size = new System.Drawing.Size(260, 21);
            this.drpSpawner0.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "-----------------",
            "Rainbow Fish",
            "Barracuda",
            "Juice Box Hero",
            "Humuhumunukunukuapua\'a"});
            this.comboBox1.Location = new System.Drawing.Point(112, 468);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // lblSpawner1
            // 
            this.lblSpawner1.AutoSize = true;
            this.lblSpawner1.Location = new System.Drawing.Point(14, 471);
            this.lblSpawner1.Name = "lblSpawner1";
            this.lblSpawner1.Size = new System.Drawing.Size(88, 13);
            this.lblSpawner1.TabIndex = 9;
            this.lblSpawner1.Text = "Coral Spawner 1:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "-----------------",
            "Rainbow Fish",
            "Barracuda",
            "Juice Box Hero",
            "Humuhumunukunukuapua\'a"});
            this.comboBox2.Location = new System.Drawing.Point(112, 495);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(260, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // lblSpawner2
            // 
            this.lblSpawner2.AutoSize = true;
            this.lblSpawner2.Location = new System.Drawing.Point(14, 498);
            this.lblSpawner2.Name = "lblSpawner2";
            this.lblSpawner2.Size = new System.Drawing.Size(88, 13);
            this.lblSpawner2.TabIndex = 11;
            this.lblSpawner2.Text = "Coral Spawner 2:";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "-----------------",
            "Rainbow Fish",
            "Barracuda",
            "Juice Box Hero",
            "Humuhumunukunukuapua\'a"});
            this.comboBox3.Location = new System.Drawing.Point(112, 522);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(260, 21);
            this.comboBox3.TabIndex = 14;
            // 
            // lblSpawner3
            // 
            this.lblSpawner3.AutoSize = true;
            this.lblSpawner3.Location = new System.Drawing.Point(14, 525);
            this.lblSpawner3.Name = "lblSpawner3";
            this.lblSpawner3.Size = new System.Drawing.Size(88, 13);
            this.lblSpawner3.TabIndex = 13;
            this.lblSpawner3.Text = "Coral Spawner 3:";
            // 
            // txtQuestDescription
            // 
            this.txtQuestDescription.Location = new System.Drawing.Point(17, 228);
            this.txtQuestDescription.Multiline = true;
            this.txtQuestDescription.Name = "txtQuestDescription";
            this.txtQuestDescription.Size = new System.Drawing.Size(355, 100);
            this.txtQuestDescription.TabIndex = 4;
            // 
            // lblCurrencyReward
            // 
            this.lblCurrencyReward.AutoSize = true;
            this.lblCurrencyReward.Location = new System.Drawing.Point(14, 336);
            this.lblCurrencyReward.Name = "lblCurrencyReward";
            this.lblCurrencyReward.Size = new System.Drawing.Size(92, 13);
            this.lblCurrencyReward.TabIndex = 15;
            this.lblCurrencyReward.Text = "Currency Reward:";
            // 
            // numCurrencyReward
            // 
            this.numCurrencyReward.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCurrencyReward.Location = new System.Drawing.Point(112, 334);
            this.numCurrencyReward.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numCurrencyReward.Name = "numCurrencyReward";
            this.numCurrencyReward.Size = new System.Drawing.Size(94, 20);
            this.numCurrencyReward.TabIndex = 16;
            this.numCurrencyReward.ThousandsSeparator = true;
            // 
            // drpQuestType
            // 
            this.drpQuestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpQuestType.FormattingEnabled = true;
            this.drpQuestType.Items.AddRange(new object[] {
            "-----------------",
            "Capture",
            "Slay"});
            this.drpQuestType.Location = new System.Drawing.Point(112, 360);
            this.drpQuestType.Name = "drpQuestType";
            this.drpQuestType.Size = new System.Drawing.Size(94, 21);
            this.drpQuestType.TabIndex = 17;
            // 
            // drpTarget
            // 
            this.drpTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpTarget.FormattingEnabled = true;
            this.drpTarget.Items.AddRange(new object[] {
            "-----------------",
            "Rainbow Fish",
            "Barracuda",
            "Juice Box Hero",
            "Humuhumunukunukuapua\'a"});
            this.drpTarget.Location = new System.Drawing.Point(112, 387);
            this.drpTarget.Name = "drpTarget";
            this.drpTarget.Size = new System.Drawing.Size(260, 21);
            this.drpTarget.TabIndex = 18;
            // 
            // lblQuestType
            // 
            this.lblQuestType.AutoSize = true;
            this.lblQuestType.Location = new System.Drawing.Point(14, 363);
            this.lblQuestType.Name = "lblQuestType";
            this.lblQuestType.Size = new System.Drawing.Size(65, 13);
            this.lblQuestType.TabIndex = 19;
            this.lblQuestType.Text = "Quest Type:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(14, 390);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(72, 13);
            this.lblTarget.TabIndex = 20;
            this.lblTarget.Text = "Quest Target:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(212, 363);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(38, 13);
            this.lblCount.TabIndex = 21;
            this.lblCount.Text = "Count:";
            // 
            // numTargetCount
            // 
            this.numTargetCount.Location = new System.Drawing.Point(256, 361);
            this.numTargetCount.Name = "numTargetCount";
            this.numTargetCount.Size = new System.Drawing.Size(63, 20);
            this.numTargetCount.TabIndex = 22;
            // 
            // frmHNFQE
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 562);
            this.Controls.Add(this.numTargetCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblQuestType);
            this.Controls.Add(this.drpTarget);
            this.Controls.Add(this.drpQuestType);
            this.Controls.Add(this.numCurrencyReward);
            this.Controls.Add(this.lblCurrencyReward);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.lblSpawner3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblSpawner2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSpawner1);
            this.Controls.Add(this.drpSpawner0);
            this.Controls.Add(this.lblSpawner0);
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
            ((System.ComponentModel.ISupportInitialize)(this.numCurrencyReward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLevelPicture;
        private System.Windows.Forms.Label lblQuestName;
        private System.Windows.Forms.TextBox txtQuestName;
        private System.Windows.Forms.Label lblQuestDescription;
        private System.Windows.Forms.Label lblLevelSelect;
        private System.Windows.Forms.ComboBox drpLevelSelect;
        private System.Windows.Forms.Label lblSpawner0;
        private System.Windows.Forms.ComboBox drpSpawner0;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSpawner1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblSpawner2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblSpawner3;
        private System.Windows.Forms.TextBox txtQuestDescription;
        private System.Windows.Forms.Label lblCurrencyReward;
        private System.Windows.Forms.NumericUpDown numCurrencyReward;
        private System.Windows.Forms.ComboBox drpQuestType;
        private System.Windows.Forms.ComboBox drpTarget;
        private System.Windows.Forms.Label lblQuestType;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.NumericUpDown numTargetCount;
    }
}

