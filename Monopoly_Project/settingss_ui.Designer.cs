
namespace Monopoly_Project
{
    partial class settingss_ui
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
            this.settings_exit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.settings_border1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.settings_borde2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.settings_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.masterVolumeTBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.masterVolLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BGMVolLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.seVolLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bgmVolumeTBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.seVolumeTBar = new Guna.UI2.WinForms.Guna2TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.settings_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_border1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_borde2)).BeginInit();
            this.SuspendLayout();
            // 
            // settings_exit
            // 
            this.settings_exit.BackColor = System.Drawing.Color.Transparent;
            this.settings_exit.Image = global::Monopoly_Project.Properties.Resources.exit_button_2_icon;
            this.settings_exit.Location = new System.Drawing.Point(532, 30);
            this.settings_exit.Name = "settings_exit";
            this.settings_exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.settings_exit.ShadowDecoration.Parent = this.settings_exit;
            this.settings_exit.Size = new System.Drawing.Size(40, 40);
            this.settings_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settings_exit.TabIndex = 0;
            this.settings_exit.TabStop = false;
            this.settings_exit.UseTransparentBackground = true;
            this.settings_exit.Click += new System.EventHandler(this.settings_exit_Click);
            // 
            // settings_border1
            // 
            this.settings_border1.BackColor = System.Drawing.Color.Transparent;
            this.settings_border1.Image = global::Monopoly_Project.Properties.Resources.menus_border;
            this.settings_border1.Location = new System.Drawing.Point(0, 1);
            this.settings_border1.Name = "settings_border1";
            this.settings_border1.ShadowDecoration.Parent = this.settings_border1;
            this.settings_border1.Size = new System.Drawing.Size(600, 400);
            this.settings_border1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settings_border1.TabIndex = 1;
            this.settings_border1.TabStop = false;
            this.settings_border1.UseTransparentBackground = true;
            // 
            // settings_borde2
            // 
            this.settings_borde2.BackColor = System.Drawing.Color.Transparent;
            this.settings_borde2.Image = global::Monopoly_Project.Properties.Resources.menus_border;
            this.settings_borde2.Location = new System.Drawing.Point(13, 14);
            this.settings_borde2.Name = "settings_borde2";
            this.settings_borde2.ShadowDecoration.Parent = this.settings_borde2;
            this.settings_borde2.Size = new System.Drawing.Size(574, 372);
            this.settings_borde2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settings_borde2.TabIndex = 2;
            this.settings_borde2.TabStop = false;
            this.settings_borde2.UseTransparentBackground = true;
            // 
            // settings_label
            // 
            this.settings_label.BackColor = System.Drawing.Color.Transparent;
            this.settings_label.Font = new System.Drawing.Font("Kabel-Heavy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_label.Location = new System.Drawing.Point(247, 30);
            this.settings_label.Name = "settings_label";
            this.settings_label.Size = new System.Drawing.Size(106, 45);
            this.settings_label.TabIndex = 3;
            this.settings_label.Text = "Settings";
            // 
            // masterVolumeTBar
            // 
            this.masterVolumeTBar.BackColor = System.Drawing.Color.Transparent;
            this.masterVolumeTBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.masterVolumeTBar.HoverState.Parent = this.masterVolumeTBar;
            this.masterVolumeTBar.IndicateFocus = false;
            this.masterVolumeTBar.Location = new System.Drawing.Point(222, 125);
            this.masterVolumeTBar.Name = "masterVolumeTBar";
            this.masterVolumeTBar.Size = new System.Drawing.Size(300, 23);
            this.masterVolumeTBar.TabIndex = 4;
            this.masterVolumeTBar.ThumbColor = System.Drawing.Color.Black;
            // 
            // masterVolLabel
            // 
            this.masterVolLabel.BackColor = System.Drawing.Color.Transparent;
            this.masterVolLabel.Font = new System.Drawing.Font("Kabel-Heavy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterVolLabel.Location = new System.Drawing.Point(29, 125);
            this.masterVolLabel.Name = "masterVolLabel";
            this.masterVolLabel.Size = new System.Drawing.Size(149, 34);
            this.masterVolLabel.TabIndex = 5;
            this.masterVolLabel.Text = "Master Volume";
            // 
            // BGMVolLabel
            // 
            this.BGMVolLabel.BackColor = System.Drawing.Color.Transparent;
            this.BGMVolLabel.Font = new System.Drawing.Font("Kabel-Heavy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGMVolLabel.Location = new System.Drawing.Point(29, 202);
            this.BGMVolLabel.Name = "BGMVolLabel";
            this.BGMVolLabel.Size = new System.Drawing.Size(138, 34);
            this.BGMVolLabel.TabIndex = 6;
            this.BGMVolLabel.Text = "BGM Volume";
            // 
            // seVolLabel
            // 
            this.seVolLabel.BackColor = System.Drawing.Color.Transparent;
            this.seVolLabel.Font = new System.Drawing.Font("Kabel-Heavy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seVolLabel.Location = new System.Drawing.Point(29, 276);
            this.seVolLabel.Name = "seVolLabel";
            this.seVolLabel.Size = new System.Drawing.Size(106, 34);
            this.seVolLabel.TabIndex = 7;
            this.seVolLabel.Text = "SE Volume";
            // 
            // bgmVolumeTBar
            // 
            this.bgmVolumeTBar.BackColor = System.Drawing.Color.Transparent;
            this.bgmVolumeTBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.bgmVolumeTBar.HoverState.Parent = this.bgmVolumeTBar;
            this.bgmVolumeTBar.IndicateFocus = false;
            this.bgmVolumeTBar.Location = new System.Drawing.Point(222, 202);
            this.bgmVolumeTBar.Name = "bgmVolumeTBar";
            this.bgmVolumeTBar.Size = new System.Drawing.Size(300, 23);
            this.bgmVolumeTBar.TabIndex = 8;
            this.bgmVolumeTBar.ThumbColor = System.Drawing.Color.Black;
            // 
            // seVolumeTBar
            // 
            this.seVolumeTBar.BackColor = System.Drawing.Color.Transparent;
            this.seVolumeTBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.seVolumeTBar.HoverState.Parent = this.seVolumeTBar;
            this.seVolumeTBar.IndicateFocus = false;
            this.seVolumeTBar.Location = new System.Drawing.Point(222, 287);
            this.seVolumeTBar.Name = "seVolumeTBar";
            this.seVolumeTBar.Size = new System.Drawing.Size(300, 23);
            this.seVolumeTBar.TabIndex = 9;
            this.seVolumeTBar.ThumbColor = System.Drawing.Color.Black;
            // 
            // settingss_ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly_Project.Properties.Resources.host_join_options_background;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.seVolumeTBar);
            this.Controls.Add(this.bgmVolumeTBar);
            this.Controls.Add(this.seVolLabel);
            this.Controls.Add(this.BGMVolLabel);
            this.Controls.Add(this.masterVolLabel);
            this.Controls.Add(this.masterVolumeTBar);
            this.Controls.Add(this.settings_label);
            this.Controls.Add(this.settings_exit);
            this.Controls.Add(this.settings_borde2);
            this.Controls.Add(this.settings_border1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settingss_ui";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.settings_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_border1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_borde2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox settings_exit;
        private Guna.UI2.WinForms.Guna2PictureBox settings_border1;
        private Guna.UI2.WinForms.Guna2PictureBox settings_borde2;
        private Guna.UI2.WinForms.Guna2HtmlLabel settings_label;
        private Guna.UI2.WinForms.Guna2TrackBar masterVolumeTBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel masterVolLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel BGMVolLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel seVolLabel;
        private Guna.UI2.WinForms.Guna2TrackBar bgmVolumeTBar;
        private Guna.UI2.WinForms.Guna2TrackBar seVolumeTBar;
    }
}