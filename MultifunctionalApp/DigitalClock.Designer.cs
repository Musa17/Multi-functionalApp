namespace MultifunctionalApp
{
    partial class DigitalClock
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timeLabel.Location = new System.Drawing.Point(226, 45);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(286, 110);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "22:22";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.secondsLabel.Location = new System.Drawing.Point(515, 98);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(62, 44);
            this.secondsLabel.TabIndex = 2;
            this.secondsLabel.Text = "22";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateLabel.Location = new System.Drawing.Point(64, 203);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(364, 57);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "August 27 2021";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dayLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dayLabel.Location = new System.Drawing.Point(517, 203);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(159, 57);
            this.dayLabel.TabIndex = 4;
            this.dayLabel.Text = "Friday";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.timeLabel);
            this.MaximizeBox = false;
            this.Name = "DigitalClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigitalClock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Timer timer;
    }
}