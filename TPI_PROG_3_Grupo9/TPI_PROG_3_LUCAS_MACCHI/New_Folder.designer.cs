
namespace TPI_PROG_3_Grupo9
{
    partial class New_Folder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Folder_Address = new System.Windows.Forms.Button();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.LBL_ADDRESS = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la Carpeta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ubicacion";
            // 
            // Folder_Address
            // 
            this.Folder_Address.Location = new System.Drawing.Point(138, 150);
            this.Folder_Address.Name = "Folder_Address";
            this.Folder_Address.Size = new System.Drawing.Size(75, 23);
            this.Folder_Address.TabIndex = 2;
            this.Folder_Address.Text = "Seleccionar";
            this.Folder_Address.UseVisualStyleBackColor = true;
            this.Folder_Address.Click += new System.EventHandler(this.Folder_Address_Click);
            // 
            // TB_NAME
            // 
            this.TB_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NAME.Location = new System.Drawing.Point(17, 74);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(289, 31);
            this.TB_NAME.TabIndex = 3;
            this.TB_NAME.TextChanged += new System.EventHandler(this.TB_NAME_TextChanged);
            // 
            // LBL_ADDRESS
            // 
            this.LBL_ADDRESS.AutoSize = true;
            this.LBL_ADDRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ADDRESS.Location = new System.Drawing.Point(12, 189);
            this.LBL_ADDRESS.Name = "LBL_ADDRESS";
            this.LBL_ADDRESS.Size = new System.Drawing.Size(0, 20);
            this.LBL_ADDRESS.TabIndex = 4;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(421, 312);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(124, 23);
            this.Save.TabIndex = 5;
            this.Save.Text = "Guardar y Salir";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(3, 312);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(79, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // New_Folder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 347);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.LBL_ADDRESS);
            this.Controls.Add(this.TB_NAME);
            this.Controls.Add(this.Folder_Address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "New_Folder";
            this.Text = "New_Folder";
            this.Load += new System.EventHandler(this.New_Folder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Folder_Address;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.Label LBL_ADDRESS;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
    }
}