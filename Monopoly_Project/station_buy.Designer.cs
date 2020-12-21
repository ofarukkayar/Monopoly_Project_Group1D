
namespace Monopoly_Project
{
    partial class station_buy
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.biddingWarLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.setBidButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
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
            this.propInfoPictureBox.TabIndex = 2;
            this.propInfoPictureBox.TabStop = false;
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
            this.guna2PictureBox1.TabIndex = 13;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // biddingWarLabel
            // 
            this.biddingWarLabel.BackColor = System.Drawing.Color.Transparent;
            this.biddingWarLabel.Font = new System.Drawing.Font("Kabel-Heavy", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biddingWarLabel.Location = new System.Drawing.Point(128, 50);
            this.biddingWarLabel.Name = "biddingWarLabel";
            this.biddingWarLabel.Size = new System.Drawing.Size(174, 53);
            this.biddingWarLabel.TabIndex = 14;
            this.biddingWarLabel.Text = "Buy or Not";
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
            this.setBidButton.Location = new System.Drawing.Point(75, 498);
            this.setBidButton.Name = "setBidButton";
            this.setBidButton.ShadowDecoration.Parent = this.setBidButton;
            this.setBidButton.Size = new System.Drawing.Size(300, 35);
            this.setBidButton.TabIndex = 15;
            this.setBidButton.Text = "No";
            this.setBidButton.Click += new System.EventHandler(this.setBidButton_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 16;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.SkyBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(75, 457);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(300, 35);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "Yes";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // station_buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly_Project.Properties.Resources.host_join_options_background;
            this.ClientSize = new System.Drawing.Size(450, 585);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.setBidButton);
            this.Controls.Add(this.biddingWarLabel);
            this.Controls.Add(this.propInfoPictureBox);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "station_buy";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "station_buy";
            ((System.ComponentModel.ISupportInitialize)(this.propInfoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox propInfoPictureBox;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel biddingWarLabel;
        private Guna.UI2.WinForms.Guna2Button setBidButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}