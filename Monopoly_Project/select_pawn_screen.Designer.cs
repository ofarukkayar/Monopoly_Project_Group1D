
namespace Monopoly_Project
{
    partial class select_pawn_screen
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
            this.selectPawnWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.selectPawnLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pawn1_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pawn2_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pawn3_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pawn4_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pawn5_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pawn6_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startGameButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectPawnWelcome
            // 
            this.selectPawnWelcome.BackColor = System.Drawing.Color.Transparent;
            this.selectPawnWelcome.Font = new System.Drawing.Font("Kabel-Heavy", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPawnWelcome.ForeColor = System.Drawing.Color.Black;
            this.selectPawnWelcome.Location = new System.Drawing.Point(105, 23);
            this.selectPawnWelcome.Name = "selectPawnWelcome";
            this.selectPawnWelcome.Size = new System.Drawing.Size(1070, 97);
            this.selectPawnWelcome.TabIndex = 1;
            this.selectPawnWelcome.Text = "Welcome To Monopoly Bidding War";
            // 
            // selectPawnLabel
            // 
            this.selectPawnLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectPawnLabel.Font = new System.Drawing.Font("Kabel-Heavy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPawnLabel.Location = new System.Drawing.Point(105, 160);
            this.selectPawnLabel.Name = "selectPawnLabel";
            this.selectPawnLabel.Size = new System.Drawing.Size(232, 45);
            this.selectPawnLabel.TabIndex = 2;
            this.selectPawnLabel.Text = "Select Your Pawn";
            // 
            // pawn1_button
            // 
            this.pawn1_button.BackColor = System.Drawing.Color.Transparent;
            this.pawn1_button.BackgroundImage = global::Monopoly_Project.Properties.Resources.menus_border;
            this.pawn1_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pawn1_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn1_button.CheckedState.Parent = this.pawn1_button;
            this.pawn1_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pawn1_button.HoverState.ImageSize = new System.Drawing.Size(105, 60);
            this.pawn1_button.HoverState.Parent = this.pawn1_button;
            this.pawn1_button.Image = global::Monopoly_Project.Properties.Resources.car_pawn;
            this.pawn1_button.ImageRotate = 0F;
            this.pawn1_button.ImageSize = new System.Drawing.Size(180, 100);
            this.pawn1_button.Location = new System.Drawing.Point(120, 240);
            this.pawn1_button.Name = "pawn1_button";
            this.pawn1_button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn1_button.PressedState.Parent = this.pawn1_button;
            this.pawn1_button.Size = new System.Drawing.Size(205, 140);
            this.pawn1_button.TabIndex = 3;
            this.pawn1_button.Click += new System.EventHandler(this.pawn1_button_Click);
            // 
            // pawn2_button
            // 
            this.pawn2_button.BackColor = System.Drawing.Color.Transparent;
            this.pawn2_button.BackgroundImage = global::Monopoly_Project.Properties.Resources.menus_border;
            this.pawn2_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pawn2_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn2_button.CheckedState.Parent = this.pawn2_button;
            this.pawn2_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pawn2_button.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn2_button.HoverState.Parent = this.pawn2_button;
            this.pawn2_button.Image = global::Monopoly_Project.Properties.Resources.hat_pawn;
            this.pawn2_button.ImageRotate = 0F;
            this.pawn2_button.ImageSize = new System.Drawing.Size(100, 80);
            this.pawn2_button.Location = new System.Drawing.Point(538, 240);
            this.pawn2_button.Name = "pawn2_button";
            this.pawn2_button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn2_button.PressedState.Parent = this.pawn2_button;
            this.pawn2_button.Size = new System.Drawing.Size(205, 140);
            this.pawn2_button.TabIndex = 4;
            this.pawn2_button.Click += new System.EventHandler(this.pawn2_button_Click);
            // 
            // pawn3_button
            // 
            this.pawn3_button.BackColor = System.Drawing.Color.Transparent;
            this.pawn3_button.BackgroundImage = global::Monopoly_Project.Properties.Resources.menus_border;
            this.pawn3_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pawn3_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn3_button.CheckedState.Parent = this.pawn3_button;
            this.pawn3_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pawn3_button.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn3_button.HoverState.Parent = this.pawn3_button;
            this.pawn3_button.Image = global::Monopoly_Project.Properties.Resources.ship_pawn;
            this.pawn3_button.ImageRotate = 0F;
            this.pawn3_button.ImageSize = new System.Drawing.Size(100, 80);
            this.pawn3_button.Location = new System.Drawing.Point(955, 240);
            this.pawn3_button.Name = "pawn3_button";
            this.pawn3_button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn3_button.PressedState.Parent = this.pawn3_button;
            this.pawn3_button.Size = new System.Drawing.Size(205, 140);
            this.pawn3_button.TabIndex = 5;
            this.pawn3_button.Click += new System.EventHandler(this.pawn3_button_Click);
            // 
            // pawn4_button
            // 
            this.pawn4_button.BackColor = System.Drawing.Color.Transparent;
            this.pawn4_button.BackgroundImage = global::Monopoly_Project.Properties.Resources.menus_border;
            this.pawn4_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pawn4_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn4_button.CheckedState.Parent = this.pawn4_button;
            this.pawn4_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pawn4_button.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn4_button.HoverState.Parent = this.pawn4_button;
            this.pawn4_button.Image = global::Monopoly_Project.Properties.Resources.shoes_pawn;
            this.pawn4_button.ImageRotate = 0F;
            this.pawn4_button.ImageSize = new System.Drawing.Size(100, 80);
            this.pawn4_button.Location = new System.Drawing.Point(120, 440);
            this.pawn4_button.Name = "pawn4_button";
            this.pawn4_button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn4_button.PressedState.Parent = this.pawn4_button;
            this.pawn4_button.Size = new System.Drawing.Size(205, 140);
            this.pawn4_button.TabIndex = 6;
            this.pawn4_button.Click += new System.EventHandler(this.pawn4_button_Click);
            // 
            // pawn5_button
            // 
            this.pawn5_button.BackColor = System.Drawing.Color.Transparent;
            this.pawn5_button.BackgroundImage = global::Monopoly_Project.Properties.Resources.menus_border;
            this.pawn5_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pawn5_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn5_button.CheckedState.Parent = this.pawn5_button;
            this.pawn5_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pawn5_button.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn5_button.HoverState.Parent = this.pawn5_button;
            this.pawn5_button.Image = global::Monopoly_Project.Properties.Resources.iron_pawn;
            this.pawn5_button.ImageRotate = 0F;
            this.pawn5_button.ImageSize = new System.Drawing.Size(100, 80);
            this.pawn5_button.Location = new System.Drawing.Point(538, 440);
            this.pawn5_button.Name = "pawn5_button";
            this.pawn5_button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn5_button.PressedState.Parent = this.pawn5_button;
            this.pawn5_button.Size = new System.Drawing.Size(205, 140);
            this.pawn5_button.TabIndex = 7;
            this.pawn5_button.Click += new System.EventHandler(this.pawn5_button_Click);
            // 
            // pawn6_button
            // 
            this.pawn6_button.BackColor = System.Drawing.Color.Transparent;
            this.pawn6_button.BackgroundImage = global::Monopoly_Project.Properties.Resources.menus_border;
            this.pawn6_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pawn6_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn6_button.CheckedState.Parent = this.pawn6_button;
            this.pawn6_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pawn6_button.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn6_button.HoverState.Parent = this.pawn6_button;
            this.pawn6_button.Image = global::Monopoly_Project.Properties.Resources.bune_pawn;
            this.pawn6_button.ImageRotate = 0F;
            this.pawn6_button.ImageSize = new System.Drawing.Size(90, 90);
            this.pawn6_button.Location = new System.Drawing.Point(955, 440);
            this.pawn6_button.Name = "pawn6_button";
            this.pawn6_button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pawn6_button.PressedState.Parent = this.pawn6_button;
            this.pawn6_button.Size = new System.Drawing.Size(205, 140);
            this.pawn6_button.TabIndex = 8;
            this.pawn6_button.Click += new System.EventHandler(this.pawn6_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startGameButton
            // 
            this.startGameButton.AutoRoundedCorners = true;
            this.startGameButton.BackColor = System.Drawing.Color.Transparent;
            this.startGameButton.BorderRadius = 19;
            this.startGameButton.BorderThickness = 3;
            this.startGameButton.CheckedState.Parent = this.startGameButton;
            this.startGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGameButton.CustomImages.Parent = this.startGameButton;
            this.startGameButton.Enabled = false;
            this.startGameButton.Font = new System.Drawing.Font("Kabel-Heavy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.ForeColor = System.Drawing.Color.White;
            this.startGameButton.HoverState.Parent = this.startGameButton;
            this.startGameButton.Image = global::Monopoly_Project.Properties.Resources.startIcon;
            this.startGameButton.ImageSize = new System.Drawing.Size(25, 25);
            this.startGameButton.Location = new System.Drawing.Point(521, 161);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.ShadowDecoration.Parent = this.startGameButton;
            this.startGameButton.Size = new System.Drawing.Size(239, 41);
            this.startGameButton.TabIndex = 10;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseTransparentBackground = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Monopoly_Project.Properties.Resources.menus_border;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1286, 720);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // select_pawn_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monopoly_Project.Properties.Resources.select_pawn_bg_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.pawn6_button);
            this.Controls.Add(this.pawn5_button);
            this.Controls.Add(this.pawn4_button);
            this.Controls.Add(this.pawn3_button);
            this.Controls.Add(this.pawn2_button);
            this.Controls.Add(this.pawn1_button);
            this.Controls.Add(this.selectPawnLabel);
            this.Controls.Add(this.selectPawnWelcome);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "select_pawn_screen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "select_pawn_screen";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel selectPawnWelcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel selectPawnLabel;
        private Guna.UI2.WinForms.Guna2ImageButton pawn1_button;
        private Guna.UI2.WinForms.Guna2ImageButton pawn2_button;
        private Guna.UI2.WinForms.Guna2ImageButton pawn3_button;
        private Guna.UI2.WinForms.Guna2ImageButton pawn4_button;
        private Guna.UI2.WinForms.Guna2ImageButton pawn5_button;
        private Guna.UI2.WinForms.Guna2ImageButton pawn6_button;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button startGameButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
