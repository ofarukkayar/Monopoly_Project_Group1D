using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Monopoly_Project
{
    public partial class Trade_Screen : Form
    {
        List<string> thisRequestedProperties;
        List<string> thisPlayerWantToTradeProperties;
        int countChoice;
        List<string> choosedProperties;
        int thisReceiverPlayerNo;
        int givenMoney = 0;
        int wantedMoney = 0;
        string senderName;
        string receiverName;
        public Trade_Screen(int receiverPlayerNo, string playerToTradeWithID, string playerWantToTradeID, Image playerToTradeWithIcon,
                            Image playerWantToTradeIcon, List<string> requestedProperties, List<string> playerWantToTradeProperties)
        {
            InitializeComponent();
            // Set things
            thisReceiverPlayerNo = receiverPlayerNo;
            senderName = playerWantToTradeID;
            receiverName = playerWantToTradeID;
            // Create requestedPropImageButton list
            countChoice = 0;
            choosedProperties = new List<string>();
            Guna.UI2.WinForms.Guna2ImageButton[] requestedPropImages = {choosedImage1, choosedImage2, choosedImage3, choosedImage4,
                                                                        choosedImage5, choosedImage6,choosedImage7};
            // make them invisible and disabled
            for (int i = 0; i < requestedPropImages.Length; i++)
            {
                requestedPropImages[i].Visible = false;
                requestedPropImages[i].Enabled = false;
            }
            Guna.UI2.WinForms.Guna2ImageButton[] playerWantToTradePropImages = {guna2ImageButton1, guna2ImageButton2, guna2ImageButton3,
                                                                                guna2ImageButton4, guna2ImageButton5, guna2ImageButton6,
                                                                                guna2ImageButton7, guna2ImageButton8, guna2ImageButton9,
                                                                                guna2ImageButton10,guna2ImageButton11,guna2ImageButton12,
                                                                                guna2ImageButton13,guna2ImageButton14,guna2ImageButton15,
                                                                                guna2ImageButton16,guna2ImageButton17,guna2ImageButton18,
                                                                                guna2ImageButton19,guna2ImageButton20,guna2ImageButton21,
                                                                                guna2ImageButton22,guna2ImageButton23};

            // make them invisible and disabled
            for (int i = 0; i < playerWantToTradePropImages.Length; i++)
            {
                playerWantToTradePropImages[i].Visible = false;
                playerWantToTradePropImages[i].Enabled = false;
            }

            // Set requested properties list
            thisRequestedProperties = requestedProperties;

            // Set PlayerWantToTradeProperties list
            thisPlayerWantToTradeProperties = playerWantToTradeProperties;

            // Set requested images
            for (int i = 0; i < thisRequestedProperties.Count; i++)
            {
                if (thisRequestedProperties[i] == "gdynia")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.gdynia_property_card;
                    requestedPropImages[i].Tag = "gdynia";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "taipei")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.taipei_property_card;
                    requestedPropImages[i].Tag = "taipei";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "grandCentral")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.grand_central_station_property_card;
                    requestedPropImages[i].Tag = "grandCentral";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "tokyo")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.tokyo_property_card;
                    requestedPropImages[i].Tag = "tokyo";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "barcelona")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.barcelona_property_card;
                    requestedPropImages[i].Tag = "barcelona";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "athens")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.athens_property_card;
                    requestedPropImages[i].Tag = "athens";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "istanbul")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.istanbul_property_card;
                    requestedPropImages[i].Tag = "istanbul";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "electricCompany")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.electric_company_property_card;
                    requestedPropImages[i].Tag = "electricCompany";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "kyiv")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.kyiv_property_card;
                    requestedPropImages[i].Tag = "kyiv";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "toronto")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.toronto_property_card;
                    requestedPropImages[i].Tag = "toronto";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "pooleHarbour")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.poole_harbour_property_card;
                    requestedPropImages[i].Tag = "pooleHarbour";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "rome")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.rome_property_card;
                    requestedPropImages[i].Tag = "rome";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "shanghai")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.shanghai_property_card;
                    requestedPropImages[i].Tag = "shanghai";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "vancouver")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.vancouver_property_card;
                    requestedPropImages[i].Tag = "vancouver";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "sydney")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.sydney_property_card;
                    requestedPropImages[i].Tag = "sydney";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "newYork")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.newyork_property_card;
                    requestedPropImages[i].Tag = "newYork";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "london")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.london_property_card;
                    requestedPropImages[i].Tag = "london";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "englishHarbour")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.english_harbour_property_card;
                    requestedPropImages[i].Tag = "englishHarbour";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "beijing")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.beijing_property_card;
                    requestedPropImages[i].Tag = "beijing";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "hongKong")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.hongkong_property_card;
                    requestedPropImages[i].Tag = "hongKong";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "waterWorks")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.water_works_property_card;
                    requestedPropImages[i].Tag = "waterWorks";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "jerusalem")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.jerusalem_property_card;
                    requestedPropImages[i].Tag = "jerusalem";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "paris")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.paris_property_card;
                    requestedPropImages[i].Tag = "paris";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "belgrade")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.belgrades_property_card;
                    requestedPropImages[i].Tag = "belgrade";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "capeTown")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.capetown_property_card;
                    requestedPropImages[i].Tag = "capeTown";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "heathrowAirport")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.heathrow_airport_property_card;
                    requestedPropImages[i].Tag = "heathrowAirport";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "riga")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.riga_property_card;
                    requestedPropImages[i].Tag = "riga";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
                else if (thisRequestedProperties[i] == "montreal")
                {
                    requestedPropImages[i].Image = Monopoly_Project.Properties.Resources.montreal_property_card;
                    requestedPropImages[i].Tag = "montreal";
                    requestedPropImages[i].Visible = true;
                    requestedPropImages[i].Enabled = true;
                }
            }

            // Set player want to trade's properties
            for (int i = 0; i < thisPlayerWantToTradeProperties.Count; i++)
            {
                if (thisPlayerWantToTradeProperties[i] == "gdynia")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.gdynia_property_card;
                    playerWantToTradePropImages[i].Tag = "gdynia";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;

                }
                else if (thisPlayerWantToTradeProperties[i] == "taipei")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.taipei_property_card;
                    playerWantToTradePropImages[i].Tag = "taipei";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "grandCentral")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.grand_central_station_property_card;
                    playerWantToTradePropImages[i].Tag = "grandCentral";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "tokyo")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.tokyo_property_card;
                    playerWantToTradePropImages[i].Tag = "tokyo";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "barcelona")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.barcelona_property_card;
                    playerWantToTradePropImages[i].Tag = "barcelona";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "athens")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.athens_property_card;
                    playerWantToTradePropImages[i].Tag = "athens";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "istanbul")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.istanbul_property_card;
                    playerWantToTradePropImages[i].Tag = "istanbul";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "electricCompany")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.electric_company_property_card;
                    playerWantToTradePropImages[i].Tag = "electricCompany";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "kyiv")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.kyiv_property_card;
                    playerWantToTradePropImages[i].Tag = "kyiv";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "toronto")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.toronto_property_card;
                    playerWantToTradePropImages[i].Tag = "toronto";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "pooleHarbour")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.poole_harbour_property_card;
                    playerWantToTradePropImages[i].Tag = "pooleHarbour";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "rome")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.rome_property_card;
                    playerWantToTradePropImages[i].Tag = "rome";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "shanghai")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.shanghai_property_card;
                    playerWantToTradePropImages[i].Tag = "shanghai";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "vancouver")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.vancouver_property_card;
                    playerWantToTradePropImages[i].Tag = "vancouver";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "sydney")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.sydney_property_card;
                    playerWantToTradePropImages[i].Tag = "sydney";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "newYork")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.newyork_property_card;
                    playerWantToTradePropImages[i].Tag = "newYork";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "london")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.london_property_card;
                    playerWantToTradePropImages[i].Tag = "london";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "englishHarbour")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.english_harbour_property_card;
                    playerWantToTradePropImages[i].Tag = "englishHarbour";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "beijing")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.beijing_property_card;
                    playerWantToTradePropImages[i].Tag = "beijing";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "hongKong")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.hongkong_property_card;
                    playerWantToTradePropImages[i].Tag = "hongKong";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "waterWorks")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.water_works_property_card;
                    playerWantToTradePropImages[i].Tag = "waterWorks";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "jerusalem")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.jerusalem_property_card;
                    playerWantToTradePropImages[i].Tag = "jerusalem";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "paris")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.paris_property_card;
                    playerWantToTradePropImages[i].Tag = "paris";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "belgrade")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.belgrades_property_card;
                    playerWantToTradePropImages[i].Tag = "belgrade";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "capeTown")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.capetown_property_card;
                    playerWantToTradePropImages[i].Tag = "capeTown";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "heathrowAirport")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.heathrow_airport_property_card;
                    playerWantToTradePropImages[i].Tag = "heathrowAirport";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "riga")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.riga_property_card;
                    playerWantToTradePropImages[i].Tag = "riga";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
                else if (thisPlayerWantToTradeProperties[i] == "montreal")
                {
                    playerWantToTradePropImages[i].Image = Monopoly_Project.Properties.Resources.montreal_property_card;
                    playerWantToTradePropImages[i].Tag = "montreal";
                    playerWantToTradePropImages[i].Visible = true;
                    playerWantToTradePropImages[i].Enabled = true;
                }
            }

            //-----------------------------------------------------

            // Direk player objelerini almam lazım burda kesiinnn player objeleriiiiiiiii id filan bi sürü şey lazımm
            // set player wantToTradeWith
            player1_name_label.Text = playerToTradeWithID;
            player1_icon_trade.Image = playerToTradeWithIcon;

            // set player want to trade
            player2_name_label.Text = playerWantToTradeID;
            player2_icon_trade.Image = playerWantToTradeIcon;
        }

        private async void letsDelay(int delayAmount)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(delayAmount));
        }

        private void cancelTradeButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            this.Dispose();
        }

        private void choosedImage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton1.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton1.Tag.ToString());
                guna2ImageButton1.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton1.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton1.Tag.ToString());
                        guna2ImageButton1.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton2.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton2.Tag.ToString());
                guna2ImageButton2.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton2.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton2.Tag.ToString());
                        guna2ImageButton2.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton3.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton3.Tag.ToString());
                guna2ImageButton3.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton3.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton3.Tag.ToString());
                        guna2ImageButton3.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton4.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton4.Tag.ToString());
                guna2ImageButton4.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton4.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton4.Tag.ToString());
                        guna2ImageButton4.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton5.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton5.Tag.ToString());
                guna2ImageButton5.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton5.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton5.Tag.ToString());
                        guna2ImageButton5.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton6.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton6.Tag.ToString());
                guna2ImageButton6.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton6.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton6.Tag.ToString());
                        guna2ImageButton6.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton7.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton7.Tag.ToString());
                guna2ImageButton7.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton7.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton7.Tag.ToString());
                        guna2ImageButton7.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton8_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton8.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton8.Tag.ToString());
                guna2ImageButton8.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton8.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton8.Tag.ToString());
                        guna2ImageButton8.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton9_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton9.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton9.Tag.ToString());
                guna2ImageButton9.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton9.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton9.Tag.ToString());
                        guna2ImageButton9.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton10_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton10.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton10.Tag.ToString());
                guna2ImageButton10.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton10.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton10.Tag.ToString());
                        guna2ImageButton10.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton11_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton11.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton11.Tag.ToString());
                guna2ImageButton11.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton11.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton11.Tag.ToString());
                        guna2ImageButton11.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton12_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton12.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton12.Tag.ToString());
                guna2ImageButton12.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton12.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton12.Tag.ToString());
                        guna2ImageButton12.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton13_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton13.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton13.Tag.ToString());
                guna2ImageButton13.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton13.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton13.Tag.ToString());
                        guna2ImageButton13.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton14_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton14.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton14.Tag.ToString());
                guna2ImageButton14.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton14.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton14.Tag.ToString());
                        guna2ImageButton14.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton15_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton15.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton15.Tag.ToString());
                guna2ImageButton15.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton15.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton15.Tag.ToString());
                        guna2ImageButton15.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton16_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton16.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton16.Tag.ToString());
                guna2ImageButton16.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton16.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton16.Tag.ToString());
                        guna2ImageButton16.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton17_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton17.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton17.Tag.ToString());
                guna2ImageButton17.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton17.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton17.Tag.ToString());
                        guna2ImageButton17.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton18_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton18.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton18.Tag.ToString());
                guna2ImageButton18.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton18.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton18.Tag.ToString());
                        guna2ImageButton18.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton19_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton19.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton19.Tag.ToString());
                guna2ImageButton19.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton19.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton19.Tag.ToString());
                        guna2ImageButton19.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton20_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton20.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton20.Tag.ToString());
                guna2ImageButton20.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton20.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton20.Tag.ToString());
                        guna2ImageButton20.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton21_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton21.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton21.Tag.ToString());
                guna2ImageButton21.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton21.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton21.Tag.ToString());
                        guna2ImageButton21.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton22_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton22.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton22.Tag.ToString());
                guna2ImageButton22.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton22.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton22.Tag.ToString());
                        guna2ImageButton22.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton23_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton23.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton23.Tag.ToString());
                guna2ImageButton23.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton23.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton23.Tag.ToString());
                        guna2ImageButton23.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }
        private void playButtonClick() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Monopoly_Project.Properties.Resources.button_click); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }
        private void sendTradeReqButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (choosedProperties.Count == 0 && (tradeMoneyTextBoxGive.Text == "0" || tradeMoneyTextBoxGive.Text == ""))
            {
                DialogResult result = MessageBox.Show("You Have to Give Something in Return", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                // SEND THE REQUEST TO THE RECEIVER
                thisReceiverPlayerNo = 10;
                using (accept_trade_screen acceptTradeScreen = new accept_trade_screen(senderName, receiverName, thisReceiverPlayerNo, choosedProperties, givenMoney, thisRequestedProperties, wantedMoney))
                {
                    acceptTradeScreen.ShowDialog();
                }

            }
        }

        private void tradeMoneyTextBoxTake_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tradeMoneyTextBoxGive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        private void tradeMoneyTextBoxGive_TextChanged(object sender, EventArgs e)
        {
            if (tradeMoneyTextBoxGive.Text != "")
            {
                givenMoney = int.Parse(tradeMoneyTextBoxGive.Text);
            }
            else
            {
                givenMoney = 0;
            }
        }

        private void tradeMoneyTextBoxTake_TextChanged(object sender, EventArgs e)
        {
            if (tradeMoneyTextBoxTake.Text != "")
            {
                wantedMoney = int.Parse(tradeMoneyTextBoxTake.Text);
            }
            else
            {
                wantedMoney = 0;
            }
        }
    }
}
