using System;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Monopoly_Project
{

    public partial class select_pawn_screen : Form
    {
        Storage dataBase;
        int pawnCounter = 0;
        bool[] boolarr;
        Guna.UI2.WinForms.Guna2PictureBox[] pawns;
        System.Windows.Forms.PictureBox[] icons;
        Guna.UI2.WinForms.Guna2HtmlLabel[] nameLabels;
        public select_pawn_screen(ref Storage s, ref Guna.UI2.WinForms.Guna2PictureBox player1Pawn,
                                  ref Guna.UI2.WinForms.Guna2PictureBox player2Pawn, ref Guna.UI2.WinForms.Guna2PictureBox player3Pawn,
                                  ref Guna.UI2.WinForms.Guna2PictureBox player4Pawn, ref System.Windows.Forms.PictureBox player1Icon,
                                  ref System.Windows.Forms.PictureBox player2Icon, ref System.Windows.Forms.PictureBox player3Icon,
                                  ref System.Windows.Forms.PictureBox player4Icon, ref Guna.UI2.WinForms.Guna2HtmlLabel player1Label,
                                  ref Guna.UI2.WinForms.Guna2HtmlLabel player2Label, ref Guna.UI2.WinForms.Guna2HtmlLabel player3Label,
                                  ref Guna.UI2.WinForms.Guna2HtmlLabel player4Label)
        {
            dataBase = s;
            InitializeComponent();
            pawns = new Guna.UI2.WinForms.Guna2PictureBox[4] { player1Pawn, player2Pawn, player3Pawn, player4Pawn };
            icons = new System.Windows.Forms.PictureBox[4] { player1Icon, player2Icon, player3Icon, player4Icon };
            nameLabels = new Guna.UI2.WinForms.Guna2HtmlLabel[4] { player1Label, player2Label, player3Label, player4Label };
            timer1.Start();
            boolarr = new bool[6];
            for (int i = 0; i < 6; i++)
            {
                boolarr[i] = true;
            }
        }

        private void pawn1_button_Click(object sender, EventArgs e)
        {
            playButtonClick();
            dataBase.pawnSelected(dataBase.myID, 0);
            dataBase.setPlayerDB();
            pawn1_button.Enabled = false;
            pawn2_button.Enabled = false;
            pawn3_button.Enabled = false;
            pawn4_button.Enabled = false;
            pawn5_button.Enabled = false;
            pawn6_button.Enabled = false;
        }

        private void pawn2_button_Click(object sender, EventArgs e)
        {
            playButtonClick();
            dataBase.pawnSelected(dataBase.myID, 1);
            dataBase.setPlayerDB();
            pawn1_button.Enabled = false;
            pawn2_button.Enabled = false;
            pawn3_button.Enabled = false;
            pawn4_button.Enabled = false;
            pawn5_button.Enabled = false;
            pawn6_button.Enabled = false;

        }

        private void pawn3_button_Click(object sender, EventArgs e)
        {
            playButtonClick();
            dataBase.pawnSelected(dataBase.myID, 2);
            dataBase.setPlayerDB();
            pawn1_button.Enabled = false;
            pawn2_button.Enabled = false;
            pawn3_button.Enabled = false;
            pawn4_button.Enabled = false;
            pawn5_button.Enabled = false;
            pawn6_button.Enabled = false;
        }

        private void pawn4_button_Click(object sender, EventArgs e)
        {
            playButtonClick();
            dataBase.pawnSelected(dataBase.myID, 3);
            dataBase.setPlayerDB();
            pawn1_button.Enabled = false;
            pawn2_button.Enabled = false;
            pawn3_button.Enabled = false;
            pawn4_button.Enabled = false;
            pawn5_button.Enabled = false;
            pawn6_button.Enabled = false;
        }

        private void pawn5_button_Click(object sender, EventArgs e)
        {
            playButtonClick();
            dataBase.pawnSelected(dataBase.myID, 4);
            dataBase.setPlayerDB();
            pawn1_button.Enabled = false;
            pawn2_button.Enabled = false;
            pawn3_button.Enabled = false;
            pawn4_button.Enabled = false;
            pawn5_button.Enabled = false;
            pawn6_button.Enabled = false;
        }

        private void pawn6_button_Click(object sender, EventArgs e)
        {
            playButtonClick();
            dataBase.pawnSelected(dataBase.myID, 5);
            dataBase.setPlayerDB();
            pawn1_button.Enabled = false;
            pawn2_button.Enabled = false;
            pawn3_button.Enabled = false;
            pawn4_button.Enabled = false;
            pawn5_button.Enabled = false;
            pawn6_button.Enabled = false;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            dataBase.getGameBoardDB();
            //dataBase.setPlayerDB();
            dataBase.getPlayerDB();
            if (dataBase.gbdb.pawn[0] == 1 && boolarr[0])
            {
                boolarr[0] = false;
                pawnCounter++;
            }
            if (dataBase.gbdb.pawn[1] == 1 && boolarr[1])
            {
                boolarr[1] = false;
                pawnCounter++;
            }
            if (dataBase.gbdb.pawn[2] == 1 && boolarr[2])
            {
                boolarr[2] = false;
                pawnCounter++;
            }
            if (dataBase.gbdb.pawn[3] == 1 && boolarr[3])
            {
                boolarr[3] = false;
                pawnCounter++;
            }
            if (dataBase.gbdb.pawn[4] == 1 && boolarr[4])
            {
                boolarr[4] = false;
                pawnCounter++;
            }
            if (dataBase.gbdb.pawn[5] == 1 && boolarr[5])
            {
                boolarr[5] = false;
                pawnCounter++;
            }
            if (pawn1_button.Enabled == true)
            {
                pawn1_button.Enabled = !(dataBase.gbdb.pawn[0] == 1);

            }
            if (pawn2_button.Enabled == true)
            {
                pawn2_button.Enabled = !(dataBase.gbdb.pawn[1] == 1);

            }
            if (pawn3_button.Enabled == true)
            {
                pawn3_button.Enabled = !(dataBase.gbdb.pawn[2] == 1);
            }
            if (pawn4_button.Enabled == true)
            {
                pawn4_button.Enabled = !(dataBase.gbdb.pawn[3] == 1);
            }
            if (pawn5_button.Enabled == true)
            {
                pawn5_button.Enabled = !(dataBase.gbdb.pawn[4] == 1);
            }
            if (pawn6_button.Enabled == true)
            {
                pawn6_button.Enabled = !(dataBase.gbdb.pawn[5] == 1);
            }
            for (int i = 0; i < 4; i++)
            {
                nameLabels[i].Text = dataBase.pdb[i].name;
                if (dataBase.pdb[i].pawnId == 0)
                {
                    if (i == 0)
                    {
                        pawn1_button.BackColor = Color.LightGreen;
                    }
                    else if (i == 1)
                    {
                        pawn1_button.BackColor = Color.BlueViolet;
                    }
                    else if (i == 2)
                    {
                        pawn1_button.BackColor = Color.PaleVioletRed;
                    }
                    else if (i == 3)
                    {
                        pawn1_button.BackColor = Color.SlateBlue;
                    }
                }
                else if (dataBase.pdb[i].pawnId == 1)
                {
                    if (i == 0)
                    {
                        pawn2_button.BackColor = Color.LightGreen;
                    }
                    else if (i == 1)
                    {
                        pawn2_button.BackColor = Color.BlueViolet;
                    }
                    else if (i == 2)
                    {
                        pawn2_button.BackColor = Color.PaleVioletRed;
                    }
                    else if (i == 3)
                    {
                        pawn2_button.BackColor = Color.SlateBlue;
                    }
                }
                else if (dataBase.pdb[i].pawnId == 2)
                {
                    if (i == 0)
                    {
                        pawn3_button.BackColor = Color.LightGreen;
                    }
                    else if (i == 1)
                    {
                        pawn3_button.BackColor = Color.BlueViolet;
                    }
                    else if (i == 2)
                    {
                        pawn3_button.BackColor = Color.PaleVioletRed;
                    }
                    else if (i == 3)
                    {
                        pawn3_button.BackColor = Color.SlateBlue;
                    }
                }
                else if (dataBase.pdb[i].pawnId == 3)
                {
                    if (i == 0)
                    {
                        pawn4_button.BackColor = Color.LightGreen;
                    }
                    else if (i == 1)
                    {
                        pawn4_button.BackColor = Color.BlueViolet;
                    }
                    else if (i == 2)
                    {
                        pawn4_button.BackColor = Color.PaleVioletRed;
                    }
                    else if (i == 3)
                    {
                        pawn4_button.BackColor = Color.SlateBlue;
                    }
                }
                else if (dataBase.pdb[i].pawnId == 4)
                {
                    if (i == 0)
                    {
                        pawn5_button.BackColor = Color.LightGreen;
                    }
                    else if (i == 1)
                    {
                        pawn5_button.BackColor = Color.BlueViolet;
                    }
                    else if (i == 2)
                    {
                        pawn5_button.BackColor = Color.PaleVioletRed;
                    }
                    else if (i == 3)
                    {
                        pawn5_button.BackColor = Color.SlateBlue;
                    }
                }
                else if (dataBase.pdb[i].pawnId == 5)
                {
                    if (i == 0)
                    {
                        pawn6_button.BackColor = Color.LightGreen;
                    }
                    else if (i == 1)
                    {
                        pawn6_button.BackColor = Color.BlueViolet;
                    }
                    else if (i == 2)
                    {
                        pawn6_button.BackColor = Color.PaleVioletRed;
                    }
                    else if (i == 3)
                    {
                        pawn6_button.BackColor = Color.SlateBlue;
                    }
                }

            }
            if (pawnCounter >= 4)
            {
                int counter = 0;
                int i = 0;
                while (i < 4)
                {
                    dataBase.getPlayerDB();
                    dataBase.getGameBoardDB();
                    letsDelay();
                    if (dataBase.pdb[i].pawnId == 0)
                    {
                        pawns[i].Image = Monopoly_Project.Properties.Resources.car_pawn_low;
                        icons[i].Image = Monopoly_Project.Properties.Resources.car_pawn_low;
                        nameLabels[i].Text = dataBase.pdb[i].name;
                        counter++;
                    }
                    else if (dataBase.pdb[i].pawnId == 1)
                    {
                        pawns[i].Image = Monopoly_Project.Properties.Resources.hat_pawn_low;
                        icons[i].Image = Monopoly_Project.Properties.Resources.hat_pawn_low;
                        nameLabels[i].Text = dataBase.pdb[i].name;
                        counter++;
                    }
                    else if (dataBase.pdb[i].pawnId == 2)
                    {
                        pawns[i].Image = Monopoly_Project.Properties.Resources.ship_pawn_low;
                        icons[i].Image = Monopoly_Project.Properties.Resources.ship_pawn_low;
                        nameLabels[i].Text = dataBase.pdb[i].name;
                        counter++;
                    }
                    else if (dataBase.pdb[i].pawnId == 3)
                    {
                        pawns[i].Image = Monopoly_Project.Properties.Resources.shoes_pawn_low;
                        icons[i].Image = Monopoly_Project.Properties.Resources.shoes_pawn_low;
                        nameLabels[i].Text = dataBase.pdb[i].name;
                        counter++;
                    }
                    else if (dataBase.pdb[i].pawnId == 4)
                    {
                        pawns[i].Image = Monopoly_Project.Properties.Resources.iron_pawn_low;
                        icons[i].Image = Monopoly_Project.Properties.Resources.iron_pawn_low;
                        nameLabels[i].Text = dataBase.pdb[i].name;
                        counter++;
                    }
                    else if (dataBase.pdb[i].pawnId == 5)
                    {
                        pawns[i].Image = Monopoly_Project.Properties.Resources.bune_pawn_low;
                        icons[i].Image = Monopoly_Project.Properties.Resources.bune_pawn_low;
                        nameLabels[i].Text = dataBase.pdb[i].name;
                        counter++;
                    }
                    i++;
                }
                startGameButton.Enabled = true;
            }
        }
        public async void letsDelay()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(5000));
        }


        private void startGameButton_Click(object sender, EventArgs e)
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
