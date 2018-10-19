using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class SQL : Form
    {
        public SQL()
        {
            InitializeComponent();
        }
        public string str = "server=.;database=data1220;user=sa;pwd=123456";
        private void button_Login_Click(object sender, EventArgs e)
        {
            string user = textBox_Name.Text;
            string pwd = textBox_Psw.Text;
            //创建数据库连接类的对象
            SqlConnection con = new SqlConnection(str);
            //将连接打开
            con.Open();
            //执行con对象的函数，返回一个SqlCommand类型的对象
            SqlCommand cmd = con.CreateCommand();
            //把输入的数据拼接成sql语句，并交给cmd对象
            cmd.CommandText = "select*from users where name='" + user + "'and pwd='" + pwd + "'";

            //用cmd的函数执行语句，返回SqlDataReader对象dr,dr就是返回的结果集（也就是数据库中查询到的表数据）
            SqlDataReader dr = cmd.ExecuteReader();
            //用dr的read函数，每执行一次，返回一个包含下一行数据的集合dr，在执行read函数之前，dr并不是集合
            if (dr.Read())
            {
                //dr[]里面可以填列名或者索引，显示获得的数据
                MessageBox.Show(dr[1].ToString()+";"+dr[2].ToString());
            }
            //用完后关闭连接，以免影响其他程序访问
            con.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            //添加数据到数据库
             string username = textBox_Name.Text;
             string upass = textBox_Psw.Text;
 
             //第一步：连接到数据库
             SqlConnection conn = new SqlConnection(str);
             conn.Open();
             SqlCommand cmd = conn.CreateCommand();
             cmd.CommandText = "insert into users values('"+username+"','"+upass+"')";
             int count=　cmd.ExecuteNonQuery();//增删改
             if (count > 0)
             {
                 MessageBox.Show("添加成功！");
             }
             else
             {
                 MessageBox.Show("添加失败！");
             }
             conn.Close();
        }

        private void button_Set_Click(object sender, EventArgs e)
        {
            string user = textBox_Name.Text;
            string pwd = textBox_Psw.Text;
            string code = textBox3.Text;
            //创建数据库连接类的对象
            SqlConnection con = new SqlConnection(str);
            con.Open();
            //执行con对象的函数，返回一个SqlCommand类型的对象
            SqlCommand cmd = con.CreateCommand();
            //拼写语句
            cmd.CommandText = "update users set name='" + user + "',pwd='" + pwd + "' where code=" + code;
            //增删改用ExecuteNonQuery，会返回一个整型数字
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
            con.Close();
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            string code = textBox3.Text;
            //创建数据库连接类的对象
            SqlConnection con = new SqlConnection(str);
            con.Open();
            //执行con对象的函数，返回一个SqlCommand类型的对象
            SqlCommand cmd = con.CreateCommand();
            //拼写语句
            cmd.CommandText = "delete from users where code=" + code;
            //增删改用ExecuteNonQuery，会返回一个整型数字
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
            con.Close();
        }
    }
}
