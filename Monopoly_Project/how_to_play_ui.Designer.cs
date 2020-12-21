
namespace Monopoly_Project
{
    partial class how_to_play_ui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(how_to_play_ui));
            this.howToPlayLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.howToPlay_border1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.howToPlay_border2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.rules_text_box = new System.Windows.Forms.TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.howToPlay_border1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.howToPlay_border2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // howToPlayLabel
            // 
            this.howToPlayLabel.BackColor = System.Drawing.Color.Transparent;
            this.howToPlayLabel.Font = new System.Drawing.Font("Kabel-Heavy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlayLabel.Location = new System.Drawing.Point(352, 31);
            this.howToPlayLabel.Name = "howToPlayLabel";
            this.howToPlayLabel.Size = new System.Drawing.Size(197, 45);
            this.howToPlayLabel.TabIndex = 0;
            this.howToPlayLabel.Text = "How To Play?";
            // 
            // howToPlay_border1
            // 
            this.howToPlay_border1.BackColor = System.Drawing.Color.Transparent;
            this.howToPlay_border1.Image = global::Monopoly_Project.Properties.Resources.menus_border;
            this.howToPlay_border1.Location = new System.Drawing.Point(-1, 0);
            this.howToPlay_border1.Name = "howToPlay_border1";
            this.howToPlay_border1.ShadowDecoration.Parent = this.howToPlay_border1;
            this.howToPlay_border1.Size = new System.Drawing.Size(902, 600);
            this.howToPlay_border1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.howToPlay_border1.TabIndex = 3;
            this.howToPlay_border1.TabStop = false;
            this.howToPlay_border1.UseTransparentBackground = true;
            // 
            // howToPlay_border2
            // 
            this.howToPlay_border2.BackColor = System.Drawing.Color.Transparent;
            this.howToPlay_border2.Image = global::Monopoly_Project.Properties.Resources.menus_border;
            this.howToPlay_border2.Location = new System.Drawing.Point(8, 12);
            this.howToPlay_border2.Name = "howToPlay_border2";
            this.howToPlay_border2.ShadowDecoration.Parent = this.howToPlay_border2;
            this.howToPlay_border2.Size = new System.Drawing.Size(885, 577);
            this.howToPlay_border2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.howToPlay_border2.TabIndex = 4;
            this.howToPlay_border2.TabStop = false;
            this.howToPlay_border2.UseTransparentBackground = true;
            // 
            // rules_text_box
            // 
            this.rules_text_box.BackColor = System.Drawing.Color.SkyBlue;
            this.rules_text_box.Font = new System.Drawing.Font("Kabel-Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rules_text_box.Location = new System.Drawing.Point(26, 95);
            this.rules_text_box.Multiline = true;
            this.rules_text_box.Name = "rules_text_box";
            this.rules_text_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rules_text_box.Size = new System.Drawing.Size(852, 471);
            this.rules_text_box.TabIndex = 36;
            this.rules_text_box.TabStop = false;
            this.rules_text_box.Text = resources.GetString("rules_text_box.Text");
            this.rules_text_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Monopoly_Project.Properties.Resources.exit_button_2_icon;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(824, 36);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 37;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // how_to_play_ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly_Project.Properties.Resources.host_join_options_background;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.rules_text_box);
            this.Controls.Add(this.howToPlayLabel);
            this.Controls.Add(this.howToPlay_border2);
            this.Controls.Add(this.howToPlay_border1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "how_to_play_ui";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "how_to_play_ui";
            ((System.ComponentModel.ISupportInitialize)(this.howToPlay_border1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.howToPlay_border2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel howToPlayLabel;
        private Guna.UI2.WinForms.Guna2PictureBox howToPlay_border1;
        private Guna.UI2.WinForms.Guna2PictureBox howToPlay_border2;
        private System.Windows.Forms.TextBox rules_text_box;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}