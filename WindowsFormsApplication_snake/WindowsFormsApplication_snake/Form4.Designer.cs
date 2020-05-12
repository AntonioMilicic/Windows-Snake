namespace WindowsFormsApplication4
{
    partial class Starting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Starting));
            this.StartingGame = new System.Windows.Forms.Button();
            this.Label_Instructions = new System.Windows.Forms.Label();
            this.Label_Movement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartingGame
            // 
            this.StartingGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartingGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartingGame.Location = new System.Drawing.Point(88, 247);
            this.StartingGame.Name = "StartingGame";
            this.StartingGame.Size = new System.Drawing.Size(178, 57);
            this.StartingGame.TabIndex = 0;
            this.StartingGame.Text = "StartNew";
            this.StartingGame.UseVisualStyleBackColor = true;
            this.StartingGame.Click += new System.EventHandler(this.StartingGame_Click);
            // 
            // Label_Instructions
            // 
            this.Label_Instructions.AutoSize = true;
            this.Label_Instructions.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_Instructions.Location = new System.Drawing.Point(47, 9);
            this.Label_Instructions.Name = "Label_Instructions";
            this.Label_Instructions.Size = new System.Drawing.Size(119, 26);
            this.Label_Instructions.TabIndex = 1;
            this.Label_Instructions.Text = "Instructions:";
            this.Label_Instructions.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label_Movement
            // 
            this.Label_Movement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Movement.AutoSize = true;
            this.Label_Movement.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_Movement.Location = new System.Drawing.Point(48, 54);
            this.Label_Movement.Name = "Label_Movement";
            this.Label_Movement.Size = new System.Drawing.Size(262, 190);
            this.Label_Movement.TabIndex = 2;
            this.Label_Movement.Text = resources.GetString("Label_Movement.Text");
            // 
            // Starting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 316);
            this.Controls.Add(this.Label_Movement);
            this.Controls.Add(this.Label_Instructions);
            this.Controls.Add(this.StartingGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Starting";
            this.Text = "StartMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartingGame;
        private System.Windows.Forms.Label Label_Instructions;
        private System.Windows.Forms.Label Label_Movement;
    }
}