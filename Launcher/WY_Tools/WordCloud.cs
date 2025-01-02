using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WY_Tools
{
    public partial class WordCloud : Form
    {
        private string _wordCludContent;
        private string _wordPath;
        public WordCloud()
        {
            InitializeComponent();
            initAllCompoentContent();

        }

        private void initAllCompoentContent()
        {
            //设置词云背景颜色模式选项，默认RGBA
            string[] modeList = new string[] {
                "RGBA",
                "RGB"
            };
            foreach (string mode in modeList)
            {
                photoColorMode.Items.Add(mode);
            }
            photoColorMode.SelectedItem = "RGBA";

            //设置字体选择选项
            String[] ttfFileNames = Directory.GetFiles("./font");
            foreach (string ttfFileName in ttfFileNames)
            {
                var ttf = ttfFileName.Replace("./font\\", "").Replace(".ttf", "");
                ttfPath.Items.Add(ttf);
            }
            ttfPath.SelectedItem = ttfPath.Items[0];

            //设置默认图案选项
            String[] maskPathNames = Directory.GetFiles("./mask");
            foreach (string maskPathName in maskPathNames)
            {
                var mask = maskPathName.Replace("./mask\\", "").Replace(".png","");
                maskCombox.Items.Add(mask);
            }
            maskCombox.SelectedItem = maskCombox.Items[0]; 
            //设置默认生成图片的宽和高
            photoWidth.Text = "1920";
            photoHeight.Text = "1080";
            //设置默认字体大小
            wordMinSize.Text = "15";
            wordMaxSize.Text = "300";
         
        }


        private void ttfPath_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void openWordPath_Click(object sender, EventArgs e)
        {
            if (oepnWordFileDialog.ShowDialog() == DialogResult.OK)
            {
                string name = oepnWordFileDialog.FileName;
                wordFileName.Text = name;
                _wordPath = name;
                System.IO.StreamReader sr = new System.IO.StreamReader(oepnWordFileDialog.FileName);
                
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void photoColorMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void genWordCloud_Click(object sender, EventArgs e)
        {
            Console.WriteLine("开始生成！");
            //获取字体目录
            var currentDir = Directory.GetCurrentDirectory();
            var gwc = currentDir + "\\tools\\GWC.exe";
            var cmd = currentDir +  "\\tools\\GWC.exe";
            Console.WriteLine("当前目录"+currentDir);
            if (_wordPath == "")
            {
                Console.WriteLine("没有选单词");
            }
            else
            {
                cmd = cmd + " --word_path " + _wordPath;
            }
            //字体路径
            if (ttfPath.Text != "")
            {
                var fontPath = currentDir + "\\font\\" + ttfPath.Text + ".ttf";
                cmd = cmd + " --font_path " + fontPath;
            }
            //背景颜色
            if (backgroudColor.Text != "")
            {
                cmd = cmd + " --background_color " + backgroudColor.Text;
            }
            //字体颜色
            if (textColor.Text != "")
            {
                cmd = cmd + " --color_id " + textColor.Text;
            }
            //mask
            if (maskCombox.Text != "")
            {
                cmd = cmd + " --mask_path " + currentDir +"\\mask\\"+ maskCombox.Text + ".png";
            }

            //repeat
            if (wordRepeat.Checked)
            {
                cmd = cmd + " --repeat " + "True";
            }
            else
            {
                cmd = cmd + " --repeat " + "False";
            }

            //宽高
            if (photoWidth.Text != "" && photoHeight.Text != "")
            {
                cmd = cmd + " --width " + photoWidth.Text + " --height " + photoHeight.Text;
            }
            //生产图背景模式
            if (photoColorMode.Text != "")
            {
                cmd = cmd + " --mode " + photoColorMode.Text;
            }
            //最小字体
            if (wordMinSize.Text != "")
            {
                cmd = cmd + " --min_font_size " + wordMinSize.Text;
            }
            //最大字体
            if (wordMaxSize.Text != "")
            {
                cmd = cmd + " --max_font_size " + wordMaxSize.Text;
            }
            Console.WriteLine("指令："+cmd);
            if (File.Exists(gwc))
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe", // 在Windows上，使用cmd.exe来执行Shell指令
                    Arguments = "/c " + cmd, // /c 参数表示执行命令然后终止
                    RedirectStandardOutput = true, // 重定向标准输出
                    RedirectStandardError = true, // 重定向标准错误（可选）
                    UseShellExecute = false, // 必须设置为false以重定向输出
                    CreateNoWindow = true // 不创建窗口（可选）
                };
                process.StartInfo = startInfo;
                process.Start();
                // 读取标准输出
                string output = process.StandardOutput.ReadToEnd();

                // 读取标准错误（可选）
                string error = process.StandardError.ReadToEnd();

                // 等待进程退出
                process.WaitForExit();

                // 输出结果
                Console.WriteLine("Output:");
                Console.WriteLine(output);
                genPicture.Image = Image.FromFile(output);
                picturePath.Text = output;
                if (!string.IsNullOrEmpty(error))
                {
                    Console.WriteLine("Error:");
                    Console.WriteLine(error);
                }
            }
            else
            {

            Console.WriteLine("不存在"); 
            }
        }

        private void textColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void genPicture_Click(object sender, EventArgs e)
        {

        }

        private void WordCloud_Load(object sender, EventArgs e)
        {

        }

        private void picturePath_Click(object sender, EventArgs e)
        {

        }
    }

    
}
