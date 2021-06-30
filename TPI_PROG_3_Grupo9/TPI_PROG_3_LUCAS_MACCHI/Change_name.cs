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

namespace TPI_PROG_3_Grupo9
{
    public partial class Change_name : Form
    {
        Form1 ventana;
        bool isFolder;
        
        public Change_name(Form1 ventana)
        {
            this.ventana = ventana;
            
            InitializeComponent();

            BoolFolder();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_save_Click(object sender, EventArgs e)
        {
            if (isFolder)
            {
                FileInfo info = new FileInfo(ventana.Temporal_path);
                string s = info.DirectoryName + "\\" + textBox1.Text;
                Directory.Move(ventana.Temporal_path, s);
            }
            else
            {
                FileInfo info = new FileInfo(ventana.Temporal_path);
                string path = info.DirectoryName + "\\" + textBox1.Text + info.Extension;
                File.Move(ventana.Temporal_path, path);
            }
            
            this.Close();
        }
        private void BoolFolder()
        {
            if (Directory.Exists(ventana.Temporal_path))
            {
                isFolder = true;
                textBox1.Text = Path.GetDirectoryName(ventana.Temporal_path);
            }
            else
            {
                isFolder = false;
                textBox1.Text = Path.GetFileName(ventana.Temporal_path);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo info = new FileInfo(ventana.Temporal_path);
            string s = info.DirectoryName+"\\" + textBox1.Text;

        }

        private void Change_name_Load(object sender, EventArgs e)
        {

        }
    }
}
