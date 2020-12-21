using System;
using System.Media;
using System.Windows.Forms;
namespace Monopoly_Project
{
    public partial class how_to_play_ui : Form
    {
        public how_to_play_ui()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            playButtonClick();
            this.Hide();
        }
        private void playButtonClick() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Monopoly_Project.Properties.Resources.button_click); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }
    }
}
