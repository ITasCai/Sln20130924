using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace _01资料管理器作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //foreach (var item in this.treeView1.Nodes)
            //{

            //}






            //获取当前正在执行的程序集（exe文件）的路径
            string exePath = Assembly.GetExecutingAssembly().Location;
            //加载文件结构到TreeView
            //得到demo文件夹的完整路径
            string path = Path.Combine(Path.GetDirectoryName(exePath), "demo");

            LoadDataToTree(path, treeView1.Nodes);
        }

        //递归加载
        private void LoadDataToTree(string path, TreeNodeCollection treeNodeCollection)
        {
            //1.获取path下的所有子文件和子文件夹的路径
            string[] files = Directory.GetFiles(path, "*.txt");
            string[] dirs = Directory.GetDirectories(path);


            //2.遍历文件与文件夹加载到TreeView上

            //遍历文件
            foreach (string item in files)
            {
                TreeNode node = treeNodeCollection.Add(Path.GetFileName(item));

                //如果是文件节点，则把当前节点的完整路径保存在节点的Tag属性中
                node.Tag = item;
            }


            //遍历文件夹
            foreach (string item in dirs)
            {
                TreeNode node = treeNodeCollection.Add(Path.GetFileName(item));
                //递归调用
                LoadDataToTree(item, node.Nodes);
            }
        }


        //TreeView的节点的鼠标双击事件
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)//表示点击的是文件节点
            {
                //获取当前双击的节点的Tag中存储的路径
                string currentPath = e.Node.Tag.ToString();

                //e.Node.Parent

                //根据该路径读取对应的文件内容
                string txt = File.ReadAllText(currentPath, Encoding.Default);
                textBox1.Text = txt;
            }

        }
    }
}
