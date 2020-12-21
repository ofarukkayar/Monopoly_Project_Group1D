using System;
using System.Media;
using System.Windows.Forms;
namespace Monopoly_Project
{
    public partial class settingss_ui : Form
    {
        public settingss_ui()
        {
            InitializeComponent();
        }

        private void settings_exit_Click(object sender, EventArgs e)
        {
            playButtonClick();
            this.Dispose();
        }
        private void playButtonClick() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Monopoly_Project.Properties.Resources.button_click); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }
    }
}
