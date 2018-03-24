using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.IO;

namespace Fruit_Ninja
{
    public partial class Main : Form
    {
        public static Settings settings;

        private CustomToolTip tip;
        public static User currentUser;
        public static Dictionary<string, User> users;
        public static List<Score> topScores;
        public Game game;
        public int ticks;
        public bool canClick;
        public string saveFile = Environment.CurrentDirectory + "\\save.txt";

        public Main()
        {
            InitializeComponent();
            Width = 1920;
            Height = 1080;
            SettingsForm.settings = new Settings(1920, 1080, "EASY");
            users = new Dictionary<string, User>();
            LoadFromFile();
            User u = new User("Guest");
            if (!users.ContainsKey("Guest"))
                users.Add("Guest", u);
            else
                foreach (User us in users.Values)
                    if (us.name.Equals("Guest"))
                    {
                        u = us;
                        break;
                    }
            currentUser = u;
            topScores = new List<Score>();
            DoubleBuffered = true;
            ticks = 0;
            canClick = false;

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            panelGame, new object[] { true });
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToFile();
        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
            game.Draw(e);
            lblTime.Text = string.Format("00:{0:00}", game.time);
        }

        private void pbHighscores_Click(object sender, EventArgs e)
        {
            HighscoresForm highscores = new HighscoresForm();
            highscores.ShowDialog();
        }

        private void pbUser_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            user.ShowDialog();
            lblUser.Text = currentUser.ToString();
        }

        private void pbPlay_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            if (settings.ShowDialog() == DialogResult.OK)
            {
                ActiveForm.Width = 1600;
                ActiveForm.Height = 1200;
                ReallyCenterToScreen();
            }
            newGame();
        }

        private void pbQuit_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            panelGame.Visible = false;
            ActiveForm.BackgroundImage = Properties.Resources._2013_08_28_105146;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void panelGame_Click(object sender, EventArgs e)
        {
            if (game.checkClick(PointToClient(Cursor.Position)))
                stopGame();
        }

        private void pbPlay_MouseHover(object sender, EventArgs e)
        {
            tip = new CustomToolTip(new Size(121, 48));
            tip.SetToolTip(pbPlay, "PLAY");
        }

        private void pbHighscores_MouseHover(object sender, EventArgs e)
        {
            tip = new CustomToolTip(new Size(312, 48));
            tip.SetToolTip(pbHighscores, "HALL OF FAME");
        }

        private void pbUser_MouseHover(object sender, EventArgs e)
        {
            tip = new CustomToolTip(new Size(121, 48));
            tip.SetToolTip(pbUser, "USER");
        }

        private void pbExit_MouseHover(object sender, EventArgs e)
        {
            tip = new CustomToolTip(new Size(121, 48));
            tip.SetToolTip(pbExit, "EXIT");
        }

        private void lblUser_TextChanged(object sender, EventArgs e)
        {
            if (lblUser.Text.Length > 9)
                lblUser.Font = new Font(lblUser.Font.FontFamily, 8);
            else if (lblUser.Text.Length > 6)
                lblUser.Font = new Font(lblUser.Font.FontFamily, 10);
            else
                lblUser.Font = new Font(lblUser.Font.FontFamily, 12);
        }

        private void pbUnpause_Click(object sender, EventArgs e)
        {
            canClick = true;
            pbUnpause.Visible = false;
            pbPause.Visible = true;
            pbQuit.Visible = false;
            pbGameOver.Visible = false;
            pbAgain.Visible = false;
            pbReturn.Visible = false;
            gameTimer.Start();
            timeTimer.Start();
        }

        private void pbPause_Click(object sender, EventArgs e)
        {
            canClick = false;
            pbUnpause.Visible = true;
            pbPause.Visible = false;
            pbQuit.Visible = true;
            pbGameOver.Visible = false;
            pbAgain.Visible = false;
            pbReturn.Visible = false;
            gameTimer.Stop();
            timeTimer.Stop();
        }

        private void pbAgain_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            panelGame.Visible = false;
            ActiveForm.BackgroundImage = Properties.Resources._2013_08_28_105146;
        }

        private void pbEasy_Click(object sender, EventArgs e)
        {
            Settings newSettings = new Settings(1920, 1080, "EASY");
            settings = newSettings;
            newGame();
        }

        private void pbMedium_Click(object sender, EventArgs e)
        {
            Settings newSettings = new Settings(1920, 1080, "MEDIUM");
            settings = newSettings;
            newGame();
        }

        private void pbHard_Click(object sender, EventArgs e)
        {
            Settings newSettings = new Settings(1920, 1080, "HARD");
            settings = newSettings;
            newGame();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            lblScore.Text = game.currentScore.points.ToString();
            if (lblScore.Right > Width)
                lblScore.Left = Width - lblScore.Width - 20;
            int speed = 0;
            switch (SettingsForm.settings.difficulty)
            {
                case "EASY":
                    {
                        speed = 40;
                        break;
                    }
                case "MEDIUM":
                    {
                        speed = 30;
                        break;
                    }
                case "HARD":
                    {
                        speed = 20;
                        break;
                    }
            }
            if (ticks++ % speed == 0)
                game.elements.Add(new Element());
            game.MoveElements();
            Invalidate(true);
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("00:{0:00}", --game.time);
            if (game.time == 0)
                stopGame();
        }

        public void newGame()
        {
            pbUnpause.Visible = true;
            pbPause.Visible = false;
            pbGameOver.Visible = false;
            pbAgain.Visible = false;
            pbReturn.Visible = false;
            lblScore.Text = "0";
            game = new Game(label1);
            tableLayoutPanel1.Visible = false;
            panelGame.Visible = true;
            ActiveForm.BackgroundImage = game.background;
            switch (SettingsForm.settings.difficulty)
            {
                case "EASY":
                    {
                        gameTimer.Interval = 50;
                        break;
                    }
                case "MEDIUM":
                    {
                        gameTimer.Interval = 30;
                        break;
                    }
                case "HARD":
                    {
                        gameTimer.Interval = 20;
                        break;
                    }
            }
            Invalidate(true);
        }

        public void stopGame()
        {
            pbGameOver.Visible = true;
            pbAgain.Visible = true;
            pbReturn.Visible = true;
            lblTime.Visible = false;
            label1.Visible = false;
            pbPause.Visible = false;

            Score currentScore = new Score(int.Parse(lblScore.Text), DateTime.Now, lblUser.Text);
            topScores.Add(currentScore);
            currentUser.addScore(currentScore);
            gameTimer.Stop();
            timeTimer.Stop();
            
        }

        protected void ReallyCenterToScreen()
        {
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - Height) / 2)
            };
        }

        public void SaveToFile()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(saveFile, FileMode.Create, FileAccess.Write);
                bf.Serialize(fs, users.Values.ToArray());
                fs.Close();
            }
            catch(Exception)
            {

            }
        }

        public void LoadFromFile()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(saveFile,FileMode.Open,FileAccess.Read);
                User[] userList = (User[])bf.Deserialize(fs);
                fs.Close();
                users = userList.ToDictionary((x) => x.name, (x) => x);
                foreach(User user in users.Values)
                    foreach (Score s in user.scores)
                        topScores.Add(s);
                User u = new User("Guest");
                if (!users.ContainsKey("Guest"))
                    users.Add("Guest", u);
                else
                    foreach (User us in users.Values)
                        if (us.name.Equals("Guest"))
                        {
                            u = us;
                            break;
                        }
                currentUser = u;
            }
            catch (Exception)
            {

            }
        }
    }
}
