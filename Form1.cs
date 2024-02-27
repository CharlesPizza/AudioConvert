using System;
using NAudio.Wave;

namespace AudioConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void ConvertWavToMp3(string inpath, string outpath)
        {
            using (var reader = new WaveFileReader(inpath))
            {
                MediaFoundationEncoder.EncodeToMp3(reader, outpath);
            }
        }
        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an audio file...";
            ofd.Filter = "Audio files (*.mp3; *.wav; *.AAC; *.WMA; *.MIDI)|*.mp3; *.wav; *.AAC; *.WMA; *.MIDI|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
                filePath.Text = filename;

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(filePath.Text != null & nameBox.Text != null)
            {
                try
                {
                    string savePath = Path.GetDirectoryName(filePath.Text) + "\\" + nameBox.Text + ".mp3";
                    ConvertWavToMp3(filePath.Text, savePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Error, please confirm file loaded and name are ready...");
            }
        }
    }
}
