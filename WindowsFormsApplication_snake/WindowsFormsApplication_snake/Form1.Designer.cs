namespace WindowsFormsApplication4
{
    partial class SnakeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.TrackLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreSaver = new System.Windows.Forms.Button();
            this.GameOver = new System.Windows.Forms.Label();
            this.GameOverLab = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 502);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreLabel.Location = new System.Drawing.Point(583, 30);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(109, 37);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Score:";
            this.ScoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TrackLabel
            // 
            this.TrackLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackLabel.AutoSize = true;
            this.TrackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TrackLabel.Location = new System.Drawing.Point(698, 30);
            this.TrackLabel.Name = "TrackLabel";
            this.TrackLabel.Size = new System.Drawing.Size(0, 37);
            this.TrackLabel.TabIndex = 2;
            // 
            // ScoreSaver
            // 
            this.ScoreSaver.Enabled = false;
            this.ScoreSaver.Location = new System.Drawing.Point(622, 142);
            this.ScoreSaver.Name = "ScoreSaver";
            this.ScoreSaver.Size = new System.Drawing.Size(75, 23);
            this.ScoreSaver.TabIndex = 3;
            this.ScoreSaver.Text = "SaveScore?";
            this.ScoreSaver.UseVisualStyleBackColor = true;
            this.ScoreSaver.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameOver
            // 
            this.GameOver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameOver.AutoSize = true;
            this.GameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameOver.Location = new System.Drawing.Point(148, 216);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(0, 55);
            this.GameOver.TabIndex = 4;
            this.GameOver.Visible = false;
            this.GameOver.Click += new System.EventHandler(this.GameOver_Click);
            // 
            // GameOverLab
            // 
            this.GameOverLab.AutoSize = true;
            this.GameOverLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameOverLab.Location = new System.Drawing.Point(214, 216);
            this.GameOverLab.Name = "GameOverLab";
            this.GameOverLab.Size = new System.Drawing.Size(0, 37);
            this.GameOverLab.TabIndex = 5;
            this.GameOverLab.Visible = false;
            this.GameOverLab.Click += new System.EventHandler(this.GameOverLab_Click);
            // 
            // restart
            // 
            this.restart.Enabled = false;
            this.restart.Location = new System.Drawing.Point(622, 202);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 6;
            this.restart.Text = "Restart?";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SnakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 526);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.GameOverLab);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.ScoreSaver);
            this.Controls.Add(this.TrackLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SnakeForm";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.SnakeForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SnakeForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label TrackLabel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button ScoreSaver;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.Label GameOverLab;
        private System.Windows.Forms.Button restart;

    }
}

