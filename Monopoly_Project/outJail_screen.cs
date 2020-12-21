using System;
using System.Media;
using System.Windows.Forms;
namespace Monopoly_Project
{
    public partial class outJail_screen : Form
    {
        int dice1;
        int dice2;
        Random rnd;
        Guna.UI2.WinForms.Guna2PictureBox p1;
        public outJail_screen()
        {
            InitializeComponent();
            rnd = new Random();
        }
        private void playDiceRoll() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Monopoly_Project.Properties.Resources.roll_dice_2); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }
        private void outJailRollDice_Click(object sender, EventArgs e)
        {
            playButtonClick();
            playDiceRoll();
            dice1_label.Visible = true;
            dice2_label.Visible = true;
            dice1Image.Visible = true;
            dice2Image.Visible = true;
            rollDice.Start();
        }

        private void rollDice_Tick(object sender, EventArgs e)
        {
            dicerBar.Increment(5);
            if (dicerBar.Value >= 100)
            {
                rollDice.Stop();
                dicerBar.Value = 0;
                if (dice1 == dice2)
                {
                    // get out of jail
                    payButton.Visible = false;
                    outJailRollDice.Visible = false;
                    getOutJailFree.Visible = false;
                    guna2HtmlLabel1.Visible = false;
                    guna2HtmlLabel2.Visible = false;
                    jailInfoLabel.Visible = false;
                    infoPanel.Visible = true;
                }
                else
                {
                    // stay 
                    /* letsDelay(2000);
                     this.Dispose();*/
                }
            }
            else
            {
                dice1 = rnd.Next(1, 7);
                dice2 = rnd.Next(1, 7);
                // if's for animating dice 1
                if (dice1 == 1)
                {
                    dice1Image.Image = global::Monopoly_Project.Properties.Resources.dice1;
                }
                else if (dice1 == 2)
                {
                    dice1Image.Image = global::Monopoly_Project.Properties.Resources.dice2;
                }
                else if (dice1 == 3)
                {
                    dice1Image.Image = global::Monopoly_Project.Properties.Resources.dice3;
                }
                else if (dice1 == 4)
                {
                    dice1Image.Image = global::Monopoly_Project.Properties.Resources.dice4;
                }
                else if (dice1 == 5)
                {
                    dice1Image.Image = global::Monopoly_Project.Properties.Resources.dice5;
                }
                else if (dice1 == 6)
                {
                    dice1Image.Image = global::Monopoly_Project.Properties.Resources.dice6;
                }

                //if's for animating dice 2

                if (dice2 == 1)
                {
                    dice2Image.Image = global::Monopoly_Project.Properties.Resources.dice1;

                }
                else if (dice2 == 2)
                {
                    dice2Image.Image = global::Monopoly_Project.Properties.Resources.dice2;
                }
                else if (dice2 == 3)
                {
                    dice2Image.Image = global::Monopoly_Project.Properties.Resources.dice3;
                }
                else if (dice2 == 4)
                {
                    dice2Image.Image = global::Monopoly_Project.Properties.Resources.dice4;
                }
                else if (dice2 == 5)
                {
                    dice2Image.Image = global::Monopoly_Project.Properties.Resources.dice5;
                }
                else if (dice2 == 6)
                {
                    dice2Image.Image = global::Monopoly_Project.Properties.Resources.dice6;
                }
                dice1_label.Text = dice1.ToString();
                dice2_label.Text = dice2.ToString();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            this.Dispose();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            playButtonClick();
            p1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.p1.BackColor = System.Drawing.Color.Transparent;
            this.p1.Location = new System.Drawing.Point(50, 50);
            this.p1.Name = "p1";
            this.p1.ShadowDecoration.Parent = this.p1;
            this.p1.Size = new System.Drawing.Size(40, 40);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 7;
            this.p1.TabStop = false;
            this.p1.Visible = false;
            this.p1.Image = Monopoly_Project.Properties.Resources.buttons_icon;
            this.p1.Visible = true;
            Controls.Add(p1);
            this.Dispose();

        }
        private void playButtonClick() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Monopoly_Project.Properties.Resources.button_click); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }

        private void getOutJailFree_Click(object sender, EventArgs e)
        {
            playButtonClick();
        }
    }
}
