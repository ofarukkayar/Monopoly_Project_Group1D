
namespace Monopoly_Project
{
    partial class buy_property_screen
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
            this.propertyCardPictureBox = new System.Windows.Forms.PictureBox();
            this.buy_border = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buyPropertyNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buyPropertyButton = new Guna.UI2.WinForms.Guna2Button();
            this.startBiddingButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.propertyCardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_border)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyCardPictureBox
            // 
            this.propertyCardPictureBox.Image = global::Monopoly_Project.Properties.Resources.istanbul_property_card;
            this.propertyCardPictureBox.Location = new System.Drawing.Point(75, 109);
            this.propertyCardPictureBox.Name = "propertyCardPictureBox";
            this.propertyCardPictureBox.Size = new System.Drawing.Size(300, 342);
            this.propertyCardPictureBox.TabIndex = 0;
            this.propertyCardPictureBox.TabStop = false;
            // 
            // buy_border
            // 
            this.buy_border.BackColor = System.Drawing.Color.Transparent;
            this.buy_border.Image = global::Monopoly_Project.Properties.Resources.blue_bid_border;
            this.buy_border.Location = new System.Drawing.Point(0, 0);
            this.buy_border.Name = "buy_border";
            this.buy_border.ShadowDecoration.Parent = this.buy_border;
            this.buy_border.Size = new System.Drawing.Size(450, 585);
            this.buy_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buy_border.TabIndex = 13;
            this.buy_border.TabStop = false;
            this.buy_border.UseTransparentBackground = true;
            // 
            // buyPropertyNameLabel
            // 
            this.buyPropertyNameLabel.AutoSize = false;
            this.buyPropertyNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.buyPropertyNameLabel.Font = new System.Drawing.Font("Kabel-Heavy", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPropertyNameLabel.Location = new System.Drawing.Point(69, 50);
            this.buyPropertyNameLabel.Name = "buyPropertyNameLabel";
            this.buyPropertyNameLabel.Size = new System.Drawing.Size(312, 53);
            this.buyPropertyNameLabel.TabIndex = 14;
            this.buyPropertyNameLabel.Text = "Buy or Bid";
            this.buyPropertyNameLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buyPropertyButton
            // 
            this.buyPropertyButton.AutoRoundedCorners = true;
            this.buyPropertyButton.BackColor = System.Drawing.Color.Transparent;
            this.buyPropertyButton.BorderRadius = 16;
            this.buyPropertyButton.BorderThickness = 3;
            this.buyPropertyButton.CheckedState.Parent = this.buyPropertyButton;
            this.buyPropertyButton.CustomImages.Parent = this.buyPropertyButton;
            this.buyPropertyButton.Enabled = false;
            this.buyPropertyButton.FillColor = System.Drawing.Color.SkyBlue;
            this.buyPropertyButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPropertyButton.ForeColor = System.Drawing.Color.White;
            this.buyPropertyButton.HoverState.Parent = this.buyPropertyButton;
            this.buyPropertyButton.Location = new System.Drawing.Point(75, 457);
            this.buyPropertyButton.Name = "buyPropertyButton";
            this.buyPropertyButton.ShadowDecoration.Parent = this.buyPropertyButton;
            this.buyPropertyButton.Size = new System.Drawing.Size(300, 35);
            this.buyPropertyButton.TabIndex = 15;
            this.buyPropertyButton.Text = "Buy For $140";
            this.buyPropertyButton.Click += new System.EventHandler(this.buyPropertyButton_Click);
            // 
            // startBiddingButton
            // 
            this.startBiddingButton.AutoRoundedCorners = true;
            this.startBiddingButton.BackColor = System.Drawing.Color.Transparent;
            this.startBiddingButton.BorderRadius = 16;
            this.startBiddingButton.BorderThickness = 3;
            this.startBiddingButton.CheckedState.Parent = this.startBiddingButton;
            this.startBiddingButton.CustomImages.Parent = this.startBiddingButton;
            this.startBiddingButton.FillColor = System.Drawing.Color.SkyBlue;
            this.startBiddingButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBiddingButton.ForeColor = System.Drawing.Color.White;
            this.startBiddingButton.HoverState.Parent = this.startBiddingButton;
            this.startBiddingButton.Location = new System.Drawing.Point(75, 498);
            this.startBiddingButton.Name = "startBiddingButton";
            this.startBiddingButton.ShadowDecoration.Parent = this.startBiddingButton;
            this.startBiddingButton.Size = new System.Drawing.Size(300, 35);
            this.startBiddingButton.TabIndex = 16;
            this.startBiddingButton.Text = "Start Bidding War";
            this.startBiddingButton.Click += new System.EventHandler(this.startBiddingButton_Click);
            // 
            // buy_property_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly_Project.Properties.Resources.host_join_options_background;
            this.ClientSize = new System.Drawing.Size(450, 585);
            this.Controls.Add(this.startBiddingButton);
            this.Controls.Add(this.buyPropertyButton);
            this.Controls.Add(this.buyPropertyNameLabel);
            this.Controls.Add(this.propertyCardPictureBox);
            this.Controls.Add(this.buy_border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "buy_property_screen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buy_property_screen";
            ((System.ComponentModel.ISupportInitialize)(this.propertyCardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_border)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox propertyCardPictureBox;
        private Guna.UI2.WinForms.Guna2PictureBox buy_border;
        private Guna.UI2.WinForms.Guna2HtmlLabel buyPropertyNameLabel;
        private Guna.UI2.WinForms.Guna2Button buyPropertyButton;
        private Guna.UI2.WinForms.Guna2Button startBiddingButton;
    }
}