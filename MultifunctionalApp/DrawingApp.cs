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
    public partial class DrawingApp : Form
    {
        Graphics g;
        Pen pen;

        int x = -1;
        int y = -1;
        bool moving = false;
        Color color = Color.Black;

        public DrawingApp()
        {
            InitializeComponent();
            g = drawingPanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(color, 5);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drawingPanel.Cursor = Cursors.Cross;
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drawingPanel.Cursor = Cursors.Default;
            moving = false;
            x = -1;
            y = -1;
        }

        private void pickColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                pen.Color = color;
            }
        }
    }
}
