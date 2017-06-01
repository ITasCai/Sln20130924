using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _07文件流加密解密
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = textBox1.Text.Trim();

            string target = textBox2.Text.Trim();

            CopyEncryptFile(source, target);
            MessageBox.Show("ok");
        }

        private void CopyEncryptFile(string source, string target)
        {
            //读
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                //写
                using (FileStream fsWrite = new FileStream(target, FileMode.Create, FileAccess.Write))
                {
                    //缓冲区
                    byte[] buffer = new byte[1024 * 1024 * 1];

                    int byteCount = fsRead.Read(buffer, 0, buffer.Length);

                    //这个应该写在循环里面
                    //========================加密==================================
                    for (int i = 0; i < byteCount; i++)
                    {
                        buffer[i] = (byte)(byte.MaxValue - buffer[i]);
                    }
                    //========================加密==================================


                    while (byteCount > 0)
                    {
                        fsWrite.Write(buffer, 0, byteCount);
                        byteCount = fsRead.Read(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
