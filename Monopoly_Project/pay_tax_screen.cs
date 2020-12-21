using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
namespace Monopoly_Project
{
    public partial class pay_tax_screen : Form
    {
        string landname;
        public pay_tax_screen(string landName, int cost)
        {
            InitializeComponent();
            landname = landName;
            payTaxButton.Text = "Pay $ " + cost;
            payTaxButton.ForeColor = Color.White;
            mortgageButton.ForeColor = Color.White;
            if (landname == "gdynia")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.gdynia_property_card;
                payTaxButton.FillColor = Color.SaddleBrown;
                mortgageButton.FillColor = Color.SaddleBrown;
            }
            else if (landname == "taipei")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.taipei_property_card;
                payTaxButton.FillColor = Color.SaddleBrown;
                mortgageButton.FillColor = Color.SaddleBrown;
            }
            else if (landname == "grandCentral")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.grand_central_station_property_card;
                payTaxButton.FillColor = Color.Gray;
                mortgageButton.FillColor = Color.Gray;
            }
            else if (landname == "tokyo")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.tokyo_property_card;
                payTaxButton.FillColor = Color.SkyBlue;
                mortgageButton.FillColor = Color.SkyBlue;
            }
            else if (landname == "barcelona")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.barcelona_property_card;
                payTaxButton.FillColor = Color.SkyBlue;
                mortgageButton.FillColor = Color.SkyBlue;
            }
            else if (landname == "athens")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.athens_property_card;
                payTaxButton.FillColor = Color.SkyBlue;
                mortgageButton.FillColor = Color.SkyBlue;
            }
            else if (landname == "istanbul")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.istanbul_property_card;
                payTaxButton.FillColor = Color.DeepPink;
                mortgageButton.FillColor = Color.DeepPink;
            }
            else if (landname == "electricCompany")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.electric_company_property_card;
                payTaxButton.FillColor = Color.White;
                mortgageButton.FillColor = Color.White;
                payTaxButton.ForeColor = Color.Black;
                mortgageButton.ForeColor = Color.Black;
            }
            else if (landname == "kyiv")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.kyiv_property_card;
                payTaxButton.FillColor = Color.DeepPink;
                mortgageButton.FillColor = Color.DeepPink;
            }
            else if (landname == "toronto")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.toronto_property_card;
                payTaxButton.FillColor = Color.DeepPink;
                mortgageButton.FillColor = Color.DeepPink;
            }
            else if (landname == "pooleHarbour")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.poole_harbour_property_card;
                payTaxButton.FillColor = Color.Gray;
                mortgageButton.FillColor = Color.Gray;
            }
            else if (landname == "rome")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.rome_property_card;
                payTaxButton.FillColor = Color.Orange;
                mortgageButton.FillColor = Color.Orange;
            }
            else if (landname == "shanghai")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.shanghai_property_card;
                payTaxButton.FillColor = Color.Orange;
                mortgageButton.FillColor = Color.Orange;
            }
            else if (landname == "vancouver")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.vancouver_property_card;
                payTaxButton.FillColor = Color.Orange;
                mortgageButton.FillColor = Color.Orange;
            }
            else if (landname == "sydney")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.sydney_property_card;
                payTaxButton.FillColor = Color.Red;
                mortgageButton.FillColor = Color.Red;
            }
            else if (landname == "newYork")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.newyork_property_card;
                payTaxButton.FillColor = Color.Red;
                mortgageButton.FillColor = Color.Red;
            }
            else if (landname == "london")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.london_property_card;
                payTaxButton.FillColor = Color.Red;
                mortgageButton.FillColor = Color.Red;
            }
            else if (landname == "englishHarbour")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.english_harbour_property_card;
                payTaxButton.FillColor = Color.Gray;
                mortgageButton.FillColor = Color.Gray;
            }
            else if (landname == "beijing")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.beijing_property_card;
                payTaxButton.FillColor = Color.Gold;
                mortgageButton.FillColor = Color.Gold;
            }
            else if (landname == "hongKong")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.hongkong_property_card;
                payTaxButton.FillColor = Color.Gold;
                mortgageButton.FillColor = Color.Gold;
            }
            else if (landname == "waterWorks")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.water_works_property_card;
                payTaxButton.FillColor = Color.White;
                mortgageButton.FillColor = Color.White;
                payTaxButton.ForeColor = Color.Black;
                mortgageButton.ForeColor = Color.Black;
            }
            else if (landname == "jerusalem")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.jerusalem_property_card;
                payTaxButton.FillColor = Color.Gold;
                mortgageButton.FillColor = Color.Gold;
            }
            else if (landname == "paris")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.paris_property_card;
                payTaxButton.FillColor = Color.DarkGreen;
                mortgageButton.FillColor = Color.DarkGreen;
            }
            else if (landname == "belgrade")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.belgrades_property_card;
                payTaxButton.FillColor = Color.DarkGreen;
                mortgageButton.FillColor = Color.DarkGreen;
            }
            else if (landname == "capeTown")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.capetown_property_card;
                payTaxButton.FillColor = Color.DarkGreen;
                mortgageButton.FillColor = Color.DarkGreen;
            }
            else if (landname == "heathrowAirport")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.heathrow_airport_property_card;
                payTaxButton.FillColor = Color.Gray;
                mortgageButton.FillColor = Color.Gray;
            }
            else if (landname == "riga")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.riga_property_card;
                payTaxButton.FillColor = Color.DarkBlue;
                mortgageButton.FillColor = Color.DarkBlue;
            }
            else if (landname == "montreal")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.montreal_property_card;
                payTaxButton.FillColor = Color.DarkBlue;
                mortgageButton.FillColor = Color.DarkBlue;
            }
        }



        private void mortgageButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            this.Dispose();
        }

        private void payTaxButton_Click(object sender, EventArgs e)
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
