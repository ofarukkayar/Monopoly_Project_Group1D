
namespace Monopoly_Project
{
    partial class outJail_screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dice1_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dice2Image = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dice1Image = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dicerBar = new System.Windows.Forms.ProgressBar();
            this.jailInfoLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dice2_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.payButton = new Guna.UI2.WinForms.Guna2Button();
            this.getOutJailFree = new Guna.UI2.WinForms.Guna2Button();
            this.outJailRollDice = new Guna.UI2.WinForms.Guna2Button();
            this.rollDice = new System.Windows.Forms.Timer(this.components);
            this.infoPanel = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.okButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dice2Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1Image)).BeginInit();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dice1_label
            // 
            this.dice1_label.AutoSize = false;
            this.dice1_label.BackColor = System.Drawing.Color.Transparent;
            this.dice1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice1_label.Location = new System.Drawing.Point(225, 213);
            this.dice1_label.Name = "dice1_label";
            this.dice1_label.Size = new System.Drawing.Size(70, 44);
            this.dice1_label.TabIndex = 10;
            this.dice1_label.Text = "6";
            this.dice1_label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dice1_label.Visible = false;
            // 
            // dice2Image
            // 
            this.dice2Image.BackColor = System.Drawing.Color.Transparent;
            this.dice2Image.Location = new System.Drawing.Point(305, 134);
            this.dice2Image.Name = "dice2Image";
            this.dice2Image.ShadowDecoration.Parent = this.dice2Image;
            this.dice2Image.Size = new System.Drawing.Size(70, 70);
            this.dice2Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice2Image.TabIndex = 8;
            this.dice2Image.TabStop = false;
            this.dice2Image.Visible = false;
            // 
            // dice1Image
            // 
            this.dice1Image.BackColor = System.Drawing.Color.Transparent;
            this.dice1Image.Location = new System.Drawing.Point(225, 134);
            this.dice1Image.Name = "dice1Image";
            this.dice1Image.ShadowDecoration.Parent = this.dice1Image;
            this.dice1Image.Size = new System.Drawing.Size(70, 70);
            this.dice1Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice1Image.TabIndex = 7;
            this.dice1Image.TabStop = false;
            this.dice1Image.Visible = false;
            // 
            // dicerBar
            // 
            this.dicerBar.Location = new System.Drawing.Point(488, 362);
            this.dicerBar.Name = "dicerBar";
            this.dicerBar.Size = new System.Drawing.Size(100, 23);
            this.dicerBar.TabIndex = 11;
            this.dicerBar.Visible = false;
            // 
            // jailInfoLabel
            // 
            this.jailInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.jailInfoLabel.Font = new System.Drawing.Font("Kabel-Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jailInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.jailInfoLabel.Location = new System.Drawing.Point(247, 40);
            this.jailInfoLabel.Name = "jailInfoLabel";
            this.jailInfoLabel.Size = new System.Drawing.Size(106, 27);
            this.jailInfoLabel.TabIndex = 12;
            this.jailInfoLabel.Text = "You are in Jail";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Kabel-Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(124, 70);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(352, 27);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "You can pay to get out or you can try your luck";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Kabel-Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(45, 100);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(510, 27);
            this.guna2HtmlLabel2.TabIndex = 14;
            this.guna2HtmlLabel2.Text = "If you roll double, you will get out at the beginning of the next round";
            // 
            // dice2_label
            // 
            this.dice2_label.AutoSize = false;
            this.dice2_label.BackColor = System.Drawing.Color.Transparent;
            this.dice2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice2_label.Location = new System.Drawing.Point(305, 213);
            this.dice2_label.Name = "dice2_label";
            this.dice2_label.Size = new System.Drawing.Size(70, 44);
            this.dice2_label.TabIndex = 15;
            this.dice2_label.Text = "6";
            this.dice2_label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dice2_label.Visible = false;
            // 
            // payButton
            // 
            this.payButton.AutoRoundedCorners = true;
            this.payButton.BackColor = System.Drawing.Color.Transparent;
            this.payButton.BorderRadius = 19;
            this.payButton.BorderThickness = 3;
            this.payButton.CheckedState.Parent = this.payButton;
            this.payButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payButton.CustomImages.Parent = this.payButton;
            this.payButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.ForeColor = System.Drawing.Color.White;
            this.payButton.HoverState.Parent = this.payButton;
            this.payButton.Location = new System.Drawing.Point(180, 268);
            this.payButton.Name = "payButton";
            this.payButton.ShadowDecoration.Parent = this.payButton;
            this.payButton.Size = new System.Drawing.Size(239, 41);
            this.payButton.TabIndex = 16;
            this.payButton.Text = "Pay $50";
            this.payButton.UseTransparentBackground = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // getOutJailFree
            // 
            this.getOutJailFree.AutoRoundedCorners = true;
            this.getOutJailFree.BackColor = System.Drawing.Color.Transparent;
            this.getOutJailFree.BorderRadius = 19;
            this.getOutJailFree.BorderThickness = 3;
            this.getOutJailFree.CheckedState.Parent = this.getOutJailFree;
            this.getOutJailFree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getOutJailFree.CustomImages.Parent = this.getOutJailFree;
            this.getOutJailFree.Enabled = false;
            this.getOutJailFree.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getOutJailFree.ForeColor = System.Drawing.Color.White;
            this.getOutJailFree.HoverState.Parent = this.getOutJailFree;
            this.getOutJailFree.Location = new System.Drawing.Point(180, 362);
            this.getOutJailFree.Name = "getOutJailFree";
            this.getOutJailFree.ShadowDecoration.Parent = this.getOutJailFree;
            this.getOutJailFree.Size = new System.Drawing.Size(239, 41);
            this.getOutJailFree.TabIndex = 18;
            this.getOutJailFree.Text = "Get Out Jail Free";
            this.getOutJailFree.UseTransparentBackground = true;
            this.getOutJailFree.Click += new System.EventHandler(this.getOutJailFree_Click);
            // 
            // outJailRollDice
            // 
            this.outJailRollDice.AutoRoundedCorners = true;
            this.outJailRollDice.BackColor = System.Drawing.Color.Transparent;
            this.outJailRollDice.BorderRadius = 19;
            this.outJailRollDice.BorderThickness = 3;
            this.outJailRollDice.CheckedState.Parent = this.outJailRollDice;
            this.outJailRollDice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outJailRollDice.CustomImages.Parent = this.outJailRollDice;
            this.outJailRollDice.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outJailRollDice.ForeColor = System.Drawing.Color.White;
            this.outJailRollDice.HoverState.Parent = this.outJailRollDice;
            this.outJailRollDice.Location = new System.Drawing.Point(180, 315);
            this.outJailRollDice.Name = "outJailRollDice";
            this.outJailRollDice.ShadowDecoration.Parent = this.outJailRollDice;
            this.outJailRollDice.Size = new System.Drawing.Size(239, 41);
            this.outJailRollDice.TabIndex = 19;
            this.outJailRollDice.Text = "Roll Dice";
            this.outJailRollDice.UseTransparentBackground = true;
            this.outJailRollDice.Click += new System.EventHandler(this.outJailRollDice_Click);
            // 
            // rollDice
            // 
            this.rollDice.Interval = 50;
            this.rollDice.Tick += new System.EventHandler(this.rollDice_Tick);
            // 
            // infoPanel
            // 
            this.infoPanel.BackgroundImage = global::Monopoly_Project.Properties.Resources.host_join_options_background;
            this.infoPanel.Controls.Add(this.guna2HtmlLabel4);
            this.infoPanel.Controls.Add(this.guna2HtmlLabel3);
            this.infoPanel.Controls.Add(this.okButton);
            this.infoPanel.Controls.Add(this.guna2PictureBox1);
            this.infoPanel.Location = new System.Drawing.Point(124, 12);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(350, 115);
            this.infoPanel.TabIndex = 20;
            this.infoPanel.Visible = false;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Kabel-Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(18, 39);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(315, 27);
            this.guna2HtmlLabel4.TabIndex = 23;
            this.guna2HtmlLabel4.Text = "You Will Get Out of the Jail in Next Turn";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Kabel-Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(40, 11);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(270, 27);
            this.guna2HtmlLabel3.TabIndex = 22;
            this.guna2HtmlLabel3.Text = "Congratulations, You rolled double!!";
            // 
            // okButton
            // 
            this.okButton.AutoRoundedCorners = true;
            this.okButton.BackColor = System.Drawing.Color.Transparent;
            this.okButton.BorderRadius = 14;
            this.okButton.BorderThickness = 3;
            this.okButton.CheckedState.Parent = this.okButton;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.CustomImages.Parent = this.okButton;
            this.okButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.HoverState.Parent = this.okButton;
            this.okButton.Location = new System.Drawing.Point(118, 75);
            this.okButton.Name = "okButton";
            this.okButton.ShadowDecoration.Parent = this.okButton;
            this.okButton.Size = new System.Drawing.Size(115, 31);
            this.okButton.TabIndex = 20;
            this.okButton.Text = "OK";
            this.okButton.UseTransparentBackground = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Monopoly_Project.Properties.Resources.menus_border;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(350, 115);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 21;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // outJail_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly_Project.Properties.Resources.jail_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.outJailRollDice);
            this.Controls.Add(this.getOutJailFree);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.dice2_label);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.jailInfoLabel);
            this.Controls.Add(this.dicerBar);
            this.Controls.Add(this.dice1_label);
            this.Controls.Add(this.dice1Image);
            this.Controls.Add(this.dice2Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "outJail_screen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "outJail_screen";
            ((System.ComponentModel.ISupportInitialize)(this.dice2Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1Image)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel dice1_label;
        private Guna.UI2.WinForms.Guna2PictureBox dice2Image;
        private Guna.UI2.WinForms.Guna2PictureBox dice1Image;
        private System.Windows.Forms.ProgressBar dicerBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel jailInfoLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel dice2_label;
        private Guna.UI2.WinForms.Guna2Button payButton;
        private Guna.UI2.WinForms.Guna2Button getOutJailFree;
        private Guna.UI2.WinForms.Guna2Button outJailRollDice;
        private System.Windows.Forms.Timer rollDice;
        private System.Windows.Forms.Panel infoPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button okButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}