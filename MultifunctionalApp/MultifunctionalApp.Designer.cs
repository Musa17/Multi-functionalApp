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
            // MultifunctionalApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 332);
            this.Controls.Add(this.musicPlayerButton);
            this.MaximizeBox = false;
            this.Name = "MultifunctionalApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi-functional App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button musicPlayerButton;
    }
}

