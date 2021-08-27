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
            this.Hide();
            MusicPlayerApp mp = new MusicPlayerApp();
            mp.Show();
        }

        private void drawingAppButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DrawingApp mp = new DrawingApp();
            mp.Show();
        }

        private void carRacingGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarRacingGame mp = new CarRacingGame();
            mp.Show();
        }

        private void digitalClockButton_Click(object sender, EventArgs e)
        {

        }
    }
}
