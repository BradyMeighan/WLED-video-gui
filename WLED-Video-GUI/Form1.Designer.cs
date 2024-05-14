namespace WLED_Video_GUI
{
    partial class Form1
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
            this.livePreviewToggle = new MetroFramework.Controls.MetroToggle();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.youtubeRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.localFileRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.videoTxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.webcamRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.advancedSettingsCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.videoView1 = new LibVLCSharp.WinForms.VideoView();
            this.desktopRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.cropTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gammaTextBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.portTextBox1 = new System.Windows.Forms.TextBox();
            this.baudrateTextBox = new System.Windows.Forms.TextBox();
            this.serialComboBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // livePreviewToggle
            // 
            this.livePreviewToggle.AutoSize = true;
            this.livePreviewToggle.Location = new System.Drawing.Point(115, 352);
            this.livePreviewToggle.Name = "livePreviewToggle";
            this.livePreviewToggle.Size = new System.Drawing.Size(80, 17);
            this.livePreviewToggle.TabIndex = 0;
            this.livePreviewToggle.Text = "Off";
            this.livePreviewToggle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Live Preview:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(248, 133);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 30);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save Configuration";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // youtubeRadioButton
            // 
            this.youtubeRadioButton.AutoSize = true;
            this.youtubeRadioButton.Location = new System.Drawing.Point(26, 283);
            this.youtubeRadioButton.Name = "youtubeRadioButton";
            this.youtubeRadioButton.Size = new System.Drawing.Size(67, 15);
            this.youtubeRadioButton.TabIndex = 4;
            this.youtubeRadioButton.TabStop = true;
            this.youtubeRadioButton.Text = "Youtube";
            this.youtubeRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.youtubeRadioButton.UseVisualStyleBackColor = true;
            this.youtubeRadioButton.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // localFileRadioButton2
            // 
            this.localFileRadioButton2.AutoSize = true;
            this.localFileRadioButton2.Location = new System.Drawing.Point(112, 283);
            this.localFileRadioButton2.Name = "localFileRadioButton2";
            this.localFileRadioButton2.Size = new System.Drawing.Size(72, 15);
            this.localFileRadioButton2.TabIndex = 5;
            this.localFileRadioButton2.TabStop = true;
            this.localFileRadioButton2.Text = "Local File";
            this.localFileRadioButton2.UseVisualStyleBackColor = true;
            this.localFileRadioButton2.CheckedChanged += new System.EventHandler(this.localFileRadioButton2_CheckedChanged);
            // 
            // videoTxt
            // 
            this.videoTxt.Enabled = false;
            this.videoTxt.Location = new System.Drawing.Point(26, 316);
            this.videoTxt.Name = "videoTxt";
            this.videoTxt.Size = new System.Drawing.Size(260, 20);
            this.videoTxt.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(301, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Host";
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(92, 80);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(139, 20);
            this.hostTextBox.TabIndex = 12;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(92, 120);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(139, 20);
            this.heightTextBox.TabIndex = 13;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(92, 158);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(139, 20);
            this.widthTextBox.TabIndex = 14;
            // 
            // webcamRadioButton3
            // 
            this.webcamRadioButton3.AutoSize = true;
            this.webcamRadioButton3.Location = new System.Drawing.Point(202, 283);
            this.webcamRadioButton3.Name = "webcamRadioButton3";
            this.webcamRadioButton3.Size = new System.Drawing.Size(70, 15);
            this.webcamRadioButton3.TabIndex = 15;
            this.webcamRadioButton3.TabStop = true;
            this.webcamRadioButton3.Text = "Webcam";
            this.webcamRadioButton3.UseVisualStyleBackColor = true;
            this.webcamRadioButton3.CheckedChanged += new System.EventHandler(this.webcamRadioButton3_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(368, 29);
            this.button3.TabIndex = 16;
            this.button3.Text = "Send to WLED";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // advancedSettingsCheckBox1
            // 
            this.advancedSettingsCheckBox1.AutoSize = true;
            this.advancedSettingsCheckBox1.Location = new System.Drawing.Point(14, 169);
            this.advancedSettingsCheckBox1.Name = "advancedSettingsCheckBox1";
            this.advancedSettingsCheckBox1.Size = new System.Drawing.Size(121, 15);
            this.advancedSettingsCheckBox1.TabIndex = 17;
            this.advancedSettingsCheckBox1.Text = "Advanced Settings";
            this.advancedSettingsCheckBox1.UseVisualStyleBackColor = true;
            this.advancedSettingsCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Location = new System.Drawing.Point(502, 77);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(275, 151);
            this.videoView1.TabIndex = 18;
            this.videoView1.Text = "videoView1";
            // 
            // desktopRadioButton1
            // 
            this.desktopRadioButton1.AutoSize = true;
            this.desktopRadioButton1.Location = new System.Drawing.Point(287, 283);
            this.desktopRadioButton1.Name = "desktopRadioButton1";
            this.desktopRadioButton1.Size = new System.Drawing.Size(66, 15);
            this.desktopRadioButton1.TabIndex = 19;
            this.desktopRadioButton1.TabStop = true;
            this.desktopRadioButton1.Text = "Desktop";
            this.desktopRadioButton1.UseVisualStyleBackColor = true;
            this.desktopRadioButton1.CheckedChanged += new System.EventHandler(this.desktopRadioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serialComboBox);
            this.groupBox1.Controls.Add(this.baudrateTextBox);
            this.groupBox1.Controls.Add(this.portTextBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(502, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 138);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advanced Settings";
            this.groupBox1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Baudrate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Serial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Scale";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Interpolation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Crop";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "stretch",
            "fill",
            "fit",
            "crop"});
            this.metroComboBox1.Location = new System.Drawing.Point(328, 77);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(135, 29);
            this.metroComboBox1.TabIndex = 24;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "hard",
            "smooth"});
            this.metroComboBox2.Location = new System.Drawing.Point(328, 112);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(135, 29);
            this.metroComboBox2.TabIndex = 25;
            // 
            // cropTextBox1
            // 
            this.cropTextBox1.Location = new System.Drawing.Point(92, 197);
            this.cropTextBox1.Name = "cropTextBox1";
            this.cropTextBox1.Size = new System.Drawing.Size(139, 20);
            this.cropTextBox1.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gammaTextBox2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.advancedSettingsCheckBox1);
            this.groupBox2.Location = new System.Drawing.Point(15, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 196);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // gammaTextBox2
            // 
            this.gammaTextBox2.Location = new System.Drawing.Point(313, 97);
            this.gammaTextBox2.Name = "gammaTextBox2";
            this.gammaTextBox2.Size = new System.Drawing.Size(135, 20);
            this.gammaTextBox2.TabIndex = 29;
            this.gammaTextBox2.Text = "0.5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Gamma";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroCheckBox2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(15, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 138);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Video Input";
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(379, 58);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(50, 15);
            this.metroCheckBox2.TabIndex = 3;
            this.metroCheckBox2.Text = "Loop";
            this.metroCheckBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 29);
            this.button1.TabIndex = 29;
            this.button1.Text = "Terminate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // portTextBox1
            // 
            this.portTextBox1.Location = new System.Drawing.Point(121, 18);
            this.portTextBox1.Name = "portTextBox1";
            this.portTextBox1.Size = new System.Drawing.Size(139, 20);
            this.portTextBox1.TabIndex = 30;
            // 
            // baudrateTextBox
            // 
            this.baudrateTextBox.Location = new System.Drawing.Point(121, 89);
            this.baudrateTextBox.Name = "baudrateTextBox";
            this.baudrateTextBox.Size = new System.Drawing.Size(139, 20);
            this.baudrateTextBox.TabIndex = 32;
            // 
            // serialComboBox
            // 
            this.serialComboBox.FormattingEnabled = true;
            this.serialComboBox.ItemHeight = 23;
            this.serialComboBox.Location = new System.Drawing.Point(121, 48);
            this.serialComboBox.Name = "serialComboBox";
            this.serialComboBox.Size = new System.Drawing.Size(139, 29);
            this.serialComboBox.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cropTextBox1);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.desktopRadioButton1);
            this.Controls.Add(this.videoView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.webcamRadioButton3);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.hostTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.videoTxt);
            this.Controls.Add(this.localFileRadioButton2);
            this.Controls.Add(this.youtubeRadioButton);
            this.Controls.Add(this.livePreviewToggle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "WLED Video";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroToggle livePreviewToggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private MetroFramework.Controls.MetroRadioButton youtubeRadioButton;
        private MetroFramework.Controls.MetroRadioButton localFileRadioButton2;
        private System.Windows.Forms.TextBox videoTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private MetroFramework.Controls.MetroRadioButton webcamRadioButton3;
        private System.Windows.Forms.Button button3;
        private MetroFramework.Controls.MetroCheckBox advancedSettingsCheckBox1;
        private LibVLCSharp.WinForms.VideoView videoView1;
        private MetroFramework.Controls.MetroRadioButton desktopRadioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.TextBox cropTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private System.Windows.Forms.TextBox gammaTextBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox baudrateTextBox;
        private System.Windows.Forms.TextBox portTextBox1;
        private MetroFramework.Controls.MetroComboBox serialComboBox;
    }
}

