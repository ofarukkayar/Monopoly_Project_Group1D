using System;
using System.Media;
using System.Windows.Forms;
namespace Monopoly_Project
{
    public partial class buildHouseScreen : Form
    {
        string landname;

        public buildHouseScreen(int houseCost, int hotelCost, string landName)
        {
            InitializeComponent();
            // Set Property Card Image
            landname = landName;
            if (landname == "gdynia")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.gdynia_property_card;
            }
            else if (landname == "taipei")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.taipei_property_card;
            }
            else if (landname == "tokyo")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.tokyo_property_card;
            }
            else if (landname == "barcelona")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.barcelona_property_card;
            }
            else if (landname == "athens")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.athens_property_card;
            }
            else if (landname == "istanbul")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.istanbul_property_card;
            }
            else if (landname == "kyiv")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.kyiv_property_card;
            }
            else if (landname == "toronto")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.toronto_property_card;
            }
            else if (landname == "rome")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.rome_property_card;
            }
            else if (landname == "shanghai")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.shanghai_property_card;
            }
            else if (landname == "vancouver")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.vancouver_property_card;
            }
            else if (landname == "sydney")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.sydney_property_card;
            }
            else if (landname == "newYork")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.newyork_property_card;
            }
            else if (landname == "london")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.london_property_card;
            }
            else if (landname == "beijing")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.beijing_property_card;
            }
            else if (landname == "hongKong")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.hongkong_property_card;
            }
            else if (landname == "jerusalem")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.jerusalem_property_card;
            }
            else if (landname == "paris")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.paris_property_card;
            }
            else if (landname == "belgrade")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.belgrades_property_card;
            }
            else if (landname == "capeTown")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.capetown_property_card;
            }
            else if (landname == "riga")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.riga_property_card;
            }
            else if (landname == "montreal")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.montreal_property_card;
            }
            if (hotelCost == 0)
            {
                buildHotel.Enabled = false;
            }
            else
            {
                buildHotel.Text = "Build Hotel For: $ " + hotelCost;
            }

            if (houseCost == 0)
            {
                houseBuild.Enabled = false;
            }
            else
            {
                houseBuild.Text = "Build House For: $ " + houseCost;
            }
        }
        public void buildHouse()
        {
            playButtonClick();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            this.Dispose();
        }

        private void houseBuild_Click(object sender, EventArgs e)
        {
            playButtonClick();
        }
        private void playButtonClick() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Monopoly_Project.Properties.Resources.button_click); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }
    }
}
