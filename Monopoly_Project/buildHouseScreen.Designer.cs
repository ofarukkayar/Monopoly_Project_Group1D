
namespace Monopoly_Project
{
    partial class buildHouseScreen
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
            this.buildHouseLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.propInfoPictureBox = new System.Windows.Forms.PictureBox();
            this.buildHotel = new Guna.UI2.WinForms.Guna2Button();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.houseBuild = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.propInfoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buildHouseLabel
            // 
            this.buildHouseLabel.BackColor = System.Drawing.Color.Transparent;
            this.buildHouseLabel.Font = new System.Drawing.Font("Kabel-Heavy", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildHouseLabel.Location = new System.Drawing.Point(247, 15);
            this.buildHouseLabel.Name = "buildHouseLabel";
            this.buildHouseLabel.Size = new System.Drawing.Size(192, 53);
            this.buildHouseLabel.TabIndex = 3;
            this.buildHouseLabel.Text = "Build House";
            // 
            // propInfoPictureBox
            // 
            this.propInfoPictureBox.Image = global::Monopoly_Project.Properties.Resources.tokyo_property_card;
            this.propInfoPictureBox.Location = new System.Drawing.Point(12, 74);
            this.propInfoPictureBox.Name = "propInfoPictureBox";
            this.propInfoPictureBox.Size = new System.Drawing.Size(300, 342);
            this.propInfoPictureBox.TabIndex = 4;
            this.propInfoPictureBox.TabStop = false;
            // 
            // buildHotel
            // 
            this.buildHotel.AutoRoundedCorners = true;
            this.buildHotel.BackColor = System.Drawing.Color.Transparent;
            this.buildHotel.BorderRadius = 44;
            this.buildHotel.BorderThickness = 2;
            this.buildHotel.CheckedState.Parent = this.buildHotel;
            this.buildHotel.CustomImages.Parent = this.buildHotel;
            this.buildHotel.FillColor = System.Drawing.Color.Red;
            this.buildHotel.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildHotel.ForeColor = System.Drawing.Color.White;
            this.buildHotel.HoverState.Parent = this.buildHotel;
            this.buildHotel.Location = new System.Drawing.Point(353, 200);
            this.buildHotel.Name = "buildHotel";
            this.buildHotel.ShadowDecoration.Parent = this.buildHotel;
            this.buildHotel.Size = new System.Drawing.Size(300, 90);
            this.buildHotel.TabIndex = 12;
            this.buildHotel.Text = "Build Hotel";
            // 
            // cancelButton
            // 
            this.cancelButton.AutoRoundedCorners = true;
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BorderColor = System.Drawing.Color.White;
            this.cancelButton.BorderRadius = 44;
            this.cancelButton.BorderThickness = 2;
            this.cancelButton.CheckedState.Parent = this.cancelButton;
            this.cancelButton.CustomImages.Parent = this.cancelButton;
            this.cancelButton.FillColor = System.Drawing.Color.Black;
            this.cancelButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.HoverState.Parent = this.cancelButton;
            this.cancelButton.Location = new System.Drawing.Point(353, 326);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.ShadowDecoration.Parent = this.cancelButton;
            this.cancelButton.Size = new System.Drawing.Size(300, 90);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Don\'t Build";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // houseBuild
            // 
            this.houseBuild.AutoRoundedCorners = true;
            this.houseBuild.BackColor = System.Drawing.Color.Transparent;
            this.houseBuild.BorderRadius = 44;
            this.houseBuild.BorderThickness = 2;
            this.houseBuild.CheckedState.Parent = this.houseBuild;
            this.houseBuild.CustomImages.Parent = this.houseBuild;
            this.houseBuild.FillColor = System.Drawing.Color.ForestGreen;
            this.houseBuild.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houseBuild.ForeColor = System.Drawing.Color.White;
            this.houseBuild.HoverState.Parent = this.houseBuild;
            this.houseBuild.Location = new System.Drawing.Point(353, 74);
            this.houseBuild.Name = "houseBuild";
            this.houseBuild.ShadowDecoration.Parent = this.houseBuild;
            this.houseBuild.Size = new System.Drawing.Size(300, 90);
            this.houseBuild.TabIndex = 14;
            this.houseBuild.Text = "Build House";
            this.houseBuild.Click += new System.EventHandler(this.houseBuild_Click);
            // 
            // buildHouseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly_Project.Properties.Resources.monopoly_bg_with_border;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 428);
            this.Controls.Add(this.houseBuild);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.buildHotel);
            this.Controls.Add(this.propInfoPictureBox);
            this.Controls.Add(this.buildHouseLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "buildHouseScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buildHouseScreen";
            ((System.ComponentModel.ISupportInitialize)(this.propInfoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel buildHouseLabel;
        private System.Windows.Forms.PictureBox propInfoPictureBox;
        private Guna.UI2.WinForms.Guna2Button buildHotel;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2Button houseBuild;
    }
}