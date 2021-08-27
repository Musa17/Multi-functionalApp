namespace MultifunctionalApp
{
    partial class MultifunctionalApp
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
            this.musicPlayerButton = new System.Windows.Forms.Button();
            this.drawingAppButton = new System.Windows.Forms.Button();
            this.carRacingGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // musicPlayerButton
            // 
            this.musicPlayerButton.BackColor = System.Drawing.Color.Firebrick;
            this.musicPlayerButton.FlatAppearance.BorderSize = 0;
            this.musicPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.musicPlayerButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.musicPlayerButton.Location = new System.Drawing.Point(12, 12);
            this.musicPlayerButton.Name = "musicPlayerButton";
            this.musicPlayerButton.Size = new System.Drawing.Size(150, 150);
            this.musicPlayerButton.TabIndex = 0;
            this.musicPlayerButton.Text = "Music Player";
            this.musicPlayerButton.UseVisualStyleBackColor = false;
            this.musicPlayerButton.Click += new System.EventHandler(this.musicPlayerButton_Click);
            // 
            // drawingAppButton
            // 
            this.drawingAppButton.BackColor = System.Drawing.Color.Orange;
            this.drawingAppButton.FlatAppearance.BorderSize = 0;
            this.drawingAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawingAppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.drawingAppButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawingAppButton.Location = new System.Drawing.Point(177, 12);
            this.drawingAppButton.Name = "drawingAppButton";
            this.drawingAppButton.Size = new System.Drawing.Size(259, 150);
            this.drawingAppButton.TabIndex = 1;
            this.drawingAppButton.Text = "Drawing App";
            this.drawingAppButton.UseVisualStyleBackColor = false;
            this.drawingAppButton.Click += new System.EventHandler(this.drawingAppButton_Click);
            // 
            // carRacingGameButton
            // 
            this.carRacingGameButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.carRacingGameButton.FlatAppearance.BorderSize = 0;
            this.carRacingGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carRacingGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carRacingGameButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.carRacingGameButton.Location = new System.Drawing.Point(12, 173);
            this.carRacingGameButton.Name = "carRacingGameButton";
            this.carRacingGameButton.Size = new System.Drawing.Size(259, 150);
            this.carRacingGameButton.TabIndex = 2;
            this.carRacingGameButton.Text = "Racing Game";
            this.carRacingGameButton.UseVisualStyleBackColor = false;
            this.carRacingGameButton.Click += new System.EventHandler(this.carRacingGameButton_Click);
            // 
            // MultifunctionalApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 332);
            this.Controls.Add(this.carRacingGameButton);
            this.Controls.Add(this.drawingAppButton);
            this.Controls.Add(this.musicPlayerButton);
            this.MaximizeBox = false;
            this.Name = "MultifunctionalApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi-functional App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button musicPlayerButton;
        private System.Windows.Forms.Button drawingAppButton;
        private System.Windows.Forms.Button carRacingGameButton;
    }
}

