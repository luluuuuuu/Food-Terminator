using System;
using System.Windows.Forms;

namespace Fruit_Ninja
{
    public partial class SettingsForm : Form
    {
        public static Settings settings;

        public SettingsForm()
        {
            InitializeComponent();
            Width = 1920;
            Height = 1080;
        }

        private void pbEasy_Click(object sender, EventArgs e)
        {
            Settings newSettings = new Settings(1920, 1080, "EASY");
            settings = newSettings;
            Close();
        }

        private void pbMedium_Click(object sender, EventArgs e)
        {
            Settings newSettings = new Settings(1920, 1080, "MEDIUM");
            settings = newSettings;
            Close();
        }

        private void pbHard_Click(object sender, EventArgs e)
        {
            Settings newSettings = new Settings(1920, 1080, "HARD");
            settings = newSettings;
            Close();
        }
    }
}
