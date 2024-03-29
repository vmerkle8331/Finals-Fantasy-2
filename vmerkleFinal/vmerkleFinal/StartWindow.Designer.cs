
namespace vmerkleFinal
{
    partial class StartWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.clericPic = new System.Windows.Forms.PictureBox();
            this.magePic = new System.Windows.Forms.PictureBox();
            this.fighterPic = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clericPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fighterPic)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.titleLabel.Location = new System.Drawing.Point(227, 244);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(365, 58);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Finals Fantasy";
            // 
            // clericPic
            // 
            this.clericPic.BackColor = System.Drawing.Color.Transparent;
            this.clericPic.BackgroundImage = global::vmerkleFinal.Properties.Resources.Cleric;
            this.clericPic.Location = new System.Drawing.Point(227, 140);
            this.clericPic.Name = "clericPic";
            this.clericPic.Size = new System.Drawing.Size(61, 66);
            this.clericPic.TabIndex = 11;
            this.clericPic.TabStop = false;
            // 
            // magePic
            // 
            this.magePic.BackColor = System.Drawing.Color.Transparent;
            this.magePic.BackgroundImage = global::vmerkleFinal.Properties.Resources.Mage;
            this.magePic.Location = new System.Drawing.Point(380, 140);
            this.magePic.Name = "magePic";
            this.magePic.Size = new System.Drawing.Size(64, 66);
            this.magePic.TabIndex = 12;
            this.magePic.TabStop = false;
            // 
            // fighterPic
            // 
            this.fighterPic.BackColor = System.Drawing.Color.Transparent;
            this.fighterPic.BackgroundImage = global::vmerkleFinal.Properties.Resources.Fighter;
            this.fighterPic.Location = new System.Drawing.Point(534, 140);
            this.fighterPic.Name = "fighterPic";
            this.fighterPic.Size = new System.Drawing.Size(58, 66);
            this.fighterPic.TabIndex = 13;
            this.fighterPic.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(227, 365);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(364, 30);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "FIGHT!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(227, 427);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(364, 30);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vmerkleFinal.Properties.Resources.stone;
            this.ClientSize = new System.Drawing.Size(820, 572);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.fighterPic);
            this.Controls.Add(this.magePic);
            this.Controls.Add(this.clericPic);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finals Fantasy";
            ((System.ComponentModel.ISupportInitialize)(this.clericPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fighterPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox clericPic;
        private System.Windows.Forms.PictureBox magePic;
        private System.Windows.Forms.PictureBox fighterPic;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
    }
}

