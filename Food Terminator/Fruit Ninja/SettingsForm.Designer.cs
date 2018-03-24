namespace Fruit_Ninja
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.pbEasy = new System.Windows.Forms.PictureBox();
            this.pbMedium = new System.Windows.Forms.PictureBox();
            this.pbHard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHard)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEasy
            // 
            this.pbEasy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEasy.BackColor = System.Drawing.Color.Transparent;
            this.pbEasy.Image = global::Fruit_Ninja.Properties.Resources.easy;
            this.pbEasy.Location = new System.Drawing.Point(109, 0);
            this.pbEasy.Name = "pbEasy";
            this.pbEasy.Size = new System.Drawing.Size(293, 651);
            this.pbEasy.TabIndex = 9;
            this.pbEasy.TabStop = false;
            this.pbEasy.Click += new System.EventHandler(this.pbEasy_Click);
            // 
            // pbMedium
            // 
            this.pbMedium.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMedium.BackColor = System.Drawing.Color.Transparent;
            this.pbMedium.Image = global::Fruit_Ninja.Properties.Resources.medium;
            this.pbMedium.Location = new System.Drawing.Point(770, 0);
            this.pbMedium.Name = "pbMedium";
            this.pbMedium.Size = new System.Drawing.Size(253, 447);
            this.pbMedium.TabIndex = 10;
            this.pbMedium.TabStop = false;
            this.pbMedium.Click += new System.EventHandler(this.pbMedium_Click);
            // 
            // pbHard
            // 
            this.pbHard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHard.BackColor = System.Drawing.Color.Transparent;
            this.pbHard.Image = global::Fruit_Ninja.Properties.Resources.hard;
            this.pbHard.Location = new System.Drawing.Point(1418, 0);
            this.pbHard.Name = "pbHard";
            this.pbHard.Size = new System.Drawing.Size(275, 651);
            this.pbHard.TabIndex = 11;
            this.pbHard.TabStop = false;
            this.pbHard.Click += new System.EventHandler(this.pbHard_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fruit_Ninja.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pbHard);
            this.Controls.Add(this.pbMedium);
            this.Controls.Add(this.pbEasy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pbEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbEasy;
        private System.Windows.Forms.PictureBox pbMedium;
        private System.Windows.Forms.PictureBox pbHard;
    }
}