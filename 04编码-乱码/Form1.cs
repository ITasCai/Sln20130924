using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _04编码_乱码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////byte[] bytes = File.ReadAllBytes("1.txt");
            //string msg = File.ReadAllText("1.txt");

            //Encoding encoding = System.Text.Encoding.GetEncoding("gb2312");
            //MessageBox.Show(msg);

            StringBuilder sb = new StringBuilder();
            EncodingInfo[] infos = Encoding.GetEncodings();
            foreach (var item in infos)
            {
                sb.AppendLine(item.CodePage + "\t" + item.Name + "\t" + item.DisplayName);
            }
            File.WriteAllText("encodings.txt", sb.ToString());
            MessageBox.Show("ok");
        }
    }
}
