using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
namespace Monopoly_Project
{
    public partial class buy_property_screen : Form
    {
        string thisLandName;
        Storage dataBase;
        CurWaitingFor s;
        bool veto;
        Game g;
        public buy_property_screen(string landname, ref Storage db, ref CurWaitingFor state, bool veto, ref Game g)
        {
            InitializeComponent();
            this.veto = veto;
            this.g = g;
            this.s = state;
            this.dataBase = db;
            if (veto)
            {
                buyPropertyButton.Enabled = true;
            }
            buyPropertyButton.ForeColor = Color.White;
            startBiddingButton.ForeColor = Color.White;
            thisLandName = landname;
            if (landname == "gdynia")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.gdynia_property_card;
                buyPropertyButton.Text = "Buy For $60";
                buyPropertyButton.FillColor = Color.SaddleBrown;
                startBiddingButton.FillColor = Color.SaddleBrown;
            }
            else if (landname == "taipei")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.taipei_property_card;
                buyPropertyButton.Text = "Buy For $60";
                buyPropertyButton.FillColor = Color.SaddleBrown;
                startBiddingButton.FillColor = Color.SaddleBrown;
            }
            else if (landname == "grandCentral")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.grand_central_station_property_card;
                buyPropertyButton.Text = "Buy For $200";
                buyPropertyButton.FillColor = Color.Gray;
                startBiddingButton.FillColor = Color.Gray;
            }
            else if (landname == "tokyo")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.tokyo_property_card;
                buyPropertyButton.Text = "Buy For $100";
                buyPropertyButton.FillColor = Color.SkyBlue;
                startBiddingButton.FillColor = Color.SkyBlue;
            }
            else if (landname == "barcelona")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.barcelona_property_card;
                buyPropertyButton.Text = "Buy For $100";
                buyPropertyButton.FillColor = Color.SkyBlue;
                startBiddingButton.FillColor = Color.SkyBlue;
            }
            else if (landname == "athens")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.athens_property_card;
                buyPropertyButton.Text = "Buy For $120";
                buyPropertyButton.FillColor = Color.SkyBlue;
                startBiddingButton.FillColor = Color.SkyBlue;
            }
            else if (landname == "istanbul")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.istanbul_property_card;
                buyPropertyButton.Text = "Buy For $140";
                buyPropertyButton.FillColor = Color.DeepPink;
                startBiddingButton.FillColor = Color.DeepPink;
            }
            else if (landname == "electricCompany")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.electric_company_property_card;
                buyPropertyButton.Text = "Buy For $150";
                buyPropertyButton.FillColor = Color.White;
                startBiddingButton.FillColor = Color.White;
                buyPropertyButton.ForeColor = Color.Black;
                startBiddingButton.ForeColor = Color.Black;
            }
            else if (landname == "kyiv")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.kyiv_property_card;
                buyPropertyButton.Text = "Buy For $140";
                buyPropertyButton.FillColor = Color.DeepPink;
                startBiddingButton.FillColor = Color.DeepPink;
            }
            else if (landname == "toronto")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.toronto_property_card;
                buyPropertyButton.Text = "Buy For $160";
                buyPropertyButton.FillColor = Color.DeepPink;
                startBiddingButton.FillColor = Color.DeepPink;
            }
            else if (landname == "pooleHarbour")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.poole_harbour_property_card;
                buyPropertyButton.Text = "Buy For $200";
                buyPropertyButton.FillColor = Color.Gray;
                startBiddingButton.FillColor = Color.Gray;
            }
            else if (landname == "rome")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.rome_property_card;
                buyPropertyButton.Text = "Buy For $180";
                buyPropertyButton.FillColor = Color.Orange;
                startBiddingButton.FillColor = Color.Orange;
            }
            else if (landname == "shanghai")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.shanghai_property_card;
                buyPropertyButton.Text = "Buy For $180";
                buyPropertyButton.FillColor = Color.Orange;
                startBiddingButton.FillColor = Color.Orange;
            }
            else if (landname == "vancouver")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.vancouver_property_card;
                buyPropertyButton.Text = "Buy For $200";
                buyPropertyButton.FillColor = Color.Orange;
                startBiddingButton.FillColor = Color.Orange;
            }
            else if (landname == "sydney")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.sydney_property_card;
                buyPropertyButton.Text = "Buy For $220";
                buyPropertyButton.FillColor = Color.Red;
                startBiddingButton.FillColor = Color.Red;
            }
            else if (landname == "newYork")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.newyork_property_card;
                buyPropertyButton.Text = "Buy For $220";
                buyPropertyButton.FillColor = Color.Red;
                startBiddingButton.FillColor = Color.Red;
            }
            else if (landname == "london")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.london_property_card;
                buyPropertyButton.Text = "Buy For $240";
                buyPropertyButton.FillColor = Color.Red;
                startBiddingButton.FillColor = Color.Red;
            }
            else if (landname == "englishHarbour")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.english_harbour_property_card;
                buyPropertyButton.Text = "Buy For $200";
                buyPropertyButton.FillColor = Color.Gray;
                startBiddingButton.FillColor = Color.Gray;
            }
            else if (landname == "beijing")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.beijing_property_card;
                buyPropertyButton.Text = "Buy For $260";
                buyPropertyButton.FillColor = Color.Gold;
                startBiddingButton.FillColor = Color.Gold;
            }
            else if (landname == "hongKong")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.hongkong_property_card;
                buyPropertyButton.Text = "Buy For $260";
                buyPropertyButton.FillColor = Color.Gold;
                startBiddingButton.FillColor = Color.Gold;
            }
            else if (landname == "waterWorks")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.water_works_property_card;
                buyPropertyButton.Text = "Buy For $150";
                buyPropertyButton.FillColor = Color.White;
                startBiddingButton.FillColor = Color.White;
                buyPropertyButton.ForeColor = Color.Black;
                startBiddingButton.ForeColor = Color.Black;
            }
            else if (landname == "jerusalem")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.jerusalem_property_card;
                buyPropertyButton.Text = "Buy For $280";
                buyPropertyButton.FillColor = Color.Gold;
                startBiddingButton.FillColor = Color.Gold;
            }
            else if (landname == "paris")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.paris_property_card;
                buyPropertyButton.Text = "Buy For $300";
                buyPropertyButton.FillColor = Color.DarkGreen;
                startBiddingButton.FillColor = Color.DarkGreen;
            }
            else if (landname == "belgrade")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.belgrades_property_card;
                buyPropertyButton.Text = "Buy For $300";
                buyPropertyButton.FillColor = Color.DarkGreen;
                startBiddingButton.FillColor = Color.DarkGreen;
            }
            else if (landname == "capeTown")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.capetown_property_card;
                buyPropertyButton.Text = "Buy For $320";
                buyPropertyButton.FillColor = Color.DarkGreen;
                startBiddingButton.FillColor = Color.DarkGreen;
            }
            else if (landname == "heathrowAirport")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.heathrow_airport_property_card;
                buyPropertyButton.Text = "Buy For $200";
                buyPropertyButton.FillColor = Color.Gray;
                startBiddingButton.FillColor = Color.Gray;
            }
            else if (landname == "riga")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.riga_property_card;
                buyPropertyButton.Text = "Buy For $350";
                buyPropertyButton.FillColor = Color.DarkBlue;
                startBiddingButton.FillColor = Color.DarkBlue;
            }
            else if (landname == "montreal")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.montreal_property_card;
                buyPropertyButton.Text = "Buy For $400";
                buyPropertyButton.FillColor = Color.DarkBlue;
                startBiddingButton.FillColor = Color.DarkBlue;
            }
        }
        public buy_property_screen(string landname, ref Storage db)
        {
            InitializeComponent();
            this.dataBase = db;
            buyPropertyButton.ForeColor = Color.White;
            startBiddingButton.ForeColor = Color.White;
            thisLandName = landname;
            if (landname == "gdynia")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.gdynia_property_card;
                buyPropertyButton.Text = "Buy For $60";
                buyPropertyButton.FillColor = Color.SaddleBrown;
                startBiddingButton.FillColor = Color.SaddleBrown;
            }
            else if (landname == "taipei")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.taipei_property_card;
                buyPropertyButton.Text = "Buy For $60";
                buyPropertyButton.FillColor = Color.SaddleBrown;
                startBiddingButton.FillColor = Color.SaddleBrown;
            }
            else if (landname == "grandCentral")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.grand_central_station_property_card;
                buyPropertyButton.Text = "Buy For $200";
                buyPropertyButton.FillColor = Color.Gray;
                startBiddingButton.FillColor = Color.Gray;
            }
            else if (landname == "tokyo")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.tokyo_property_card;
                buyPropertyButton.Text = "Buy For $100";
                buyPropertyButton.FillColor = Color.SkyBlue;
                startBiddingButton.FillColor = Color.SkyBlue;
            }
            else if (landname == "barcelona")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.barcelona_property_card;
                buyPropertyButton.Text = "Buy For $100";
                buyPropertyButton.FillColor = Color.SkyBlue;
                startBiddingButton.FillColor = Color.SkyBlue;
            }
            else if (landname == "athens")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.athens_property_card;
                buyPropertyButton.Text = "Buy For $120";
                buyPropertyButton.FillColor = Color.SkyBlue;
                startBiddingButton.FillColor = Color.SkyBlue;
            }
            else if (landname == "istanbul")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.istanbul_property_card;
                buyPropertyButton.Text = "Buy For $140";
                buyPropertyButton.FillColor = Color.DeepPink;
                startBiddingButton.FillColor = Color.DeepPink;
            }
            else if (landname == "electricCompany")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.electric_company_property_card;
                buyPropertyButton.Text = "Buy For $150";
                buyPropertyButton.FillColor = Color.White;
                startBiddingButton.FillColor = Color.White;
                buyPropertyButton.ForeColor = Color.Black;
                startBiddingButton.ForeColor = Color.Black;
            }
            else if (landname == "kyiv")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.kyiv_property_card;
                buyPropertyButton.Text = "Buy For $140";
                buyPropertyButton.FillColor = Color.DeepPink;
                startBiddingButton.FillColor = Color.DeepPink;
            }
            else if (landname == "toronto")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.toronto_property_card;
                buyPropertyButton.Text = "Buy For $160";
                buyPropertyButton.FillColor = Color.DeepPink;
                startBiddingButton.FillColor = Color.DeepPink;
            }
            else if (landname == "pooleHarbour")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.poole_harbour_property_card;
                buyPropertyButton.Text = "Buy For $200";
                buyPropertyButton.FillColor = Color.Gray;
                startBiddingButton.FillColor = Color.Gray;
            }
            else if (landname == "rome")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.rome_property_card;
                buyPropertyButton.Text = "Buy For $180";
                buyPropertyButton.FillColor = Color.Orange;
                startBiddingButton.FillColor = Color.Orange;
            }
            else if (landname == "shanghai")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.shanghai_property_card;
                buyPropertyButton.Text = "Buy For $180";
                buyPropertyButton.FillColor = Color.Orange;
                startBiddingButton.FillColor = Color.Orange;
            }
            else if (landname == "vancouver")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.vancouver_property_card;
                buyPropertyButton.Text = "Buy For $200";
                buyPropertyButton.FillColor = Color.Orange;
                startBiddingButton.FillColor = Color.Orange;
            }
            else if (landname == "sydney")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.sydney_property_card;
                buyPropertyButton.Text = "Buy For $220";
                buyPropertyButton.FillColor = Color.Red;
                startBiddingButton.FillColor = Color.Red;
            }
            else if (landname == "newYork")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.newyork_property_card;
                buyPropertyButton.Text = "Buy For $220";
                buyPropertyButton.FillColor = Color.Red;
                startBiddingButton.FillColor = Color.Red;
            }
            else if (landname == "london")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.london_property_card;
                buyPropertyButton.Text = "Buy For $240";
                buyPropertyButton.FillColor = Color.Red;
                startBiddingButton.FillColor = Color.Red;
            }
            else if (landname == "englishHarbour")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.english_harbour_property_card;
                buyPropertyButton.Text = "Buy For $200";
                buyPropertyButton.FillColor = Color.Gray;
                startBiddingButton.FillColor = Color.Gray;
            }
            else if (landname == "beijing")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.beijing_property_card;
                buyPropertyButton.Text = "Buy For $260";
                buyPropertyButton.FillColor = Color.Gold;
                startBiddingButton.FillColor = Color.Gold;
            }
            else if (landname == "hongKong")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.hongkong_property_card;
                buyPropertyButton.Text = "Buy For $260";
                buyPropertyButton.FillColor = Color.Gold;
                startBiddingButton.FillColor = Color.Gold;
            }
            else if (landname == "waterWorks")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.water_works_property_card;
                buyPropertyButton.Text = "Buy For $150";
                buyPropertyButton.FillColor = Color.White;
                startBiddingButton.FillColor = Color.White;
                buyPropertyButton.ForeColor = Color.Black;
                startBiddingButton.ForeColor = Color.Black;
            }
            else if (landname == "jerusalem")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.jerusalem_property_card;
                buyPropertyButton.Text = "Buy For $280";
                buyPropertyButton.FillColor = Color.Gold;
                startBiddingButton.FillColor = Color.Gold;
            }
            else if (landname == "paris")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.paris_property_card;
                buyPropertyButton.Text = "Buy For $300";
                buyPropertyButton.FillColor = Color.DarkGreen;
                startBiddingButton.FillColor = Color.DarkGreen;
            }
            else if (landname == "belgrade")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.belgrades_property_card;
                buyPropertyButton.Text = "Buy For $300";
                buyPropertyButton.FillColor = Color.DarkGreen;
                startBiddingButton.FillColor = Color.DarkGreen;
            }
            else if (landname == "capeTown")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.capetown_property_card;
                buyPropertyButton.Text = "Buy For $320";
                buyPropertyButton.FillColor = Color.DarkGreen;
                startBiddingButton.FillColor = Color.DarkGreen;
            }
            else if (landname == "heathrowAirport")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.heathrow_airport_property_card;
                buyPropertyButton.Text = "Buy For $200";
                buyPropertyButton.FillColor = Color.Gray;
                startBiddingButton.FillColor = Color.Gray;
            }
            else if (landname == "riga")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.riga_property_card;
                buyPropertyButton.Text = "Buy For $350";
                buyPropertyButton.FillColor = Color.DarkBlue;
                startBiddingButton.FillColor = Color.DarkBlue;
            }
            else if (landname == "montreal")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.montreal_property_card;
                buyPropertyButton.Text = "Buy For $400";
                buyPropertyButton.FillColor = Color.DarkBlue;
                startBiddingButton.FillColor = Color.DarkBlue;
            }
        }
        public buy_property_screen(string landname)
        {
            InitializeComponent();
            this.dataBase = null;
            buyPropertyButton.ForeColor = Color.White;
            startBiddingButton.ForeColor = Color.White;
            thisLandName = landname;
            if (landname == "gdynia")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.gdynia_property_card;
                buyPropertyButton.Text = "Buy For $60";
                buyPropertyButton.FillColor = Color.SaddleBrown;
                startBiddingButton.FillColor = Color.SaddleBrown;
            }
            else if (landname == "taipei")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.taipei_property_card;
                buyPropertyButton.Text = "Buy For $60";
                buyPropertyButton.FillColor = Color.SaddleBrown;
                startBiddingButton.FillColor = Color.SaddleBrown;
            }
            else if (landname == "grandCentral")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.grand_central_station_property_card;
                buyPropertyButton.Text = "Buy For $200";
                buyPropertyButton.FillColor = Color.Gray;
                startBiddingButton.FillColor = Color.Gray;
            }
            else if (landname == "tokyo")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.tokyo_property_card;
                buyPropertyButton.Text = "Buy For $100";
                buyPropertyButton.FillColor = Color.SkyBlue;
                startBiddingButton.FillColor = Color.SkyBlue;
            }
            else if (landname == "barcelona")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.barcelona_property_card;
                buyPropertyButton.Text = "Buy For $100";
                buyPropertyButton.FillColor = Color.SkyBlue;
                startBiddingButton.FillColor = Color.SkyBlue;
            }
            else if (landname == "athens")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.athens_property_card;
                buyPropertyButton.Text = "Buy For $120";
                buyPropertyButton.FillColor = Color.SkyBlue;
                startBiddingButton.FillColor = Color.SkyBlue;
            }
            else if (landname == "istanbul")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.istanbul_property_card;
                buyPropertyButton.Text = "Buy For $140";
                buyPropertyButton.FillColor = Color.DeepPink;
                startBiddingButton.FillColor = Color.DeepPink;
            }
            else if (landname == "electricCompany")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.electric_company_property_card;
                buyPropertyButton.Text = "Buy For $150";
                buyPropertyButton.FillColor = Color.White;
                startBiddingButton.FillColor = Color.White;
                buyPropertyButton.ForeColor = Color.Black;
                startBiddingButton.ForeColor = Color.Black;
            }
            else if (landname == "kyiv")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.kyiv_property_card;
                buyPropertyButton.Text = "Buy For $140";
                buyPropertyButton.FillColor = Color.DeepPink;
                startBiddingButton.FillColor = Color.DeepPink;
            }
            else if (landname == "toronto")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.toronto_property_card;
                buyPropertyButton.Text = "Buy For $160";
                buyPropertyButton.FillColor = Color.DeepPink;
                startBiddingButton.FillColor = Color.DeepPink;
            }
            else if (landname == "pooleHarbour")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.poole_harbour_property_card;
                buyPropertyButton.Text = "Buy For $200";
                buyPropertyButton.FillColor = Color.Gray;
                startBiddingButton.FillColor = Color.Gray;
            }
            else if (landname == "rome")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.rome_property_card;
                buyPropertyButton.Text = "Buy For $180";
                buyPropertyButton.FillColor = Color.Orange;
                startBiddingButton.FillColor = Color.Orange;
            }
            else if (landname == "shanghai")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.shanghai_property_card;
                buyPropertyButton.Text = "Buy For $180";
                buyPropertyButton.FillColor = Color.Orange;
                startBiddingButton.FillColor = Color.Orange;
            }
            else if (landname == "vancouver")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.vancouver_property_card;
                buyPropertyButton.Text = "Buy For $200";
                buyPropertyButton.FillColor = Color.Orange;
                startBiddingButton.FillColor = Color.Orange;
            }
            else if (landname == "sydney")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.sydney_property_card;
                buyPropertyButton.Text = "Buy For $220";
                buyPropertyButton.FillColor = Color.Red;
                startBiddingButton.FillColor = Color.Red;
            }
            else if (landname == "newYork")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.newyork_property_card;
                buyPropertyButton.Text = "Buy For $220";
                buyPropertyButton.FillColor = Color.Red;
                startBiddingButton.FillColor = Color.Red;
            }
            else if (landname == "london")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.london_property_card;
                buyPropertyButton.Text = "Buy For $240";
                buyPropertyButton.FillColor = Color.Red;
                startBiddingButton.FillColor = Color.Red;
            }
            else if (landname == "englishHarbour")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.english_harbour_property_card;
                buyPropertyButton.Text = "Buy For $200";
                buyPropertyButton.FillColor = Color.Gray;
                startBiddingButton.FillColor = Color.Gray;
            }
            else if (landname == "beijing")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.beijing_property_card;
                buyPropertyButton.Text = "Buy For $260";
                buyPropertyButton.FillColor = Color.Gold;
                startBiddingButton.FillColor = Color.Gold;
            }
            else if (landname == "hongKong")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.hongkong_property_card;
                buyPropertyButton.Text = "Buy For $260";
                buyPropertyButton.FillColor = Color.Gold;
                startBiddingButton.FillColor = Color.Gold;
            }
            else if (landname == "waterWorks")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.water_works_property_card;
                buyPropertyButton.Text = "Buy For $150";
                buyPropertyButton.FillColor = Color.White;
                startBiddingButton.FillColor = Color.White;
                buyPropertyButton.ForeColor = Color.Black;
                startBiddingButton.ForeColor = Color.Black;
            }
            else if (landname == "jerusalem")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.jerusalem_property_card;
                buyPropertyButton.Text = "Buy For $280";
                buyPropertyButton.FillColor = Color.Gold;
                startBiddingButton.FillColor = Color.Gold;
            }
            else if (landname == "paris")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.paris_property_card;
                buyPropertyButton.Text = "Buy For $300";
                buyPropertyButton.FillColor = Color.DarkGreen;
                startBiddingButton.FillColor = Color.DarkGreen;
            }
            else if (landname == "belgrade")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.belgrades_property_card;
                buyPropertyButton.Text = "Buy For $300";
                buyPropertyButton.FillColor = Color.DarkGreen;
                startBiddingButton.FillColor = Color.DarkGreen;
            }
            else if (landname == "capeTown")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.capetown_property_card;
                buyPropertyButton.Text = "Buy For $320";
                buyPropertyButton.FillColor = Color.DarkGreen;
                startBiddingButton.FillColor = Color.DarkGreen;
            }
            else if (landname == "heathrowAirport")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.heathrow_airport_property_card;
                buyPropertyButton.Text = "Buy For $200";
                buyPropertyButton.FillColor = Color.Gray;
                startBiddingButton.FillColor = Color.Gray;
            }
            else if (landname == "riga")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.riga_property_card;
                buyPropertyButton.Text = "Buy For $350";
                buyPropertyButton.FillColor = Color.DarkBlue;
                startBiddingButton.FillColor = Color.DarkBlue;
            }
            else if (landname == "montreal")
            {
                propertyCardPictureBox.Image = Monopoly_Project.Properties.Resources.montreal_property_card;
                buyPropertyButton.Text = "Buy For $400";
                buyPropertyButton.FillColor = Color.DarkBlue;
                startBiddingButton.FillColor = Color.DarkBlue;
            }
        }

        private void buyPropertyButton_Click(object sender, EventArgs e)
        {
            int pos = g.findProperty(thisLandName);
            g.buy(g.currPlayer, pos);
            dataBase.setBidNotMade(true);
            playButtonClick();
            this.Dispose();
        }

        private void startBiddingButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            dataBase.setBidMade(true);

            using (bidding_screen biddingScreen = new bidding_screen(thisLandName, ref dataBase, ref s))
            {
                biddingScreen.ShowDialog();
            }

            this.Dispose();
        }
        private void playButtonClick() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Monopoly_Project.Properties.Resources.button_click); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }
    }
}
