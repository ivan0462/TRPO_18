using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проверочная_по_Хешированию_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream load = new FileStream("C:/Users/Пасворд/source/repos/Проверочная по Хешированию_1/one.txt", FileMode.Open);
            StreamReader read = new StreamReader(load);
            textBox1.Text = read.ReadToEnd();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/Пасворд/source/repos/Проверочная по Хешированию_1/one.txt";
            Process.Start(path);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/Пасворд/source/repos/Проверочная по Хешированию_1/two.txt";
            Process.Start(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream load = new FileStream("C:/Users/Пасворд/source/repos/Проверочная по Хешированию_1/two.txt", FileMode.Open);
            StreamReader read = new StreamReader(load);
            textBox2.Text = read.ReadToEnd();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string r = System.IO.File.ReadAllText("C:/Users/Пасворд/source/repos/Проверочная по Хешированию_1/one.txt", Encoding.Default).Replace("\n", " ");
                HashSh1(r);
            }
        }

        private static string HashSh1(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hashSh1 = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));

                // declare stringbuilder
                var sb = new StringBuilder(hashSh1.Length * 2);

                // computing hashSh1
                foreach (byte b in hashSh1)
                {
                    // "x2"
                    sb.Append(b.ToString("X2").ToLower());
                }

                // final output
                Console.WriteLine(string.Format("The SHA1 hash of {0} is: {1}", input, sb.ToString()));
                File.WriteAllText("C:/Users/Пасворд/source/repos/Проверочная по Хешированию_1/two.txt", $"{sb}", Encoding.Default);

                return sb.ToString();
            }


        }
    }
}







