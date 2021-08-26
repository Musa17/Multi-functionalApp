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
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        String[] paths, files;

        private void selectSongsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = true;
            ofd.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    songsListBox.Items.Add(files[i]);
                }
            }
        }

        private void songsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = paths[songsListBox.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
