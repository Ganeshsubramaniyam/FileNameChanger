using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FileNameChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                label4.Text = folderBrowserDialog1.SelectedPath;
                string[] filePaths = Directory.GetFiles(label4.Text, "*.mp3", SearchOption.AllDirectories);
                listBox1.Items.Clear();
                for (int i = 0; i < filePaths.Length - 1; i++)
                {
                    listBox1.Items.Add(filePaths[i]);
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for(int i=0;i<listBox1.Items.Count;i++)
            {
                String oldName = listBox1.Items[i].ToString();
                String newName = oldName.Replace("-StarMusiQ.Com", "");
                if(oldName.Contains("-StarMusiQ.Com"))
                {
                    if (File.Exists(oldName))
                    {
                        File.Copy(oldName, newName, true);
                        File.Delete(oldName);
                    }
                }
                
            }
            string[] filePaths = Directory.GetFiles(label4.Text, "*.mp3", SearchOption.AllDirectories);
            listBox2.Items.Clear();
            for (int i = 0; i < filePaths.Length - 1; i++)
            {
                listBox2.Items.Add(filePaths[i]);
            }
        }
    }
}
