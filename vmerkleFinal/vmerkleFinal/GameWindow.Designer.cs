
namespace vmerkleFinal
{
    partial class GameWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.clericPic = new System.Windows.Forms.PictureBox();
            this.magePic = new System.Windows.Forms.PictureBox();
            this.fighterPic = new System.Windows.Forms.PictureBox();
            this.clericActionCB = new System.Windows.Forms.ComboBox();
            this.mageActionCB = new System.Windows.Forms.ComboBox();
            this.fighterActionCB = new System.Windows.Forms.ComboBox();
            this.mageActionLabel = new System.Windows.Forms.Label();
            this.clericActionLabel = new System.Windows.Forms.Label();
            this.fighterActionLabel = new System.Windows.Forms.Label();
            this.turnResultTB = new System.Windows.Forms.TextBox();
            this.enemyPB = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.startTurnButton = new System.Windows.Forms.Button();
            this.clericHealthLabel = new System.Windows.Forms.Label();
            this.mageHealthLabel = new System.Windows.Forms.Label();
            this.fighterHealthLabel = new System.Windows.Forms.Label();
            this.monsterHealthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clericPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fighterPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPB)).BeginInit();
            this.SuspendLayout();
            // 
            // clericPic
            // 
            this.clericPic.BackColor = System.Drawing.Color.Transparent;
            this.clericPic.BackgroundImage = global::vmerkleFinal.Properties.Resources.Cleric;
            this.clericPic.Location = new System.Drawing.Point(91, 72);
            this.clericPic.Name = "clericPic";
            this.clericPic.Size = new System.Drawing.Size(61, 66);
            this.clericPic.TabIndex = 12;
            this.clericPic.TabStop = false;
            // 
            // magePic
            // 
            this.magePic.BackColor = System.Drawing.Color.Transparent;
            this.magePic.BackgroundImage = global::vmerkleFinal.Properties.Resources.Mage;
            this.magePic.Location = new System.Drawing.Point(217, 72);
            this.magePic.Name = "magePic";
            this.magePic.Size = new System.Drawing.Size(64, 66);
            this.magePic.TabIndex = 13;
            this.magePic.TabStop = false;
            // 
            // fighterPic
            // 
            this.fighterPic.BackColor = System.Drawing.Color.Transparent;
            this.fighterPic.BackgroundImage = global::vmerkleFinal.Properties.Resources.Fighter;
            this.fighterPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fighterPic.Location = new System.Drawing.Point(337, 72);
            this.fighterPic.Name = "fighterPic";
            this.fighterPic.Size = new System.Drawing.Size(58, 66);
            this.fighterPic.TabIndex = 14;
            this.fighterPic.TabStop = false;
            // 
            // clericActionCB
            // 
            this.clericActionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clericActionCB.FormattingEnabled = true;
            this.clericActionCB.ItemHeight = 20;
            this.clericActionCB.Location = new System.Drawing.Point(91, 241);
            this.clericActionCB.Name = "clericActionCB";
            this.clericActionCB.Size = new System.Drawing.Size(304, 28);
            this.clericActionCB.TabIndex = 9;
            // 
            // mageActionCB
            // 
            this.mageActionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mageActionCB.FormattingEnabled = true;
            this.mageActionCB.ItemHeight = 20;
            this.mageActionCB.Location = new System.Drawing.Point(91, 322);
            this.mageActionCB.Name = "mageActionCB";
            this.mageActionCB.Size = new System.Drawing.Size(304, 28);
            this.mageActionCB.TabIndex = 15;
            // 
            // fighterActionCB
            // 
            this.fighterActionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fighterActionCB.FormattingEnabled = true;
            this.fighterActionCB.ItemHeight = 20;
            this.fighterActionCB.Location = new System.Drawing.Point(91, 397);
            this.fighterActionCB.Name = "fighterActionCB";
            this.fighterActionCB.Size = new System.Drawing.Size(304, 28);
            this.fighterActionCB.TabIndex = 16;
            // 
            // mageActionLabel
            // 
            this.mageActionLabel.AutoSize = true;
            this.mageActionLabel.BackColor = System.Drawing.Color.Transparent;
            this.mageActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mageActionLabel.ForeColor = System.Drawing.Color.White;
            this.mageActionLabel.Location = new System.Drawing.Point(195, 299);
            this.mageActionLabel.Name = "mageActionLabel";
            this.mageActionLabel.Size = new System.Drawing.Size(113, 20);
            this.mageActionLabel.TabIndex = 17;
            this.mageActionLabel.Text = "Mage Action";
            // 
            // clericActionLabel
            // 
            this.clericActionLabel.AutoSize = true;
            this.clericActionLabel.BackColor = System.Drawing.Color.Transparent;
            this.clericActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clericActionLabel.ForeColor = System.Drawing.Color.White;
            this.clericActionLabel.Location = new System.Drawing.Point(195, 218);
            this.clericActionLabel.Name = "clericActionLabel";
            this.clericActionLabel.Size = new System.Drawing.Size(118, 20);
            this.clericActionLabel.TabIndex = 18;
            this.clericActionLabel.Text = "Cleric Action";
            // 
            // fighterActionLabel
            // 
            this.fighterActionLabel.AutoSize = true;
            this.fighterActionLabel.BackColor = System.Drawing.Color.Transparent;
            this.fighterActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fighterActionLabel.ForeColor = System.Drawing.Color.White;
            this.fighterActionLabel.Location = new System.Drawing.Point(181, 374);
            this.fighterActionLabel.Name = "fighterActionLabel";
            this.fighterActionLabel.Size = new System.Drawing.Size(127, 20);
            this.fighterActionLabel.TabIndex = 19;
            this.fighterActionLabel.Text = "Fighter Action";
            // 
            // turnResultTB
            // 
            this.turnResultTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.turnResultTB.Location = new System.Drawing.Point(507, 218);
            this.turnResultTB.Multiline = true;
            this.turnResultTB.Name = "turnResultTB";
            this.turnResultTB.ReadOnly = true;
            this.turnResultTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.turnResultTB.Size = new System.Drawing.Size(427, 132);
            this.turnResultTB.TabIndex = 10;
            // 
            // enemyPB
            // 
            this.enemyPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enemyPB.BackColor = System.Drawing.Color.Transparent;
            this.enemyPB.InitialImage = global::vmerkleFinal.Properties.Resources.Bandit;
            this.enemyPB.Location = new System.Drawing.Point(670, 86);
            this.enemyPB.Margin = new System.Windows.Forms.Padding(4);
            this.enemyPB.Name = "enemyPB";
            this.enemyPB.Size = new System.Drawing.Size(58, 66);
            this.enemyPB.TabIndex = 21;
            this.enemyPB.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Bandit.png");
            this.imageList1.Images.SetKeyName(1, "Cleric.png");
            this.imageList1.Images.SetKeyName(2, "Dragon.png");
            this.imageList1.Images.SetKeyName(3, "Fighter.png");
            this.imageList1.Images.SetKeyName(4, "Mage.png");
            this.imageList1.Images.SetKeyName(5, "Ogre.png");
            // 
            // startTurnButton
            // 
            this.startTurnButton.Location = new System.Drawing.Point(507, 374);
            this.startTurnButton.Name = "startTurnButton";
            this.startTurnButton.Size = new System.Drawing.Size(426, 51);
            this.startTurnButton.TabIndex = 22;
            this.startTurnButton.Text = "Attack!";
            this.startTurnButton.UseVisualStyleBackColor = true;
            this.startTurnButton.Click += new System.EventHandler(this.startTurnButton_Click);
            // 
            // clericHealthLabel
            // 
            this.clericHealthLabel.AutoSize = true;
            this.clericHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.clericHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clericHealthLabel.ForeColor = System.Drawing.Color.White;
            this.clericHealthLabel.Location = new System.Drawing.Point(91, 173);
            this.clericHealthLabel.Name = "clericHealthLabel";
            this.clericHealthLabel.Size = new System.Drawing.Size(0, 16);
            this.clericHealthLabel.TabIndex = 23;
            // 
            // mageHealthLabel
            // 
            this.mageHealthLabel.AutoSize = true;
            this.mageHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.mageHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mageHealthLabel.ForeColor = System.Drawing.Color.White;
            this.mageHealthLabel.Location = new System.Drawing.Point(217, 173);
            this.mageHealthLabel.Name = "mageHealthLabel";
            this.mageHealthLabel.Size = new System.Drawing.Size(0, 16);
            this.mageHealthLabel.TabIndex = 24;
            // 
            // fighterHealthLabel
            // 
            this.fighterHealthLabel.AutoSize = true;
            this.fighterHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.fighterHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fighterHealthLabel.ForeColor = System.Drawing.Color.White;
            this.fighterHealthLabel.Location = new System.Drawing.Point(337, 173);
            this.fighterHealthLabel.Name = "fighterHealthLabel";
            this.fighterHealthLabel.Size = new System.Drawing.Size(0, 16);
            this.fighterHealthLabel.TabIndex = 25;
            // 
            // monsterHealthLabel
            // 
            this.monsterHealthLabel.AutoSize = true;
            this.monsterHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.monsterHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monsterHealthLabel.ForeColor = System.Drawing.Color.White;
            this.monsterHealthLabel.Location = new System.Drawing.Point(670, 173);
            this.monsterHealthLabel.Name = "monsterHealthLabel";
            this.monsterHealthLabel.Size = new System.Drawing.Size(0, 16);
            this.monsterHealthLabel.TabIndex = 26;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vmerkleFinal.Properties.Resources.stone;
            this.ClientSize = new System.Drawing.Size(1020, 473);
            this.Controls.Add(this.monsterHealthLabel);
            this.Controls.Add(this.fighterHealthLabel);
            this.Controls.Add(this.mageHealthLabel);
            this.Controls.Add(this.clericHealthLabel);
            this.Controls.Add(this.startTurnButton);
            this.Controls.Add(this.enemyPB);
            this.Controls.Add(this.turnResultTB);
            this.Controls.Add(this.fighterActionLabel);
            this.Controls.Add(this.clericActionLabel);
            this.Controls.Add(this.mageActionLabel);
            this.Controls.Add(this.fighterActionCB);
            this.Controls.Add(this.mageActionCB);
            this.Controls.Add(this.clericActionCB);
            this.Controls.Add(this.fighterPic);
            this.Controls.Add(this.magePic);
            this.Controls.Add(this.clericPic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finals Fantasy";
            ((System.ComponentModel.ISupportInitialize)(this.clericPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fighterPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox clericPic;
        private System.Windows.Forms.PictureBox magePic;
        private System.Windows.Forms.PictureBox fighterPic;
        private System.Windows.Forms.ComboBox clericActionCB;
        private System.Windows.Forms.ComboBox mageActionCB;
        private System.Windows.Forms.ComboBox fighterActionCB;
        private System.Windows.Forms.Label mageActionLabel;
        private System.Windows.Forms.Label clericActionLabel;
        private System.Windows.Forms.Label fighterActionLabel;
        private System.Windows.Forms.PictureBox enemyPB;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button startTurnButton;
        private System.Windows.Forms.Label clericHealthLabel;
        private System.Windows.Forms.Label mageHealthLabel;
        private System.Windows.Forms.Label fighterHealthLabel;
        private System.Windows.Forms.Label monsterHealthLabel;
        public System.Windows.Forms.TextBox turnResultTB;
    }
}