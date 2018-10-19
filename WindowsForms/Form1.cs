using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public List<string> NameList = new List<string>();
        public int index = 0;
        public string PathFolder = "E:/WinFromProject/UISource/CommonAtlas/";
        public Form1()
        {
            InitializeComponent();
        }
        private string pathname = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            if (index-1 < 0)
            {
                MessageBox.Show("这是第一张!");
                return;
            }
            else
            {
                this.pictureBox1.Load(PathFolder + NameList[index - 1]);
                index--;
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index + 1 >= NameList.Count)
            {
                MessageBox.Show("这是最后一张!");
                return;
            }
            else
            {
                this.pictureBox1.Load(PathFolder + NameList[index + 1]);
                index++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DirectoryInfo directoryInfo = new DirectoryInfo(@"E:\WinFromProject\UISource\CommonAtlas");
            //FileInfo[] fileInfo = directoryInfo.GetFiles();
            //foreach (FileInfo file in fileInfo)
            //{
            //    NameList.Add(file.Name);
            //}
            //this.pictureBox1.Load(path + NameList[index]);
        }
        public void pictureBoxPathCallBack(string path)
        {
            string Path = PathFolder + path;
            this.pictureBox1.Load(Path);
            //int index = NameList.IndexOf(path);
            //return index;
        }
    }
}
