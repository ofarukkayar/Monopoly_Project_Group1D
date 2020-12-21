
namespace Monopoly_Project
{
    partial class main_screen_ui
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.playButton = new Guna.UI2.WinForms.Guna2Button();
            this.settingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.howToPlayButton = new Guna.UI2.WinForms.Guna2Button();
            this.creditsButton = new Guna.UI2.WinForms.Guna2Button();
            this.exitGameButton = new Guna.UI2.WinForms.Guna2Button();
            this.joinButton = new Guna.UI2.WinForms.Guna2Button();
            this.hostButton = new Guna.UI2.WinForms.Guna2Button();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.AutoRoundedCorners = true;
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BorderRadius = 18;
            this.playButton.BorderThickness = 3;
            this.playButton.CheckedState.Parent = this.playButton;
            this.playButton.CustomImages.Parent = this.playButton;
            this.playButton.FillColor = System.Drawing.Color.Red;
            this.playButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.HoverState.Parent = this.playButton;
            this.playButton.Image = global::Monopoly_Project.Properties.Resources.buttons_icon;
            this.playButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.playButton.ImageSize = new System.Drawing.Size(40, 40);
            this.playButton.Location = new System.Drawing.Point(797, 420);
            this.playButton.Name = "playButton";
            this.playButton.PressedDepth = 80;
            this.playButton.ShadowDecoration.Parent = this.playButton;
            this.playButton.Size = new System.Drawing.Size(310, 45);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY";
            this.playButton.UseTransparentBackground = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.AutoRoundedCorners = true;
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BorderRadius = 18;
            this.settingsButton.BorderThickness = 3;
            this.settingsButton.CheckedState.Parent = this.settingsButton;
            this.settingsButton.CustomImages.Parent = this.settingsButton;
            this.settingsButton.FillColor = System.Drawing.Color.Red;
            this.settingsButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.HoverState.Parent = this.settingsButton;
            this.settingsButton.Image = global::Monopoly_Project.Properties.Resources.buttons_icon;
            this.settingsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsButton.ImageSize = new System.Drawing.Size(40, 40);
            this.settingsButton.Location = new System.Drawing.Point(797, 480);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.PressedDepth = 80;
            this.settingsButton.ShadowDecoration.Parent = this.settingsButton;
            this.settingsButton.Size = new System.Drawing.Size(310, 45);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.UseTransparentBackground = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // howToPlayButton
            // 
            this.howToPlayButton.AutoRoundedCorners = true;
            this.howToPlayButton.BackColor = System.Drawing.Color.Transparent;
            this.howToPlayButton.BorderRadius = 18;
            this.howToPlayButton.BorderThickness = 3;
            this.howToPlayButton.CheckedState.Parent = this.howToPlayButton;
            this.howToPlayButton.CustomImages.Parent = this.howToPlayButton;
            this.howToPlayButton.FillColor = System.Drawing.Color.Red;
            this.howToPlayButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlayButton.ForeColor = System.Drawing.Color.White;
            this.howToPlayButton.HoverState.Parent = this.howToPlayButton;
            this.howToPlayButton.Image = global::Monopoly_Project.Properties.Resources.buttons_icon;
            this.howToPlayButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.howToPlayButton.ImageSize = new System.Drawing.Size(40, 40);
            this.howToPlayButton.Location = new System.Drawing.Point(797, 540);
            this.howToPlayButton.Name = "howToPlayButton";
            this.howToPlayButton.PressedDepth = 80;
            this.howToPlayButton.ShadowDecoration.Parent = this.howToPlayButton;
            this.howToPlayButton.Size = new System.Drawing.Size(310, 45);
            this.howToPlayButton.TabIndex = 2;
            this.howToPlayButton.Text = "HOW TO PLAY";
            this.howToPlayButton.UseTransparentBackground = true;
            this.howToPlayButton.Click += new System.EventHandler(this.howToPlayButton_Click);
            // 
            // creditsButton
            // 
            this.creditsButton.AutoRoundedCorners = true;
            this.creditsButton.BackColor = System.Drawing.Color.Transparent;
            this.creditsButton.BorderRadius = 18;
            this.creditsButton.BorderThickness = 3;
            this.creditsButton.CheckedState.Parent = this.creditsButton;
            this.creditsButton.CustomImages.Parent = this.creditsButton;
            this.creditsButton.FillColor = System.Drawing.Color.Red;
            this.creditsButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsButton.ForeColor = System.Drawing.Color.White;
            this.creditsButton.HoverState.Parent = this.creditsButton;
            this.creditsButton.Image = global::Monopoly_Project.Properties.Resources.buttons_icon;
            this.creditsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.creditsButton.ImageSize = new System.Drawing.Size(40, 40);
            this.creditsButton.Location = new System.Drawing.Point(797, 600);
            this.creditsButton.Name = "creditsButton";
            this.creditsButton.PressedDepth = 80;
            this.creditsButton.ShadowDecoration.Parent = this.creditsButton;
            this.creditsButton.Size = new System.Drawing.Size(310, 45);
            this.creditsButton.TabIndex = 3;
            this.creditsButton.Text = "CREDITS";
            this.creditsButton.UseTransparentBackground = true;
            this.creditsButton.Click += new System.EventHandler(this.creditsButton_Click);
            // 
            // exitGameButton
            // 
            this.exitGameButton.AutoRoundedCorners = true;
            this.exitGameButton.BackColor = System.Drawing.Color.Transparent;
            this.exitGameButton.BorderRadius = 18;
            this.exitGameButton.BorderThickness = 3;
            this.exitGameButton.CheckedState.Parent = this.exitGameButton;
            this.exitGameButton.CustomImages.Parent = this.exitGameButton;
            this.exitGameButton.FillColor = System.Drawing.Color.Red;
            this.exitGameButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitGameButton.ForeColor = System.Drawing.Color.White;
            this.exitGameButton.HoverState.Parent = this.exitGameButton;
            this.exitGameButton.Image = global::Monopoly_Project.Properties.Resources.buttons_icon;
            this.exitGameButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exitGameButton.ImageSize = new System.Drawing.Size(40, 40);
            this.exitGameButton.Location = new System.Drawing.Point(797, 660);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.PressedDepth = 80;
            this.exitGameButton.ShadowDecoration.Parent = this.exitGameButton;
            this.exitGameButton.Size = new System.Drawing.Size(310, 45);
            this.exitGameButton.TabIndex = 4;
            this.exitGameButton.Text = "EXIT GAME";
            this.exitGameButton.UseTransparentBackground = true;
            this.exitGameButton.Click += new System.EventHandler(this.exitGameButton_Click);
            // 
            // joinButton
            // 
            this.joinButton.AutoRoundedCorners = true;
            this.joinButton.BackColor = System.Drawing.Color.Transparent;
            this.joinButton.BorderRadius = 18;
            this.joinButton.BorderThickness = 3;
            this.joinButton.CheckedState.Parent = this.joinButton;
            this.joinButton.CustomImages.Parent = this.joinButton;
            this.joinButton.FillColor = System.Drawing.Color.Red;
            this.joinButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinButton.ForeColor = System.Drawing.Color.White;
            this.joinButton.HoverState.Parent = this.joinButton;
            this.joinButton.Image = global::Monopoly_Project.Properties.Resources.buttons_icon;
            this.joinButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.joinButton.ImageSize = new System.Drawing.Size(40, 40);
            this.joinButton.Location = new System.Drawing.Point(852, 480);
            this.joinButton.Name = "joinButton";
            this.joinButton.PressedDepth = 80;
            this.joinButton.ShadowDecoration.Parent = this.joinButton;
            this.joinButton.Size = new System.Drawing.Size(200, 45);
            this.joinButton.TabIndex = 5;
            this.joinButton.Text = "JOIN";
            this.joinButton.UseTransparentBackground = true;
            this.joinButton.Visible = false;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // hostButton
            // 
            this.hostButton.AutoRoundedCorners = true;
            this.hostButton.BackColor = System.Drawing.Color.Transparent;
            this.hostButton.BorderRadius = 18;
            this.hostButton.BorderThickness = 3;
            this.hostButton.CheckedState.Parent = this.hostButton;
            this.hostButton.CustomImages.Parent = this.hostButton;
            this.hostButton.FillColor = System.Drawing.Color.Red;
            this.hostButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostButton.ForeColor = System.Drawing.Color.White;
            this.hostButton.HoverState.Parent = this.hostButton;
            this.hostButton.Image = global::Monopoly_Project.Properties.Resources.buttons_icon;
            this.hostButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.hostButton.ImageSize = new System.Drawing.Size(40, 40);
            this.hostButton.Location = new System.Drawing.Point(852, 540);
            this.hostButton.Name = "hostButton";
            this.hostButton.PressedDepth = 80;
            this.hostButton.ShadowDecoration.Parent = this.hostButton;
            this.hostButton.Size = new System.Drawing.Size(200, 45);
            this.hostButton.TabIndex = 6;
            this.hostButton.Text = "HOST";
            this.hostButton.UseTransparentBackground = true;
            this.hostButton.Visible = false;
            this.hostButton.Click += new System.EventHandler(this.hostButton_Click);
            // 
            // backButton
            // 
            this.backButton.AutoRoundedCorners = true;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BorderRadius = 18;
            this.backButton.BorderThickness = 3;
            this.backButton.CheckedState.Parent = this.backButton;
            this.backButton.CustomImages.Parent = this.backButton;
            this.backButton.FillColor = System.Drawing.Color.Red;
            this.backButton.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.HoverState.Parent = this.backButton;
            this.backButton.Image = global::Monopoly_Project.Properties.Resources.buttons_icon;
            this.backButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.backButton.ImageSize = new System.Drawing.Size(40, 40);
            this.backButton.Location = new System.Drawing.Point(852, 600);
            this.backButton.Name = "backButton";
            this.backButton.PressedDepth = 80;
            this.backButton.ShadowDecoration.Parent = this.backButton;
            this.backButton.Size = new System.Drawing.Size(200, 45);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "BACK";
            this.backButton.UseTransparentBackground = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // main_screen_ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly_Project.Properties.Resources.main_screen_backgorund;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.hostButton);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.exitGameButton);
            this.Controls.Add(this.creditsButton);
            this.Controls.Add(this.howToPlayButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.playButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_screen_ui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button playButton;
        private Guna.UI2.WinForms.Guna2Button settingsButton;
        private Guna.UI2.WinForms.Guna2Button howToPlayButton;
        private Guna.UI2.WinForms.Guna2Button creditsButton;
        private Guna.UI2.WinForms.Guna2Button exitGameButton;
        private Guna.UI2.WinForms.Guna2Button joinButton;
        private Guna.UI2.WinForms.Guna2Button hostButton;  
        private Guna.UI2.WinForms.Guna2Button backButton;
    }
}

