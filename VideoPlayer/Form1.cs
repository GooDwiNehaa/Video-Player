using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;

namespace VideoPlayer
{
    public partial class Form1 : Form
    {
        private static Video video;
        private static List<string> playList = new List<string>();
        private static Size formSize;
        private static Size pnlSize;
        private static string namePlayingVideoFile;
        private static int indexClose = 0;
        private static DialogResult dialogResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = new Size(this.Width, this.Height);
            pnlSize = new Size(Screen.Width, Screen.Height);
        }

        private void добавитьВидеоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "WMV files|*.wmv|AVI files|*.avi";

            if (open.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < open.FileNames.LongLength; i++)
                {
                    if (PlayListBox.Items.Contains(open.SafeFileNames.GetValue(i)) == false)
                    {
                        PlayListBox.Items.Add(open.SafeFileNames.GetValue(i));
                        playList.Add(open.FileNames[i]);
                    }
                    else
                    {
                        MessageBox.Show("Выбранное вами видео уже добавлено в плейлист!");
                    }
                }
            }

            if (PlayListBox.SelectedIndex < 0 & PlayListBox.Items.Count > 0) { PlayListBox.SetSelected(0, true); }
        }

        private void удалитьВидеоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < playList.Count; i++)
            {
                if (PlayListBox.SelectedIndex != -1)
                {
                    if (namePlayingVideoFile == playList[PlayListBox.SelectedIndex])
                    {
                        video.Dispose();
                        VideoName.Text = "Название видео";
                        Time.Text = "00:00:00/00:00:00";
                        trackBar1.Enabled = false;
                        trackBar1.Value = 0;
                        Continue.Enabled = false;
                        Pause.Enabled = false;
                        timer1.Enabled = false;
                    }

                    if (i == PlayListBox.SelectedIndex)
                    {
                        playList.RemoveAt(i);
                        break;
                    }
                }
            }
            if (PlayListBox.SelectedIndex != -1)
            {
                PlayListBox.Items.RemoveAt(PlayListBox.SelectedIndex);
            }
        }

        private void PlayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlayListBox.SelectedIndex != -1)
            {
                Play.Enabled = true;
            }
            else
            {
                Play.Enabled = false;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (PlayListBox.Items.Count > 1 & PlayListBox.SelectedIndex != -1)
            {

                if (PlayListBox.SelectedIndex != PlayListBox.Items.Count - 1)
                {
                    PlayListBox.SetSelected(PlayListBox.SelectedIndex + 1, true);
                    Play_Click(sender, e);
                }
                else
                {
                    PlayListBox.SetSelected(PlayListBox.SelectedIndex - PlayListBox.Items.Count + 1, true);
                    Play_Click(sender, e);
                }
            }
        }

        private void Previo_Click(object sender, EventArgs e)
        {
            if (PlayListBox.Items.Count > 1 & PlayListBox.SelectedIndex != -1)
            {

                if (PlayListBox.SelectedIndex != 0)
                {
                    PlayListBox.SetSelected(PlayListBox.SelectedIndex - 1, true);
                    Play_Click(sender, e);
                }
                else
                {
                    PlayListBox.SetSelected(PlayListBox.SelectedIndex + PlayListBox.Items.Count - 1, true);
                    Play_Click(sender, e);
                }
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (playList.Count > 0 & PlayListBox.SelectedIndex != -1)
            {
                if (video == null)
                {
                    PlayVideo(PlayListBox, Screen, timer1, VideoName);

                }
                else
                {
                    video.Dispose();
                    PlayVideo(PlayListBox, Screen, timer1, VideoName);
                }

                Continue.Enabled = true;
                Pause.Enabled = true;
                trackBar1.Enabled = true;
            }
        }

        private static void PlayVideo(ListBox listBox, Panel panel, Timer timer, Label label)
        {
            listBox.SetSelected(listBox.SelectedIndex, true);
            video = new Video(playList[listBox.SelectedIndex]);
            namePlayingVideoFile = playList[listBox.SelectedIndex];

            video.Owner = panel;
            video.Play();
            panel.Size = pnlSize;
            timer.Enabled = true;
            label.Text = listBox.SelectedItem.ToString();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            video.Pause();
            timer1.Enabled = false;
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            video.Play();
            timer1.Enabled = true;

        }

        private void полныйЭкранToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (video != null)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                video.Owner = this;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape & video != null)
            {
                //exit full screen when escape is pressed
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                this.Size = formSize;
                video.Owner = Screen;
                Screen.Size = pnlSize;
            }
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                TrackBar.Maximum = Convert.ToInt32(video.Audio.Duration);
                video.Audio.Volume = TrackBar.Value;
            }
            catch
            {
                // Если ни одно видео не запущено, игнорируем нажатие кнопки
            }
        }

        private void громкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrackBar.Visible = !TrackBar.Visible;
            label1.Visible = !label1.Visible;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int currentTime = Convert.ToInt32(video.CurrentPosition);
            int maxTime = Convert.ToInt32(video.Duration);

            trackBar1.Maximum = maxTime;
            trackBar1.Value = currentTime;

            Time.Text = string.Format("{0:00}:{1:00}:{2:00}", currentTime / 3600, (currentTime / 60) % 60, currentTime % 60)
                                    + " / " +
                                    string.Format("{0:00}:{1:00}:{2:00}", maxTime / 3600, (maxTime / 60) % 60, maxTime % 60);
        }

        private void PlayListBox_DoubleClick(object sender, EventArgs e)
        {
            if (playList.Count > 0 & PlayListBox.SelectedIndex != -1)
            {
                Play_Click(sender, e);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            video.CurrentPosition = trackBar1.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (indexClose != 1)
            {
                dialogResult = MessageBox.Show("Вы уверены, что хотите выйти?", "VideoPlayer", MessageBoxButtons.YesNo);
            }
            if (dialogResult == DialogResult.Yes)
            {
                indexClose = 1;
                dialogResult = DialogResult.None;
                e.Cancel = false;
            }
            if (dialogResult == DialogResult.No)
            {
                indexClose = 0;
                dialogResult = DialogResult.None;
                e.Cancel = true;
            }
        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти?", "VideoPlayer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                indexClose = 1;
                dialogResult = DialogResult.None;
                this.Close();
            }
            if (dialogResult == DialogResult.No)
            {
                //do something else
                dialogResult = DialogResult.None;
                indexClose = 0;
            }
        }
    }
}
