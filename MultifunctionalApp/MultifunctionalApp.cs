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
    public partial class MultifunctionalApp : Form
    {
        public MultifunctionalApp()
        {
            InitializeComponent();
        }

        private void musicPlayerButton_Click(object sender, EventArgs e)
        {
            MusicPlayerApp mp = new MusicPlayerApp();
            mp.Show();
            this.Hide();
        }

        private void drawingAppButton_Click(object sender, EventArgs e)
        {
            DrawingApp mp = new DrawingApp();
            mp.Show();
            this.Hide();
        }

        private void carRacingGameButton_Click(object sender, EventArgs e)
        {
            CarRacingGame mp = new CarRacingGame();
            mp.Show();
            this.Hide();
        }

        private void digitalClockButton_Click(object sender, EventArgs e)
        {
            DigitalClock mp = new DigitalClock();
            mp.Show();
            this.Hide();
        }
    }
}
