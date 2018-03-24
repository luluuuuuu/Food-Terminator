namespace Fruit_Ninja
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.pbHighscores = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.pbPause = new System.Windows.Forms.PictureBox();
            this.pbUnpause = new System.Windows.Forms.PictureBox();
            this.pbQuit = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbGameOver = new System.Windows.Forms.PictureBox();
            this.pbAgain = new System.Windows.Forms.PictureBox();
            this.pbReturn = new System.Windows.Forms.PictureBox();
            this.panelGame = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHighscores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnpause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.panelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.89543F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.89543F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.89543F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36598F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.94772F));
            this.tableLayoutPanel1.Controls.Add(this.pbPlay, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbHighscores, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbExit, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUser, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1920, 1080);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // pbPlay
            // 
            this.pbPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPlay.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.pbPlay, 2);
            this.pbPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPlay.Image = global::Fruit_Ninja.Properties.Resources.play2;
            this.pbPlay.Location = new System.Drawing.Point(462, 652);
            this.pbPlay.Margin = new System.Windows.Forms.Padding(4);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(908, 208);
            this.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlay.TabIndex = 5;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.pbPlay_Click);
            this.pbPlay.MouseHover += new System.EventHandler(this.pbPlay_MouseHover);
            // 
            // pbHighscores
            // 
            this.pbHighscores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHighscores.BackColor = System.Drawing.Color.Transparent;
            this.pbHighscores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHighscores.Image = global::Fruit_Ninja.Properties.Resources.trophy;
            this.pbHighscores.Location = new System.Drawing.Point(4, 652);
            this.pbHighscores.Margin = new System.Windows.Forms.Padding(4);
            this.pbHighscores.Name = "pbHighscores";
            this.tableLayoutPanel1.SetRowSpan(this.pbHighscores, 2);
            this.pbHighscores.Size = new System.Drawing.Size(450, 424);
            this.pbHighscores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHighscores.TabIndex = 4;
            this.pbHighscores.TabStop = false;
            this.pbHighscores.Click += new System.EventHandler(this.pbHighscores_Click);
            this.pbHighscores.MouseHover += new System.EventHandler(this.pbHighscores_MouseHover);
            // 
            // pbExit
            // 
            this.pbExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::Fruit_Ninja.Properties.Resources.exit2;
            this.pbExit.Location = new System.Drawing.Point(1721, 61);
            this.pbExit.Margin = new System.Windows.Forms.Padding(4);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(166, 151);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 8;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseHover += new System.EventHandler(this.pbExit_MouseHover);
            // 
            // pbUser
            // 
            this.pbUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbUser.BackColor = System.Drawing.Color.Transparent;
            this.pbUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUser.Image = global::Fruit_Ninja.Properties.Resources.user;
            this.pbUser.Location = new System.Drawing.Point(4, 30);
            this.pbUser.Margin = new System.Windows.Forms.Padding(4);
            this.pbUser.Name = "pbUser";
            this.pbUser.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.pbUser.Size = new System.Drawing.Size(150, 155);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 7;
            this.pbUser.TabStop = false;
            this.pbUser.Click += new System.EventHandler(this.pbUser_Click);
            this.pbUser.MouseHover += new System.EventHandler(this.pbUser_MouseHover);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(3, 216);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(101, 37);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "Guest";
            this.lblUser.TextChanged += new System.EventHandler(this.lblUser_TextChanged);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // timeTimer
            // 
            this.timeTimer.Interval = 1000;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // pbPause
            // 
            this.pbPause.BackColor = System.Drawing.Color.Transparent;
            this.pbPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPause.Image = global::Fruit_Ninja.Properties.Resources.pause;
            this.pbPause.Location = new System.Drawing.Point(0, 4);
            this.pbPause.Margin = new System.Windows.Forms.Padding(4);
            this.pbPause.Name = "pbPause";
            this.pbPause.Size = new System.Drawing.Size(52, 46);
            this.pbPause.TabIndex = 1;
            this.pbPause.TabStop = false;
            this.pbPause.Visible = false;
            this.pbPause.Click += new System.EventHandler(this.pbPause_Click);
            // 
            // pbUnpause
            // 
            this.pbUnpause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbUnpause.BackColor = System.Drawing.Color.Transparent;
            this.pbUnpause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUnpause.Image = global::Fruit_Ninja.Properties.Resources.unpaused;
            this.pbUnpause.Location = new System.Drawing.Point(790, 361);
            this.pbUnpause.Margin = new System.Windows.Forms.Padding(4);
            this.pbUnpause.Name = "pbUnpause";
            this.pbUnpause.Size = new System.Drawing.Size(350, 330);
            this.pbUnpause.TabIndex = 2;
            this.pbUnpause.TabStop = false;
            this.pbUnpause.Click += new System.EventHandler(this.pbUnpause_Click);
            // 
            // pbQuit
            // 
            this.pbQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbQuit.BackColor = System.Drawing.Color.Transparent;
            this.pbQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuit.Image = global::Fruit_Ninja.Properties.Resources.back;
            this.pbQuit.Location = new System.Drawing.Point(4, 1007);
            this.pbQuit.Margin = new System.Windows.Forms.Padding(4);
            this.pbQuit.Name = "pbQuit";
            this.pbQuit.Size = new System.Drawing.Size(87, 73);
            this.pbQuit.TabIndex = 3;
            this.pbQuit.TabStop = false;
            this.pbQuit.Click += new System.EventHandler(this.pbQuit_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Engravers MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(1644, 12);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(257, 84);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "01:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 62);
            this.label1.TabIndex = 7;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Engravers MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(1837, 996);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(83, 84);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "0";
            // 
            // pbGameOver
            // 
            this.pbGameOver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGameOver.Image = global::Fruit_Ninja.Properties.Resources.gameover;
            this.pbGameOver.Location = new System.Drawing.Point(561, 272);
            this.pbGameOver.Name = "pbGameOver";
            this.pbGameOver.Size = new System.Drawing.Size(900, 236);
            this.pbGameOver.TabIndex = 13;
            this.pbGameOver.TabStop = false;
            // 
            // pbAgain
            // 
            this.pbAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAgain.Image = global::Fruit_Ninja.Properties.Resources.again;
            this.pbAgain.Location = new System.Drawing.Point(477, 625);
            this.pbAgain.Name = "pbAgain";
            this.pbAgain.Size = new System.Drawing.Size(306, 306);
            this.pbAgain.TabIndex = 14;
            this.pbAgain.TabStop = false;
            this.pbAgain.Click += new System.EventHandler(this.pbAgain_Click);
            // 
            // pbReturn
            // 
            this.pbReturn.Image = global::Fruit_Ninja.Properties.Resources._new;
            this.pbReturn.Location = new System.Drawing.Point(1168, 625);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(305, 303);
            this.pbReturn.TabIndex = 15;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.Transparent;
            this.panelGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGame.Controls.Add(this.pbReturn);
            this.panelGame.Controls.Add(this.pbAgain);
            this.panelGame.Controls.Add(this.pbGameOver);
            this.panelGame.Controls.Add(this.lblScore);
            this.panelGame.Controls.Add(this.label1);
            this.panelGame.Controls.Add(this.lblTime);
            this.panelGame.Controls.Add(this.pbQuit);
            this.panelGame.Controls.Add(this.pbUnpause);
            this.panelGame.Controls.Add(this.pbPause);
            this.panelGame.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Margin = new System.Windows.Forms.Padding(4);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1920, 1080);
            this.panelGame.TabIndex = 12;
            this.panelGame.Visible = false;
            this.panelGame.Click += new System.EventHandler(this.panelGame_Click);
            this.panelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGame_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fruit_Ninja.Properties.Resources.mainpage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fruit Ninja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHighscores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnpause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbHighscores;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.PictureBox pbPause;
        private System.Windows.Forms.PictureBox pbUnpause;
        private System.Windows.Forms.PictureBox pbQuit;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbGameOver;
        private System.Windows.Forms.PictureBox pbAgain;
        private System.Windows.Forms.PictureBox pbReturn;
        public System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label lblUser;
    }
}

