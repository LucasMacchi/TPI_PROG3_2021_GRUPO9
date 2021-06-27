
namespace TPI_PROG_3_LUCAS_MACCHI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TB_SHOW_ARCHIVES = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Actualizar_iconos = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_descripcion = new System.Windows.Forms.Panel();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Delete_arc = new System.Windows.Forms.Button();
            this.Open_archivo = new System.Windows.Forms.Button();
            this.lbl_last_modifed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_create_time = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ubicacion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Descripcion_picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MS_MOD_DES = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_RAW_DES = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_raw_data = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MS_DES_RAW = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_MOD_RAW = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_modificacion = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.CHANGE_ADDRESS = new System.Windows.Forms.Button();
            this.TB_DESCRIPCION_MOD = new System.Windows.Forms.TextBox();
            this.TB_DIRECCION_MOD = new System.Windows.Forms.TextBox();
            this.TB_NOMBRE_MOD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.MS_DES_MOD = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_RAW_MOD = new System.Windows.Forms.ToolStripMenuItem();
            this.Grid_view_button = new System.Windows.Forms.Button();
            this.Flow_button = new System.Windows.Forms.Button();
            this.DG_ARCHIVOS = new System.Windows.Forms.DataGridView();
            this.DG_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_SIZE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_CREATED_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_LAST_MOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_FORMATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_PATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FBD_CHANGE = new System.Windows.Forms.FolderBrowserDialog();
            this.New_folder_but = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Select_general_address = new System.Windows.Forms.Button();
            this.lbl_current_address = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.FBD_GENERAL = new System.Windows.Forms.FolderBrowserDialog();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Select_archive_des = new System.Windows.Forms.Button();
            this.OFD_DESCRIPCIONES = new System.Windows.Forms.OpenFileDialog();
            this.Save_des = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.Save_archive_des = new System.Windows.Forms.Button();
            this.SFD_DESCRIPCIONES = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel_descripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Descripcion_picture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel_raw_data.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel_modificacion.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ARCHIVOS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_SHOW_ARCHIVES
            // 
            this.TB_SHOW_ARCHIVES.Location = new System.Drawing.Point(210, 27);
            this.TB_SHOW_ARCHIVES.Multiline = true;
            this.TB_SHOW_ARCHIVES.Name = "TB_SHOW_ARCHIVES";
            this.TB_SHOW_ARCHIVES.Size = new System.Drawing.Size(328, 247);
            this.TB_SHOW_ARCHIVES.TabIndex = 0;
            this.TB_SHOW_ARCHIVES.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 399);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 234);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            this.flowLayoutPanel1.DoubleClick += new System.EventHandler(this.flowLayoutPanel1_DoubleClick);
            // 
            // Actualizar_iconos
            // 
            this.Actualizar_iconos.Location = new System.Drawing.Point(8, 358);
            this.Actualizar_iconos.Name = "Actualizar_iconos";
            this.Actualizar_iconos.Size = new System.Drawing.Size(75, 23);
            this.Actualizar_iconos.TabIndex = 0;
            this.Actualizar_iconos.Text = "Actualizar";
            this.Actualizar_iconos.UseVisualStyleBackColor = true;
            this.Actualizar_iconos.Click += new System.EventHandler(this.Actualizar_iconos_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_descripcion
            // 
            this.panel_descripcion.AutoScroll = true;
            this.panel_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_descripcion.Controls.Add(this.lbl_descripcion);
            this.panel_descripcion.Controls.Add(this.label9);
            this.panel_descripcion.Controls.Add(this.Delete_arc);
            this.panel_descripcion.Controls.Add(this.Open_archivo);
            this.panel_descripcion.Controls.Add(this.lbl_last_modifed);
            this.panel_descripcion.Controls.Add(this.label7);
            this.panel_descripcion.Controls.Add(this.lbl_create_time);
            this.panel_descripcion.Controls.Add(this.label6);
            this.panel_descripcion.Controls.Add(this.lbl_size);
            this.panel_descripcion.Controls.Add(this.label5);
            this.panel_descripcion.Controls.Add(this.lbl_nombre);
            this.panel_descripcion.Controls.Add(this.label3);
            this.panel_descripcion.Controls.Add(this.lbl_ubicacion);
            this.panel_descripcion.Controls.Add(this.label2);
            this.panel_descripcion.Controls.Add(this.Descripcion_picture);
            this.panel_descripcion.Controls.Add(this.label1);
            this.panel_descripcion.Controls.Add(this.menuStrip1);
            this.panel_descripcion.Location = new System.Drawing.Point(480, 12);
            this.panel_descripcion.Name = "panel_descripcion";
            this.panel_descripcion.Size = new System.Drawing.Size(558, 341);
            this.panel_descripcion.TabIndex = 4;
            this.panel_descripcion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(15, 312);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(0, 16);
            this.lbl_descripcion.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Descripcion:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Delete_arc
            // 
            this.Delete_arc.Location = new System.Drawing.Point(249, 76);
            this.Delete_arc.Name = "Delete_arc";
            this.Delete_arc.Size = new System.Drawing.Size(94, 34);
            this.Delete_arc.TabIndex = 13;
            this.Delete_arc.Text = "Eliminar";
            this.Delete_arc.UseVisualStyleBackColor = true;
            this.Delete_arc.Click += new System.EventHandler(this.Delete_arc_Click);
            // 
            // Open_archivo
            // 
            this.Open_archivo.Location = new System.Drawing.Point(138, 76);
            this.Open_archivo.Name = "Open_archivo";
            this.Open_archivo.Size = new System.Drawing.Size(94, 34);
            this.Open_archivo.TabIndex = 12;
            this.Open_archivo.Text = "Abrir";
            this.Open_archivo.UseVisualStyleBackColor = true;
            this.Open_archivo.Click += new System.EventHandler(this.Open_archivo_Click);
            // 
            // lbl_last_modifed
            // 
            this.lbl_last_modifed.AutoSize = true;
            this.lbl_last_modifed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last_modifed.Location = new System.Drawing.Point(15, 280);
            this.lbl_last_modifed.Name = "lbl_last_modifed";
            this.lbl_last_modifed.Size = new System.Drawing.Size(0, 16);
            this.lbl_last_modifed.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ultima Modificacion:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_create_time
            // 
            this.lbl_create_time.AutoSize = true;
            this.lbl_create_time.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_create_time.Location = new System.Drawing.Point(15, 248);
            this.lbl_create_time.Name = "lbl_create_time";
            this.lbl_create_time.Size = new System.Drawing.Size(0, 16);
            this.lbl_create_time.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de Creacion:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.Location = new System.Drawing.Point(15, 216);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(0, 16);
            this.lbl_size.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tamaño:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(15, 184);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(0, 16);
            this.lbl_nombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_ubicacion
            // 
            this.lbl_ubicacion.AutoSize = true;
            this.lbl_ubicacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ubicacion.Location = new System.Drawing.Point(15, 152);
            this.lbl_ubicacion.Name = "lbl_ubicacion";
            this.lbl_ubicacion.Size = new System.Drawing.Size(0, 16);
            this.lbl_ubicacion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ubicacion: ";
            // 
            // Descripcion_picture
            // 
            this.Descripcion_picture.Location = new System.Drawing.Point(7, 62);
            this.Descripcion_picture.Name = "Descripcion_picture";
            this.Descripcion_picture.Size = new System.Drawing.Size(79, 62);
            this.Descripcion_picture.TabIndex = 1;
            this.Descripcion_picture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion del Archivo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_MOD_DES,
            this.MS_RAW_DES});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MS_MOD_DES
            // 
            this.MS_MOD_DES.Name = "MS_MOD_DES";
            this.MS_MOD_DES.Size = new System.Drawing.Size(89, 20);
            this.MS_MOD_DES.Text = "Modificacion";
            this.MS_MOD_DES.Click += new System.EventHandler(this.MS_MOD_DES_Click);
            // 
            // MS_RAW_DES
            // 
            this.MS_RAW_DES.Name = "MS_RAW_DES";
            this.MS_RAW_DES.Size = new System.Drawing.Size(68, 20);
            this.MS_RAW_DES.Text = "Raw Data";
            this.MS_RAW_DES.Click += new System.EventHandler(this.rawDataToolStripMenuItem_Click);
            // 
            // panel_raw_data
            // 
            this.panel_raw_data.BackColor = System.Drawing.SystemColors.Control;
            this.panel_raw_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_raw_data.Controls.Add(this.label4);
            this.panel_raw_data.Controls.Add(this.TB_SHOW_ARCHIVES);
            this.panel_raw_data.Controls.Add(this.menuStrip2);
            this.panel_raw_data.Location = new System.Drawing.Point(480, 12);
            this.panel_raw_data.Name = "panel_raw_data";
            this.panel_raw_data.Size = new System.Drawing.Size(553, 341);
            this.panel_raw_data.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Raw Data";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_DES_RAW,
            this.MS_MOD_RAW});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(551, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MS_DES_RAW
            // 
            this.MS_DES_RAW.Name = "MS_DES_RAW";
            this.MS_DES_RAW.Size = new System.Drawing.Size(81, 20);
            this.MS_DES_RAW.Text = "Descripcion";
            this.MS_DES_RAW.Click += new System.EventHandler(this.MS_DES_RAW_Click);
            // 
            // MS_MOD_RAW
            // 
            this.MS_MOD_RAW.Name = "MS_MOD_RAW";
            this.MS_MOD_RAW.Size = new System.Drawing.Size(89, 20);
            this.MS_MOD_RAW.Text = "Modificacion";
            this.MS_MOD_RAW.Click += new System.EventHandler(this.MS_MOD_RAW_Click);
            // 
            // panel_modificacion
            // 
            this.panel_modificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_modificacion.Controls.Add(this.Save_des);
            this.panel_modificacion.Controls.Add(this.button2);
            this.panel_modificacion.Controls.Add(this.CHANGE_ADDRESS);
            this.panel_modificacion.Controls.Add(this.TB_DESCRIPCION_MOD);
            this.panel_modificacion.Controls.Add(this.TB_DIRECCION_MOD);
            this.panel_modificacion.Controls.Add(this.TB_NOMBRE_MOD);
            this.panel_modificacion.Controls.Add(this.label12);
            this.panel_modificacion.Controls.Add(this.label11);
            this.panel_modificacion.Controls.Add(this.label10);
            this.panel_modificacion.Controls.Add(this.label8);
            this.panel_modificacion.Controls.Add(this.menuStrip3);
            this.panel_modificacion.Location = new System.Drawing.Point(479, 12);
            this.panel_modificacion.Name = "panel_modificacion";
            this.panel_modificacion.Size = new System.Drawing.Size(558, 341);
            this.panel_modificacion.TabIndex = 2;
            this.panel_modificacion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_modificacion_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cambiar nombre";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CHANGE_ADDRESS
            // 
            this.CHANGE_ADDRESS.Location = new System.Drawing.Point(269, 157);
            this.CHANGE_ADDRESS.Name = "CHANGE_ADDRESS";
            this.CHANGE_ADDRESS.Size = new System.Drawing.Size(110, 23);
            this.CHANGE_ADDRESS.TabIndex = 18;
            this.CHANGE_ADDRESS.Text = "Cambiar Ubicacion";
            this.CHANGE_ADDRESS.UseVisualStyleBackColor = true;
            this.CHANGE_ADDRESS.Click += new System.EventHandler(this.CHANGE_ADDRESS_Click);
            // 
            // TB_DESCRIPCION_MOD
            // 
            this.TB_DESCRIPCION_MOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DESCRIPCION_MOD.Location = new System.Drawing.Point(19, 187);
            this.TB_DESCRIPCION_MOD.Name = "TB_DESCRIPCION_MOD";
            this.TB_DESCRIPCION_MOD.Size = new System.Drawing.Size(520, 20);
            this.TB_DESCRIPCION_MOD.TabIndex = 17;
            // 
            // TB_DIRECCION_MOD
            // 
            this.TB_DIRECCION_MOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DIRECCION_MOD.Location = new System.Drawing.Point(136, 131);
            this.TB_DIRECCION_MOD.Name = "TB_DIRECCION_MOD";
            this.TB_DIRECCION_MOD.Size = new System.Drawing.Size(403, 20);
            this.TB_DIRECCION_MOD.TabIndex = 16;
            // 
            // TB_NOMBRE_MOD
            // 
            this.TB_NOMBRE_MOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NOMBRE_MOD.Location = new System.Drawing.Point(146, 84);
            this.TB_NOMBRE_MOD.Name = "TB_NOMBRE_MOD";
            this.TB_NOMBRE_MOD.Size = new System.Drawing.Size(198, 29);
            this.TB_NOMBRE_MOD.TabIndex = 15;
            this.TB_NOMBRE_MOD.TextChanged += new System.EventHandler(this.TB_NOMBRE_MOD_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 22);
            this.label12.TabIndex = 14;
            this.label12.Text = "Descripcion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 22);
            this.label11.TabIndex = 13;
            this.label11.Text = "Ubicacion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Modificacion de Archivo";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_DES_MOD,
            this.MS_RAW_MOD});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(556, 24);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // MS_DES_MOD
            // 
            this.MS_DES_MOD.Name = "MS_DES_MOD";
            this.MS_DES_MOD.Size = new System.Drawing.Size(81, 20);
            this.MS_DES_MOD.Text = "Descripcion";
            this.MS_DES_MOD.Click += new System.EventHandler(this.MS_DES_MOD_Click);
            // 
            // MS_RAW_MOD
            // 
            this.MS_RAW_MOD.Name = "MS_RAW_MOD";
            this.MS_RAW_MOD.Size = new System.Drawing.Size(68, 20);
            this.MS_RAW_MOD.Text = "Raw Data";
            this.MS_RAW_MOD.Click += new System.EventHandler(this.MS_RAW_MOD_Click);
            // 
            // Grid_view_button
            // 
            this.Grid_view_button.Location = new System.Drawing.Point(98, 358);
            this.Grid_view_button.Name = "Grid_view_button";
            this.Grid_view_button.Size = new System.Drawing.Size(130, 23);
            this.Grid_view_button.TabIndex = 16;
            this.Grid_view_button.Text = "Mostrar sin iconos";
            this.Grid_view_button.UseVisualStyleBackColor = true;
            this.Grid_view_button.Click += new System.EventHandler(this.Grid_view_button_Click);
            // 
            // Flow_button
            // 
            this.Flow_button.Location = new System.Drawing.Point(234, 359);
            this.Flow_button.Name = "Flow_button";
            this.Flow_button.Size = new System.Drawing.Size(130, 23);
            this.Flow_button.TabIndex = 17;
            this.Flow_button.Text = "Mostrar con iconos";
            this.Flow_button.UseVisualStyleBackColor = true;
            this.Flow_button.Click += new System.EventHandler(this.Flow_button_Click);
            // 
            // DG_ARCHIVOS
            // 
            this.DG_ARCHIVOS.AllowUserToOrderColumns = true;
            this.DG_ARCHIVOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG_ARCHIVOS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DG_ARCHIVOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_ARCHIVOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DG_ID,
            this.DG_NOMBRE,
            this.DG_SIZE,
            this.DG_CREATED_TIME,
            this.DG_LAST_MOD,
            this.DG_FORMATO,
            this.DG_PATH});
            this.DG_ARCHIVOS.Location = new System.Drawing.Point(12, 388);
            this.DG_ARCHIVOS.Name = "DG_ARCHIVOS";
            this.DG_ARCHIVOS.Size = new System.Drawing.Size(998, 245);
            this.DG_ARCHIVOS.TabIndex = 18;
            this.DG_ARCHIVOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_ARCHIVOS_CellClick);
            this.DG_ARCHIVOS.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_ARCHIVOS_CellContentDoubleClick);
            // 
            // DG_ID
            // 
            this.DG_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DG_ID.HeaderText = "Id";
            this.DG_ID.Name = "DG_ID";
            this.DG_ID.Width = 41;
            // 
            // DG_NOMBRE
            // 
            this.DG_NOMBRE.HeaderText = "Nombre";
            this.DG_NOMBRE.Name = "DG_NOMBRE";
            this.DG_NOMBRE.Width = 69;
            // 
            // DG_SIZE
            // 
            this.DG_SIZE.HeaderText = "Tamaño (Bytes)";
            this.DG_SIZE.Name = "DG_SIZE";
            this.DG_SIZE.Width = 97;
            // 
            // DG_CREATED_TIME
            // 
            this.DG_CREATED_TIME.HeaderText = "Fecha de Creacion";
            this.DG_CREATED_TIME.Name = "DG_CREATED_TIME";
            this.DG_CREATED_TIME.Width = 112;
            // 
            // DG_LAST_MOD
            // 
            this.DG_LAST_MOD.HeaderText = "Ultima Modificacion";
            this.DG_LAST_MOD.Name = "DG_LAST_MOD";
            this.DG_LAST_MOD.Width = 114;
            // 
            // DG_FORMATO
            // 
            this.DG_FORMATO.HeaderText = "Formato";
            this.DG_FORMATO.Name = "DG_FORMATO";
            this.DG_FORMATO.Width = 70;
            // 
            // DG_PATH
            // 
            this.DG_PATH.HeaderText = "Ubicacion";
            this.DG_PATH.Name = "DG_PATH";
            this.DG_PATH.Width = 80;
            // 
            // New_folder_but
            // 
            this.New_folder_but.Location = new System.Drawing.Point(370, 359);
            this.New_folder_but.Name = "New_folder_but";
            this.New_folder_but.Size = new System.Drawing.Size(90, 23);
            this.New_folder_but.TabIndex = 21;
            this.New_folder_but.Text = "Nueva Carpeta";
            this.New_folder_but.UseVisualStyleBackColor = true;
            this.New_folder_but.Click += new System.EventHandler(this.New_folder_but_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Save_archive_des);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.Select_archive_des);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.Select_general_address);
            this.panel1.Controls.Add(this.lbl_current_address);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(8, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 340);
            this.panel1.TabIndex = 22;
            // 
            // Select_general_address
            // 
            this.Select_general_address.Location = new System.Drawing.Point(245, 40);
            this.Select_general_address.Name = "Select_general_address";
            this.Select_general_address.Size = new System.Drawing.Size(110, 23);
            this.Select_general_address.TabIndex = 19;
            this.Select_general_address.Text = "Seleccionar";
            this.Select_general_address.UseVisualStyleBackColor = true;
            this.Select_general_address.Click += new System.EventHandler(this.Select_general_address_Click);
            // 
            // lbl_current_address
            // 
            this.lbl_current_address.AutoSize = true;
            this.lbl_current_address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_address.Location = new System.Drawing.Point(5, 83);
            this.lbl_current_address.Name = "lbl_current_address";
            this.lbl_current_address.Size = new System.Drawing.Size(65, 18);
            this.lbl_current_address.TabIndex = 3;
            this.lbl_current_address.Text = "Ninguna";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(235, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "Direccion seleccionada:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 24);
            this.label14.TabIndex = 20;
            this.label14.Text = "Seleccionar archivo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 24);
            this.label15.TabIndex = 21;
            this.label15.Text = "Descripciones:";
            // 
            // Select_archive_des
            // 
            this.Select_archive_des.Location = new System.Drawing.Point(245, 202);
            this.Select_archive_des.Name = "Select_archive_des";
            this.Select_archive_des.Size = new System.Drawing.Size(110, 23);
            this.Select_archive_des.TabIndex = 22;
            this.Select_archive_des.Text = "Seleccionar";
            this.Select_archive_des.UseVisualStyleBackColor = true;
            this.Select_archive_des.Click += new System.EventHandler(this.Select_archive_des_Click);
            // 
            // Save_des
            // 
            this.Save_des.Location = new System.Drawing.Point(414, 248);
            this.Save_des.Name = "Save_des";
            this.Save_des.Size = new System.Drawing.Size(116, 39);
            this.Save_des.TabIndex = 20;
            this.Save_des.Text = "Guardar";
            this.Save_des.UseVisualStyleBackColor = true;
            this.Save_des.Click += new System.EventHandler(this.Save_des_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(167, 24);
            this.label16.TabIndex = 23;
            this.label16.Text = "Guardar archivo:";
            // 
            // Save_archive_des
            // 
            this.Save_archive_des.Location = new System.Drawing.Point(245, 244);
            this.Save_archive_des.Name = "Save_archive_des";
            this.Save_archive_des.Size = new System.Drawing.Size(110, 23);
            this.Save_archive_des.TabIndex = 24;
            this.Save_archive_des.Text = "Guardar";
            this.Save_archive_des.UseVisualStyleBackColor = true;
            this.Save_archive_des.Click += new System.EventHandler(this.Save_archive_des_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.New_folder_but);
            this.Controls.Add(this.DG_ARCHIVOS);
            this.Controls.Add(this.Flow_button);
            this.Controls.Add(this.panel_modificacion);
            this.Controls.Add(this.Grid_view_button);
            this.Controls.Add(this.panel_raw_data);
            this.Controls.Add(this.panel_descripcion);
            this.Controls.Add(this.Actualizar_iconos);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Trabajo Practico Integrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel_descripcion.ResumeLayout(false);
            this.panel_descripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Descripcion_picture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_raw_data.ResumeLayout(false);
            this.panel_raw_data.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel_modificacion.ResumeLayout(false);
            this.panel_modificacion.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ARCHIVOS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TB_SHOW_ARCHIVES;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Actualizar_iconos;
        private System.Windows.Forms.Panel panel_descripcion;
        private System.Windows.Forms.PictureBox Descripcion_picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ubicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_create_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_last_modifed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Delete_arc;
        private System.Windows.Forms.Button Open_archivo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_MOD_DES;
        private System.Windows.Forms.ToolStripMenuItem MS_RAW_DES;
        private System.Windows.Forms.Panel panel_raw_data;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MS_DES_RAW;
        private System.Windows.Forms.ToolStripMenuItem MS_MOD_RAW;
        private System.Windows.Forms.Panel panel_modificacion;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem MS_DES_MOD;
        private System.Windows.Forms.ToolStripMenuItem MS_RAW_MOD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Grid_view_button;
        private System.Windows.Forms.Button Flow_button;
        private System.Windows.Forms.DataGridView DG_ARCHIVOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_SIZE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_CREATED_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_LAST_MOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_FORMATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_PATH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_DESCRIPCION_MOD;
        private System.Windows.Forms.TextBox TB_DIRECCION_MOD;
        private System.Windows.Forms.TextBox TB_NOMBRE_MOD;
        private System.Windows.Forms.Button CHANGE_ADDRESS;
        private System.Windows.Forms.FolderBrowserDialog FBD_CHANGE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button New_folder_but;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Select_general_address;
        private System.Windows.Forms.Label lbl_current_address;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.FolderBrowserDialog FBD_GENERAL;
        private System.Windows.Forms.Button Select_archive_des;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog OFD_DESCRIPCIONES;
        private System.Windows.Forms.Button Save_des;
        private System.Windows.Forms.Button Save_archive_des;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.SaveFileDialog SFD_DESCRIPCIONES;
    }
}

