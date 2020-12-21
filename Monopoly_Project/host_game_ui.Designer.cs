
namespace Monopoly_Project
{
    partial class host_game_ui
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
            this.host_border1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.host_border2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.host_exit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.host_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.host_playerID_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.host_gameID_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.host_enter_button = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.host_border1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.host_border2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.host_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // host_border1
            // 
            this.host_border1.BackColor = System.Drawing.Color.Transparent;
            this.host_border1.Image = global::Monopoly_Project.Properties.Resources.menus_border;
            this.host_border1.Location = new System.Drawing.Point(13, 14);
            this.host_border1.Name = "host_border1";
            this.host_border1.ShadowDecoration.Parent = this.host_border1;
            this.host_border1.Size = new System.Drawing.Size(574, 372);
            this.host_border1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.host_border1.TabIndex = 3;
            this.host_border1.TabStop = false;
            this.host_border1.UseTransparentBackground = true;
            // 
            // host_border2
            // 
            this.host_border2.BackColor = System.Drawing.Color.Transparent;
            this.host_border2.Image = global::Monopoly_Project.Properties.Resources.menus_border;
            this.host_border2.Location = new System.Drawing.Point(0, 0);
            this.host_border2.Name = "host_border2";
            this.host_border2.ShadowDecoration.Parent = this.host_border2;
            this.host_border2.Size = new System.Drawing.Size(600, 400);
            this.host_border2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.host_border2.TabIndex = 4;
            this.host_border2.TabStop = false;
            this.host_border2.UseTransparentBackground = true;
            // 
            // host_exit
            // 
            this.host_exit.BackColor = System.Drawing.Color.Transparent;
            this.host_exit.Image = global::Monopoly_Project.Properties.Resources.exit_button_2_icon;
            this.host_exit.Location = new System.Drawing.Point(532, 30);
            this.host_exit.Name = "host_exit";
            this.host_exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.host_exit.ShadowDecoration.Parent = this.host_exit;
            this.host_exit.Size = new System.Drawing.Size(40, 40);
            this.host_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.host_exit.TabIndex = 5;
            this.host_exit.TabStop = false;
            this.host_exit.UseTransparentBackground = true;
            this.host_exit.Click += new System.EventHandler(this.host_exit_Click);
            // 
            // host_label
            // 
            this.host_label.BackColor = System.Drawing.Color.Transparent;
            this.host_label.Font = new System.Drawing.Font("Kabel-Heavy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.host_label.Location = new System.Drawing.Point(221, 30);
            this.host_label.Name = "host_label";
            this.host_label.Size = new System.Drawing.Size(158, 45);
            this.host_label.TabIndex = 6;
            this.host_label.Text = "Host Game";
            // 
            // host_playerID_textbox
            // 
            this.host_playerID_textbox.BackColor = System.Drawing.Color.SkyBlue;
            this.host_playerID_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.host_playerID_textbox.DefaultText = "";
            this.host_playerID_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.host_playerID_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.host_playerID_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.host_playerID_textbox.DisabledState.Parent = this.host_playerID_textbox;
            this.host_playerID_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.host_playerID_textbox.FillColor = System.Drawing.Color.SkyBlue;
            this.host_playerID_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.host_playerID_textbox.FocusedState.Parent = this.host_playerID_textbox;
            this.host_playerID_textbox.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.host_playerID_textbox.ForeColor = System.Drawing.Color.White;
            this.host_playerID_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.host_playerID_textbox.HoverState.Parent = this.host_playerID_textbox;
            this.host_playerID_textbox.Location = new System.Drawing.Point(172, 79);
            this.host_playerID_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.host_playerID_textbox.MaxLength = 12;
            this.host_playerID_textbox.Name = "host_playerID_textbox";
            this.host_playerID_textbox.PasswordChar = '\0';
            this.host_playerID_textbox.PlaceholderText = "Player ID";
            this.host_playerID_textbox.SelectedText = "";
            this.host_playerID_textbox.ShadowDecoration.Parent = this.host_playerID_textbox;
            this.host_playerID_textbox.Size = new System.Drawing.Size(257, 45);
            this.host_playerID_textbox.TabIndex = 7;
            // 
            // host_gameID_textbox
            // 
            this.host_gameID_textbox.BackColor = System.Drawing.Color.SkyBlue;
            this.host_gameID_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.host_gameID_textbox.DefaultText = "";
            this.host_gameID_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.host_gameID_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.host_gameID_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.host_gameID_textbox.DisabledState.Parent = this.host_gameID_textbox;
            this.host_gameID_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.host_gameID_textbox.FillColor = System.Drawing.Color.SkyBlue;
            this.host_gameID_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.host_gameID_textbox.FocusedState.Parent = this.host_gameID_textbox;
            this.host_gameID_textbox.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.host_gameID_textbox.ForeColor = System.Drawing.Color.White;
            this.host_gameID_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.host_gameID_textbox.HoverState.Parent = this.host_gameID_textbox;
            this.host_gameID_textbox.Location = new System.Drawing.Point(172, 134);
            this.host_gameID_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.host_gameID_textbox.Name = "host_gameID_textbox";
            this.host_gameID_textbox.PasswordChar = '\0';
            this.host_gameID_textbox.PlaceholderText = "Game ID";
            this.host_gameID_textbox.SelectedText = "";
            this.host_gameID_textbox.ShadowDecoration.Parent = this.host_gameID_textbox;
            this.host_gameID_textbox.Size = new System.Drawing.Size(257, 45);
            this.host_gameID_textbox.TabIndex = 8;
            // 
            // host_enter_button
            // 
            this.host_enter_button.AutoRoundedCorners = true;
            this.host_enter_button.BackColor = System.Drawing.Color.Transparent;
            this.host_enter_button.BorderRadius = 21;
            this.host_enter_button.BorderThickness = 2;
            this.host_enter_button.CheckedState.Parent = this.host_enter_button;
            this.host_enter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.host_enter_button.CustomImages.Parent = this.host_enter_button;
            this.host_enter_button.FillColor = System.Drawing.Color.SkyBlue;
            this.host_enter_button.Font = new System.Drawing.Font("Kabel-Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.host_enter_button.ForeColor = System.Drawing.Color.White;
            this.host_enter_button.HoverState.Parent = this.host_enter_button;
            this.host_enter_button.Image = global::Monopoly_Project.Properties.Resources.buttons_icon;
            this.host_enter_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.host_enter_button.ImageSize = new System.Drawing.Size(40, 40);
            this.host_enter_button.Location = new System.Drawing.Point(192, 208);
            this.host_enter_button.Name = "host_enter_button";
            this.host_enter_button.PressedDepth = 80;
            this.host_enter_button.ShadowDecoration.Parent = this.host_enter_button;
            this.host_enter_button.Size = new System.Drawing.Size(216, 44);
            this.host_enter_button.TabIndex = 9;
            this.host_enter_button.Text = "ENTER";
            this.host_enter_button.UseTransparentBackground = true;
            this.host_enter_button.Click += new System.EventHandler(this.host_enter_button_Click);
            // 
            // host_game_ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly_Project.Properties.Resources.host_join_options_background;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.host_enter_button);
            this.Controls.Add(this.host_gameID_textbox);
            this.Controls.Add(this.host_playerID_textbox);
            this.Controls.Add(this.host_label);
            this.Controls.Add(this.host_exit);
            this.Controls.Add(this.host_border1);
            this.Controls.Add(this.host_border2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "host_game_ui";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "host_game_ui";
            ((System.ComponentModel.ISupportInitialize)(this.host_border1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.host_border2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.host_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox host_border1;
        private Guna.UI2.WinForms.Guna2PictureBox host_border2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox host_exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel host_label;
        private Guna.UI2.WinForms.Guna2TextBox host_playerID_textbox;
        private Guna.UI2.WinForms.Guna2TextBox host_gameID_textbox;
        private Guna.UI2.WinForms.Guna2Button host_enter_button;
    }
}