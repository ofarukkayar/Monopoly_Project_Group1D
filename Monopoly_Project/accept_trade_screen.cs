using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
namespace Monopoly_Project
{
    public partial class accept_trade_screen : Form
    {
        List<string> thisGivenProperties;
        List<string> thisWantedProperties;
        int thisGivenMoney;
        int thisWantedMoney;
        public accept_trade_screen(string senderName, string receiverName, int PlayerNo, List<string> givenProperties, int givenMoney,
                                   List<string> wantedProperties, int wantedMoney)
        {
            InitializeComponent();


            // Set vars
            thisGivenProperties = givenProperties;
            thisWantedProperties = wantedProperties;
            thisGivenMoney = givenMoney;
            thisWantedMoney = wantedMoney;
            givesMoneyLabel.Text = "and " + givenMoney;
            wantsMoneyLabel.Text = "and " + wantedMoney;
            senderIDLabel.Text = senderName + " Sended a Trade Request";
            // create arrs for image buttons
            Guna.UI2.WinForms.Guna2ImageButton[] givenPropImages = {givesImage1, givesImage2, givesImage3, givesImage4, givesImage5,
                                                                    givesImage6, givesImage7};
            Guna.UI2.WinForms.Guna2ImageButton[] wantedPropImages = {wantsImage1, wantsImage2, wantsImage3, wantsImage4, wantsImage5,
                                                                     wantsImage6, wantsImage7};

            // make image buttons invisible and disabled
            for (int i = 0; i < givenPropImages.Length; i++)
            {
                givenPropImages[i].Visible = false;
                givenPropImages[i].Enabled = false;
                wantedPropImages[i].Visible = false;
                wantedPropImages[i].Enabled = false;
            }

            // Setting given prop images
            for (int i = 0; i < givenProperties.Count; i++)
            {
                if (thisGivenProperties[i] == "gdynia")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.gdynia_property_card;
                    givenPropImages[i].Tag = "gdynia";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "taipei")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.taipei_property_card;
                    givenPropImages[i].Tag = "taipei";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "grandCentral")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.grand_central_station_property_card;
                    givenPropImages[i].Tag = "grandCentral";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "tokyo")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.tokyo_property_card;
                    givenPropImages[i].Tag = "tokyo";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "barcelona")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.barcelona_property_card;
                    givenPropImages[i].Tag = "barcelona";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "athens")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.athens_property_card;
                    givenPropImages[i].Tag = "athens";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "istanbul")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.istanbul_property_card;
                    givenPropImages[i].Tag = "istanbul";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "electricCompany")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.electric_company_property_card;
                    givenPropImages[i].Tag = "electricCompany";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "kyiv")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.kyiv_property_card;
                    givenPropImages[i].Tag = "kyiv";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "toronto")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.toronto_property_card;
                    givenPropImages[i].Tag = "toronto";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "pooleHarbour")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.poole_harbour_property_card;
                    givenPropImages[i].Tag = "pooleHarbour";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "rome")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.rome_property_card;
                    givenPropImages[i].Tag = "rome";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "shanghai")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.shanghai_property_card;
                    givenPropImages[i].Tag = "shanghai";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "vancouver")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.vancouver_property_card;
                    givenPropImages[i].Tag = "vancouver";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "sydney")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.sydney_property_card;
                    givenPropImages[i].Tag = "sydney";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "newYork")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.newyork_property_card;
                    givenPropImages[i].Tag = "newYork";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "london")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.london_property_card;
                    givenPropImages[i].Tag = "london";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "englishHarbour")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.english_harbour_property_card;
                    givenPropImages[i].Tag = "englishHarbour";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "beijing")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.beijing_property_card;
                    givenPropImages[i].Tag = "beijing";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "hongKong")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.hongkong_property_card;
                    givenPropImages[i].Tag = "hongKong";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "waterWorks")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.water_works_property_card;
                    givenPropImages[i].Tag = "waterWorks";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "jerusalem")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.jerusalem_property_card;
                    givenPropImages[i].Tag = "jerusalem";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "paris")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.paris_property_card;
                    givenPropImages[i].Tag = "paris";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "belgrade")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.belgrades_property_card;
                    givenPropImages[i].Tag = "belgrade";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "capeTown")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.capetown_property_card;
                    givenPropImages[i].Tag = "capeTown";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "heathrowAirport")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.heathrow_airport_property_card;
                    givenPropImages[i].Tag = "heathrowAirport";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "riga")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.riga_property_card;
                    givenPropImages[i].Tag = "riga";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
                else if (thisGivenProperties[i] == "montreal")
                {
                    givenPropImages[i].Image = Monopoly_Project.Properties.Resources.montreal_property_card;
                    givenPropImages[i].Tag = "montreal";
                    givenPropImages[i].Visible = true;
                    givenPropImages[i].Enabled = true;
                }
            }
            // Setting wanted prop images
            for (int i = 0; i < wantedProperties.Count; i++)
            {
                if (thisWantedProperties[i] == "gdynia")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.gdynia_property_card;
                    wantedPropImages[i].Tag = "gdynia";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "taipei")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.taipei_property_card;
                    wantedPropImages[i].Tag = "taipei";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "grandCentral")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.grand_central_station_property_card;
                    wantedPropImages[i].Tag = "grandCentral";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "tokyo")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.tokyo_property_card;
                    wantedPropImages[i].Tag = "tokyo";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "barcelona")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.barcelona_property_card;
                    wantedPropImages[i].Tag = "barcelona";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "athens")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.athens_property_card;
                    wantedPropImages[i].Tag = "athens";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "istanbul")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.istanbul_property_card;
                    wantedPropImages[i].Tag = "istanbul";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "electricCompany")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.electric_company_property_card;
                    wantedPropImages[i].Tag = "electricCompany";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "kyiv")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.kyiv_property_card;
                    wantedPropImages[i].Tag = "kyiv";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "toronto")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.toronto_property_card;
                    wantedPropImages[i].Tag = "toronto";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "pooleHarbour")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.poole_harbour_property_card;
                    wantedPropImages[i].Tag = "pooleHarbour";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "rome")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.rome_property_card;
                    wantedPropImages[i].Tag = "rome";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "shanghai")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.shanghai_property_card;
                    wantedPropImages[i].Tag = "shanghai";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "vancouver")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.vancouver_property_card;
                    wantedPropImages[i].Tag = "vancouver";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "sydney")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.sydney_property_card;
                    wantedPropImages[i].Tag = "sydney";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "newYork")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.newyork_property_card;
                    wantedPropImages[i].Tag = "newYork";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "london")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.london_property_card;
                    wantedPropImages[i].Tag = "london";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "englishHarbour")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.english_harbour_property_card;
                    wantedPropImages[i].Tag = "englishHarbour";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "beijing")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.beijing_property_card;
                    wantedPropImages[i].Tag = "beijing";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "hongKong")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.hongkong_property_card;
                    wantedPropImages[i].Tag = "hongKong";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "waterWorks")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.water_works_property_card;
                    wantedPropImages[i].Tag = "waterWorks";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "jerusalem")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.jerusalem_property_card;
                    wantedPropImages[i].Tag = "jerusalem";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "paris")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.paris_property_card;
                    wantedPropImages[i].Tag = "paris";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "belgrade")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.belgrades_property_card;
                    wantedPropImages[i].Tag = "belgrade";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "capeTown")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.capetown_property_card;
                    wantedPropImages[i].Tag = "capeTown";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "heathrowAirport")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.heathrow_airport_property_card;
                    wantedPropImages[i].Tag = "heathrowAirport";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "riga")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.riga_property_card;
                    wantedPropImages[i].Tag = "riga";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
                else if (thisWantedProperties[i] == "montreal")
                {
                    wantedPropImages[i].Image = Monopoly_Project.Properties.Resources.montreal_property_card;
                    wantedPropImages[i].Tag = "montreal";
                    wantedPropImages[i].Visible = true;
                    wantedPropImages[i].Enabled = true;
                }
            }
        }



        private void acceptButton_Click(object sender, EventArgs e)
        {
            // do smth
            playButtonClick();
        }

        private void refuseButton_Click(object sender, EventArgs e)
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
