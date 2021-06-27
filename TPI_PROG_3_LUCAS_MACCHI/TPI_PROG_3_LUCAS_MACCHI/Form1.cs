using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TPI_PROG_3_LUCAS_MACCHI
{
    public partial class Form1 : Form
    {
        string general_Path = "";
        string[] files_All;

        string temporal_path;
        Image imagen_temporal;
        string current_Description_Path;
        string explorer_path;

        Contenedor contenedor;
        LastSession ultimaSesion;

        #region Declaracion de Propiedades
        public string Temporal_path { get => temporal_path; set => temporal_path = value; }
        public Image Imagen_temporal { get => imagen_temporal; set => imagen_temporal = value; }
        public string General_Path { get => general_Path; set => general_Path = value; }
        public string[] Files_All { get => files_All; set => files_All = value; }
        #endregion

        public Form1()
        {
            
            contenedor = new Contenedor();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DG_ARCHIVOS.Visible = false;
            panel_modificacion.Visible = false;
            panel_raw_data.Visible = false;
            timer1.Enabled = true;
            Open_archivo.Enabled = false;
            Delete_arc.Enabled = false;
            //Esta parte se encarga de abrir la aplicacion justo como la habian dejado
            if (File.Exists("last_session.xml"))
            {
                ultimaSesion = Abrir_last_xml();
            }
            if(ultimaSesion != null)
            {
                
                general_Path = ultimaSesion.direccion;
                Crear_de_Nuevo(ultimaSesion.todosArchivos);
            }
            else
            {
                GetFile();
            }
            
        }


        
        //*********************Inicio*************************//
        #region Creador de Archivos
        //Este metodo consigue todos los archivos dentro de una carpeta y los pone en un array de strings, ademas crear la clase para guardar la sesion
        public void GetFile()
        {
            if (General_Path != "")
            {
                //Conseguir todos los archivos dentro de una carpeta
                Files_All = Directory.GetFileSystemEntries(General_Path, "*.*");
                ultimaSesion = new LastSession(Files_All, general_Path);

                TB_SHOW_ARCHIVES.Text = "";
                foreach (string name in Files_All)
                {
                    TB_SHOW_ARCHIVES.Text += name + Environment.NewLine;

                }
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (General_Path != "")
                lbl_current_address.Text = General_Path;
            Crear_Modificacion();
            MiMetodo_SetDescriptionOfFile();
            GetFile();
        }



        private void Actualizar_iconos_Click(object sender, EventArgs e)
        {
            Crear_de_Nuevo(Files_All);
        }

        public void Crear_de_Nuevo(string[] archivos)
        {
            flowLayoutPanel1.Controls.Clear();
            DG_ARCHIVOS.Rows.Clear();
            CrearIcono(archivos);
            DataGrid_Manager(archivos);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private string File_Length(string path)
        {
            long size;
            string final_size = "0";
            try
            {
                FileInfo info = new FileInfo(path);
                size = info.Length;
                final_size = size.ToString();
                return final_size;
            }
            catch (FileNotFoundException)
            {

                size = 0;
                return final_size;

            }
        }

        private void Delete_arc_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres eliminar el archivo?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    File.Delete(current_Description_Path);
                }
                catch (Exception)
                {

                    Directory.Delete(current_Description_Path);
                }


            }


        }
        #endregion
        //**********************Fin**********************//

        

        //*********************Inicio*************************//
        #region FlowPanel
        private void CrearIcono(string[] files)
        {
            if (General_Path != "")
            {
                foreach (string path in files)
                {

                    Image_with_label image_With_Label = new Image_with_label(path, this);


                    flowLayoutPanel1.Controls.Add(image_With_Label);
                }
            }
        }
        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            GetFile();
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            GetFile();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            GetFile();
        }
        private void flowLayoutPanel1_DoubleClick(object sender, EventArgs e)
        {
        }
        #endregion
        //**********************Fin**********************//



        //*********************Inicio*************************//
        #region Menustrip for panels
        private void rawDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_RawData();
        }

        private void MS_DES_RAW_Click(object sender, EventArgs e)
        {
            Show_description();
        }
        private void Show_description()
        {
            panel_modificacion.Visible = false;
            panel_raw_data.Visible = false;
            panel_descripcion.Visible = true;
        }
        private void Show_RawData()
        {
            panel_modificacion.Visible = false;
            panel_raw_data.Visible = false;
            panel_raw_data.Visible = true;
        }
        private void Show_Modificacion()
        {
            SET_DESCRIPTION();
            panel_modificacion.Visible = false;
            panel_raw_data.Visible = false;
            panel_modificacion.Visible = true;
        }

        private void MS_MOD_RAW_Click(object sender, EventArgs e)
        {
            Show_Modificacion();
        }

        private void MS_MOD_DES_Click(object sender, EventArgs e)
        {
            Show_Modificacion();
        }

        private void MS_DES_MOD_Click(object sender, EventArgs e)
        {
            Show_description();
        }

        private void MS_RAW_MOD_Click(object sender, EventArgs e)
        {
            Show_RawData();
        }
        #endregion
        //**********************Fin**********************//



        //*********************Inicio*************************//
        #region otros
        private void Grid_view_button_Click(object sender, EventArgs e)
        {
            DG_ARCHIVOS.Visible = true;
            flowLayoutPanel1.Visible = false;
            Grid_view_button.Enabled = false;
            Flow_button.Enabled = true;
        }

        private void Flow_button_Click(object sender, EventArgs e)
        {
            DG_ARCHIVOS.Visible = false;
            flowLayoutPanel1.Visible = true;
            Flow_button.Enabled = false;
            Grid_view_button.Enabled = true;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        //**********************Fin**********************//



        //*********************Inicio*************************//
        #region Administrador del GridData
        private void DataGrid_Manager(string[] files_paths)
        {
            if(General_Path != "")
            {
                int id = 0;
                foreach (string path in files_paths)
                {
                    id++;
                    //Creo una fila nueva
                    int fila = DG_ARCHIVOS.Rows.Add();
                    //Saco la informacion del archivo
                    FileInfo info = new FileInfo(path);
                    string filename = info.Name;
                    string size = File_Length(path);
                    string create_date = info.CreationTime.ToString();
                    string last_modified = info.LastWriteTime.ToString();
                    string format = info.Extension;
                    //Empiezo a llenar la fila
                    DG_ARCHIVOS.Rows[fila].Cells[0].Value = id;
                    DG_ARCHIVOS.Rows[fila].Cells[1].Value = filename;
                    DG_ARCHIVOS.Rows[fila].Cells[2].Value = size;
                    DG_ARCHIVOS.Rows[fila].Cells[3].Value = create_date;
                    DG_ARCHIVOS.Rows[fila].Cells[4].Value = last_modified;
                    DG_ARCHIVOS.Rows[fila].Cells[5].Value = format;
                    DG_ARCHIVOS.Rows[fila].Cells[6].Value = path;
                }
            

            }
        }
        private void DG_ARCHIVOS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i != -1)
            {
                
                temporal_path = DG_ARCHIVOS.Rows[i].Cells[6].Value.ToString();
                Process.Start(temporal_path);
            }
        }
        #endregion
        //**********************Fin**********************//



        //*********************Inicio*************************//
        #region Creador de descripcion

        private void Open_archivo_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(current_Description_Path);
            }
            catch (InvalidOperationException)
            {
            }

        }

        private void DG_ARCHIVOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i != -1)
            {
                temporal_path = DG_ARCHIVOS.Rows[i].Cells[6].Value.ToString();
            }
        }

        private void MiMetodo_SetDescriptionOfFile()
        {

            if (temporal_path != null)
            {
                current_Description_Path = temporal_path;
                FileInfo info = new FileInfo(Temporal_path);
                lbl_ubicacion.Text = temporal_path;
                Descripcion_picture.Image = GetIcon_description();
                if (Descripcion_picture.Image.Width < 100 || Descripcion_picture.Image.Height < 100)
                {
                    Descripcion_picture.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                string filename = Path.GetFileName(temporal_path);
                lbl_nombre.Text = filename;
                lbl_descripcion.Text = contenedor.Traer_descripcion(filename);
                lbl_size.Text = File_Length(temporal_path) + " en Bytes";
                var created = info.CreationTime;
                var last_modified = info.LastWriteTime;
                lbl_create_time.Text = created.ToString();
                lbl_last_modifed.Text = last_modified.ToString();
                Open_archivo.Enabled = true;
                Delete_arc.Enabled = true;
            }


        }

        private Image GetIcon_description()
        {
            //En esta parte determino el icono de la descripcion del archivo
            Image imagen;
            string image_path = @"Resources\StatusAnnotations_Warning_32xLG_color.png";
            try
            {
                string file_extension = Path.GetExtension(temporal_path);
                bool isDirectory = (File.GetAttributes(temporal_path) & FileAttributes.Directory) == FileAttributes.Directory;

                if (isDirectory)
                {
                    image_path = @"Resources\folder_Open_32xLG.png";
                    imagen = Image.FromFile(image_path);
                }
                else if (file_extension == ".txt" || file_extension == ".pdf" || file_extension == ".doc")
                {
                    image_path = @"Resources\Textfile_818_32x.png";
                    imagen = Image.FromFile(image_path);
                }
                else if (file_extension == ".jpg" || file_extension == ".png")
                {
                    image_path = @"Resources\resource_32xLG.png";
                    imagen = Image.FromFile(image_path);
                }
                else if (file_extension == ".mp4" || file_extension == ".wmv" || file_extension == ".gif" || file_extension == ".flv" || file_extension == ".webm")
                {
                    image_path = @"Resources\filmstrip_32xLG.png";
                    imagen = Image.FromFile(image_path);

                }
                else if (file_extension == ".exe")
                {
                    image_path = @"Resources\application_32xLG.png";
                    imagen = Image.FromFile(image_path);

                }
                else
                {
                    image_path = @"Resources\document_32xLG.png";
                    imagen = Image.FromFile(image_path);

                }
                return imagen;

            }
            catch (Exception error)
            {
                imagen = Image.FromFile(image_path);
                //MessageBox.Show("Error: " + error.Message);
                return imagen;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel_modificacion_Paint(object sender, PaintEventArgs e)
        {

        }

        
        #endregion
        //************************************************//



        //*********************Inicio*************************//
        #region Modificador

        private void Crear_Modificacion()
        {
            try
            {
                
                FileInfo fileInfo = new FileInfo(temporal_path);
                TB_NOMBRE_MOD.Text = fileInfo.Name;
                TB_DIRECCION_MOD.Text = fileInfo.FullName;
                
            }
            catch (ArgumentNullException)
            {

                
            }
            


        }

        private void TB_NOMBRE_MOD_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void CHANGE_ADDRESS_Click(object sender, EventArgs e)
        {
            bool isFolder;
            if (Directory.Exists(Temporal_path))
            {
                isFolder = true;
            }
            else
            {
                isFolder = false;
            }
            if (FBD_CHANGE.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (isFolder)
                    {
                        FileInfo info = new FileInfo(temporal_path);
                        string nombre = info.Name;
                        explorer_path = FBD_CHANGE.SelectedPath;
                        explorer_path += "\\" + nombre;
                        label13.Text = explorer_path;
                        //Aca iria el cambio de direccion
                        Directory.Move(temporal_path, explorer_path);
                        temporal_path =  explorer_path;
                    }
                    else
                    {
                        FileInfo info = new FileInfo(temporal_path);
                        string nombre = info.Name;
                        explorer_path = FBD_CHANGE.SelectedPath;
                        explorer_path += "\\"+ nombre;
                        label13.Text = explorer_path;
                        //Aca iria el cambio de direccion
                        File.Move(temporal_path, explorer_path);
                        temporal_path = explorer_path;
                    }
                    
                }
                catch (Exception h)
                {

                    MessageBox.Show("Hubo un error al mover el archivo:" + h.Message);
                }
                
            }

        }

        private void Change_Name()
        {
            File.Move(Path.GetFileName(temporal_path), TB_NOMBRE_MOD.Text);
        }

        private void OFD_Change_dialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Change_name change_Name = new Change_name(this);
            change_Name.ShowDialog();
        }

        private void New_folder_but_Click(object sender, EventArgs e)
        {
            New_Folder new_Folder = new New_Folder();
            new_Folder.ShowDialog();
        }

        private void Select_general_address_Click(object sender, EventArgs e)
        {
            if(FBD_GENERAL.ShowDialog() == DialogResult.OK)
            {
                General_Path = FBD_GENERAL.SelectedPath;
            }
        }

        private void SET_DESCRIPTION()
        {
            try
            {
                TB_DESCRIPCION_MOD.Text = contenedor.Traer_descripcion(TB_NOMBRE_MOD.Text);
            }
            catch (ArgumentNullException)
            {

                TB_DESCRIPCION_MOD.Text = "";
            }
            
        }

        private void Save_des_Click(object sender, EventArgs e)
        {
            contenedor.Descripciones.Add(TB_NOMBRE_MOD.Text, TB_DESCRIPCION_MOD.Text);
            TB_DESCRIPCION_MOD.Text = "";
            MessageBox.Show("Descripcion Guardada");
        }

        #endregion
        //**********************Fin**********************//



        //*********************Inicio*************************//
        #region Abrir y guardar descripciones
        private void Select_archive_des_Click(object sender, EventArgs e)
        {
            if(OFD_DESCRIPCIONES.ShowDialog() == DialogResult.OK)
            {
                Abrir_Objeto(OFD_DESCRIPCIONES.FileName);
            }
        }

        private void Save_archive_des_Click(object sender, EventArgs e)
        {
            if(SFD_DESCRIPCIONES.ShowDialog() == DialogResult.OK)
            {
                Guardar_archivo(contenedor, SFD_DESCRIPCIONES.FileName);
            }
        }
        private void Guardar_archivo(Contenedor mi_objeto, string filename)
        {
            FileStream save_path = new FileStream(filename, FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(save_path, mi_objeto);
            save_path.Close();
        }

        private void Abrir_Objeto(string filename)
        {
            FileStream f = new FileStream(filename, FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            contenedor = (Contenedor)b.Deserialize(f);
            f.Close();
        }
        #endregion
        //**********************Fin**********************//



        //*********************Inicio*************************//
        #region Info de ultima sesion
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(general_Path != "" || general_Path != null)
            {
                Guardar_last_xml(ultimaSesion);
            }
            
        }
        private void Guardar_last_xml(LastSession objeto)
        {
            using (FileStream f = new FileStream("last_session.xml", FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(LastSession));
                xml.Serialize(f, objeto);
            }
        }
        private LastSession Abrir_last_xml()
        {
            using (FileStream f = new FileStream("last_session.xml", FileMode.Open))
            {
                XmlSerializer xml = new XmlSerializer(typeof(LastSession));
                return (LastSession)xml.Deserialize(f);
            }

        }
        #endregion
        //**********************Fin**********************//

    }

}
