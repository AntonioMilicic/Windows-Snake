namespace WindowsFormsApplication4
{
    partial class SaveScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveScoreForm));
            this.NamePlayerLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.GoToHigh = new System.Windows.Forms.Button();
            this.GoToGame = new System.Windows.Forms.Button();
            this.NOT_IMPLEMENTED = new System.Windows.Forms.Label();
            this.Label_Joke = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // NamePlayerLabel
            // 
            this.NamePlayerLabel.AutoSize = true;
            this.NamePlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NamePlayerLabel.Location = new System.Drawing.Point(69, 81);
            this.NamePlayerLabel.Name = "NamePlayerLabel";
            this.NamePlayerLabel.Size = new System.Drawing.Size(112, 37);
            this.NamePlayerLabel.TabIndex = 0;
            this.NamePlayerLabel.Text = "Name:";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameBox.Location = new System.Drawing.Point(220, 78);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(119, 44);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // GoToHigh
            // 
            this.GoToHigh.Location = new System.Drawing.Point(88, 163);
            this.GoToHigh.Name = "GoToHigh";
            this.GoToHigh.Size = new System.Drawing.Size(93, 23);
            this.GoToHigh.TabIndex = 2;
            this.GoToHigh.Text = "HighScore?";
            this.GoToHigh.UseVisualStyleBackColor = true;
            this.GoToHigh.Click += new System.EventHandler(this.GoToHigh_Click);
            // 
            // GoToGame
            // 
            this.GoToGame.Location = new System.Drawing.Point(220, 163);
            this.GoToGame.Name = "GoToGame";
            this.GoToGame.Size = new System.Drawing.Size(94, 23);
            this.GoToGame.TabIndex = 3;
            this.GoToGame.Text = "BackToGame?";
            this.GoToGame.UseVisualStyleBackColor = true;
            this.GoToGame.Click += new System.EventHandler(this.GoToGame_Click);
            // 
            // NOT_IMPLEMENTED
            // 
            this.NOT_IMPLEMENTED.AutoSize = true;
            this.NOT_IMPLEMENTED.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NOT_IMPLEMENTED.Location = new System.Drawing.Point(12, 18);
            this.NOT_IMPLEMENTED.Name = "NOT_IMPLEMENTED";
            this.NOT_IMPLEMENTED.Size = new System.Drawing.Size(314, 38);
            this.NOT_IMPLEMENTED.TabIndex = 4;
            this.NOT_IMPLEMENTED.Text = "This part is still not implemented, coming soon\r\n(Nisam napravio bazu koja bi pov" +
    "ezivala sve to)";
            // 
            // Label_Joke
            // 
            this.Label_Joke.AutoSize = true;
            this.Label_Joke.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_Joke.Location = new System.Drawing.Point(323, 18);
            this.Label_Joke.Name = "Label_Joke";
            this.Label_Joke.Size = new System.Drawing.Size(81, 19);
            this.Label_Joke.TabIndex = 5;
            this.Label_Joke.TabStop = true;
            this.Label_Joke.Text = "BlizzardTM";
            this.Label_Joke.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Label_Joke_LinkClicked);
            // 
            // SaveScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 231);
            this.Controls.Add(this.Label_Joke);
            this.Controls.Add(this.NOT_IMPLEMENTED);
            this.Controls.Add(this.GoToGame);
            this.Controls.Add(this.GoToHigh);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NamePlayerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveScoreForm";
            this.Text = "SaveScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NamePlayerLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button GoToHigh;
        private System.Windows.Forms.Button GoToGame;
        private System.Windows.Forms.Label NOT_IMPLEMENTED;
        private System.Windows.Forms.LinkLabel Label_Joke;
    }
}