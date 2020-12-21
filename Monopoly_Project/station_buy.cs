using System;
using System.Drawing;
using System.Windows.Forms;

namespace Monopoly_Project
{
    public partial class station_buy : Form
    {
        string landname;
        Storage dataBase;
        Game game;
        public station_buy(string landName, ref Storage db, ref Game g)
        {
            InitializeComponent();
            this.landname = landName;
            this.dataBase = db;
            this.game = g;
            setBidButton.ForeColor = Color.White;
            guna2Button1.ForeColor = Color.White;
            if (landname == "grandCentral")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.grand_central_station_property_card;
                setBidButton.FillColor = Color.Gray;
                guna2Button1.FillColor = Color.Gray;
            }
            else if (landname == "electricCompany")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.electric_company_property_card;
                setBidButton.FillColor = Color.White;
                guna2Button1.FillColor = Color.White;
                setBidButton.ForeColor = Color.Black;
                guna2Button1.ForeColor = Color.Black;
            }
            else if (landname == "pooleHarbour")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.poole_harbour_property_card;
                setBidButton.FillColor = Color.Gray;
                guna2Button1.FillColor = Color.Gray;
            }
            else if (landname == "englishHarbour")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.english_harbour_property_card;
                setBidButton.FillColor = Color.Gray;
                guna2Button1.FillColor = Color.Gray;
            }

            else if (landname == "waterWorks")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.water_works_property_card;
                setBidButton.FillColor = Color.White;
                guna2Button1.FillColor = Color.White;
                setBidButton.ForeColor = Color.Black;
                guna2Button1.ForeColor = Color.Black;
            }
            else if (landname == "heathrowAirport")
            {
                propInfoPictureBox.Image = Monopoly_Project.Properties.Resources.heathrow_airport_property_card;
                setBidButton.FillColor = Color.Gray;
                guna2Button1.FillColor = Color.Gray;
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int pos = game.findProperty(landname);
            game.buy(game.currPlayer, pos);
            dataBase.setBoughtUtility(true);
            this.Dispose();
        }

        private void setBidButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
