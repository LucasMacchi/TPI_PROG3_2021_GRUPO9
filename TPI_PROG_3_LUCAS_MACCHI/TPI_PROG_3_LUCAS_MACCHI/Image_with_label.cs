using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_PROG_3_LUCAS_MACCHI
{
    class Image_with_label : UserControl
    {
        private PictureBox pictureBox;
        private Label texto;
        string filename;
        const int alturaImagen = 100;
        const int anchuraImagen = 100;
        //string[] formats = { ".txt", ".pdf", ".doc", ".jpg", ".png", ".mp4", ".wmv", ".gif", ".flv", ".webm", ".exe" };
        string file_path;
        Form1 ventanaPrincipal;
        public Image_with_label(string path, Form1 ventanaPrincipal)
        {
            //Traigo a la ventana principal
            this.ventanaPrincipal = ventanaPrincipal;
            //Creo el label, path y el Picture box
            texto = new Label();
            pictureBox = new PictureBox();
            file_path = path;
            //Seteo la imagen y sus eventos
            Image imagen1 = Image.FromFile(GetImage());
            pictureBox.DoubleClick += PictureBox_DoubleClick;
            pictureBox.Click += PictureBox_Click;
            //Consigo el nombre del archivo
            filename = Path.GetFileName(path);
            pictureBox.Image = imagen1;
            //Seteo el texto del label y el evento
            texto.Text = filename;
            if (pictureBox.Image.Width < anchuraImagen || pictureBox.Image.Height < alturaImagen)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            
            Controls.Add(pictureBox);
            pictureBox.Location = new Point(0, 0);
            Controls.Add(texto);
            int a = pictureBox.Width - 85;
            texto.Location = new Point( a , pictureBox.Height);
            

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.Temporal_path = file_path;
            
        }

        private void PictureBox_DoubleClick(object sender, EventArgs e)
        {
            if (Directory.Exists(file_path))
            {
                ventanaPrincipal.General_Path = file_path;
                ventanaPrincipal.GetFile();
                ventanaPrincipal.Crear_de_Nuevo(ventanaPrincipal.Files_All);
            }
        }

        private string GetImage()
        {
            string file_extension = Path.GetExtension(file_path);
            bool isDirectory = (File.GetAttributes(file_path) & FileAttributes.Directory) == FileAttributes.Directory;
            string image_path = @"Resources\StatusAnnotations_Warning_32xLG_color.png";
            try
            {
                if (isDirectory)
                {
                    image_path = @"Resources\folder_Open_32xLG.png";
                    return image_path;
                }
                else if (file_extension == ".txt" || file_extension == ".pdf" || file_extension == ".doc")
                {
                    image_path = @"Resources\Textfile_818_32x.png";
                }
                else if (file_extension == ".jpg" || file_extension == ".png")
                {
                    image_path = @"Resources\resource_32xLG.png";
                }
                else if (file_extension == ".mp4" || file_extension == ".wmv" || file_extension == ".gif" || file_extension == ".flv" || file_extension == ".webm")
                {
                    image_path = @"Resources\filmstrip_32xLG.png";

                }
                else if (file_extension == ".exe")
                {
                    image_path = @"Resources\application_32xLG.png";

                }
                else
                {
                    image_path = @"Resources\document_32xLG.png";

                }
                
                return image_path;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return image_path;
            }
          
        }

    }
}
