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
            this.txtQuestDescription = new System.Windows.Forms.TextBox();
            this.lblCurrencyReward = new System.Windows.Forms.Label();
            this.numCurrencyReward = new System.Windows.Forms.NumericUpDown();
            this.drpQuestType = new System.Windows.Forms.ComboBox();
            this.drpTarget = new System.Windows.Forms.ComboBox();
            this.lblQuestType = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.numTargetCount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPrerequisite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLevelPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrencyReward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetCount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLevelPicture
            // 
            this.imgLevelPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLevelPicture.BackgroundImage")));
            this.imgLevelPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgLevelPicture.Enabled = false;
            this.imgLevelPicture.Location = new System.Drawing.Point(17, 27);
            this.imgLevelPicture.Name = "imgLevelPicture";
            this.imgLevelPicture.Size = new System.Drawing.Size(355, 171);
            this.imgLevelPicture.TabIndex = 0;
            this.imgLevelPicture.TabStop = false;
            // 
            // lblQuestName
            // 
            this.lblQuestName.AutoSize = true;
            this.lblQuestName.Location = new System.Drawing.Point(14, 207);
            this.lblQuestName.Name = "lblQuestName";
            this.lblQuestName.Size = new System.Drawing.Size(69, 13);
            this.lblQuestName.TabIndex = 1;
            this.lblQuestName.Text = "Quest Name:";
            // 
            // txtQuestName
            // 
            this.txtQuestName.Location = new System.Drawing.Point(89, 204);
            this.txtQuestName.Name = "txtQuestName";
            this.txtQuestName.Size = new System.Drawing.Size(283, 20);
            this.txtQuestName.TabIndex = 2;
            // 
            // lblQuestDescription
            // 
            this.lblQuestDescription.AutoSize = true;
            this.lblQuestDescription.Location = new System.Drawing.Point(14, 227);
            this.lblQuestDescription.Name = "lblQuestDescription";
            this.lblQuestDescription.Size = new System.Drawing.Size(94, 13);
            this.lblQuestDescription.TabIndex = 3;
            this.lblQuestDescription.Text = "Quest Description:";
            // 
            // lblLevelSelect
            // 
            this.lblLevelSelect.AutoSize = true;
            this.lblLevelSelect.Location = new System.Drawing.Point(14, 458);
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
            this.drpLevelSelect.Location = new System.Drawing.Point(112, 455);
            this.drpLevelSelect.Name = "drpLevelSelect";
            this.drpLevelSelect.Size = new System.Drawing.Size(260, 21);
            this.drpLevelSelect.TabIndex = 6;
            // 
            // lblSpawner0
            // 
            this.lblSpawner0.AutoSize = true;
            this.lblSpawner0.Location = new System.Drawing.Point(14, 485);
            this.lblSpawner0.Name = "lblSpawner0";
            this.lblSpawner0.Size = new System.Drawing.Size(80, 13);
            this.lblSpawner0.TabIndex = 7;
            this.lblSpawner0.Text = "Cave Spawner:";
            // 
            // txtQuestDescription
            // 
            this.txtQuestDescription.Location = new System.Drawing.Point(17, 243);
            this.txtQuestDescription.Multiline = true;
            this.txtQuestDescription.Name = "txtQuestDescription";
            this.txtQuestDescription.Size = new System.Drawing.Size(355, 100);
            this.txtQuestDescription.TabIndex = 4;
            // 
            // lblCurrencyReward
            // 
            this.lblCurrencyReward.AutoSize = true;
            this.lblCurrencyReward.Location = new System.Drawing.Point(14, 377);
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
            this.numCurrencyReward.Location = new System.Drawing.Point(112, 375);
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
            this.drpQuestType.Location = new System.Drawing.Point(112, 401);
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
            this.drpTarget.Location = new System.Drawing.Point(112, 428);
            this.drpTarget.Name = "drpTarget";
            this.drpTarget.Size = new System.Drawing.Size(260, 21);
            this.drpTarget.TabIndex = 18;
            // 
            // lblQuestType
            // 
            this.lblQuestType.AutoSize = true;
            this.lblQuestType.Location = new System.Drawing.Point(14, 404);
            this.lblQuestType.Name = "lblQuestType";
            this.lblQuestType.Size = new System.Drawing.Size(65, 13);
            this.lblQuestType.TabIndex = 19;
            this.lblQuestType.Text = "Quest Type:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(14, 431);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(72, 13);
            this.lblTarget.TabIndex = 20;
            this.lblTarget.Text = "Quest Target:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(212, 404);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(38, 13);
            this.lblCount.TabIndex = 21;
            this.lblCount.Text = "Count:";
            // 
            // numTargetCount
            // 
            this.numTargetCount.Location = new System.Drawing.Point(256, 402);
            this.numTargetCount.Name = "numTargetCount";
            this.numTargetCount.Size = new System.Drawing.Size(63, 20);
            this.numTargetCount.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 21);
            this.button1.TabIndex = 23;
            this.button1.Text = "Edit Spawner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnFileMenu
            // 
            this.btnFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnLoad});
            this.btnFileMenu.Name = "btnFileMenu";
            this.btnFileMenu.Size = new System.Drawing.Size(37, 20);
            this.btnFileMenu.Text = "File";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 22);
            this.btnSave.Text = "Save";
            // 
            // btnLoad
            // 
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(152, 22);
            this.btnLoad.Text = "Load";
            // 
            // txtPrerequisite
            // 
            this.txtPrerequisite.Location = new System.Drawing.Point(112, 349);
            this.txtPrerequisite.Name = "txtPrerequisite";
            this.txtPrerequisite.Size = new System.Drawing.Size(260, 20);
            this.txtPrerequisite.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Prerequisite:";
            // 
            // frmHNFQE
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrerequisite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numTargetCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblQuestType);
            this.Controls.Add(this.drpTarget);
            this.Controls.Add(this.drpQuestType);
            this.Controls.Add(this.numCurrencyReward);
            this.Controls.Add(this.lblCurrencyReward);
            this.Controls.Add(this.lblSpawner0);
            this.Controls.Add(this.drpLevelSelect);
            this.Controls.Add(this.lblLevelSelect);
            this.Controls.Add(this.txtQuestDescription);
            this.Controls.Add(this.lblQuestDescription);
            this.Controls.Add(this.txtQuestName);
            this.Controls.Add(this.lblQuestName);
            this.Controls.Add(this.imgLevelPicture);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "frmHNFQE";
            this.Text = "HNF Quest Editor";
            this.Load += new System.EventHandler(this.frmHNFQE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLevelPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrencyReward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetCount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
  private System.Windows.Forms.TextBox txtQuestDescription;
  private System.Windows.Forms.Label lblCurrencyReward;
  private System.Windows.Forms.NumericUpDown numCurrencyReward;
  private System.Windows.Forms.ComboBox drpQuestType;
  private System.Windows.Forms.ComboBox drpTarget;
  private System.Windows.Forms.Label lblQuestType;
  private System.Windows.Forms.Label lblTarget;
  private System.Windows.Forms.Label lblCount;
  private System.Windows.Forms.NumericUpDown numTargetCount;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnFileMenu;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnLoad;
        private System.Windows.Forms.TextBox txtPrerequisite;
        private System.Windows.Forms.Label label1;
    }
}
