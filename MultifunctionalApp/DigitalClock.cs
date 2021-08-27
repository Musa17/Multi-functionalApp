using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultifunctionalApp
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm");
            secondsLabel.Text = DateTime.Now.ToString("ss");
            dateLabel.Text = DateTime.Now.ToString("dd. MMM yyyy.");
            dayLabel.Text = DateTime.Now.ToString("dddd");

            secondsLabel.Location = new Point(timeLabel.Location.X + timeLabel.Width - 7, secondsLabel.Location.Y);
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
