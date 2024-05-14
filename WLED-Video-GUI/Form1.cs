using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;
using System.IO.Ports;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using YoutubeDLSharp;
using System.Threading.Tasks;




namespace WLED_Video_GUI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        public Form1()
        {
            InitializeComponent();
            PopulateSerialPorts();

            // Initialize LibVLC
            Core.Initialize();
            _libVLC = new LibVLC();

            // Create and set up the media player
            _mediaPlayer = new MediaPlayer(_libVLC);

            // Set the VideoView's MediaPlayer
            videoView1.MediaPlayer = _mediaPlayer;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string configPath = Path.Combine(Application.StartupPath, "config.json");
            if (File.Exists(configPath))
            {
                string jsonText = File.ReadAllText(configPath);
                dynamic config = JsonConvert.DeserializeObject(jsonText);

                hostTextBox.Text = config.host;
                heightTextBox.Text = config.height;
                widthTextBox.Text = config.width;
                cropTextBox1.Text = config.crop;
                metroComboBox1.SelectedItem = ((string)config.scale).Trim();
                metroComboBox2.SelectedItem = ((string)config.interpolation).Trim();
                gammaTextBox2.Text = config.gamma;
            }
            else
            {
                MessageBox.Show("Config file not found.");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // Code
            foreach (Process process in Process.GetProcesses().Where(p =>
                                            p.ProcessName == "python"))
            {
                process.Kill();
            }
            // Dispose of the media player and libVLC
            _mediaPlayer.Dispose();
            _libVLC.Dispose();
        }

        private void PopulateSerialPorts()
        {
            // Get an array of available serial port names
            string[] ports = SerialPort.GetPortNames();

            // Clear existing items
            serialComboBox.Items.Clear();

            // Add ports to the ComboBox
            foreach (string port in ports)
            {
                serialComboBox.Items.Add(port);
            }

            // Optionally, select the first item
            if (serialComboBox.Items.Count > 0)
            {
                serialComboBox.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var config = new
            {
                host = hostTextBox.Text,
                height = heightTextBox.Text,
                width = widthTextBox.Text
            };

            string jsonText = JsonConvert.SerializeObject(config, Formatting.Indented);

            string configPath = Path.Combine(Application.StartupPath, "config.json");
            File.WriteAllText(configPath, jsonText);

            MessageBox.Show("Configuration saved successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Dispose();

            foreach (Process process in Process.GetProcesses().Where(p =>
                                                        p.ProcessName == "python"))
            {
                process.Kill();
            }
            string host = hostTextBox.Text;
            string width = widthTextBox.Text;
            string height = heightTextBox.Text;
            string crop = cropTextBox1.Text;
            string scale = metroComboBox1.Text;
            string interpolation = metroComboBox2.Text;
            string gamma = gammaTextBox2.Text;
            string video = videoTxt.Text;
            string port = portTextBox1.Text;
            string serial = serialComboBox.Text;
            string baud = baudrateTextBox.Text;

            Console.WriteLine("Sending to WLED");
            // Construct the command
            string command = $"python wledvideo.py";

            if (!string.IsNullOrEmpty(host))
            {
                command += $" --host {host}";
            }
            if (!string.IsNullOrEmpty(width))
            {
                command += $" --width {width}";
            }
            if (!string.IsNullOrEmpty(height))
            {
                command += $" --height {height}";
            }
            if (!string.IsNullOrEmpty(crop))
            {
                command += $" --crop {crop}";
            }
            if (!string.IsNullOrEmpty(scale))
            {
                command += $" --scale {scale}";
            }
            if (!string.IsNullOrEmpty(interpolation))
            {
                command += $" --interpolation {interpolation}";
            }
            if (!string.IsNullOrEmpty(gamma))
            {
                command += $" --gamma {gamma}";
            }
            if (advancedSettingsCheckBox1.Checked)
            {
                if (!string.IsNullOrEmpty(port))
                {
                    command += $" --port {port}";
                }
                if (!string.IsNullOrEmpty(serial))
                {
                    command += $" --serial {serial}";
                }
                if (!string.IsNullOrEmpty(baud))
                {
                    command += $" --baudrate {baud}";
                }
            }
            if (metroCheckBox2.Checked)
            {
                command += " --loop";
            }
            if (youtubeRadioButton.Checked || localFileRadioButton2.Checked)
            {
                command += " " + videoTxt.Text;
            }
            else if (webcamRadioButton3.Checked)
            {
                command += " --camera";
            }
            else if (desktopRadioButton1.Checked)
            {
                command += " --display";
            }

            Console.WriteLine(command);
            // Execute the command
            ExecuteCommand(command);
            if (livePreviewToggle.Checked)
            {
                if (localFileRadioButton2.Checked)
                {
                    string filePath = videoTxt.Text;
                    LoadVideo(filePath);
                }
            }
        }



        public void LoadVideo(string mediaPath)
        {
            if (!string.IsNullOrEmpty(mediaPath))
            {
                var media = new Media(_libVLC, mediaPath, FromType.FromPath);
                _mediaPlayer.Play(media);
            }
        }
        private string ConvertYouTubeUrlToEmbed(string url)
        {
            // Basic conversion, this might need to be more robust depending on input format
            if (!url.Contains("embed"))
            {
                var videoId = url.Split(new string[] { "watch?v=" }, StringSplitOptions.None)[1];
                return $"https://www.youtube.com/embed/{videoId}?autoplay=1";
            }
            return url;
        }
        private async void ExecuteCommand(string command)
        {
            try
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string subFolderPath = Path.Combine(baseDirectory, "wled-video");

                ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WorkingDirectory = subFolderPath
                };

                using (Process process = new Process { StartInfo = processStartInfo })
                {
                    process.Start();

                    // Asynchronously read the standard output and standard error
                    string output = await process.StandardOutput.ReadToEndAsync();
                    string error = await process.StandardError.ReadToEndAsync();
                    process.WaitForExit();

                    // Optionally, handle the output and error
                    if (!string.IsNullOrEmpty(output))
                    {
                        MessageBox.Show("Output: " + output);
                    }
                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show("Error: " + error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to execute command: " + ex.Message);
            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            videoTxt.Enabled = youtubeRadioButton.Checked;
            livePreviewToggle.Enabled = false;
            livePreviewToggle.Checked = false;
        }

        private void localFileRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            videoTxt.Enabled = localFileRadioButton2.Checked;
            button2.Enabled = localFileRadioButton2.Checked;
            livePreviewToggle.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Optional: Filter files by extension
            openFileDialog.Filter = "Video Files (*.mp4)|*.mp4|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            // Show the dialog and get the result.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path.
                string filePath = openFileDialog.FileName;

                // Set the text of the textbox to the file path.
                videoTxt.Text = filePath;
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = advancedSettingsCheckBox1.Checked;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Process process in Process.GetProcesses().Where(p =>
                                            p.ProcessName == "python"))
            {
                process.Kill();
            }
            if (livePreviewToggle.Checked)
            {
                _mediaPlayer.Stop();
            }

        }

        private void desktopRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            livePreviewToggle.Checked = false;
            livePreviewToggle.Enabled = false;
        }

        private void webcamRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            livePreviewToggle.Checked = false;
            livePreviewToggle.Enabled = false;
        }
    }
}
