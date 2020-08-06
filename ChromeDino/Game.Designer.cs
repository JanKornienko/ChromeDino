namespace ChromeDino
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.ground = new System.Windows.Forms.PictureBox();
            this.gameOverText = new System.Windows.Forms.PictureBox();
            this.restartBtn = new System.Windows.Forms.PictureBox();
            this.hiText = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.moveT = new System.Windows.Forms.Timer(this.components);
            this.dino = new System.Windows.Forms.PictureBox();
            this.fastLevelT = new System.Windows.Forms.Timer(this.components);
            this.JumpT = new System.Windows.Forms.Timer(this.components);
            this.cactus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-9, 275);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(2402, 26);
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // gameOverText
            // 
            this.gameOverText.BackColor = System.Drawing.Color.Transparent;
            this.gameOverText.Image = ((System.Drawing.Image)(resources.GetObject("gameOverText.Image")));
            this.gameOverText.Location = new System.Drawing.Point(254, 12);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(387, 25);
            this.gameOverText.TabIndex = 2;
            this.gameOverText.TabStop = false;
            this.gameOverText.Visible = false;
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.Transparent;
            this.restartBtn.Image = ((System.Drawing.Image)(resources.GetObject("restartBtn.Image")));
            this.restartBtn.Location = new System.Drawing.Point(408, 60);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(73, 65);
            this.restartBtn.TabIndex = 3;
            this.restartBtn.TabStop = false;
            this.restartBtn.Click += new System.EventHandler(this.restart_Click);
            // 
            // hiText
            // 
            this.hiText.BackColor = System.Drawing.Color.Transparent;
            this.hiText.Image = ((System.Drawing.Image)(resources.GetObject("hiText.Image")));
            this.hiText.Location = new System.Drawing.Point(749, 11);
            this.hiText.Name = "hiText";
            this.hiText.Size = new System.Drawing.Size(43, 26);
            this.hiText.TabIndex = 4;
            this.hiText.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.DimGray;
            this.scoreText.Location = new System.Drawing.Point(791, 3);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(33, 37);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "0";
            // 
            // moveT
            // 
            this.moveT.Interval = 1;
            this.moveT.Tick += new System.EventHandler(this.moveT_Tick);
            // 
            // dino
            // 
            this.dino.BackColor = System.Drawing.Color.Transparent;
            this.dino.Image = ((System.Drawing.Image)(resources.GetObject("dino.Image")));
            this.dino.Location = new System.Drawing.Point(75, 190);
            this.dino.Name = "dino";
            this.dino.Size = new System.Drawing.Size(89, 92);
            this.dino.TabIndex = 6;
            this.dino.TabStop = false;
            // 
            // fastLevelT
            // 
            this.fastLevelT.Interval = 5000;
            this.fastLevelT.Tick += new System.EventHandler(this.fastLevel_Tick);
            // 
            // JumpT
            // 
            this.JumpT.Interval = 1;
            this.JumpT.Tick += new System.EventHandler(this.JumpT_Tick);
            // 
            // cactus
            // 
            this.cactus.BackColor = System.Drawing.Color.Transparent;
            this.cactus.Image = ((System.Drawing.Image)(resources.GetObject("cactus.Image")));
            this.cactus.Location = new System.Drawing.Point(889, 184);
            this.cactus.Name = "cactus";
            this.cactus.Size = new System.Drawing.Size(59, 98);
            this.cactus.TabIndex = 7;
            this.cactus.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 299);
            this.Controls.Add(this.cactus);
            this.Controls.Add(this.dino);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.hiText);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.ground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(903, 338);
            this.MinimumSize = new System.Drawing.Size(903, 338);
            this.Name = "Game";
            this.Text = "T-Rex";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox gameOverText;
        private System.Windows.Forms.PictureBox restartBtn;
        private System.Windows.Forms.PictureBox hiText;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer moveT;
        private System.Windows.Forms.PictureBox dino;
        private System.Windows.Forms.Timer fastLevelT;
        private System.Windows.Forms.Timer JumpT;
        private System.Windows.Forms.PictureBox cactus;
    }
}

