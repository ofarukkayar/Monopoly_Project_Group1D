
namespace Monopoly_Project
{
    partial class pay_tax_screen
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
            this.buyPropertyNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.payTax_border = new Guna.UI2.WinForms.Guna2PictureBox();
            this.propInfoPictureBox = new System.Windows.Forms.PictureBox();
            this.payTaxButton = new Guna.UI2.WinForms.Guna2Button();
            this.mortgageButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.payTax_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propInfoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buyPropertyNameLabel
            // 
            this.buyPropertyNameLabel.AutoSize = false;
            this.buyPropertyNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.buyPropertyNameLabel.Font = new System.Drawing.Font("Kabel-Heavy", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPropertyNameLabel.Location = new System.Drawing.Point(69, 50);
            this.buyPropertyNameLabel.Name = "buyPropertyNameLabel";
            this.buyPropertyNameLabel.Size = new System.Drawing.Size(312, 53);
            this.buyPropertyNameLabel.TabIndex = 15;
            this.buyPropertyNameLabel.Text = "Pay Tax";
            this.buyPropertyNameLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // payTax_border
            // 
            this.payTax_border.BackColor = System.Drawing.Color.Transparent;
            this.payTax_border.Image = global::Monopoly_Project.Properties.Resources.blue_bid_border;
            this.payTax_border.Location = new System.Drawing.Point(0, 0);
            this.payTax_border.Name = "payTax_border";
            this.payTax_border.ShadowDecoration.Parent = this.payTax_border;
            this.payTax_border.Size = new System.Drawing.Size(450, 585);
            this.payTax_border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.payTax_border.TabIndex = 14;
            this.payTax_border.TabStop = false;
            this.payTax_border.UseTransparentBackground = true;
            // 
            // propInfoPictureBox
            // 
            this.propInfoPictureBox.Image = global::Monopoly_Project.Properties.Resources.istanbul_property_card;
            this.propInfoPictureBox.Location = new System.Drawing.Point(75, 109);
            this.propInfoPictureBox.Name = "propInfoPictureBox";
            this.propInfoPictureBox.Size = new System.Drawing.Size(300, 342);
            this.propInfoPictureBox.TabIndex = 16;
            this.propInfoPictureBox.TabStop = false;
            // 
            // payTaxButton
            // 
            this.payTaxButton.AutoRoundedCorners = true;
            this.payTaxButton.BackColor = System.Drawing.Color.Transparent;
            this.payTaxButton.BorderRadius = 16;
            this.payTaxButton.BorderThickness = 3;
            this.payTaxButton.CheckedState.Parent = this.payTaxButton;
            this.payTaxButton.CustomImages.Parent = this.payTaxButton;
            this.payTaxButton.FillColor = System.Drawing.Color.SkyBlue;
            this.payTaxButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payTaxButton.ForeColor = System.Drawing.Color.White;
            this.payTaxButton.HoverState.Parent = this.payTaxButton;
            this.payTaxButton.Location = new System.Drawing.Point(75, 457);
            this.payTaxButton.Name = "payTaxButton";
            this.payTaxButton.ShadowDecoration.Parent = this.payTaxButton;
            this.payTaxButton.Size = new System.Drawing.Size(300, 35);
            this.payTaxButton.TabIndex = 17;
            this.payTaxButton.Text = "Pay $30";
            this.payTaxButton.Click += new System.EventHandler(this.payTaxButton_Click);
            // 
            // mortgageButton
            // 
            this.mortgageButton.AutoRoundedCorners = true;
            this.mortgageButton.BackColor = System.Drawing.Color.Transparent;
            this.mortgageButton.BorderRadius = 16;
            this.mortgageButton.BorderThickness = 3;
            this.mortgageButton.CheckedState.Parent = this.mortgageButton;
            this.mortgageButton.CustomImages.Parent = this.mortgageButton;
            this.mortgageButton.FillColor = System.Drawing.Color.SkyBlue;
            this.mortgageButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mortgageButton.ForeColor = System.Drawing.Color.White;
            this.mortgageButton.HoverState.Parent = this.mortgageButton;
            this.mortgageButton.Location = new System.Drawing.Point(75, 498);
            this.mortgageButton.Name = "mortgageButton";
            this.mortgageButton.ShadowDecoration.Parent = this.mortgageButton;
            this.mortgageButton.Size = new System.Drawing.Size(300, 35);
            this.mortgageButton.TabIndex = 19;
            this.mortgageButton.Text = "Mortgage";
            this.mortgageButton.Visible = false;
            this.mortgageButton.Click += new System.EventHandler(this.mortgageButton_Click);
            // 
            // pay_tax_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly_Project.Properties.Resources.host_join_options_background;
            this.ClientSize = new System.Drawing.Size(450, 585);
            this.Controls.Add(this.mortgageButton);
            this.Controls.Add(this.payTaxButton);
            this.Controls.Add(this.propInfoPictureBox);
            this.Controls.Add(this.buyPropertyNameLabel);
            this.Controls.Add(this.payTax_border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pay_tax_screen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pay_tax_screen";
            ((System.ComponentModel.ISupportInitialize)(this.payTax_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propInfoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel buyPropertyNameLabel;
        private Guna.UI2.WinForms.Guna2PictureBox payTax_border;
        private System.Windows.Forms.PictureBox propInfoPictureBox;
        private Guna.UI2.WinForms.Guna2Button payTaxButton;
        private Guna.UI2.WinForms.Guna2Button mortgageButton;
    }
}