using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WY_Tools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wordCloudLaunch_Click(object sender, EventArgs e)
        {
            WordCloud wordCloud = new WordCloud();
            wordCloud.Show();
            this.Hide();
            Console.WriteLine("启动词云");
        }
    }


    

}
