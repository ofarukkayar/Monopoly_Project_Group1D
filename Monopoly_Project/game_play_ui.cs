using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Monopoly_Project
{
    public enum CurWaitingFor
    {
        dice,
        buyScreen,
        trade,
        bidWinner,
        endTurn,
        utility
    }
    public partial class game_play_ui : Form
    {
        // Database
        Storage dataBase;
        Game g;
        bool flagDice = true;
        bool flagDiceCur = true;
        bool flagEndTurn = true;
        bool flagBid = true;
        bool flagBidWinner = true;
        bool flagEndTurnIf = true;
        bool flagElse = true;
        bool flagUtility1 = true;
        bool flagUtility2 = true;
        string buyScreenAt = "";
        CurWaitingFor state;

        // house build stuff
        string buildHouselandName = "";
        string buildHotellandName = "";
        // Locations for player pawns
        //Player1
        readonly Dictionary<string, int[]> player1_pawnLocations = new Dictionary<string, int[]>()
        {
            {"start", new int[]{930,920} },
            {"gdynia", new int[]{860,880}},
            {"cmLowerLeft",new int[]{800,840} },
            {"taipei", new int[]{720,790 } },
            {"incomeTax", new int[]{660,750} },
            {"grandCentral", new int[]{590,700} },
            {"tokyo", new int[]{510,660} },
            {"chanceLowerLeft", new int[]{450,620} },
            {"barcelona", new int[]{370,580} },
            {"athens", new int[]{300,540} },
            {"visitor", new int[]{240,480} },
            {"istanbul", new int[]{320,440} },
            {"electricCompany", new int[]{380,400} },
            {"kyiv", new int[]{450,350} },
            {"toronto", new int[]{520,310} },
            {"pooleHarbour", new int[]{590,270} },
            {"rome", new int[]{660,220} },
            {"cmUpperLeft", new int[]{730,180} },
            {"shanghai", new int[]{800,140} },
            {"vancouver", new int[]{870,90} },
            {"freePark", new int[]{940,50} },
            {"sydney", new int[]{1050,120} },
            {"chanceUpperRight", new int[]{1120,160} },
            {"newYork", new int[]{1190,210} },
            {"london", new int[]{1260,250} },
            {"englishHarbour", new int[]{1330,290} },
            {"beijing", new int[]{1400,330} },
            {"hongKong", new int[]{1470,380} },
            {"waterWorks", new int[]{1540,420} },
            {"jerusalem", new int[]{1600,460} },
            {"goToJail", new int[]{1670,510} },
            {"paris", new int[]{1570,570} },
            {"belgrade", new int[]{1500,610} },
            {"cmLowerRight", new int[]{1430,660} },
            {"capeTown", new int[]{1360,700} },
            {"heathrowAirport", new int[]{1290,740} },
            {"chanceLowerRight", new int[]{1220,790} },
            {"riga", new int[]{1150,830} },
            {"luxuryTax", new int[]{1080,870} },
            {"montreal", new int[]{1010,920} },
        };
        // Player2
        readonly Dictionary<string, int[]> player2_pawnLocations = new Dictionary<string, int[]>()
        {
            {"start", new int[]{970,930} },
            {"gdynia", new int[]{890,900}},
            {"cmLowerLeft",new int[]{820,860} },
            {"taipei", new int[]{750,820 } },
            {"incomeTax", new int[]{690,770} },
            {"grandCentral", new int[]{630,730} },
            {"tokyo", new int[]{550,690} },
            {"chanceLowerLeft", new int[]{490,640} },
            {"barcelona", new int[]{410,600} },
            {"athens", new int[]{340,560} },
            {"visitor", new int[]{210,500} },
            {"istanbul", new int[]{280,460} },
            {"electricCompany", new int[]{350,410} },
            {"kyiv", new int[]{420,370} },
            {"toronto", new int[]{490,330} },
            {"pooleHarbour", new int[]{560,290} },
            {"rome", new int[]{630,250} },
            {"cmUpperLeft", new int[]{700,200} },
            {"shanghai", new int[]{760,160} },
            {"vancouver", new int[]{830,110} },
            {"freePark", new int[]{900,70} },
            {"sydney", new int[]{1010,90} },
            {"chanceUpperRight", new int[]{1080,140} },
            {"newYork", new int[]{1150,180} },
            {"london", new int[]{1220,220} },
            {"englishHarbour", new int[]{1280,270} },
            {"beijing", new int[]{1350,310} },
            {"hongKong", new int[]{1420,350} },
            {"waterWorks", new int[]{1490,400} },
            {"jerusalem", new int[]{1560,440} },
            {"goToJail", new int[]{1630,480} },
            {"paris", new int[]{1600,550} },
            {"belgrade", new int[]{1530,590} },
            {"cmLowerRight", new int[]{1460,630} },
            {"capeTown", new int[]{1390,680} },
            {"heathrowAirport", new int[]{1320,720} },
            {"chanceLowerRight", new int[]{1250,760} },
            {"riga", new int[]{1180,810} },
            {"luxuryTax", new int[]{1110,850} },
            {"montreal", new int[]{1040,900} },
        };

        // Player3
        readonly Dictionary<string, int[]> player3_pawnLocations = new Dictionary<string, int[]>()
        {
            {"start", new int[]{890,940} },
            {"gdynia", new int[]{820,900}},
            {"cmLowerLeft",new int[]{750,850} },
            {"taipei", new int[]{680,810 } },
            {"incomeTax", new int[]{610,770} },
            {"grandCentral", new int[]{540,720} },
            {"tokyo", new int[]{470,680} },
            {"chanceLowerLeft", new int[]{410,630} },
            {"barcelona", new int[]{330,590} },
            {"athens", new int[]{270,550} },
            {"visitor", new int[]{210,520} },
            {"istanbul", new int[]{320,460} },
            {"electricCompany", new int[]{390,420} },
            {"kyiv", new int[]{470,370} },
            {"toronto", new int[]{530,330} },
            {"pooleHarbour", new int[]{610,290} },
            {"rome", new int[]{670,240} },
            {"cmUpperLeft", new int[]{750,210} },
            {"shanghai", new int[]{810,160} },
            {"vancouver", new int[]{880,110} },
            {"freePark", new int[]{930,100} },
            {"sydney", new int[]{970,110} },
            {"chanceUpperRight", new int[]{1030,160} },
            {"newYork", new int[]{1110,200} },
            {"london", new int[]{1180,240} },
            {"englishHarbour", new int[]{1240,290} },
            {"beijing", new int[]{1320,320} },
            {"hongKong", new int[]{1390,370} },
            {"waterWorks", new int[]{1450,420} },
            {"jerusalem", new int[]{1530,450} },
            {"goToJail", new int[]{1580,510} },
            {"paris", new int[]{1530,560} },
            {"belgrade", new int[]{1460,600} },
            {"cmLowerRight", new int[]{1380,640} },
            {"capeTown", new int[]{1320,690} },
            {"heathrowAirport", new int[]{1240,730} },
            {"chanceLowerRight", new int[]{1170,770} },
            {"riga", new int[]{1120,820} },
            {"luxuryTax", new int[]{1040,860} },
            {"montreal", new int[]{980,900} },
        };

        // Player4
        readonly Dictionary<string, int[]> player4_pawnLocations = new Dictionary<string, int[]>()
        {
            {"start", new int[]{940,950} },
            {"gdynia", new int[]{870,910}},
            {"cmLowerLeft",new int[]{800,870} },
            {"taipei", new int[]{740,830 } },
            {"incomeTax", new int[]{670,790} },
            {"grandCentral", new int[]{590,740} },
            {"tokyo", new int[]{530,700} },
            {"chanceLowerLeft", new int[]{460,660} },
            {"barcelona", new int[]{390,610} },
            {"athens", new int[]{320,570} },
            {"visitor", new int[]{250,530} },
            {"istanbul", new int[]{310,480} },
            {"electricCompany", new int[]{390,440} },
            {"kyiv", new int[]{440,390} },
            {"toronto", new int[]{510,350} },
            {"pooleHarbour", new int[]{590,310} },
            {"rome", new int[]{650,260} },
            {"cmUpperLeft", new int[]{730,220} },
            {"shanghai", new int[]{790,170} },
            {"vancouver", new int[]{860,130} },
            {"freePark", new int[]{980,80} },
            {"sydney", new int[]{1030,130} },
            {"chanceUpperRight", new int[]{1090,180} },
            {"newYork", new int[]{1170,220} },
            {"london", new int[]{1230,260} },
            {"englishHarbour", new int[]{1290,310} },
            {"beijing", new int[]{1380,350} },
            {"hongKong", new int[]{1450,390} },
            {"waterWorks", new int[]{1500,440} },
            {"jerusalem", new int[]{1580,480} },
            {"goToJail", new int[]{1640,530} },
            {"paris", new int[]{1570,530} },
            {"belgrade", new int[]{1510,580} },
            {"cmLowerRight", new int[]{1430,620} },
            {"capeTown", new int[]{1370,660} },
            {"heathrowAirport", new int[]{1290,700} },
            {"chanceLowerRight", new int[]{1220,740} },
            {"riga", new int[]{1160,790} },
            {"luxuryTax", new int[]{1080,830} },
            {"montreal", new int[]{1020,880} },
        };

        // to hide in_game_settings_panel
        const int WM_PARENTNOTIFY = 0x210;
        const int WM_LBUTTONDOWN = 0x201;

        // For dice
        private readonly Random _random = new Random();
        int dice_total;
        int dice_total_to_show;
        int dice1;
        int dice2;

        // For movement
        int playerNo; // it will change !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        string landName;

        // Current landnames of players
        // string player1_landName;
        //string player2_landName;
        //string player3_landName;
        //string player4_landName;
        public game_play_ui(ref Storage dataBase)
        {
            this.dataBase = dataBase;
            InitializeComponent();

            openSelectPawnScreen();
            this.g = new Game();

            playerNo = 1;
            g.currPlayer = 0;
            turnTimer.Start();
            this.state = CurWaitingFor.dice;
        }
        public async void openSelectPawnScreen()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(300));
            using (select_pawn_screen selectPawnScreen = new select_pawn_screen(ref dataBase, ref player1_pawn, ref player2_pawn, ref player3_pawn,
                                                                                ref player4_pawn, ref player1_icon, ref player2_icon, ref player3_icon,
                                                                                ref player4_icon, ref player1_name_label, ref player2_name_label,
                                                                                ref player3_name_label, ref player4_name_label))
            {
                selectPawnScreen.ShowDialog();
            }
        }

        // Set Build House Panel 
        public void setBuildHousePanel(int houseCost, int hotelCost, string landname)
        {
            buildHouselandName = landname;
            buildHotellandName = landname;
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
        // Move methods
        private void startMove()
        {
            landName = "start";
            dice_total--;
            timer1.Start();
        }
        private void gdyniaMove()
        {
            landName = "gdynia";
            dice_total--;
            timer1.Start();
        }
        private void cmLowerLeftMove()
        {
            landName = "cmLowerLeft";
            dice_total--;
            timer1.Start();
        }
        private void taipeiMove()
        {
            landName = "taipei";
            dice_total--;
            timer1.Start();
        }
        private void incomeTaxMove()
        {
            landName = "incomeTax";
            dice_total--;
            timer1.Start();
        }
        private void grandCentralMove()
        {
            landName = "grandCentral";
            dice_total--;
            timer1.Start();
        }
        private void tokyoMove()
        {
            landName = "tokyo";
            dice_total--;
            timer1.Start();
        }
        private void chanceLowerLeftMove()
        {
            landName = "chanceLowerLeft";
            dice_total--;
            timer1.Start();
        }
        private void barcelonaMove()
        {
            landName = "barcelona";
            dice_total--;
            timer1.Start();
        }
        private void athensMove()
        {
            landName = "athens";
            dice_total--;
            timer1.Start();
        }
        private void visitorMove()
        {
            landName = "visitor";
            dice_total--;
            timer1.Start();
        }
        private void istanbulMove()
        {
            landName = "istanbul";
            dice_total--;
            timer1.Start();
        }
        private void electricCompanyMove()
        {
            landName = "electricCompany";
            dice_total--;
            timer1.Start();
        }
        private void kyivMove()
        {
            landName = "kyiv";
            dice_total--;
            timer1.Start();
        }
        private void torontoMove()
        {
            landName = "toronto";
            dice_total--;
            timer1.Start();
        }
        private void pooleHarbourMove()
        {
            landName = "pooleHarbour";
            dice_total--;
            timer1.Start();
        }
        private void romeMove()
        {
            landName = "rome";
            dice_total--;
            timer1.Start();
        }
        private void cmUpperLeftMove()
        {
            landName = "cmUpperLeft";
            dice_total--;
            timer1.Start();
        }
        private void shanghaiMove()
        {
            landName = "shanghai";
            dice_total--;
            timer1.Start();
        }
        private void vancouverMove()
        {
            landName = "vancouver";
            dice_total--;
            timer1.Start();
        }
        private void freeParkMove()
        {
            landName = "freePark";
            dice_total--;
            timer1.Start();
        }
        private void sydneyMove()
        {
            landName = "sydney";
            dice_total--;
            timer1.Start();
        }
        private void chanceUpperRightMove()
        {
            landName = "chanceUpperRight";
            dice_total--;
            timer1.Start();
        }
        private void newYorkMove()
        {
            landName = "newYork";
            dice_total--;
            timer1.Start();
        }
        private void londonMove()
        {
            landName = "london";
            dice_total--;
            timer1.Start();
        }
        private void englishHarbourMove()
        {
            landName = "englishHarbour";
            dice_total--;
            timer1.Start();
        }
        private void beijingMove()
        {
            landName = "beijing";
            dice_total--;
            timer1.Start();
        }
        private void hongKongMove()
        {
            landName = "hongKong";
            dice_total--;
            timer1.Start();
        }
        private void waterWorksMove()
        {
            landName = "waterWorks";
            dice_total--;
            timer1.Start();
        }
        private void jerusalemMove()
        {
            landName = "jerusalem";
            dice_total--;
            timer1.Start();
        }
        private void goToJailMove()
        {
            landName = "goToJail";
            dice_total--;
            timer1.Start();
        }
        private void parisMove()
        {
            landName = "paris";
            dice_total--;
            timer1.Start();
        }
        private void belgradeMove()
        {
            landName = "belgrade";
            dice_total--;
            timer1.Start();
        }
        private void cmLowerRightMove()
        {
            landName = "cmLowerRight";
            dice_total--;
            timer1.Start();
        }
        private void capeTownMove()
        {
            landName = "capeTown";
            dice_total--;
            timer1.Start();
        }
        private void heathrowAirportMove()
        {
            landName = "heathrowAirport";
            dice_total--;
            timer1.Start();
        }
        private void chanceLowerRightMove()
        {
            landName = "chanceLowerRight";
            dice_total--;
            timer1.Start();
        }
        private void rigaMove()
        {
            landName = "riga";
            dice_total--;
            timer1.Start();
        }
        private void luxuryTaxMove()
        {
            landName = "luxuryTax";
            dice_total--;
            timer1.Start();
        }
        private void montrealMove()
        {
            landName = "montreal";
            dice_total--;
            timer1.Start();
        }

        // Teleport
        private void teleport(int playerNo, string str)
        {
            if (playerNo == 1)
            {
                player1_pawn.Location = new Point(player1_pawnLocations[str][0], player1_pawnLocations[str][1]);
            }
            else if (playerNo == 2)
            {
                player2_pawn.Location = new Point(player2_pawnLocations[str][0], player2_pawnLocations[str][1]);
            }
            else if (playerNo == 3)
            {
                player3_pawn.Location = new Point(player3_pawnLocations[str][0], player3_pawnLocations[str][1]);
            }
            else
            {
                player4_pawn.Location = new Point(player4_pawnLocations[str][0], player4_pawnLocations[str][1]);
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            DialogResult result = MessageBox.Show("Are you sure wish to quit game?", "Quit Game", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                using (main_screen_ui mainScreen = new main_screen_ui())
                {
                    mainScreen.ShowDialog();
                }
            }
        }
        private void playDiceRoll() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Monopoly_Project.Properties.Resources.roll_dice_2); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }
        private void dice_button_Click(object sender, EventArgs e)
        {
            playButtonClick();
            playDiceRoll();
            //SystemSounds.Asterisk.Play();
            //SystemSounds.Question.Play();
            dice_panel.Visible = true;
            dice_timer.Start();
            dice_button.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            player1_pawn.Location = new Point(930, 920);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player1_pawn.Location = new Point(800, 840);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            playerNo = 2;
            //player2_pawn.Location = new Point(970, 930);
            player2_pawn.BringToFront();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            playerNo = 1;
            //player1_pawn.Location = new Point(930, 920);
            player1_pawn.BringToFront();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            playerNo = 3;
            //player3_pawn.Location = new Point(890, 940);
            player3_pawn.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerNo = 4;
            // player4_pawn.Location = new Point(940, 950);
            player4_pawn.BringToFront();
        }



        // Hides settings panel if clicked outside
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN || (m.Msg == WM_PARENTNOTIFY && (int)m.WParam == WM_LBUTTONDOWN))
            {
                if (!in_game_settings_panel.ClientRectangle.Contains(in_game_settings_panel.PointToClient(Cursor.Position)))
                {
                    in_game_settings_panel.Visible = false;
                }
                if (!ch_cm_panel.ClientRectangle.Contains(ch_cm_panel.PointToClient(Cursor.Position)))
                {
                    ch_cm_panel.Visible = false;
                }
            }
            base.WndProc(ref m);
        }
        // Hides chance, community chance panel


        private void pause_button_Click(object sender, EventArgs e)
        {
            playButtonClick();
            in_game_settings_panel.Visible = true;
        }

        private void settings_in_game_Click(object sender, EventArgs e)
        {
            playButtonClick();
            using (settingss_ui settingsScreen = new settingss_ui())
            {
                in_game_settings_panel.Visible = false;
                settingsScreen.ShowDialog();
            }
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            in_game_settings_panel.Visible = false;
        }

        // Dice animations and start moves
        private void dice_timer_Tick(object sender, EventArgs e)
        {
            dicePrgBar.Increment(5);
            if (dicePrgBar.Value >= 100)
            {
                dice_timer.Stop();
                if (g.currPlayer == dataBase.myID)
                {
                    dice_total = 3 + 4;
                    dataBase.setDice(3, 4);
                }
                else
                {
                    dice_total = dataBase.gbdb.dice1 + dataBase.gbdb.dice2;
                    int ddice1 = dataBase.gbdb.dice1;
                    int ddice2 = dataBase.gbdb.dice2;
                    if (ddice1 == 1)
                    {
                        picDice1.Image = global::Monopoly_Project.Properties.Resources._1;
                    }
                    else if (ddice1 == 2)
                    {
                        picDice1.Image = global::Monopoly_Project.Properties.Resources._2;
                    }
                    else if (ddice1 == 3)
                    {
                        picDice1.Image = global::Monopoly_Project.Properties.Resources._3;
                    }
                    else if (ddice1 == 4)
                    {
                        picDice1.Image = global::Monopoly_Project.Properties.Resources._4;
                    }
                    else if (ddice1 == 5)
                    {
                        picDice1.Image = global::Monopoly_Project.Properties.Resources._5;
                    }
                    else if (ddice1 == 6)
                    {
                        picDice1.Image = global::Monopoly_Project.Properties.Resources._6;
                    }

                    //if's for animating dice 2

                    if (ddice2 == 1)
                    {
                        picDice2.Image = global::Monopoly_Project.Properties.Resources._1;

                    }
                    else if (ddice2 == 2)
                    {
                        picDice2.Image = global::Monopoly_Project.Properties.Resources._2;
                    }
                    else if (ddice2 == 3)
                    {
                        picDice2.Image = global::Monopoly_Project.Properties.Resources._3;
                    }
                    else if (ddice2 == 4)
                    {
                        picDice2.Image = global::Monopoly_Project.Properties.Resources._4;
                    }
                    else if (ddice2 == 5)
                    {
                        picDice2.Image = global::Monopoly_Project.Properties.Resources._5;
                    }
                    else if (ddice2 == 6)
                    {
                        picDice2.Image = global::Monopoly_Project.Properties.Resources._6;
                    }
                }
                g.move(dice_total);
                diceTotal_label.Text = dice_total.ToString();

                // Playerdan dicelar alınıp burda setlenecek gibi ??
                dicePrgBar.Value = 0;
                // start timer for move animation
                // jail oalyları

                if (playerNo == 1)
                {
                    if (player1_pawn.Location.X == player1_pawnLocations["start"][0] && player1_pawn.Location.Y == player1_pawnLocations["start"][1])
                    {
                        startMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["gdynia"][0] && player1_pawn.Location.Y == player1_pawnLocations["gdynia"][1])
                    {
                        gdyniaMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["cmLowerLeft"][0] && player1_pawn.Location.Y == player1_pawnLocations["cmLowerLeft"][1])
                    {
                        cmLowerLeftMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["taipei"][0] && player1_pawn.Location.Y == player1_pawnLocations["taipei"][1])
                    {
                        taipeiMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["incomeTax"][0] && player1_pawn.Location.Y == player1_pawnLocations["incomeTax"][1])
                    {
                        incomeTaxMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["grandCentral"][0] && player1_pawn.Location.Y == player1_pawnLocations["grandCentral"][1])
                    {
                        grandCentralMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["tokyo"][0] && player1_pawn.Location.Y == player1_pawnLocations["tokyo"][1])
                    {
                        tokyoMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["tokyo"][0] && player1_pawn.Location.Y == player1_pawnLocations["tokyo"][1])
                    {
                        tokyoMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["chanceLowerLeft"][0] && player1_pawn.Location.Y == player1_pawnLocations["chanceLowerLeft"][1])
                    {
                        chanceLowerLeftMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["barcelona"][0] && player1_pawn.Location.Y == player1_pawnLocations["barcelona"][1])
                    {
                        barcelonaMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["athens"][0] && player1_pawn.Location.Y == player1_pawnLocations["athens"][1])
                    {
                        athensMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["visitor"][0] && player1_pawn.Location.Y == player1_pawnLocations["visitor"][1])
                    {
                        visitorMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["istanbul"][0] && player1_pawn.Location.Y == player1_pawnLocations["istanbul"][1])
                    {
                        istanbulMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["electricCompany"][0] && player1_pawn.Location.Y == player1_pawnLocations["electricCompany"][1])
                    {
                        electricCompanyMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["kyiv"][0] && player1_pawn.Location.Y == player1_pawnLocations["kyiv"][1])
                    {
                        kyivMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["toronto"][0] && player1_pawn.Location.Y == player1_pawnLocations["toronto"][1])
                    {
                        torontoMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["pooleHarbour"][0] && player1_pawn.Location.Y == player1_pawnLocations["pooleHarbour"][1])
                    {
                        pooleHarbourMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["rome"][0] && player1_pawn.Location.Y == player1_pawnLocations["rome"][1])
                    {
                        romeMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["cmUpperLeft"][0] && player1_pawn.Location.Y == player1_pawnLocations["cmUpperLeft"][1])
                    {
                        cmUpperLeftMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["shanghai"][0] && player1_pawn.Location.Y == player1_pawnLocations["shanghai"][1])
                    {
                        shanghaiMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["vancouver"][0] && player1_pawn.Location.Y == player1_pawnLocations["vancouver"][1])
                    {
                        vancouverMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["freePark"][0] && player1_pawn.Location.Y == player1_pawnLocations["freePark"][1])
                    {
                        freeParkMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["sydney"][0] && player1_pawn.Location.Y == player1_pawnLocations["sydney"][1])
                    {
                        sydneyMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["chanceUpperRight"][0] && player1_pawn.Location.Y == player1_pawnLocations["chanceUpperRight"][1])
                    {
                        chanceUpperRightMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["newYork"][0] && player1_pawn.Location.Y == player1_pawnLocations["newYork"][1])
                    {
                        newYorkMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["london"][0] && player1_pawn.Location.Y == player1_pawnLocations["london"][1])
                    {
                        londonMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["englishHarbour"][0] && player1_pawn.Location.Y == player1_pawnLocations["englishHarbour"][1])
                    {
                        englishHarbourMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["beijing"][0] && player1_pawn.Location.Y == player1_pawnLocations["beijing"][1])
                    {
                        beijingMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["hongKong"][0] && player1_pawn.Location.Y == player1_pawnLocations["hongKong"][1])
                    {
                        hongKongMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["waterWorks"][0] && player1_pawn.Location.Y == player1_pawnLocations["waterWorks"][1])
                    {
                        waterWorksMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["jerusalem"][0] && player1_pawn.Location.Y == player1_pawnLocations["jerusalem"][1])
                    {
                        jerusalemMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["goToJail"][0] && player1_pawn.Location.Y == player1_pawnLocations["goToJail"][1])
                    {
                        goToJailMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["paris"][0] && player1_pawn.Location.Y == player1_pawnLocations["paris"][1])
                    {
                        parisMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["belgrade"][0] && player1_pawn.Location.Y == player1_pawnLocations["belgrade"][1])
                    {
                        belgradeMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["cmLowerRight"][0] && player1_pawn.Location.Y == player1_pawnLocations["cmLowerRight"][1])
                    {
                        cmLowerRightMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["capeTown"][0] && player1_pawn.Location.Y == player1_pawnLocations["capeTown"][1])
                    {
                        capeTownMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["heathrowAirport"][0] && player1_pawn.Location.Y == player1_pawnLocations["heathrowAirport"][1])
                    {
                        heathrowAirportMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["chanceLowerRight"][0] && player1_pawn.Location.Y == player1_pawnLocations["chanceLowerRight"][1])
                    {
                        chanceLowerRightMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["riga"][0] && player1_pawn.Location.Y == player1_pawnLocations["riga"][1])
                    {
                        rigaMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["luxuryTax"][0] && player1_pawn.Location.Y == player1_pawnLocations["luxuryTax"][1])
                    {
                        luxuryTaxMove();
                    }
                    else if (player1_pawn.Location.X == player1_pawnLocations["montreal"][0] && player1_pawn.Location.Y == player1_pawnLocations["montreal"][1])
                    {
                        montrealMove();
                    }
                }
                else if (playerNo == 2)
                {
                    if (player2_pawn.Location.X == player2_pawnLocations["start"][0] && player2_pawn.Location.Y == player2_pawnLocations["start"][1])
                    {
                        startMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["gdynia"][0] && player2_pawn.Location.Y == player2_pawnLocations["gdynia"][1])
                    {
                        gdyniaMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["cmLowerLeft"][0] && player2_pawn.Location.Y == player2_pawnLocations["cmLowerLeft"][1])
                    {
                        cmLowerLeftMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["taipei"][0] && player2_pawn.Location.Y == player2_pawnLocations["taipei"][1])
                    {
                        taipeiMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["incomeTax"][0] && player2_pawn.Location.Y == player2_pawnLocations["incomeTax"][1])
                    {
                        incomeTaxMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["grandCentral"][0] && player2_pawn.Location.Y == player2_pawnLocations["grandCentral"][1])
                    {
                        grandCentralMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["tokyo"][0] && player2_pawn.Location.Y == player2_pawnLocations["tokyo"][1])
                    {
                        tokyoMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["tokyo"][0] && player2_pawn.Location.Y == player2_pawnLocations["tokyo"][1])
                    {
                        tokyoMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["chanceLowerLeft"][0] && player2_pawn.Location.Y == player2_pawnLocations["chanceLowerLeft"][1])
                    {
                        chanceLowerLeftMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["barcelona"][0] && player2_pawn.Location.Y == player2_pawnLocations["barcelona"][1])
                    {
                        barcelonaMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["athens"][0] && player2_pawn.Location.Y == player2_pawnLocations["athens"][1])
                    {
                        athensMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["visitor"][0] && player2_pawn.Location.Y == player2_pawnLocations["visitor"][1])
                    {
                        visitorMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["istanbul"][0] && player2_pawn.Location.Y == player2_pawnLocations["istanbul"][1])
                    {
                        istanbulMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["electricCompany"][0] && player2_pawn.Location.Y == player2_pawnLocations["electricCompany"][1])
                    {
                        electricCompanyMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["kyiv"][0] && player2_pawn.Location.Y == player2_pawnLocations["kyiv"][1])
                    {
                        kyivMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["toronto"][0] && player2_pawn.Location.Y == player2_pawnLocations["toronto"][1])
                    {
                        torontoMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["pooleHarbour"][0] && player2_pawn.Location.Y == player2_pawnLocations["pooleHarbour"][1])
                    {
                        pooleHarbourMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["rome"][0] && player2_pawn.Location.Y == player2_pawnLocations["rome"][1])
                    {
                        romeMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["cmUpperLeft"][0] && player2_pawn.Location.Y == player2_pawnLocations["cmUpperLeft"][1])
                    {
                        cmUpperLeftMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["shanghai"][0] && player2_pawn.Location.Y == player2_pawnLocations["shanghai"][1])
                    {
                        shanghaiMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["vancouver"][0] && player2_pawn.Location.Y == player2_pawnLocations["vancouver"][1])
                    {
                        vancouverMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["freePark"][0] && player2_pawn.Location.Y == player2_pawnLocations["freePark"][1])
                    {
                        freeParkMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["sydney"][0] && player2_pawn.Location.Y == player2_pawnLocations["sydney"][1])
                    {
                        sydneyMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["chanceUpperRight"][0] && player2_pawn.Location.Y == player2_pawnLocations["chanceUpperRight"][1])
                    {
                        chanceUpperRightMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["newYork"][0] && player2_pawn.Location.Y == player2_pawnLocations["newYork"][1])
                    {
                        newYorkMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["london"][0] && player2_pawn.Location.Y == player2_pawnLocations["london"][1])
                    {
                        londonMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["englishHarbour"][0] && player2_pawn.Location.Y == player2_pawnLocations["englishHarbour"][1])
                    {
                        englishHarbourMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["beijing"][0] && player2_pawn.Location.Y == player2_pawnLocations["beijing"][1])
                    {
                        beijingMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["hongKong"][0] && player2_pawn.Location.Y == player2_pawnLocations["hongKong"][1])
                    {
                        hongKongMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["waterWorks"][0] && player2_pawn.Location.Y == player2_pawnLocations["waterWorks"][1])
                    {
                        waterWorksMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["jerusalem"][0] && player2_pawn.Location.Y == player2_pawnLocations["jerusalem"][1])
                    {
                        jerusalemMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["goToJail"][0] && player2_pawn.Location.Y == player2_pawnLocations["goToJail"][1])
                    {
                        goToJailMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["paris"][0] && player2_pawn.Location.Y == player2_pawnLocations["paris"][1])
                    {
                        parisMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["belgrade"][0] && player2_pawn.Location.Y == player2_pawnLocations["belgrade"][1])
                    {
                        belgradeMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["cmLowerRight"][0] && player2_pawn.Location.Y == player2_pawnLocations["cmLowerRight"][1])
                    {
                        cmLowerRightMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["capeTown"][0] && player2_pawn.Location.Y == player2_pawnLocations["capeTown"][1])
                    {
                        capeTownMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["heathrowAirport"][0] && player2_pawn.Location.Y == player2_pawnLocations["heathrowAirport"][1])
                    {
                        heathrowAirportMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["chanceLowerRight"][0] && player2_pawn.Location.Y == player2_pawnLocations["chanceLowerRight"][1])
                    {
                        chanceLowerRightMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["riga"][0] && player2_pawn.Location.Y == player2_pawnLocations["riga"][1])
                    {
                        rigaMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["luxuryTax"][0] && player2_pawn.Location.Y == player2_pawnLocations["luxuryTax"][1])
                    {
                        luxuryTaxMove();
                    }
                    else if (player2_pawn.Location.X == player2_pawnLocations["montreal"][0] && player2_pawn.Location.Y == player2_pawnLocations["montreal"][1])
                    {
                        montrealMove();
                    }
                }
                else if (playerNo == 3)
                {
                    if (player3_pawn.Location.X == player3_pawnLocations["start"][0] && player3_pawn.Location.Y == player3_pawnLocations["start"][1])
                    {
                        startMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["gdynia"][0] && player3_pawn.Location.Y == player3_pawnLocations["gdynia"][1])
                    {
                        gdyniaMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["cmLowerLeft"][0] && player3_pawn.Location.Y == player3_pawnLocations["cmLowerLeft"][1])
                    {
                        cmLowerLeftMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["taipei"][0] && player3_pawn.Location.Y == player3_pawnLocations["taipei"][1])
                    {
                        taipeiMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["incomeTax"][0] && player3_pawn.Location.Y == player3_pawnLocations["incomeTax"][1])
                    {
                        incomeTaxMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["grandCentral"][0] && player3_pawn.Location.Y == player3_pawnLocations["grandCentral"][1])
                    {
                        grandCentralMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["tokyo"][0] && player3_pawn.Location.Y == player3_pawnLocations["tokyo"][1])
                    {
                        tokyoMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["tokyo"][0] && player3_pawn.Location.Y == player3_pawnLocations["tokyo"][1])
                    {
                        tokyoMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["chanceLowerLeft"][0] && player3_pawn.Location.Y == player3_pawnLocations["chanceLowerLeft"][1])
                    {
                        chanceLowerLeftMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["barcelona"][0] && player3_pawn.Location.Y == player3_pawnLocations["barcelona"][1])
                    {
                        barcelonaMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["athens"][0] && player3_pawn.Location.Y == player3_pawnLocations["athens"][1])
                    {
                        athensMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["visitor"][0] && player3_pawn.Location.Y == player3_pawnLocations["visitor"][1])
                    {
                        visitorMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["istanbul"][0] && player3_pawn.Location.Y == player3_pawnLocations["istanbul"][1])
                    {
                        istanbulMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["electricCompany"][0] && player3_pawn.Location.Y == player3_pawnLocations["electricCompany"][1])
                    {
                        electricCompanyMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["kyiv"][0] && player3_pawn.Location.Y == player3_pawnLocations["kyiv"][1])
                    {
                        kyivMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["toronto"][0] && player3_pawn.Location.Y == player3_pawnLocations["toronto"][1])
                    {
                        torontoMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["pooleHarbour"][0] && player3_pawn.Location.Y == player3_pawnLocations["pooleHarbour"][1])
                    {
                        pooleHarbourMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["rome"][0] && player3_pawn.Location.Y == player3_pawnLocations["rome"][1])
                    {
                        romeMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["cmUpperLeft"][0] && player3_pawn.Location.Y == player3_pawnLocations["cmUpperLeft"][1])
                    {
                        cmUpperLeftMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["shanghai"][0] && player3_pawn.Location.Y == player3_pawnLocations["shanghai"][1])
                    {
                        shanghaiMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["vancouver"][0] && player3_pawn.Location.Y == player3_pawnLocations["vancouver"][1])
                    {
                        vancouverMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["freePark"][0] && player3_pawn.Location.Y == player3_pawnLocations["freePark"][1])
                    {
                        freeParkMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["sydney"][0] && player3_pawn.Location.Y == player3_pawnLocations["sydney"][1])
                    {
                        sydneyMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["chanceUpperRight"][0] && player3_pawn.Location.Y == player3_pawnLocations["chanceUpperRight"][1])
                    {
                        chanceUpperRightMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["newYork"][0] && player3_pawn.Location.Y == player3_pawnLocations["newYork"][1])
                    {
                        newYorkMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["london"][0] && player3_pawn.Location.Y == player3_pawnLocations["london"][1])
                    {
                        londonMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["englishHarbour"][0] && player3_pawn.Location.Y == player3_pawnLocations["englishHarbour"][1])
                    {
                        englishHarbourMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["beijing"][0] && player3_pawn.Location.Y == player3_pawnLocations["beijing"][1])
                    {
                        beijingMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["hongKong"][0] && player3_pawn.Location.Y == player3_pawnLocations["hongKong"][1])
                    {
                        hongKongMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["waterWorks"][0] && player3_pawn.Location.Y == player3_pawnLocations["waterWorks"][1])
                    {
                        waterWorksMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["jerusalem"][0] && player3_pawn.Location.Y == player3_pawnLocations["jerusalem"][1])
                    {
                        jerusalemMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["goToJail"][0] && player3_pawn.Location.Y == player3_pawnLocations["goToJail"][1])
                    {
                        goToJailMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["paris"][0] && player3_pawn.Location.Y == player3_pawnLocations["paris"][1])
                    {
                        parisMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["belgrade"][0] && player3_pawn.Location.Y == player3_pawnLocations["belgrade"][1])
                    {
                        belgradeMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["cmLowerRight"][0] && player3_pawn.Location.Y == player3_pawnLocations["cmLowerRight"][1])
                    {
                        cmLowerRightMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["capeTown"][0] && player3_pawn.Location.Y == player3_pawnLocations["capeTown"][1])
                    {
                        capeTownMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["heathrowAirport"][0] && player3_pawn.Location.Y == player3_pawnLocations["heathrowAirport"][1])
                    {
                        heathrowAirportMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["chanceLowerRight"][0] && player3_pawn.Location.Y == player3_pawnLocations["chanceLowerRight"][1])
                    {
                        chanceLowerRightMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["riga"][0] && player3_pawn.Location.Y == player3_pawnLocations["riga"][1])
                    {
                        rigaMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["luxuryTax"][0] && player3_pawn.Location.Y == player3_pawnLocations["luxuryTax"][1])
                    {
                        luxuryTaxMove();
                    }
                    else if (player3_pawn.Location.X == player3_pawnLocations["montreal"][0] && player3_pawn.Location.Y == player3_pawnLocations["montreal"][1])
                    {
                        montrealMove();
                    }
                }
                else if (playerNo == 4)
                {
                    if (player4_pawn.Location.X == player4_pawnLocations["start"][0] && player4_pawn.Location.Y == player4_pawnLocations["start"][1])
                    {
                        startMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["gdynia"][0] && player4_pawn.Location.Y == player4_pawnLocations["gdynia"][1])
                    {
                        gdyniaMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["cmLowerLeft"][0] && player4_pawn.Location.Y == player4_pawnLocations["cmLowerLeft"][1])
                    {
                        cmLowerLeftMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["taipei"][0] && player4_pawn.Location.Y == player4_pawnLocations["taipei"][1])
                    {
                        taipeiMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["incomeTax"][0] && player4_pawn.Location.Y == player4_pawnLocations["incomeTax"][1])
                    {
                        incomeTaxMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["grandCentral"][0] && player4_pawn.Location.Y == player4_pawnLocations["grandCentral"][1])
                    {
                        grandCentralMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["tokyo"][0] && player4_pawn.Location.Y == player4_pawnLocations["tokyo"][1])
                    {
                        tokyoMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["tokyo"][0] && player4_pawn.Location.Y == player4_pawnLocations["tokyo"][1])
                    {
                        tokyoMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["chanceLowerLeft"][0] && player4_pawn.Location.Y == player4_pawnLocations["chanceLowerLeft"][1])
                    {
                        chanceLowerLeftMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["barcelona"][0] && player4_pawn.Location.Y == player4_pawnLocations["barcelona"][1])
                    {
                        barcelonaMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["athens"][0] && player4_pawn.Location.Y == player4_pawnLocations["athens"][1])
                    {
                        athensMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["visitor"][0] && player4_pawn.Location.Y == player4_pawnLocations["visitor"][1])
                    {
                        visitorMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["istanbul"][0] && player4_pawn.Location.Y == player4_pawnLocations["istanbul"][1])
                    {
                        istanbulMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["electricCompany"][0] && player4_pawn.Location.Y == player4_pawnLocations["electricCompany"][1])
                    {
                        electricCompanyMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["kyiv"][0] && player4_pawn.Location.Y == player4_pawnLocations["kyiv"][1])
                    {
                        kyivMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["toronto"][0] && player4_pawn.Location.Y == player4_pawnLocations["toronto"][1])
                    {
                        torontoMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["pooleHarbour"][0] && player4_pawn.Location.Y == player4_pawnLocations["pooleHarbour"][1])
                    {
                        pooleHarbourMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["rome"][0] && player4_pawn.Location.Y == player4_pawnLocations["rome"][1])
                    {
                        romeMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["cmUpperLeft"][0] && player4_pawn.Location.Y == player4_pawnLocations["cmUpperLeft"][1])
                    {
                        cmUpperLeftMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["shanghai"][0] && player4_pawn.Location.Y == player4_pawnLocations["shanghai"][1])
                    {
                        shanghaiMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["vancouver"][0] && player4_pawn.Location.Y == player4_pawnLocations["vancouver"][1])
                    {
                        vancouverMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["freePark"][0] && player4_pawn.Location.Y == player4_pawnLocations["freePark"][1])
                    {
                        freeParkMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["sydney"][0] && player4_pawn.Location.Y == player4_pawnLocations["sydney"][1])
                    {
                        sydneyMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["chanceUpperRight"][0] && player4_pawn.Location.Y == player4_pawnLocations["chanceUpperRight"][1])
                    {
                        chanceUpperRightMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["newYork"][0] && player4_pawn.Location.Y == player4_pawnLocations["newYork"][1])
                    {
                        newYorkMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["london"][0] && player4_pawn.Location.Y == player4_pawnLocations["london"][1])
                    {
                        londonMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["englishHarbour"][0] && player4_pawn.Location.Y == player4_pawnLocations["englishHarbour"][1])
                    {
                        englishHarbourMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["beijing"][0] && player4_pawn.Location.Y == player4_pawnLocations["beijing"][1])
                    {
                        beijingMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["hongKong"][0] && player4_pawn.Location.Y == player4_pawnLocations["hongKong"][1])
                    {
                        hongKongMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["waterWorks"][0] && player4_pawn.Location.Y == player4_pawnLocations["waterWorks"][1])
                    {
                        waterWorksMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["jerusalem"][0] && player4_pawn.Location.Y == player4_pawnLocations["jerusalem"][1])
                    {
                        jerusalemMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["goToJail"][0] && player4_pawn.Location.Y == player4_pawnLocations["goToJail"][1])
                    {
                        goToJailMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["paris"][0] && player4_pawn.Location.Y == player4_pawnLocations["paris"][1])
                    {
                        parisMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["belgrade"][0] && player4_pawn.Location.Y == player4_pawnLocations["belgrade"][1])
                    {
                        belgradeMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["cmLowerRight"][0] && player4_pawn.Location.Y == player4_pawnLocations["cmLowerRight"][1])
                    {
                        cmLowerRightMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["capeTown"][0] && player4_pawn.Location.Y == player4_pawnLocations["capeTown"][1])
                    {
                        capeTownMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["heathrowAirport"][0] && player4_pawn.Location.Y == player4_pawnLocations["heathrowAirport"][1])
                    {
                        heathrowAirportMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["chanceLowerRight"][0] && player4_pawn.Location.Y == player4_pawnLocations["chanceLowerRight"][1])
                    {
                        chanceLowerRightMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["riga"][0] && player4_pawn.Location.Y == player4_pawnLocations["riga"][1])
                    {
                        rigaMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["luxuryTax"][0] && player4_pawn.Location.Y == player4_pawnLocations["luxuryTax"][1])
                    {
                        luxuryTaxMove();
                    }
                    else if (player4_pawn.Location.X == player4_pawnLocations["montreal"][0] && player4_pawn.Location.Y == player4_pawnLocations["montreal"][1])
                    {
                        montrealMove();
                    }
                }


            }
            else
            {
                dice1 = _random.Next(1, 7);
                dice2 = _random.Next(1, 7);
                // if's for animating dice 1
                if (dice1 == 1)
                {
                    picDice1.Image = global::Monopoly_Project.Properties.Resources._1;
                }
                else if (dice1 == 2)
                {
                    picDice1.Image = global::Monopoly_Project.Properties.Resources._2;
                }
                else if (dice1 == 3)
                {
                    picDice1.Image = global::Monopoly_Project.Properties.Resources._3;
                }
                else if (dice1 == 4)
                {
                    picDice1.Image = global::Monopoly_Project.Properties.Resources._4;
                }
                else if (dice1 == 5)
                {
                    picDice1.Image = global::Monopoly_Project.Properties.Resources._5;
                }
                else if (dice1 == 6)
                {
                    picDice1.Image = global::Monopoly_Project.Properties.Resources._6;
                }

                //if's for animating dice 2

                if (dice2 == 1)
                {
                    picDice2.Image = global::Monopoly_Project.Properties.Resources._1;

                }
                else if (dice2 == 2)
                {
                    picDice2.Image = global::Monopoly_Project.Properties.Resources._2;
                }
                else if (dice2 == 3)
                {
                    picDice2.Image = global::Monopoly_Project.Properties.Resources._3;
                }
                else if (dice2 == 4)
                {
                    picDice2.Image = global::Monopoly_Project.Properties.Resources._4;
                }
                else if (dice2 == 5)
                {
                    picDice2.Image = global::Monopoly_Project.Properties.Resources._5;
                }
                else if (dice2 == 6)
                {
                    picDice2.Image = global::Monopoly_Project.Properties.Resources._6;
                }
                dice_total_to_show = dice1 + dice2;
                diceTotal_label.Text = dice_total_to_show.ToString();
            }
        }
        // Move animations
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;

            if (playerNo == 1)
            {
                x = player1_pawn.Location.X;
                y = player1_pawn.Location.Y;
            }
            else if (playerNo == 2)
            {
                x = player2_pawn.Location.X;
                y = player2_pawn.Location.Y;
            }
            else if (playerNo == 3)
            {
                x = player3_pawn.Location.X;
                y = player3_pawn.Location.Y;
            }
            else
            {
                x = player4_pawn.Location.X;
                y = player4_pawn.Location.Y;
            }
            if (landName == "start")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["gdynia"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            gdyniaMove();
                        }
                        else
                        {

                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "gdynia";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("gdynia", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 8, y - 3);
                    if (player2_pawn.Location.X == player2_pawnLocations["gdynia"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            gdyniaMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "gdynia";
                            dataBase.setDiceRolledInside(false);
                            int pos = g.findProperty(buyScreenAt);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)];
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("gdynia", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["gdynia"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            gdyniaMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "gdynia";
                            dataBase.setDiceRolledInside(false);
                            int pos = g.findProperty(buyScreenAt);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)];
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("gdynia", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["gdynia"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            gdyniaMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "gdynia";
                            dataBase.setDiceRolledInside(false);
                            int pos = g.findProperty(buyScreenAt);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)];
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("gdynia", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "gdynia")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 6, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["cmLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerLeftMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawCommunityChestCard();
                            g.communityChestCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_cmn;
                                teleport(playerNo, "start");
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.bank_error_favor_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.beauty_contest_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.birthday_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.doctors_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.hospital_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.income_tax_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.inherit_100_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.life_insurance_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.opera_opening_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.receive_consultancy_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.sale_of_stock_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.school_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.street_repairs_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["cmLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerLeftMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawCommunityChestCard();
                            g.communityChestCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_cmn;
                                teleport(playerNo, "start");
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.bank_error_favor_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.beauty_contest_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.birthday_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.doctors_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.hospital_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.income_tax_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.inherit_100_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.life_insurance_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.opera_opening_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.receive_consultancy_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.sale_of_stock_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.school_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.street_repairs_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y - 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["cmLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerLeftMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawCommunityChestCard();
                            g.communityChestCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_cmn;
                                teleport(playerNo, "start");
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.bank_error_favor_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.beauty_contest_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.birthday_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.doctors_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.hospital_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.income_tax_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.inherit_100_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.life_insurance_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.opera_opening_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.receive_consultancy_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.sale_of_stock_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.school_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.street_repairs_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["cmLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerLeftMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawCommunityChestCard();
                            g.communityChestCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_cmn;
                                teleport(playerNo, "start");
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.bank_error_favor_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.beauty_contest_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.birthday_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.doctors_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.hospital_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.income_tax_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.inherit_100_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.life_insurance_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.opera_opening_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.receive_consultancy_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.sale_of_stock_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.school_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.street_repairs_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
            }
            else if (landName == "cmLowerLeft")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 8, y - 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["taipei"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            taipeiMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "taipei";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("taipei", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["taipei"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            taipeiMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "taipei";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("taipei", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["taipei"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            taipeiMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "taipei";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("taipei", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 6, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["taipei"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            taipeiMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "taipei";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("taipei", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "taipei")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 6, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["incomeTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            incomeTaxMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            g.payTax();
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 6, y - 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["incomeTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            incomeTaxMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            g.payTax();
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["incomeTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            incomeTaxMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            g.payTax();
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["incomeTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            incomeTaxMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            g.payTax();
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                        }
                    }
                }
            }
            else if (landName == "incomeTax")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y - 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["grandCentral"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            grandCentralMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "grandCentral";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("grandCentral", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 6, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["grandCentral"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            grandCentralMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "grandCentral";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("grandCentral", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y - 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["grandCentral"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            grandCentralMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "grandCentral";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("grandCentral", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 8, y - 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["grandCentral"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            grandCentralMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "grandCentral";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("grandCentral", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "grandCentral")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 8, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["tokyo"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            tokyoMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "tokyo";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("tokyo", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 8, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["tokyo"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            tokyoMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "tokyo";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("tokyo", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["tokyo"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            tokyoMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "tokyo";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("tokyo", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 6, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["tokyo"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            tokyoMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "tokyo";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("tokyo", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "tokyo")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 6, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["chanceLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerLeftMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawChanceCard();
                            g.chanceCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_istanbul_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "istanbul");
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_london_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "london");
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_montreal_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "montreal");
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advanec_to_station;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "pooleHarbour");
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.banks_pay_dividend_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.crossword_competition_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.building_loan_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.elected_chairman_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.general_repair_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_chance;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_back_3_spaces_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "incomeTax");
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "visitor");
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.pay_poor_tax_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.take_trip_to_station_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.to_nearest_utility_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "electricCompany");
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 6, y - 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["chanceLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerLeftMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawChanceCard();
                            g.chanceCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_istanbul_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "istanbul");
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_london_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "london");
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_montreal_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "montreal");
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advanec_to_station;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "pooleHarbour");
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.banks_pay_dividend_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.crossword_competition_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.building_loan_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.elected_chairman_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.general_repair_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_chance;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_back_3_spaces_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "incomeTax");
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "visitor");
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.pay_poor_tax_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.take_trip_to_station_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.to_nearest_utility_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "electricCompany");
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 6, y - 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["chanceLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerLeftMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawChanceCard();
                            g.chanceCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_istanbul_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "istanbul");
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_london_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "london");
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_montreal_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "montreal");
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advanec_to_station;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "pooleHarbour");
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.banks_pay_dividend_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.crossword_competition_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.building_loan_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.elected_chairman_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.general_repair_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_chance;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_back_3_spaces_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "incomeTax");
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "visitor");
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.pay_poor_tax_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.take_trip_to_station_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.to_nearest_utility_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "electricCompany");
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["chanceLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerLeftMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawChanceCard();
                            g.chanceCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_istanbul_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "istanbul");
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_london_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "london");
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_montreal_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "montreal");
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advanec_to_station;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "pooleHarbour");
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.banks_pay_dividend_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.crossword_competition_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.building_loan_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.elected_chairman_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.general_repair_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_chance;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_back_3_spaces_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "incomeTax");
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "visitor");
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.pay_poor_tax_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.take_trip_to_station_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.to_nearest_utility_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "electricCompany");
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
            }
            else if (landName == "chanceLowerLeft")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 8, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["barcelona"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            barcelonaMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "barcelona";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("barcelona", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 8, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["barcelona"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            barcelonaMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "barcelona";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("barcelona", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 8, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["barcelona"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            barcelonaMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "barcelona";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("barcelona", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y - 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["barcelona"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            barcelonaMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "barcelona";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("barcelona", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "barcelona")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["athens"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            athensMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "athens";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("athens", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["athens"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            athensMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "athens";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("athens", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 6, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["athens"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            athensMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "athens";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("athens", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["athens"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            athensMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "athens";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("athens", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "athens")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 6, y - 6);
                    if (player1_pawn.Location.X == player1_pawnLocations["visitor"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            visitorMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 13, y - 6);
                    if (player2_pawn.Location.X == player2_pawnLocations["visitor"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            visitorMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 6, y - 3);
                    if (player3_pawn.Location.X == player3_pawnLocations["visitor"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            visitorMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["visitor"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            visitorMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
            else if (landName == "visitor")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 8, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["istanbul"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            istanbulMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "istanbul";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("istanbul", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["istanbul"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            istanbulMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "istanbul";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("istanbul", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 11, y - 6);
                    if (player3_pawn.Location.X == player3_pawnLocations["istanbul"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            istanbulMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "istanbul";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("istanbul", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 6, y - 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["istanbul"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            istanbulMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "istanbul";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("istanbul", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "istanbul")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 6, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["electricCompany"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            electricCompanyMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "electricCompany";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("electricCompany", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["electricCompany"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            electricCompanyMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "electricCompany";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("electricCompany", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 7, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["electricCompany"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            electricCompanyMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "electricCompany";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("electricCompany", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 8, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["electricCompany"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            electricCompanyMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "electricCompany";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("electricCompany", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "electricCompany")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["kyiv"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            kyivMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "kyiv";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("kyiv", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["kyiv"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            kyivMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "kyiv";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("kyiv", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 8, y - 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["kyiv"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            kyivMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "kyiv";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("kyiv", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 5, y - 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["kyiv"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            kyivMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "kyiv";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("kyiv", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "kyiv")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["toronto"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            torontoMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "toronto";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("toronto", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["toronto"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            torontoMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "toronto";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("toronto", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 6, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["toronto"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            torontoMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "toronto";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("toronto", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["toronto"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            torontoMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "toronto";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("toronto", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "toronto")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["pooleHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            pooleHarbourMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "pooleHarbour";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("pooleHarbour", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["pooleHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            pooleHarbourMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "pooleHarbour";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("pooleHarbour", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 8, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["pooleHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            pooleHarbourMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "pooleHarbour";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("pooleHarbour", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 8, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["pooleHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            pooleHarbourMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "pooleHarbour";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("pooleHarbour", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "pooleHarbour")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["rome"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            romeMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "rome";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("rome", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["rome"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            romeMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "rome";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("rome", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 6, y - 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["rome"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            romeMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "rome";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("rome", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 6, y - 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["rome"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            romeMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "rome";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("rome", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "rome")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["cmUpperLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmUpperLeftMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawCommunityChestCard();
                            g.communityChestCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.bank_error_favor_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.beauty_contest_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.birthday_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.doctors_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.hospital_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.income_tax_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.inherit_100_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.life_insurance_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.opera_opening_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.receive_consultancy_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.sale_of_stock_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.school_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.street_repairs_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["cmUpperLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmUpperLeftMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawCommunityChestCard();
                            g.communityChestCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.bank_error_favor_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.beauty_contest_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.birthday_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.doctors_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.hospital_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.income_tax_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.inherit_100_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.life_insurance_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.opera_opening_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.receive_consultancy_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.sale_of_stock_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.school_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.street_repairs_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 8, y - 3);
                    if (player3_pawn.Location.X == player3_pawnLocations["cmUpperLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmUpperLeftMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawCommunityChestCard();
                            g.communityChestCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.bank_error_favor_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.beauty_contest_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.birthday_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.doctors_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.hospital_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.income_tax_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.inherit_100_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.life_insurance_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.opera_opening_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.receive_consultancy_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.sale_of_stock_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.school_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.street_repairs_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 8, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["cmUpperLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmUpperLeftMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawCommunityChestCard();
                            g.communityChestCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.bank_error_favor_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.beauty_contest_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.birthday_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.doctors_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.hospital_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.income_tax_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.inherit_100_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.life_insurance_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.opera_opening_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.receive_consultancy_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.sale_of_stock_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.school_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.street_repairs_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
            }
            else if (landName == "cmUpperLeft")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["shanghai"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            shanghaiMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "shanghai";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("shanghai", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 6, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["shanghai"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            shanghaiMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "shanghai";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("shanghai", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 6, y - 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["shanghai"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            shanghaiMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "shanghai";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("shanghai", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 6, y - 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["shanghai"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            shanghaiMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "shanghai";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("shanghai", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "shanghai")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["vancouver"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            vancouverMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "vancouver";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("vancouver", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["vancouver"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            vancouverMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "vancouver";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("vancouver", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 7, y - 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["vancouver"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            vancouverMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "vancouver";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("vancouver", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["vancouver"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            vancouverMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "vancouver";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("vancouver", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "vancouver")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["freePark"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            freeParkMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["freePark"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            freeParkMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 5, y - 1);
                    if (player3_pawn.Location.X == player3_pawnLocations["freePark"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            freeParkMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 12, y - 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["freePark"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            freeParkMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
            else if (landName == "freePark")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 11, y + 7);
                    if (player1_pawn.Location.X == player1_pawnLocations["sydney"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            sydneyMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "sydney";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("sydney", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 11, y + 2);
                    if (player2_pawn.Location.X == player2_pawnLocations["sydney"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            sydneyMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "sydney";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("sydney", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 4, y + 1);
                    if (player3_pawn.Location.X == player3_pawnLocations["sydney"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            sydneyMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "sydney";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("sydney", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 5, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["sydney"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            sydneyMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "sydney";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("sydney", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "sydney")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["chanceUpperRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceUpperRightMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawChanceCard();
                            g.chanceCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_istanbul_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "istanbul");
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_london_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "london");
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_montreal_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "montreal");
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advanec_to_station;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "englishHarbour");
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.banks_pay_dividend_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.crossword_competition_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.building_loan_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.elected_chairman_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.general_repair_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_chance;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_back_3_spaces_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "vancouver");
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "visitor");
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.pay_poor_tax_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.take_trip_to_station_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.to_nearest_utility_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "waterWorks");
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["chanceUpperRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceUpperRightMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawChanceCard();
                            g.chanceCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_istanbul_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "istanbul");
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_london_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "london");
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_montreal_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "montreal");
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advanec_to_station;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "englishHarbour");
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.banks_pay_dividend_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.crossword_competition_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.building_loan_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.elected_chairman_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.general_repair_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_chance;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_back_3_spaces_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "vancouver");
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "visitor");
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.pay_poor_tax_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.take_trip_to_station_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.to_nearest_utility_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "waterWorks");
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 6, y + 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["chanceUpperRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceUpperRightMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawChanceCard();
                            g.chanceCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_istanbul_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "istanbul");
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_london_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "london");
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_montreal_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "montreal");
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advanec_to_station;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "englishHarbour");
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.banks_pay_dividend_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.crossword_competition_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.building_loan_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.elected_chairman_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.general_repair_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_chance;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_back_3_spaces_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "vancouver");
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "visitor");
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.pay_poor_tax_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.take_trip_to_station_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.to_nearest_utility_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "waterWorks");
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 6, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["chanceUpperRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceUpperRightMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawChanceCard();
                            g.chanceCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_istanbul_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "istanbul");
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_london_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "london");
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_montreal_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "montreal");
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advanec_to_station;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "englishHarbour");
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.banks_pay_dividend_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.crossword_competition_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.building_loan_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.elected_chairman_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.general_repair_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_chance;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_back_3_spaces_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "vancouver");
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "visitor");
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.pay_poor_tax_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.take_trip_to_station_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.to_nearest_utility_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "waterWorks");
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
            }
            else if (landName == "chanceUpperRight")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["newYork"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            newYorkMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "newYork";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("newYork", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["newYork"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            newYorkMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "newYork";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("newYork", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 8, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["newYork"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            newYorkMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "newYork";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("newYork", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 8, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["newYork"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            newYorkMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "newYork";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("newYork", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "newYork")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["london"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            londonMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "london";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("london", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["london"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            londonMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "london";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("london", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 7, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["london"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            londonMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "london";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("london", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 6, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["london"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            londonMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "london";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("london", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "london")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["englishHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            englishHarbourMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "englishHarbour";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("englishHarbour", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 6, y + 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["englishHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            englishHarbourMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "englishHarbour";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("englishHarbour", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 6, y + 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["englishHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            englishHarbourMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "englishHarbour";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("englishHarbour", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 6, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["englishHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            englishHarbourMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "englishHarbour";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("englishHarbour", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "englishHarbour")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["beijing"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            beijingMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "beijing";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("beijing", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["beijing"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            beijingMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "beijing";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("beijing", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 8, y + 3);
                    if (player3_pawn.Location.X == player3_pawnLocations["beijing"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            beijingMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "beijing";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("beijing", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 9, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["beijing"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            beijingMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "beijing";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("beijing", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "beijing")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["hongKong"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            hongKongMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "hongKong";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("hongKong", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["hongKong"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            hongKongMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "hongKong";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("hongKong", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 7, y + 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["hongKong"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            hongKongMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "hongKong";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("hongKong", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 7, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["hongKong"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            hongKongMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "hongKong";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("hongKong", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "hongKong")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["waterWorks"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            waterWorksMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "waterWorks";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("waterWorks", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["waterWorks"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            waterWorksMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "waterWorks";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("waterWorks", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 6, y + 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["waterWorks"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            waterWorksMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "waterWorks";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("waterWorks", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 5, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["waterWorks"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            waterWorksMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "waterWorks";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("waterWorks", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "waterWorks")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 6, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["jerusalem"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            jerusalemMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "jerusalem";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("jerusalem", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["jerusalem"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            jerusalemMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "jerusalem";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("jerusalem", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 8, y + 3);
                    if (player3_pawn.Location.X == player3_pawnLocations["jerusalem"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            jerusalemMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "jerusalem";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("jerusalem", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 8, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["jerusalem"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            jerusalemMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "jerusalem";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("jerusalem", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "jerusalem")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["goToJail"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            goToJailMove();
                        }
                        else
                        {
                            // TO DO
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["goToJail"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            goToJailMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 5, y + 6);
                    if (player3_pawn.Location.X == player3_pawnLocations["goToJail"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            goToJailMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 6, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["goToJail"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            goToJailMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
            else if (landName == "goToJail")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 10, y + 6);
                    if (player1_pawn.Location.X == player1_pawnLocations["paris"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            parisMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "paris";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("paris", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 3, y + 7);
                    if (player2_pawn.Location.X == player2_pawnLocations["paris"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            parisMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "paris";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("paris", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 5, y + 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["paris"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            parisMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "paris";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("paris", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y);
                    if (player4_pawn.Location.X == player4_pawnLocations["paris"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            parisMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "paris";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("paris", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "paris")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["belgrade"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            belgradeMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "belgrade";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("belgrade", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["belgrade"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            belgradeMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "belgrade";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("belgrade", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["belgrade"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            belgradeMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "belgrade";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("belgrade", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 6, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["belgrade"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            belgradeMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "belgrade";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("belgrade", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "belgrade")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["cmLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerRightMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawCommunityChestCard();
                            g.communityChestCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_cmn;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.bank_error_favor_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.beauty_contest_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.birthday_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.doctors_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.hospital_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.income_tax_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.inherit_100_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.life_insurance_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.opera_opening_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.receive_consultancy_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.sale_of_stock_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.school_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.street_repairs_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["cmLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerRightMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawCommunityChestCard();
                            g.communityChestCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_cmn;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.bank_error_favor_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.beauty_contest_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.birthday_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.doctors_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.hospital_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.income_tax_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.inherit_100_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.life_insurance_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.opera_opening_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.receive_consultancy_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.sale_of_stock_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.school_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.street_repairs_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 8, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["cmLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerRightMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawCommunityChestCard();
                            g.communityChestCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_cmn;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.bank_error_favor_cmn;
                                ch_cm_panel.Visible = true;

                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.beauty_contest_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.birthday_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.doctors_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.hospital_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.income_tax_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.inherit_100_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.life_insurance_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.opera_opening_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.receive_consultancy_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.sale_of_stock_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.school_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.street_repairs_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 8, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["cmLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerRightMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawCommunityChestCard();
                            g.communityChestCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_cmn;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.bank_error_favor_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.beauty_contest_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.birthday_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.doctors_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.hospital_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.income_tax_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.inherit_100_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.life_insurance_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.opera_opening_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.receive_consultancy_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.sale_of_stock_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.school_fee_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.street_repairs_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                        }
                    }
                }
            }
            else if (landName == "cmLowerRight")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["capeTown"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            capeTownMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "capeTown";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("capeTown", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["capeTown"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            capeTownMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "capeTown";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("capeTown", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 6, y + 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["capeTown"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            capeTownMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "capeTown";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("capeTown", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 6, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["capeTown"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            capeTownMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "capeTown";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("capeTown", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "capeTown")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["heathrowAirport"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            heathrowAirportMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "heathrowAirport";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("heathrowAirport", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["heathrowAirport"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            heathrowAirportMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "heathrowAirport";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("heathrowAirport", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 8, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["heathrowAirport"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            heathrowAirportMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "heathrowAirport";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("heathrowAirport", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 8, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["heathrowAirport"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            heathrowAirportMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "heathrowAirport";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.utility;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (station_buy stationBuy = new station_buy("heathrowAirport", ref dataBase, ref g))
                                    {
                                        stationBuy.ShowDialog();
                                    }
                                    state = CurWaitingFor.utility;
                                }
                                else
                                {
                                    state = CurWaitingFor.utility;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "heathrowAirport")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["chanceLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerRightMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawChanceCard();
                            g.chanceCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_istanbul_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "istanbul");
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_london_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "london");
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_montreal_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "montreal");
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advanec_to_station;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "grandCentral");
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.banks_pay_dividend_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.crossword_competition_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.building_loan_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.elected_chairman_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.general_repair_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_chance;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_back_3_spaces_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "cmLowerRight");
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "visitor");
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.pay_poor_tax_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.take_trip_to_station_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.to_nearest_utility_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "electricCompany");
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["chanceLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerRightMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawChanceCard();
                            g.chanceCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_istanbul_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "istanbul");
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_london_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "london");
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_montreal_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "montreal");
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advanec_to_station;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "grandCentral");
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.banks_pay_dividend_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.crossword_competition_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.building_loan_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.elected_chairman_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.general_repair_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_chance;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_back_3_spaces_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "cmLowerRight");
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "visitor");
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.pay_poor_tax_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.take_trip_to_station_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.to_nearest_utility_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "electricCompany");
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["chanceLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerRightMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawChanceCard();
                            g.chanceCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_istanbul_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "istanbul");
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_london_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "london");
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_montreal_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "montreal");
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advanec_to_station;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "grandCentral");
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.banks_pay_dividend_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.crossword_competition_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.building_loan_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.elected_chairman_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.general_repair_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_chance;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_back_3_spaces_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "cmLowerRight");
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "visitor");
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.pay_poor_tax_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.take_trip_to_station_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.to_nearest_utility_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "electricCompany");
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["chanceLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerRightMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            int c = g.drawChanceCard();
                            g.chanceCard(c);
                            if (c == 0)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_go_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "start");
                            }
                            else if (c == 1)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_istanbul_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "istanbul");
                            }
                            else if (c == 2)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_london_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "london");
                            }
                            else if (c == 3)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_montreal_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "montreal");
                            }
                            else if (c == 4)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advanec_to_station;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "grandCentral");
                            }
                            else if (c == 5)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.banks_pay_dividend_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 6)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.crossword_competition_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 7)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.building_loan_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 8)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.elected_chairman_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 9)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.general_repair_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 10)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.get_out_jail_chance;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 11)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_back_3_spaces_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "cmLowerRight");
                            }
                            else if (c == 12)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "visitor");
                            }
                            else if (c == 13)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.pay_poor_tax_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 14)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.take_trip_to_station_ch;
                                ch_cm_panel.Visible = true;
                            }
                            else if (c == 15)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.to_nearest_utility_ch;
                                ch_cm_panel.Visible = true;
                                teleport(playerNo, "electricCompany");
                            }
                            else if (c == 16)
                            {
                                ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.xmas_fund_cmn;
                                ch_cm_panel.Visible = true;
                            }
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            if (g.currPlayer == dataBase.myID)
                            {
                                endTurnButton.Enabled = true;
                            }
                        }
                    }
                }
            }
            else if (landName == "chanceLowerRight")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["riga"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            rigaMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "riga";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("riga", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["riga"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            rigaMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "riga";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("riga", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 5, y + 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["riga"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            rigaMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "riga";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("riga", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 6, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["riga"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            rigaMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "riga";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("riga", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "riga")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["luxuryTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            luxuryTaxMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            g.payTax();
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["luxuryTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            luxuryTaxMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            g.payTax();
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 8, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["luxuryTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            luxuryTaxMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            g.payTax();
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 8, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["luxuryTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            luxuryTaxMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            dataBase.setDiceRolledInside(false);
                            state = default;
                            g.payTax();
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                        }
                    }
                }
            }
            else if (landName == "luxuryTax")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["montreal"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            montrealMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "montreal";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("montreal", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["montreal"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            montrealMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "montreal";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("montreal", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 6, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["montreal"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            montrealMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "montreal";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("montreal", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 6, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["montreal"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            montrealMove();
                        }
                        else
                        {
                            flagElse = true;
                            flagEndTurn = true;
                            flagEndTurnIf = true;

                            buyScreenAt = "montreal";
                            int pos = g.findProperty(buyScreenAt);
                            dataBase.setDiceRolledInside(false);
                            if (g.isOwned(pos))
                            {
                                if (g.isOwnedBy(g.currPlayer))
                                {
                                    //nothing
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    g.payRent();
                                    winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " has paid " + g.getRentOnProperty(pos) + "$ rent to " + dataBase.pdb[g.getPlayerNameOnProperty(pos)].name;
                                    player1_money.Text = g.parr[0].money.ToString();
                                    player2_money.Text = g.parr[1].money.ToString();
                                    player3_money.Text = g.parr[2].money.ToString();
                                    player4_money.Text = g.parr[3].money.ToString();
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            else
                            {
                                if (g.currPlayer == dataBase.myID)
                                {

                                    using (buy_property_screen buyPropScreen = new buy_property_screen("montreal", ref dataBase, ref state, g.getVeto(playerNo - 1), ref g))
                                    {
                                        buyPropScreen.ShowDialog();
                                    }
                                    state = CurWaitingFor.buyScreen;
                                }
                                else
                                {
                                    state = CurWaitingFor.buyScreen;
                                }
                            }
                            if (g.currPlayer == dataBase.myID)
                                endTurnButton.Enabled = true;
                        }
                    }
                }
            }
            else if (landName == "montreal")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 8, y);
                    if (player1_pawn.Location.X == player1_pawnLocations["start"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            startMove();
                        }
                        else
                        {

                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 3);
                    if (player2_pawn.Location.X == player2_pawnLocations["start"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            startMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 9, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["start"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            startMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 8, y + 7);
                    if (player4_pawn.Location.X == player4_pawnLocations["start"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            startMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //testShowProp.Tag = "gdynia";
            //button5.Text = testShowProp.Tag.ToString();
            using (buy_property_screen buyPropScreen = new buy_property_screen(landName))
            {
                buyPropScreen.ShowDialog();
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            /*
                using (bidding_screen bidScreen = new bidding_screen("newYork"))
                {
                    bidScreen.ShowDialog();
                }
            */
        }

        private void playButtonClick() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Monopoly_Project.Properties.Resources.button_click); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }
        private void player1_show_info_Click(object sender, EventArgs e)
        {
            playButtonClick();
            List<string> props = g.parr[0].assets;
            using (ShowPropertiesScreen showPropsScreen = new ShowPropertiesScreen(props, 1, dataBase.pdb[0].name, player1_icon.Image, ref dataBase, ref g))
            {
                showPropsScreen.ShowDialog();
            }
        }

        private void player2_show_info_Click(object sender, EventArgs e)
        {
            // ARR DENEME YERİNE PLAYER.GETPROPERTİES OLACAK EZZZZZZZ
            playButtonClick();
            List<string> props = g.parr[1].assets;
            using (ShowPropertiesScreen showPropsScreen = new ShowPropertiesScreen(props, 2, dataBase.pdb[1].name, player2_icon.Image, ref dataBase, ref g))
            {
                showPropsScreen.ShowDialog();
            }
        }

        private void playe3_show_info_Click(object sender, EventArgs e)
        {
            playButtonClick();
            List<string> props = g.parr[2].assets;
            using (ShowPropertiesScreen showPropsScreen = new ShowPropertiesScreen(props, 3, dataBase.pdb[2].name, player3_icon.Image, ref dataBase, ref g))
            {
                showPropsScreen.ShowDialog();
            }
        }

        private void player4_show_info_Click(object sender, EventArgs e)
        {
            playButtonClick();
            List<string> props = g.parr[3].assets;
            using (ShowPropertiesScreen showPropsScreen = new ShowPropertiesScreen(props, 4, dataBase.pdb[2].name, player4_icon.Image, ref dataBase, ref g))
            {
                showPropsScreen.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (outJail_screen outJailScreen = new outJail_screen())
            {
                outJailScreen.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setBuildHousePanel(200, 1, "gdynia");
            buildHousePanel.Visible = true;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            buildHousePanel.Visible = false;
        }

        private void houseBuild_Click(object sender, EventArgs e)
        {
            playButtonClick();
            int buildHouseCount = _random.Next(1, 5);

            count++;
            houseBuild.Text = "Count:  " + count.ToString();
            buildHotel.Text = "ith house: " + buildHouseCount.ToString();
            if (count == 22)
            {
                count = 0;
            }
            string[] arr = { "gdynia", "taipei", "tokyo" , "barcelona" ,"athens" ,"istanbul" , "kyiv", "toronto" , "rome", "shanghai","vancouver", "sydney",
                            "newYork", "london", "beijing", "hongKong", "jerusalem", "paris", "belgrade", "capeTown", "riga", "montreal"};
            buildHouselandName = arr[count];
            if (buildHouselandName == "gdynia")
            {
                if (buildHouseCount == 1)
                {
                    gdyniaHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    gdyniaHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    gdyniaHouse3.Visible = true;
                }
                else // 4
                {
                    gdyniaHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "taipei")
            {
                if (buildHouseCount == 1)
                {
                    taipeiHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    taipeiHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    taipeiHouse3.Visible = true;
                }
                else // 4
                {
                    taipeiHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "tokyo")
            {
                if (buildHouseCount == 1)
                {
                    tokyoHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    tokyoHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    tokyoHouse3.Visible = true;
                }
                else // 4
                {
                    tokyoHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "barcelona")
            {
                if (buildHouseCount == 1)
                {
                    barcelonaHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    barcelonaHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    barcelonaHouse3.Visible = true;
                }
                else // 4
                {
                    barcelonaHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "athens")
            {
                if (buildHouseCount == 1)
                {
                    athensHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    athensHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    athensHouse3.Visible = true;
                }
                else // 4
                {
                    athensHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "istanbul")
            {
                if (buildHouseCount == 1)
                {
                    istanbulHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    istanbulHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    istanbulHouse3.Visible = true;
                }
                else // 4
                {
                    istanbulHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "kyiv")
            {
                if (buildHouseCount == 1)
                {
                    kyivHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    kyivHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    kyivHouse3.Visible = true;
                }
                else // 4
                {
                    kyivHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "toronto")
            {
                if (buildHouseCount == 1)
                {
                    torontoHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    torontoHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    torontoHouse3.Visible = true;
                }
                else // 4
                {
                    torontoHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "rome")
            {
                if (buildHouseCount == 1)
                {
                    romeHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    romeHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    romeHouse3.Visible = true;
                }
                else // 4
                {
                    romeHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "shanghai")
            {
                if (buildHouseCount == 1)
                {
                    shanghaiHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    shanghaiHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    shanghaiHouse3.Visible = true;
                }
                else // 4
                {
                    shanghaiHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "vancouver")
            {
                if (buildHouseCount == 1)
                {
                    vancouverHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    vancouverHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    vancouverHouse3.Visible = true;
                }
                else // 4
                {
                    vancouverHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "sydney")
            {
                if (buildHouseCount == 1)
                {
                    sydneyHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    sydneyHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    sydneyHouse3.Visible = true;
                }
                else // 4
                {
                    sydneyHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "newYork")
            {
                if (buildHouseCount == 1)
                {
                    newYorkHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    newYorkHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    newYorkHouse3.Visible = true;
                }
                else // 4
                {
                    newYorkHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "london")
            {
                if (buildHouseCount == 1)
                {
                    londonHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    londonHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    londonHouse3.Visible = true;
                }
                else // 4
                {
                    londonHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "beijing")
            {
                if (buildHouseCount == 1)
                {
                    beijingHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    beijingHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    beijingHouse3.Visible = true;
                }
                else // 4
                {
                    beijingHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "hongKong")
            {
                if (buildHouseCount == 1)
                {
                    hongKongHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    hongKongHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    hongKongHouse3.Visible = true;
                }
                else // 4
                {
                    hongKongHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "jerusalem")
            {
                if (buildHouseCount == 1)
                {
                    jerusalemHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    jerusalemHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    jerusalemHouse3.Visible = true;
                }
                else // 4
                {
                    jerusalemHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "paris")
            {
                if (buildHouseCount == 1)
                {
                    parisHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    parisHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    parisHouse3.Visible = true;
                }
                else // 4
                {
                    parisHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "belgrade")
            {
                if (buildHouseCount == 1)
                {
                    belgradeHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    belgradeHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    belgradeHouse3.Visible = true;
                }
                else // 4
                {
                    belgradeHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "capeTown")
            {
                if (buildHouseCount == 1)
                {
                    capeTownHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    capeTownHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    capeTownHouse3.Visible = true;
                }
                else // 4
                {
                    capeTownHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "riga")
            {
                if (buildHouseCount == 1)
                {
                    rigaHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    rigaHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    rigaHouse3.Visible = true;
                }
                else // 4
                {
                    rigaHouse4.Visible = true;
                }
            }
            else if (buildHouselandName == "montreal")
            {
                if (buildHouseCount == 1)
                {
                    montrealHouse1.Visible = true;
                }
                else if (buildHouseCount == 2)
                {
                    montrealHouse2.Visible = true;
                }
                else if (buildHouseCount == 3)
                {
                    montrealHouse3.Visible = true;
                }
                else // 4
                {
                    montrealHouse4.Visible = true;
                }
            }

        }
        int count = 0;
        private void buildHotel_Click(object sender, EventArgs e)
        {
            playButtonClick();
            count++;
            if (count == 22)
            {
                count = 0;
            }
            string[] arr = { "gdynia", "taipei", "tokyo" , "barcelona" ,"athens" ,"istanbul" , "kyiv", "toronto" , "rome", "shanghai","vancouver", "sydney",
                            "newYork", "london", "beijing", "hongKong", "jerusalem", "paris", "belgrade", "capeTown", "riga", "montreal"};
            buildHotellandName = arr[count];
            if (buildHotellandName == "gdynia")
            {
                gdyniaHouse1.Visible = false;
                gdyniaHouse2.Visible = false;
                gdyniaHouse3.Visible = false;
                gdyniaHouse4.Visible = false;
                gdyniaHotel.Visible = true;
            }
            else if (buildHotellandName == "taipei")
            {
                taipeiHouse1.Visible = false;
                taipeiHouse2.Visible = false;
                taipeiHouse3.Visible = false;
                taipeiHouse4.Visible = false;
                taipeiHotel.Visible = true;
            }
            else if (buildHotellandName == "tokyo")
            {
                tokyoHouse1.Visible = false;
                tokyoHouse2.Visible = false;
                tokyoHouse3.Visible = false;
                tokyoHouse4.Visible = false;
                tokyoHotel.Visible = true;
            }
            else if (buildHotellandName == "barcelona")
            {
                barcelonaHouse1.Visible = false;
                barcelonaHouse2.Visible = false;
                barcelonaHouse3.Visible = false;
                barcelonaHouse4.Visible = false;
                barcelonaHotel.Visible = true;
            }
            else if (buildHotellandName == "athens")
            {
                athensHouse1.Visible = false;
                athensHouse2.Visible = false;
                athensHouse3.Visible = false;
                athensHouse4.Visible = false;
                athensHotel.Visible = true;
            }
            else if (buildHotellandName == "istanbul")
            {
                istanbulHouse1.Visible = false;
                istanbulHouse2.Visible = false;
                istanbulHouse3.Visible = false;
                istanbulHouse4.Visible = false;
                istanbulHotel.Visible = true;
            }
            else if (buildHotellandName == "kyiv")
            {
                kyivHouse1.Visible = false;
                kyivHouse2.Visible = false;
                kyivHouse3.Visible = false;
                kyivHouse4.Visible = false;
                kyivHotel.Visible = true;
            }
            else if (buildHotellandName == "toronto")
            {
                torontoHouse1.Visible = false;
                torontoHouse2.Visible = false;
                torontoHouse3.Visible = false;
                torontoHouse4.Visible = false;
                torontoHotel.Visible = true;
            }
            else if (buildHotellandName == "rome")
            {
                romeHouse1.Visible = false;
                romeHouse2.Visible = false;
                romeHouse3.Visible = false;
                romeHouse4.Visible = false;
                romeHotel.Visible = true;
            }
            else if (buildHotellandName == "shanghai")
            {
                shanghaiHouse1.Visible = false;
                shanghaiHouse2.Visible = false;
                shanghaiHouse3.Visible = false;
                shanghaiHouse4.Visible = false;
                shanghaiHotel.Visible = true;
            }
            else if (buildHotellandName == "vancouver")
            {
                vancouverHouse1.Visible = false;
                vancouverHouse2.Visible = false;
                vancouverHouse3.Visible = false;
                vancouverHouse4.Visible = false;
                vancouverHotel.Visible = true;
            }
            else if (buildHotellandName == "sydney")
            {
                sydneyHouse1.Visible = false;
                sydneyHouse2.Visible = false;
                sydneyHouse3.Visible = false;
                sydneyHouse4.Visible = false;
                sydneyHotel.Visible = true;
            }
            else if (buildHotellandName == "newYork")
            {
                newYorkHouse1.Visible = false;
                newYorkHouse2.Visible = false;
                newYorkHouse3.Visible = false;
                newYorkHouse4.Visible = false;
                newYorkHotel.Visible = true;
            }
            else if (buildHotellandName == "london")
            {
                londonHouse1.Visible = false;
                londonHouse2.Visible = false;
                londonHouse3.Visible = false;
                londonHouse4.Visible = false;
                londonHotel.Visible = true;
            }
            else if (buildHotellandName == "beijing")
            {
                beijingHouse1.Visible = false;
                beijingHouse2.Visible = false;
                beijingHouse3.Visible = false;
                beijingHouse4.Visible = false;
                beijingHotel.Visible = true;
            }
            else if (buildHotellandName == "hongKong")
            {
                hongKongHouse1.Visible = false;
                hongKongHouse2.Visible = false;
                hongKongHouse3.Visible = false;
                hongKongHouse4.Visible = false;
                hongKongHotel.Visible = true;
            }
            else if (buildHotellandName == "jerusalem")
            {
                jerusalemHouse1.Visible = false;
                jerusalemHouse2.Visible = false;
                jerusalemHouse3.Visible = false;
                jerusalemHouse4.Visible = false;
                jerusalemHotel.Visible = true;
            }
            else if (buildHotellandName == "paris")
            {
                parisHouse1.Visible = false;
                parisHouse2.Visible = false;
                parisHouse3.Visible = false;
                parisHouse4.Visible = false;
                parisHotel.Visible = true;
            }
            else if (buildHotellandName == "belgrade")
            {
                belgradeHouse1.Visible = false;
                belgradeHouse2.Visible = false;
                belgradeHouse3.Visible = false;
                belgradeHouse4.Visible = false;
                belgradeHotel.Visible = true;
            }
            else if (buildHotellandName == "capeTown")
            {
                capeTownHouse1.Visible = false;
                capeTownHouse2.Visible = false;
                capeTownHouse3.Visible = false;
                capeTownHouse4.Visible = false;
                capeTownHotel.Visible = true;
            }
            else if (buildHotellandName == "riga")
            {
                rigaHouse1.Visible = false;
                rigaHouse2.Visible = false;
                rigaHouse3.Visible = false;
                rigaHouse4.Visible = false;
                rigaHotel.Visible = true;
            }
            else if (buildHotellandName == "montreal")
            {
                montrealHouse1.Visible = false;
                montrealHouse2.Visible = false;
                montrealHouse3.Visible = false;
                montrealHouse4.Visible = false;
                montrealHotel.Visible = true;
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (button4.Visible == true)
            {
                button4.Visible = false;
                button3.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button11.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
            }
            else
            {
                button4.Visible = true;
                button3.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button11.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (pay_tax_screen payTaxScreen = new pay_tax_screen("tokyo", 30))
            {
                payTaxScreen.ShowDialog();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.advance_to_montreal_ch;
            ch_cm_panel.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ch_cm_panel.BackgroundImage = Monopoly_Project.Properties.Resources.go_to_jail_cmn;
            ch_cm_panel.Visible = true;
        }

        private void game_play_ui_Load(object sender, EventArgs e)
        {

        }

        private void turnTimer_Tick(object sender, EventArgs e)
        {
            if (dataBase.gbdb.endTurn)
            {
                if (dataBase.myID == 0)
                {
                    if (flagEndTurnIf)
                    {
                        endTurnForAll();
                        state = CurWaitingFor.endTurn;
                        //
                        dataBase.setOfferNoBid(0, 0);
                        dataBase.setOfferNoBid(0, 1);
                        dataBase.setOfferNoBid(0, 2);
                        dataBase.setOfferNoBid(0, 3);
                        dataBase.setBidCount(0);
                        flagBid = true;
                        flagBidWinner = true;
                        flagDice = true;
                        flagDiceCur = true;
                        flagEndTurn = true;
                        dataBase.setAll(false);
                        flagEndTurnIf = false;
                        dataBase.gbdb.diceRolled = false;
                        dataBase.getGameBoardDB();
                        dataBase.getPlayerDB();
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (flagElse)
                    {
                        dataBase.getGameBoardDB();
                        dataBase.getPlayerDB();
                        endTurnForAll();
                        state = CurWaitingFor.endTurn;
                        flagBid = true;
                        flagElse = false;
                        flagBidWinner = true;
                        flagDice = true;
                        flagDiceCur = true;
                        flagEndTurn = true;
                    }
                }
            }
            switch (state)
            {
                case CurWaitingFor.dice:
                    dataBase.getGameBoardDB();
                    if (g.currPlayer == dataBase.myID)
                    {
                        if (flagDiceCur)
                        {
                            dataBase.getGameBoardDB();
                            dice_button.Enabled = true;
                            flagDiceCur = false;
                            dataBase.setEndTurnInside(false);
                            /*
                            if(dataBase.gbdb.endTurn == false)
                            {
                                flagEndTurn = true;
                                flagEndTurnIf = true;
                                flagElse = true;

                            }
                            */
                        }
                        else
                        {
                            int k = 10;
                        }

                    }
                    else
                    {
                        /*
                        if(dataBase.gbdb.endTurn == false)
                        {
                            flagEndTurn = true;
                            flagEndTurnIf = true;
                            flagElse = true;
                        }
                        */
                        dataBase.getGameBoardDB();
                        dice_button.Enabled = false;
                        if (dataBase.gbdb.diceRolled && dataBase.gbdb.endTurn == false)
                        {
                            dice_panel.Visible = true;
                            if (flagDice)
                            {
                                flagDice = false;
                                dice_timer.Start();
                            }
                        }
                    }
                    //dataBase.setEndTurn(false);
                    //dataBase.getGameBoardDB();
                    //                      flagEndTurnIf = true;
                    flagEndTurn = true;
                    break;
                case CurWaitingFor.bidWinner:

                    if (dataBase.gbdb.bidCount >= 4)
                    {
                        int winner;
                        winner = g.biddingWar(dataBase.pdb[0].bid, dataBase.pdb[1].bid, dataBase.pdb[2].bid, dataBase.pdb[3].bid, buyScreenAt);

                        winnerLabel.Text = dataBase.pdb[winner].name + " Won the Bidding War";
                        winnerLabel.Visible = true;
                        player1_money.Text = g.parr[0].money.ToString();
                        player2_money.Text = g.parr[1].money.ToString();
                        player3_money.Text = g.parr[2].money.ToString();
                        player4_money.Text = g.parr[3].money.ToString();

                        state = default;
                    }
                    else
                    {
                        dataBase.getGameBoardDB();
                        dataBase.getPlayerDB();
                    }
                    break;
                case CurWaitingFor.buyScreen:
                    if (g.currPlayer == dataBase.myID)
                    {
                        dataBase.getGameBoardDB();
                        if (dataBase.gbdb.bidNotMade)
                        {
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                            winnerLabel.Text = dataBase.pdb[g.currPlayer].name + " bought " + buyScreenAt;
                            winnerLabel.Visible = true;
                        }
                        else if (dataBase.gbdb.bidMade)
                        {
                            state = CurWaitingFor.bidWinner;
                        }
                    }
                    else
                    {
                        dataBase.getGameBoardDB();
                        if (dataBase.gbdb.bidMade)
                        {
                            if (flagBid)
                            {
                                flagBid = false;
                                using (bidding_screen biddingScreen = new bidding_screen(buyScreenAt, ref dataBase))
                                {
                                    biddingScreen.ShowDialog();
                                }
                                state = CurWaitingFor.bidWinner;
                            }
                        }
                        else if (dataBase.gbdb.bidNotMade)
                        {
                            if (flagBidWinner)
                            {
                                int pos = g.findProperty(buyScreenAt);
                                g.buy(g.currPlayer, pos);
                                flagBidWinner = false;
                                player1_money.Text = g.parr[0].money.ToString();
                                player2_money.Text = g.parr[1].money.ToString();
                                player3_money.Text = g.parr[2].money.ToString();
                                player4_money.Text = g.parr[3].money.ToString();

                            }
                        }
                        else
                        {

                        }
                    }
                    break;
                case CurWaitingFor.endTurn:
                    if (flagEndTurn)
                    {
                        flagEndTurn = false;
                        dataBase.getGameBoardDB();
                        dataBase.getPlayerDB();
                        player1_money.Text = g.parr[0].money.ToString();
                        player2_money.Text = g.parr[1].money.ToString();
                        player3_money.Text = g.parr[2].money.ToString();
                        player4_money.Text = g.parr[3].money.ToString();
                        state = CurWaitingFor.dice;
                        endTurnButton.Enabled = false;
                    }
                    break;
                case CurWaitingFor.utility:
                    if (g.currPlayer == dataBase.myID)
                    {
                        dataBase.getGameBoardDB();
                        if (dataBase.gbdb.boughtUtility)
                        {
                            player1_money.Text = g.parr[0].money.ToString();
                            player2_money.Text = g.parr[1].money.ToString();
                            player3_money.Text = g.parr[2].money.ToString();
                            player4_money.Text = g.parr[3].money.ToString();
                        }

                    }
                    else
                    {
                        dataBase.getGameBoardDB();
                        if (dataBase.gbdb.boughtUtility)
                        {
                            if (flagUtility1)
                            {
                                flagUtility1 = false;
                                int pos = g.findProperty(buyScreenAt);
                                g.buy(g.currPlayer, pos);
                                player1_money.Text = g.parr[0].money.ToString();
                                player2_money.Text = g.parr[1].money.ToString();
                                player3_money.Text = g.parr[2].money.ToString();
                                player4_money.Text = g.parr[3].money.ToString();
                            }
                        }
                    }
                    break;
                default:
                    break;
            }


        }

        private void endTurnButton_Click(object sender, EventArgs e)
        {
            dataBase.setEndTurn(true);
            int k = g.currPlayer;
            k += 1;
            k = k % 4;
            dataBase.setCurrentPlayer(k);
            state = CurWaitingFor.endTurn;
            dice_button.Enabled = false;
        }
        public void endTurnForAll()
        {
            g.currPlayer = g.currPlayer + 1;
            g.currPlayer = g.currPlayer % 4;
            if (playerNo == 1)
            {
                playerNo = 2;
            }
            else if (playerNo == 2)
            {
                playerNo = 3;
            }
            else if (playerNo == 3)
            {
                playerNo = 4;
            }
            else if (playerNo == 4)
            {
                playerNo = 1;
            }
        }
    }
}
