using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
namespace Monopoly_Project
{

    public partial class ShowPropertiesScreen : Form
    {
        List<string> thisProperties;
        List<string> choosedProperties;
        int thisPlayerNO;
        int countChoice;
        Game g;
        Storage dataBase;
        public ShowPropertiesScreen(List<string> properties, int playerNO, string playerID, Image toShow, ref Storage db, ref Game game)
        {
            InitializeComponent();
            thisProperties = properties;
            this.g = game;
            dataBase = db;
            thisPlayerNO = playerNO;
            countChoice = 0;
            choosedProperties = new List<string>();
            if (thisPlayerNO == 1)
            {
                player_panel_show_prop.BackColor = Color.LightGreen;
                player_panel_show_prop.BackgroundImage = Monopoly_Project.Properties.Resources.yesil_border;
            }
            else if (thisPlayerNO == 2)
            {
                player_panel_show_prop.BackColor = Color.BlueViolet;
                player_panel_show_prop.BackgroundImage = Monopoly_Project.Properties.Resources.mor_border;
            }
            else if (thisPlayerNO == 3)
            {
                player_panel_show_prop.BackColor = Color.PaleVioletRed;
                player_panel_show_prop.BackgroundImage = Monopoly_Project.Properties.Resources.pembe_border;
            }
            else if (thisPlayerNO == 4)
            {
                player_panel_show_prop.BackColor = Color.SlateBlue;
                player_panel_show_prop.BackgroundImage = Monopoly_Project.Properties.Resources.mavii_border;
            }
            player_name_show_prop.Text = playerID;
            player_icon_show_prop.Image = toShow;
            Guna.UI2.WinForms.Guna2ImageButton[] imageButtonArray = {guna2ImageButton1, guna2ImageButton2, guna2ImageButton3,
                                                                     guna2ImageButton4, guna2ImageButton5, guna2ImageButton6,
                                                                     guna2ImageButton7, guna2ImageButton8, guna2ImageButton9,
                                                                     guna2ImageButton10,guna2ImageButton11,guna2ImageButton12,
                                                                     guna2ImageButton13,guna2ImageButton14,guna2ImageButton15,
                                                                     guna2ImageButton16,guna2ImageButton17,guna2ImageButton18,
                                                                     guna2ImageButton19,guna2ImageButton20,guna2ImageButton21,
                                                                     guna2ImageButton22,guna2ImageButton23,guna2ImageButton24,
                                                                     guna2ImageButton25,guna2ImageButton26,guna2ImageButton27};

            for (int i = 0; i < imageButtonArray.Length; i++)
            {
                imageButtonArray[i].Visible = false;
                imageButtonArray[i].Enabled = false;
            }
            for (int i = 0; i < thisProperties.Count; i++)
            {
                if (thisProperties[i] == "gdynia")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.gdynia_property_card;
                    imageButtonArray[i].Tag = "gdynia";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;

                }
                else if (thisProperties[i] == "taipei")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.taipei_property_card;
                    imageButtonArray[i].Tag = "taipei";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "grandCentral")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.grand_central_station_property_card;
                    imageButtonArray[i].Tag = "grandCentral";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "tokyo")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.tokyo_property_card;
                    imageButtonArray[i].Tag = "tokyo";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "barcelona")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.barcelona_property_card;
                    imageButtonArray[i].Tag = "barcelona";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "athens")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.athens_property_card;
                    imageButtonArray[i].Tag = "athens";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "istanbul")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.istanbul_property_card;
                    imageButtonArray[i].Tag = "istanbul";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "electricCompany")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.electric_company_property_card;
                    imageButtonArray[i].Tag = "electricCompany";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "kyiv")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.kyiv_property_card;
                    imageButtonArray[i].Tag = "kyiv";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "toronto")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.toronto_property_card;
                    imageButtonArray[i].Tag = "toronto";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "pooleHarbour")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.poole_harbour_property_card;
                    imageButtonArray[i].Tag = "pooleHarbour";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "rome")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.rome_property_card;
                    imageButtonArray[i].Tag = "rome";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "shanghai")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.shanghai_property_card;
                    imageButtonArray[i].Tag = "shanghai";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "vancouver")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.vancouver_property_card;
                    imageButtonArray[i].Tag = "vancouver";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "sydney")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.sydney_property_card;
                    imageButtonArray[i].Tag = "sydney";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "newYork")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.newyork_property_card;
                    imageButtonArray[i].Tag = "newYork";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "london")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.london_property_card;
                    imageButtonArray[i].Tag = "london";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "englishHarbour")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.english_harbour_property_card;
                    imageButtonArray[i].Tag = "englishHarbour";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "beijing")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.beijing_property_card;
                    imageButtonArray[i].Tag = "beijing";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "hongKong")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.hongkong_property_card;
                    imageButtonArray[i].Tag = "hongKong";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "waterWorks")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.water_works_property_card;
                    imageButtonArray[i].Tag = "waterWorks";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "jerusalem")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.jerusalem_property_card;
                    imageButtonArray[i].Tag = "jerusalem";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "paris")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.paris_property_card;
                    imageButtonArray[i].Tag = "paris";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "belgrade")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.belgrades_property_card;
                    imageButtonArray[i].Tag = "belgrade";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "capeTown")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.capetown_property_card;
                    imageButtonArray[i].Tag = "capeTown";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "heathrowAirport")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.heathrow_airport_property_card;
                    imageButtonArray[i].Tag = "heathrowAirport";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "riga")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.riga_property_card;
                    imageButtonArray[i].Tag = "riga";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
                }
                else if (thisProperties[i] == "montreal")
                {
                    imageButtonArray[i].Image = Monopoly_Project.Properties.Resources.montreal_property_card;
                    imageButtonArray[i].Tag = "montreal";
                    imageButtonArray[i].Visible = true;
                    imageButtonArray[i].Enabled = true;
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

            if (sendTradeReqButton.Text == "Send Trade Request")
            {
                List<string> props = g.parr[thisPlayerNO].assets;
                using (Trade_Screen tradeScreen = new Trade_Screen(thisPlayerNO, dataBase.pdb[thisPlayerNO - 1].name, dataBase.pdb[dataBase.myID].name, player_icon_show_prop.Image, player_icon_show_prop.Image, choosedProperties, props))
                {
                    tradeScreen.ShowDialog();
                }
            }
            else if (sendTradeReqButton.Text == "Mortgage")
            {

            }
        }

        private void join_exit_Click(object sender, EventArgs e)
        {
            playButtonClick();
            this.Dispose();
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

        private void guna2ImageButton24_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton24.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton24.Tag.ToString());
                guna2ImageButton24.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton24.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton24.Tag.ToString());
                        guna2ImageButton24.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }
        }

        private void guna2ImageButton25_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton25.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton25.Tag.ToString());
                guna2ImageButton25.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton25.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton25.Tag.ToString());
                        guna2ImageButton25.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }


        }

        private void guna2ImageButton26_Click(object sender, EventArgs e)
        {
            playButtonClick();
            if (guna2ImageButton26.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton26.Tag.ToString());
                guna2ImageButton26.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton26.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton26.Tag.ToString());
                        guna2ImageButton26.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }


        }



        private void guna2ImageButton27_Click_1(object sender, EventArgs e)
        {

            playButtonClick();
            if (guna2ImageButton27.BackColor == Color.Crimson)
            {
                choosedProperties.Remove(guna2ImageButton27.Tag.ToString());
                guna2ImageButton27.BackColor = Color.Transparent;
                countChoice--;
            }
            else
            {
                if (countChoice < 7)
                {
                    if (guna2ImageButton27.BackColor == Color.Transparent)
                    {
                        choosedProperties.Add(guna2ImageButton27.Tag.ToString());
                        guna2ImageButton27.BackColor = Color.Crimson;
                        countChoice++;
                    }
                }
            }

        }
    }
}
