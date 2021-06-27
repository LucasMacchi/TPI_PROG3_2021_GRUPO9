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

namespace TPI_PROG_3_LUCAS_MACCHI
{
    public partial class New_Folder : Form
    {
        
        string path;
        bool ready;
        bool ready2;
        public New_Folder()
        {

            InitializeComponent();
        }

        private void New_Folder_Load(object sender, EventArgs e)
        {

        }

        private void TB_NAME_TextChanged(object sender, EventArgs e)
        {
            ready = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(ready && ready2)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La caperta ya existe");
                }

            }
            else
            {
                MessageBox.Show("Faltan campos");
            }
        }

        private void Folder_Address_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                ready2 = true;
                path = folderBrowserDialog1.SelectedPath;
                if(TB_NAME.Text != "")
                {
                    path += "\\" + TB_NAME.Text;
                    LBL_ADDRESS.Text = path;
                }
                else
                {
                    path += "\\Carpeta sin Nombre";
                    LBL_ADDRESS.Text = path;
                }

            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
