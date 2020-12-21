using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
namespace Monopoly_Project
{
    public partial class bidding_screen : Form
    {
        int bid = 0;
        Storage dataBase;
        CurWaitingFor s;
        public bidding_screen(string landname, ref Storage db, ref CurWaitingFor state)
        {
            InitializeComponent();
            this.s = state;
            dataBase = db;
            setBidButton.ForeColor = Color.White;
            bidTextBox.ForeColor = Color.White;
            if (landname == "gdynia")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.gdynia_property_card;
                setBidButton.FillColor = Color.SaddleBrown;
                bidTextBox.FillColor = Color.SaddleBrown;
            }
            else if (landname == "taipei")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.taipei_property_card;
                setBidButton.FillColor = Color.SaddleBrown;
                bidTextBox.FillColor = Color.SaddleBrown;
            }
            else if (landname == "grandCentral")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.grand_central_station_property_card;
                setBidButton.FillColor = Color.Gray;
                bidTextBox.FillColor = Color.Gray;
            }
            else if (landname == "tokyo")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.tokyo_property_card;
                setBidButton.FillColor = Color.SkyBlue;
                bidTextBox.FillColor = Color.SkyBlue;
            }
            else if (landname == "barcelona")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.barcelona_property_card;
                setBidButton.FillColor = Color.SkyBlue;
                bidTextBox.FillColor = Color.SkyBlue;
            }
            else if (landname == "athens")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.athens_property_card;
                setBidButton.FillColor = Color.SkyBlue;
                bidTextBox.FillColor = Color.SkyBlue;
            }
            else if (landname == "istanbul")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.istanbul_property_card;
                setBidButton.FillColor = Color.DeepPink;
                bidTextBox.FillColor = Color.DeepPink;
            }
            else if (landname == "electricCompany")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.electric_company_property_card;
                setBidButton.FillColor = Color.White;
                bidTextBox.FillColor = Color.White;
                setBidButton.ForeColor = Color.Black;
                bidTextBox.ForeColor = Color.Black;
            }
            else if (landname == "kyiv")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.kyiv_property_card;
                setBidButton.FillColor = Color.DeepPink;
                bidTextBox.FillColor = Color.DeepPink;
            }
            else if (landname == "toronto")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.toronto_property_card;
                setBidButton.FillColor = Color.DeepPink;
                bidTextBox.FillColor = Color.DeepPink;
            }
            else if (landname == "pooleHarbour")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.poole_harbour_property_card;
                setBidButton.FillColor = Color.Gray;
                bidTextBox.FillColor = Color.Gray;
            }
            else if (landname == "rome")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.rome_property_card;
                setBidButton.FillColor = Color.Orange;
                bidTextBox.FillColor = Color.Orange;
            }
            else if (landname == "shanghai")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.shanghai_property_card;
                setBidButton.FillColor = Color.Orange;
                bidTextBox.FillColor = Color.Orange;
            }
            else if (landname == "vancouver")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.vancouver_property_card;
                setBidButton.FillColor = Color.Orange;
                bidTextBox.FillColor = Color.Orange;
            }
            else if (landname == "sydney")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.sydney_property_card;
                setBidButton.FillColor = Color.Red;
                bidTextBox.FillColor = Color.Red;
            }
            else if (landname == "newYork")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.newyork_property_card;
                setBidButton.FillColor = Color.Red;
                bidTextBox.FillColor = Color.Red;
            }
            else if (landname == "london")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.london_property_card;
                setBidButton.FillColor = Color.Red;
                bidTextBox.FillColor = Color.Red;
            }
            else if (landname == "englishHarbour")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.english_harbour_property_card;
                setBidButton.FillColor = Color.Gray;
                bidTextBox.FillColor = Color.Gray;
            }
            else if (landname == "beijing")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.beijing_property_card;
                setBidButton.FillColor = Color.Gold;
                bidTextBox.FillColor = Color.Gold;
            }
            else if (landname == "hongKong")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.hongkong_property_card;
                setBidButton.FillColor = Color.Gold;
                bidTextBox.FillColor = Color.Gold;
            }
            else if (landname == "waterWorks")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.water_works_property_card;
                setBidButton.FillColor = Color.White;
                bidTextBox.FillColor = Color.White;
                setBidButton.ForeColor = Color.Black;
                bidTextBox.ForeColor = Color.Black;
            }
            else if (landname == "jerusalem")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.jerusalem_property_card;
                setBidButton.FillColor = Color.Gold;
                bidTextBox.FillColor = Color.Gold;
            }
            else if (landname == "paris")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.paris_property_card;
                setBidButton.FillColor = Color.DarkGreen;
                bidTextBox.FillColor = Color.DarkGreen;
            }
            else if (landname == "belgrade")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.belgrades_property_card;
                setBidButton.FillColor = Color.DarkGreen;
                bidTextBox.FillColor = Color.DarkGreen;
            }
            else if (landname == "capeTown")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.capetown_property_card;
                setBidButton.FillColor = Color.DarkGreen;
                bidTextBox.FillColor = Color.DarkGreen;
            }
            else if (landname == "heathrowAirport")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.heathrow_airport_property_card;
                setBidButton.FillColor = Color.Gray;
                bidTextBox.FillColor = Color.Gray;
            }
            else if (landname == "riga")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.riga_property_card;
                setBidButton.FillColor = Color.DarkBlue;
                bidTextBox.FillColor = Color.DarkBlue;
            }
            else if (landname == "montreal")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.montreal_property_card;
                bidTextBox.FillColor = Color.DarkBlue;
                setBidButton.FillColor = Color.DarkBlue;
            }
        }
        public bidding_screen(string landname, ref Storage db)
        {
            InitializeComponent();
            dataBase = db;
            setBidButton.ForeColor = Color.White;
            bidTextBox.ForeColor = Color.White;
            if (landname == "gdynia")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.gdynia_property_card;
                setBidButton.FillColor = Color.SaddleBrown;
                bidTextBox.FillColor = Color.SaddleBrown;
            }
            else if (landname == "taipei")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.taipei_property_card;
                setBidButton.FillColor = Color.SaddleBrown;
                bidTextBox.FillColor = Color.SaddleBrown;
            }
            else if (landname == "grandCentral")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.grand_central_station_property_card;
                setBidButton.FillColor = Color.Gray;
                bidTextBox.FillColor = Color.Gray;
            }
            else if (landname == "tokyo")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.tokyo_property_card;
                setBidButton.FillColor = Color.SkyBlue;
                bidTextBox.FillColor = Color.SkyBlue;
            }
            else if (landname == "barcelona")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.barcelona_property_card;
                setBidButton.FillColor = Color.SkyBlue;
                bidTextBox.FillColor = Color.SkyBlue;
            }
            else if (landname == "athens")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.athens_property_card;
                setBidButton.FillColor = Color.SkyBlue;
                bidTextBox.FillColor = Color.SkyBlue;
            }
            else if (landname == "istanbul")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.istanbul_property_card;
                setBidButton.FillColor = Color.DeepPink;
                bidTextBox.FillColor = Color.DeepPink;
            }
            else if (landname == "electricCompany")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.electric_company_property_card;
                setBidButton.FillColor = Color.White;
                bidTextBox.FillColor = Color.White;
                setBidButton.ForeColor = Color.Black;
                bidTextBox.ForeColor = Color.Black;
            }
            else if (landname == "kyiv")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.kyiv_property_card;
                setBidButton.FillColor = Color.DeepPink;
                bidTextBox.FillColor = Color.DeepPink;
            }
            else if (landname == "toronto")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.toronto_property_card;
                setBidButton.FillColor = Color.DeepPink;
                bidTextBox.FillColor = Color.DeepPink;
            }
            else if (landname == "pooleHarbour")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.poole_harbour_property_card;
                setBidButton.FillColor = Color.Gray;
                bidTextBox.FillColor = Color.Gray;
            }
            else if (landname == "rome")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.rome_property_card;
                setBidButton.FillColor = Color.Orange;
                bidTextBox.FillColor = Color.Orange;
            }
            else if (landname == "shanghai")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.shanghai_property_card;
                setBidButton.FillColor = Color.Orange;
                bidTextBox.FillColor = Color.Orange;
            }
            else if (landname == "vancouver")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.vancouver_property_card;
                setBidButton.FillColor = Color.Orange;
                bidTextBox.FillColor = Color.Orange;
            }
            else if (landname == "sydney")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.sydney_property_card;
                setBidButton.FillColor = Color.Red;
                bidTextBox.FillColor = Color.Red;
            }
            else if (landname == "newYork")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.newyork_property_card;
                setBidButton.FillColor = Color.Red;
                bidTextBox.FillColor = Color.Red;
            }
            else if (landname == "london")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.london_property_card;
                setBidButton.FillColor = Color.Red;
                bidTextBox.FillColor = Color.Red;
            }
            else if (landname == "englishHarbour")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.english_harbour_property_card;
                setBidButton.FillColor = Color.Gray;
                bidTextBox.FillColor = Color.Gray;
            }
            else if (landname == "beijing")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.beijing_property_card;
                setBidButton.FillColor = Color.Gold;
                bidTextBox.FillColor = Color.Gold;
            }
            else if (landname == "hongKong")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.hongkong_property_card;
                setBidButton.FillColor = Color.Gold;
                bidTextBox.FillColor = Color.Gold;
            }
            else if (landname == "waterWorks")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.water_works_property_card;
                setBidButton.FillColor = Color.White;
                bidTextBox.FillColor = Color.White;
                setBidButton.ForeColor = Color.Black;
                bidTextBox.ForeColor = Color.Black;
            }
            else if (landname == "jerusalem")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.jerusalem_property_card;
                setBidButton.FillColor = Color.Gold;
                bidTextBox.FillColor = Color.Gold;
            }
            else if (landname == "paris")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.paris_property_card;
                setBidButton.FillColor = Color.DarkGreen;
                bidTextBox.FillColor = Color.DarkGreen;
            }
            else if (landname == "belgrade")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.belgrades_property_card;
                setBidButton.FillColor = Color.DarkGreen;
                bidTextBox.FillColor = Color.DarkGreen;
            }
            else if (landname == "capeTown")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.capetown_property_card;
                setBidButton.FillColor = Color.DarkGreen;
                bidTextBox.FillColor = Color.DarkGreen;
            }
            else if (landname == "heathrowAirport")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.heathrow_airport_property_card;
                setBidButton.FillColor = Color.Gray;
                bidTextBox.FillColor = Color.Gray;
            }
            else if (landname == "riga")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.riga_property_card;
                setBidButton.FillColor = Color.DarkBlue;
                bidTextBox.FillColor = Color.DarkBlue;
            }
            else if (landname == "montreal")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.montreal_property_card;
                bidTextBox.FillColor = Color.DarkBlue;
                setBidButton.FillColor = Color.DarkBlue;
            }
        }


        private void setBidButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            dataBase.getGameBoardDB();
            bid = int.Parse(bidTextBox.Text);
            dataBase.setOffer(bid, dataBase.myID);
            s = CurWaitingFor.bidWinner;

            this.Dispose();

        }

        private void bidTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void playButtonClick() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Monopoly_Project.Properties.Resources.button_click); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }
    }
}
