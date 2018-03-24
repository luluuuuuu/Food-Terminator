using System;
using System.Linq;
using System.Windows.Forms;

namespace Fruit_Ninja
{
    public partial class HighscoresForm : Form
    {
        public HighscoresForm()
        {
            InitializeComponent();
            lblCurrUser.Enabled = false;
            lblAllUsers.Enabled = true;
            resetFields();
            Main.currentUser.scores.Sort();
            Main.currentUser.scores.Reverse();
            foreach (Score score in Main.currentUser.scores)
            {
                lbUserName.Items.Add(Main.currentUser.name);
                lbDate.Items.Add(score.date);
                lbScores.Items.Add(score.points);
            }

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblCurrUser_Click(object sender, EventArgs e)
        {
            lblCurrUser.Enabled = false;
            lblAllUsers.Enabled = true;
            resetFields();
            Main.currentUser.scores.Sort();
            Main.currentUser.scores.Reverse();
            foreach (Score score in Main.currentUser.scores)
            {
                lbUserName.Items.Add(Main.currentUser.name);
                lbDate.Items.Add(score.date);
                lbScores.Items.Add(score.points);
            }
        }

        private void lblAllUsers_Click(object sender, EventArgs e)
        {
            lblCurrUser.Enabled = true;
            lblAllUsers.Enabled = false;
            resetFields();
            if (Main.topScores.Count != 0)
            {
                Main.topScores.Sort();
                Main.topScores.Reverse();
                int end = 10;
                if (Main.topScores.Count <= 10)
                    end = Main.topScores.Count;
                for (int i = 0; i < end; ++i)
                {
                    lbUserName.Items.Add(Main.topScores.ElementAt(i).name);
                    lbDate.Items.Add(Main.topScores.ElementAt(i).date);
                    lbScores.Items.Add(Main.topScores.ElementAt(i).points);
                }
            }
        }

        private void resetFields()
        {
            lbUserName.Items.Clear();
            lbScores.Items.Clear();
            lbDate.Items.Clear();
        }
    }
}
