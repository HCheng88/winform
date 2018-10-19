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
    public partial class MainForm : Form
    {
        public string PathFolder=@"E:\WinFromProject\UISource\CommonAtlas";
        List<string> NameList = new List<string>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(PathFolder);
            FileInfo[] fileInfo = directoryInfo.GetFiles();
            
            foreach (FileInfo file in fileInfo)
            {
                NameList.Add(file.Name);
            }
            this.comboBox1.ValueMember = "user";
            this.comboBox1.DisplayMember = "user";
            this.comboBox1.DataSource = NameList;
            this.listBox1.DataSource = NameList;
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {           
            Form1 form1 = new Form1();
            form1.NameList = this.NameList;
            int id = NameList.IndexOf(this.comboBox1.SelectedItem.ToString());
            form1.index = id;
            //MessageBox.Show(id.ToString());
            form1.pictureBoxPathCallBack(this.comboBox1.SelectedItem.ToString());
            form1.ShowDialog();
        }
        
        public DataTable GetDataTable(string path)
        {
            if (Directory.Exists(path) == true)
            {
                string[] strArrFiles = Directory.GetFiles(path);
                DataTable dt = new DataTable();
                DataColumn dc = new DataColumn("user", typeof(string));
                dt.Columns.Add(dc);
                foreach (string s in strArrFiles)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = Path.GetFileName(s);
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Load(PathFolder+"/" + this.comboBox1.SelectedItem.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
