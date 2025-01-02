namespace WY_Tools
{
    partial class WordCloud
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
            this.wordCludSettingTab = new System.Windows.Forms.TabControl();
            this.normalSetting = new System.Windows.Forms.TabPage();
            this.textColor = new System.Windows.Forms.TextBox();
            this.wordRepeat = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.genPicture = new System.Windows.Forms.PictureBox();
            this.genWordCloud = new System.Windows.Forms.Button();
            this.wordFileName = new System.Windows.Forms.Label();
            this.openWordPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.maskCombox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroudColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.ttfPath = new System.Windows.Forms.ComboBox();
            this.l1 = new System.Windows.Forms.Label();
            this.seniorSetting = new System.Windows.Forms.TabPage();
            this.maskImage = new System.Windows.Forms.Label();
            this.wordMaxSize = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.wordMinSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.photoColorMode = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.photoHeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.photoWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oepnWordFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.picturePath = new System.Windows.Forms.Label();
            this.wordCludSettingTab.SuspendLayout();
            this.normalSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genPicture)).BeginInit();
            this.seniorSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordCludSettingTab
            // 
            this.wordCludSettingTab.Controls.Add(this.normalSetting);
            this.wordCludSettingTab.Controls.Add(this.seniorSetting);
            this.wordCludSettingTab.Location = new System.Drawing.Point(12, 1);
            this.wordCludSettingTab.Name = "wordCludSettingTab";
            this.wordCludSettingTab.SelectedIndex = 0;
            this.wordCludSettingTab.Size = new System.Drawing.Size(776, 437);
            this.wordCludSettingTab.TabIndex = 0;
            // 
            // normalSetting
            // 
            this.normalSetting.Controls.Add(this.picturePath);
            this.normalSetting.Controls.Add(this.textColor);
            this.normalSetting.Controls.Add(this.wordRepeat);
            this.normalSetting.Controls.Add(this.label6);
            this.normalSetting.Controls.Add(this.label5);
            this.normalSetting.Controls.Add(this.genPicture);
            this.normalSetting.Controls.Add(this.genWordCloud);
            this.normalSetting.Controls.Add(this.wordFileName);
            this.normalSetting.Controls.Add(this.openWordPath);
            this.normalSetting.Controls.Add(this.label4);
            this.normalSetting.Controls.Add(this.maskCombox);
            this.normalSetting.Controls.Add(this.label3);
            this.normalSetting.Controls.Add(this.backgroudColor);
            this.normalSetting.Controls.Add(this.label1);
            this.normalSetting.Controls.Add(this.l2);
            this.normalSetting.Controls.Add(this.ttfPath);
            this.normalSetting.Controls.Add(this.l1);
            this.normalSetting.Location = new System.Drawing.Point(4, 25);
            this.normalSetting.Name = "normalSetting";
            this.normalSetting.Padding = new System.Windows.Forms.Padding(3);
            this.normalSetting.Size = new System.Drawing.Size(768, 408);
            this.normalSetting.TabIndex = 0;
            this.normalSetting.Text = "普通设置";
            this.normalSetting.UseVisualStyleBackColor = true;
            // 
            // textColor
            // 
            this.textColor.Location = new System.Drawing.Point(325, 19);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(100, 25);
            this.textColor.TabIndex = 16;
            this.textColor.Text = "#FFFFFF";
            this.textColor.TextChanged += new System.EventHandler(this.textColor_TextChanged);
            // 
            // wordRepeat
            // 
            this.wordRepeat.AutoSize = true;
            this.wordRepeat.Location = new System.Drawing.Point(255, 75);
            this.wordRepeat.Name = "wordRepeat";
            this.wordRepeat.Size = new System.Drawing.Size(119, 19);
            this.wordRepeat.TabIndex = 15;
            this.wordRepeat.Text = "允许词汇重复";
            this.wordRepeat.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "图片预览";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // genPicture
            // 
            this.genPicture.Location = new System.Drawing.Point(6, 170);
            this.genPicture.Name = "genPicture";
            this.genPicture.Size = new System.Drawing.Size(756, 232);
            this.genPicture.TabIndex = 12;
            this.genPicture.TabStop = false;
            this.genPicture.Click += new System.EventHandler(this.genPicture_Click);
            // 
            // genWordCloud
            // 
            this.genWordCloud.Location = new System.Drawing.Point(510, 116);
            this.genWordCloud.Name = "genWordCloud";
            this.genWordCloud.Size = new System.Drawing.Size(252, 43);
            this.genWordCloud.TabIndex = 11;
            this.genWordCloud.Text = "生成词云";
            this.genWordCloud.UseVisualStyleBackColor = true;
            this.genWordCloud.Click += new System.EventHandler(this.genWordCloud_Click);
            // 
            // wordFileName
            // 
            this.wordFileName.AutoSize = true;
            this.wordFileName.Location = new System.Drawing.Point(200, 116);
            this.wordFileName.Name = "wordFileName";
            this.wordFileName.Size = new System.Drawing.Size(52, 15);
            this.wordFileName.TabIndex = 10;
            this.wordFileName.Text = "文件名";
            // 
            // openWordPath
            // 
            this.openWordPath.Location = new System.Drawing.Point(78, 109);
            this.openWordPath.Name = "openWordPath";
            this.openWordPath.Size = new System.Drawing.Size(116, 29);
            this.openWordPath.TabIndex = 9;
            this.openWordPath.Text = "打开词条文件";
            this.openWordPath.UseVisualStyleBackColor = true;
            this.openWordPath.Click += new System.EventHandler(this.openWordPath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "词条文件";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // maskCombox
            // 
            this.maskCombox.FormattingEnabled = true;
            this.maskCombox.Location = new System.Drawing.Point(79, 71);
            this.maskCombox.Name = "maskCombox";
            this.maskCombox.Size = new System.Drawing.Size(121, 23);
            this.maskCombox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "图案选择";
            // 
            // backgroudColor
            // 
            this.backgroudColor.Location = new System.Drawing.Point(662, 15);
            this.backgroudColor.Name = "backgroudColor";
            this.backgroudColor.Size = new System.Drawing.Size(100, 25);
            this.backgroudColor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "背景颜色";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(252, 25);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(67, 15);
            this.l2.TabIndex = 2;
            this.l2.Text = "字体颜色";
            // 
            // ttfPath
            // 
            this.ttfPath.FormattingEnabled = true;
            this.ttfPath.Location = new System.Drawing.Point(79, 19);
            this.ttfPath.Name = "ttfPath";
            this.ttfPath.Size = new System.Drawing.Size(155, 23);
            this.ttfPath.TabIndex = 1;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(6, 25);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(67, 15);
            this.l1.TabIndex = 0;
            this.l1.Text = "字体选择";
            this.l1.Click += new System.EventHandler(this.ttfPath_Click);
            // 
            // seniorSetting
            // 
            this.seniorSetting.Controls.Add(this.maskImage);
            this.seniorSetting.Controls.Add(this.wordMaxSize);
            this.seniorSetting.Controls.Add(this.label11);
            this.seniorSetting.Controls.Add(this.wordMinSize);
            this.seniorSetting.Controls.Add(this.label10);
            this.seniorSetting.Controls.Add(this.photoColorMode);
            this.seniorSetting.Controls.Add(this.label9);
            this.seniorSetting.Controls.Add(this.button1);
            this.seniorSetting.Controls.Add(this.photoHeight);
            this.seniorSetting.Controls.Add(this.label8);
            this.seniorSetting.Controls.Add(this.photoWidth);
            this.seniorSetting.Controls.Add(this.label7);
            this.seniorSetting.Controls.Add(this.label2);
            this.seniorSetting.Location = new System.Drawing.Point(4, 25);
            this.seniorSetting.Name = "seniorSetting";
            this.seniorSetting.Padding = new System.Windows.Forms.Padding(3);
            this.seniorSetting.Size = new System.Drawing.Size(768, 408);
            this.seniorSetting.TabIndex = 1;
            this.seniorSetting.Text = "高级设置";
            this.seniorSetting.UseVisualStyleBackColor = true;
            // 
            // maskImage
            // 
            this.maskImage.AutoSize = true;
            this.maskImage.Location = new System.Drawing.Point(329, 14);
            this.maskImage.Name = "maskImage";
            this.maskImage.Size = new System.Drawing.Size(52, 15);
            this.maskImage.TabIndex = 21;
            this.maskImage.Text = "文件名";
            // 
            // wordMaxSize
            // 
            this.wordMaxSize.Location = new System.Drawing.Point(420, 99);
            this.wordMaxSize.Name = "wordMaxSize";
            this.wordMaxSize.Size = new System.Drawing.Size(66, 25);
            this.wordMaxSize.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "词汇最大字体的大小";
            // 
            // wordMinSize
            // 
            this.wordMinSize.Location = new System.Drawing.Point(420, 55);
            this.wordMinSize.Name = "wordMinSize";
            this.wordMinSize.Size = new System.Drawing.Size(66, 25);
            this.wordMinSize.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "词汇最小字体的大小";
            // 
            // photoColorMode
            // 
            this.photoColorMode.FormattingEnabled = true;
            this.photoColorMode.Location = new System.Drawing.Point(133, 141);
            this.photoColorMode.Name = "photoColorMode";
            this.photoColorMode.Size = new System.Drawing.Size(121, 23);
            this.photoColorMode.TabIndex = 16;
            this.photoColorMode.SelectedIndexChanged += new System.EventHandler(this.photoColorMode_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "生成图背景模式";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "打开图案底图";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // photoHeight
            // 
            this.photoHeight.Location = new System.Drawing.Point(118, 92);
            this.photoHeight.Name = "photoHeight";
            this.photoHeight.Size = new System.Drawing.Size(66, 25);
            this.photoHeight.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "生成图片的高";
            // 
            // photoWidth
            // 
            this.photoWidth.Location = new System.Drawing.Point(118, 55);
            this.photoWidth.Name = "photoWidth";
            this.photoWidth.Size = new System.Drawing.Size(66, 25);
            this.photoWidth.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "生成图片的宽";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "自定义生成图案样式图选择";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // oepnWordFileDialog
            // 
            this.oepnWordFileDialog.FileName = "选择词条文件";
            // 
            // picturePath
            // 
            this.picturePath.AllowDrop = true;
            this.picturePath.AutoSize = true;
            this.picturePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.picturePath.Location = new System.Drawing.Point(6, 334);
            this.picturePath.Name = "picturePath";
            this.picturePath.Size = new System.Drawing.Size(67, 15);
            this.picturePath.TabIndex = 17;
            this.picturePath.Text = "图片地址";
            this.picturePath.Click += new System.EventHandler(this.picturePath_Click);
            // 
            // WordCloud
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wordCludSettingTab);
            this.Name = "WordCloud";
            this.Text = "词云生成器";
            this.Load += new System.EventHandler(this.WordCloud_Load);
            this.wordCludSettingTab.ResumeLayout(false);
            this.normalSetting.ResumeLayout(false);
            this.normalSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genPicture)).EndInit();
            this.seniorSetting.ResumeLayout(false);
            this.seniorSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl wordCludSettingTab;
        private System.Windows.Forms.TabPage normalSetting;
        private System.Windows.Forms.TabPage seniorSetting;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.ComboBox ttfPath;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox backgroudColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox maskCombox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button openWordPath;
        private System.Windows.Forms.OpenFileDialog oepnWordFileDialog;
        private System.Windows.Forms.Label wordFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox genPicture;
        private System.Windows.Forms.Button genWordCloud;
        private System.Windows.Forms.CheckBox wordRepeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox photoHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox photoWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox wordMaxSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox wordMinSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox photoColorMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textColor;
        private System.Windows.Forms.Label maskImage;
        private System.Windows.Forms.Label picturePath;
    }
}