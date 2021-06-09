
namespace Game_Arkanoid
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.TxtPunkte = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.HightBox = new System.Windows.Forms.PictureBox();
            this.HightPunkte = new System.Windows.Forms.Label();
            this.TxtGewonnen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HightBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = global::Game_Arkanoid.Properties.Resources.akanoid_player;
            this.Player.Location = new System.Drawing.Point(357, 519);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(126, 30);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.BackgroundImage = global::Game_Arkanoid.Properties.Resources.akanoid_ball;
            this.Ball.Location = new System.Drawing.Point(409, 427);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(16, 16);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // TxtPunkte
            // 
            this.TxtPunkte.AutoSize = true;
            this.TxtPunkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPunkte.Location = new System.Drawing.Point(13, 11);
            this.TxtPunkte.Name = "TxtPunkte";
            this.TxtPunkte.Size = new System.Drawing.Size(88, 24);
            this.TxtPunkte.TabIndex = 2;
            this.TxtPunkte.Text = "Punkte: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // HightBox
            // 
            this.HightBox.BackColor = System.Drawing.Color.Transparent;
            this.HightBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HightBox.BackgroundImage")));
            this.HightBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HightBox.Location = new System.Drawing.Point(135, 179);
            this.HightBox.Name = "HightBox";
            this.HightBox.Size = new System.Drawing.Size(615, 202);
            this.HightBox.TabIndex = 3;
            this.HightBox.TabStop = false;
            this.HightBox.Visible = false;
            // 
            // HightPunkte
            // 
            this.HightPunkte.AutoSize = true;
            this.HightPunkte.BackColor = System.Drawing.Color.Aqua;
            this.HightPunkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HightPunkte.ForeColor = System.Drawing.Color.OrangeRed;
            this.HightPunkte.Location = new System.Drawing.Point(350, 274);
            this.HightPunkte.Name = "HightPunkte";
            this.HightPunkte.Size = new System.Drawing.Size(182, 39);
            this.HightPunkte.TabIndex = 4;
            this.HightPunkte.Text = "Punkte: 80";
            this.HightPunkte.Visible = false;
            // 
            // TxtGewonnen
            // 
            this.TxtGewonnen.AutoSize = true;
            this.TxtGewonnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGewonnen.ForeColor = System.Drawing.Color.Snow;
            this.TxtGewonnen.Location = new System.Drawing.Point(368, 393);
            this.TxtGewonnen.Name = "TxtGewonnen";
            this.TxtGewonnen.Size = new System.Drawing.Size(153, 31);
            this.TxtGewonnen.TabIndex = 5;
            this.TxtGewonnen.Text = "Gewonnen";
            this.TxtGewonnen.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.TxtGewonnen);
            this.Controls.Add(this.HightPunkte);
            this.Controls.Add(this.HightBox);
            this.Controls.Add(this.TxtPunkte);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.Text = "Arkanoid";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IsKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HightBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Label TxtPunkte;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox HightBox;
        private System.Windows.Forms.Label HightPunkte;
        private System.Windows.Forms.Label TxtGewonnen;
    }
}

