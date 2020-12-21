
namespace Monopoly_Project
{
    partial class bidding_screen
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
            this.propInfoPictureBox = new System.Windows.Forms.PictureBox();
            this.biddingWarLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.setBidButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bidTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.propInfoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // propInfoPictureBox
            // 
            this.propInfoPictureBox.Image = global::Monopoly_Project.Properties.Resources.tokyo_property_card;
            this.propInfoPictureBox.Location = new System.Drawing.Point(75, 109);
            this.propInfoPictureBox.Name = "propInfoPictureBox";
            this.propInfoPictureBox.Size = new System.Drawing.Size(300, 342);
            this.propInfoPictureBox.TabIndex = 1;
            this.propInfoPictureBox.TabStop = false;
            // 
            // biddingWarLabel
            // 
            this.biddingWarLabel.BackColor = System.Drawing.Color.Transparent;
            this.biddingWarLabel.Font = new System.Drawing.Font("Kabel-Heavy", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biddingWarLabel.Location = new System.Drawing.Point(128, 50);
            this.biddingWarLabel.Name = "biddingWarLabel";
            this.biddingWarLabel.Size = new System.Drawing.Size(195, 53);
            this.biddingWarLabel.TabIndex = 2;
            this.biddingWarLabel.Text = "Bidding War";
            // 
            // setBidButton
            // 
            this.setBidButton.AutoRoundedCorners = true;
            this.setBidButton.BackColor = System.Drawing.Color.Transparent;
            this.setBidButton.BorderRadius = 16;
            this.setBidButton.BorderThickness = 3;
            this.setBidButton.CheckedState.Parent = this.setBidButton;
            this.setBidButton.CustomImages.Parent = this.setBidButton;
            this.setBidButton.FillColor = System.Drawing.Color.SkyBlue;
            this.setBidButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBidButton.ForeColor = System.Drawing.Color.White;
            this.setBidButton.HoverState.Parent = this.setBidButton;
            this.setBidButton.Location = new System.Drawing.Point(75, 500);
            this.setBidButton.Name = "setBidButton";
            this.setBidButton.ShadowDecoration.Parent = this.setBidButton;
            this.setBidButton.Size = new System.Drawing.Size(300, 35);
            this.setBidButton.TabIndex = 11;
            this.setBidButton.Text = "Confirm";
            this.setBidButton.Click += new System.EventHandler(this.setBidButton_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Monopoly_Project.Properties.Resources.blue_bid_border;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(450, 585);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // bidTextBox
            // 
            this.bidTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.bidTextBox.BorderColor = System.Drawing.Color.Black;
            this.bidTextBox.BorderThickness = 2;
            this.bidTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bidTextBox.DefaultText = "";
            this.bidTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bidTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bidTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bidTextBox.DisabledState.Parent = this.bidTextBox;
            this.bidTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bidTextBox.FillColor = System.Drawing.Color.SkyBlue;
            this.bidTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bidTextBox.FocusedState.Parent = this.bidTextBox;
            this.bidTextBox.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bidTextBox.ForeColor = System.Drawing.Color.White;
            this.bidTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bidTextBox.HoverState.Parent = this.bidTextBox;
            this.bidTextBox.Location = new System.Drawing.Point(75, 458);
            this.bidTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bidTextBox.MaxLength = 4;
            this.bidTextBox.Name = "bidTextBox";
            this.bidTextBox.PasswordChar = '\0';
            this.bidTextBox.PlaceholderText = "Enter Your Offer";
            this.bidTextBox.SelectedText = "";
            this.bidTextBox.ShadowDecoration.Parent = this.bidTextBox;
            this.bidTextBox.Size = new System.Drawing.Size(300, 35);
            this.bidTextBox.TabIndex = 14;
            this.bidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bidTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bidTextBox_KeyPress);
            // 
            // bidding_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImage = global::Monopoly_Project.Properties.Resources.host_join_options_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 585);
            this.Controls.Add(this.bidTextBox);
            this.Controls.Add(this.setBidButton);
            this.Controls.Add(this.biddingWarLabel);
            this.Controls.Add(this.propInfoPictureBox);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bidding_screen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bidding_screen";
            ((System.ComponentModel.ISupportInitialize)(this.propInfoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox propInfoPictureBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel biddingWarLabel;
        private Guna.UI2.WinForms.Guna2Button setBidButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox bidTextBox;
    }
}