namespace WY_Tools
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.wordCloudLaunch = new System.Windows.Forms.Button();
            this.toolsBackgroudPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBackgroudPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // wordCloudLaunch
            // 
            this.wordCloudLaunch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wordCloudLaunch.Location = new System.Drawing.Point(26, 33);
            this.wordCloudLaunch.Name = "wordCloudLaunch";
            this.wordCloudLaunch.Size = new System.Drawing.Size(164, 59);
            this.wordCloudLaunch.TabIndex = 0;
            this.wordCloudLaunch.Text = "启动词云生成器";
            this.wordCloudLaunch.UseVisualStyleBackColor = false;
            this.wordCloudLaunch.Click += new System.EventHandler(this.wordCloudLaunch_Click);
            // 
            // toolsBackgroudPicture
            // 
            this.toolsBackgroudPicture.Location = new System.Drawing.Point(12, 12);
            this.toolsBackgroudPicture.Name = "toolsBackgroudPicture";
            this.toolsBackgroudPicture.Size = new System.Drawing.Size(776, 426);
            this.toolsBackgroudPicture.TabIndex = 1;
            this.toolsBackgroudPicture.TabStop = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wordCloudLaunch);
            this.Controls.Add(this.toolsBackgroudPicture);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainForm";
            this.Text = "WY工具箱";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolsBackgroudPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wordCloudLaunch;
        private System.Windows.Forms.PictureBox toolsBackgroudPicture;
    }
}

