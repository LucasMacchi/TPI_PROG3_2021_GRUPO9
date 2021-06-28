
namespace TPI_PROG_3_LUCAS_MACCHI
{
    partial class Change_name
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Close_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba el nuevo nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Close_save
            // 
            this.Close_save.Location = new System.Drawing.Point(228, 129);
            this.Close_save.Name = "Close_save";
            this.Close_save.Size = new System.Drawing.Size(105, 23);
            this.Close_save.TabIndex = 2;
            this.Close_save.Text = "Guardar y Cerrar";
            this.Close_save.UseVisualStyleBackColor = true;
            this.Close_save.Click += new System.EventHandler(this.Close_save_Click);
            // 
            // Change_name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 164);
            this.Controls.Add(this.Close_save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Change_name";
            this.Text = "Change_name";
            this.Load += new System.EventHandler(this.Change_name_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Close_save;
    }
}