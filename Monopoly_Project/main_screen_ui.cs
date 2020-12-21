using System;
using System.Media;
using System.Windows.Forms;
namespace Monopoly_Project
{
    public partial class main_screen_ui : Form
    {



        // Storage
        Storage dataBase;

        public main_screen_ui()
        {
            dataBase = new Storage();
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            settingsButton.Visible = false;
            howToPlayButton.Visible = false;
            creditsButton.Visible = false;
            exitGameButton.Visible = false;

            joinButton.Visible = true;
            hostButton.Visible = true;
            backButton.Visible = true;

            playButton.Enabled = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            settingsButton.Visible = true;
            howToPlayButton.Visible = true;
            creditsButton.Visible = true;
            exitGameButton.Visible = true;

            joinButton.Visible = false;
            hostButton.Visible = false;
            backButton.Visible = false;

            playButton.Enabled = true;
        }

        private void exitGameButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            DialogResult result = MessageBox.Show("Are you sure wish to quit?", "Exit Game", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            using (settingss_ui settingsScreen = new settingss_ui())
            {
                settingsScreen.ShowDialog();
            }
        }

        private void howToPlayButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            using (how_to_play_ui howToPlayScreen = new how_to_play_ui())
            {
                howToPlayScreen.ShowDialog();
            }
        }

        private void creditsButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            using (credits_ui creditsScreen = new credits_ui())
            {
                creditsScreen.ShowDialog();
            }
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            using (join_game_ui joinScreen = new join_game_ui(dataBase) { Owner = this })
            {
                joinScreen.ShowDialog();
            }
        }

        private void hostButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            using (host_game_ui hostScreen = new host_game_ui(dataBase) { Owner = this })
            {
                hostScreen.ShowDialog();
            }
        }
        private void playButtonClick() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Monopoly_Project.Properties.Resources.button_click); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }
    }
}
