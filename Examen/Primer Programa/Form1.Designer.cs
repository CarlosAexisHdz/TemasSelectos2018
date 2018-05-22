namespace Entrenamiento
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
            this.AgregarObjeto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreObjeto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GuardarDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Finalizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ObjetosRegistrados = new System.Windows.Forms.CheckedListBox();
            this.EliminarArchivo = new System.Windows.Forms.Button();
            this.ObjetosAgregados = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Capturar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Parametro_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parametro_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parametro_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarObjeto
            // 
            this.AgregarObjeto.Location = new System.Drawing.Point(229, 20);
            this.AgregarObjeto.Name = "AgregarObjeto";
            this.AgregarObjeto.Size = new System.Drawing.Size(107, 23);
            this.AgregarObjeto.TabIndex = 0;
            this.AgregarObjeto.Text = "Agregar Objeto";
            this.AgregarObjeto.UseVisualStyleBackColor = true;
            this.AgregarObjeto.Click += new System.EventHandler(this.AgregarObjeto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Objeto";
            // 
            // NombreObjeto
            // 
            this.NombreObjeto.Location = new System.Drawing.Point(114, 22);
            this.NombreObjeto.Name = "NombreObjeto";
            this.NombreObjeto.Size = new System.Drawing.Size(100, 20);
            this.NombreObjeto.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parametro_1,
            this.Parametro_2,
            this.Parametro_3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 230);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // GuardarDatos
            // 
            this.GuardarDatos.Location = new System.Drawing.Point(110, 354);
            this.GuardarDatos.Name = "GuardarDatos";
            this.GuardarDatos.Size = new System.Drawing.Size(104, 23);
            this.GuardarDatos.TabIndex = 4;
            this.GuardarDatos.Text = "Guardar Datos";
            this.GuardarDatos.UseVisualStyleBackColor = true;
            this.GuardarDatos.Click += new System.EventHandler(this.GuardarDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Objetos Agregados Recientemente";
            // 
            // Finalizar
            // 
            this.Finalizar.Location = new System.Drawing.Point(570, 302);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(75, 23);
            this.Finalizar.TabIndex = 8;
            this.Finalizar.Text = "Finalizar";
            this.Finalizar.UseVisualStyleBackColor = true;
            this.Finalizar.Click += new System.EventHandler(this.Finalizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Objetos Registrados";
            // 
            // ObjetosRegistrados
            // 
            this.ObjetosRegistrados.BackColor = System.Drawing.Color.LightCoral;
            this.ObjetosRegistrados.CheckOnClick = true;
            this.ObjetosRegistrados.FormattingEnabled = true;
            this.ObjetosRegistrados.Location = new System.Drawing.Point(457, 180);
            this.ObjetosRegistrados.Name = "ObjetosRegistrados";
            this.ObjetosRegistrados.Size = new System.Drawing.Size(188, 94);
            this.ObjetosRegistrados.TabIndex = 13;
            // 
            // EliminarArchivo
            // 
            this.EliminarArchivo.Location = new System.Drawing.Point(457, 302);
            this.EliminarArchivo.Name = "EliminarArchivo";
            this.EliminarArchivo.Size = new System.Drawing.Size(99, 23);
            this.EliminarArchivo.TabIndex = 14;
            this.EliminarArchivo.Text = "Eliminar Objetos";
            this.EliminarArchivo.UseVisualStyleBackColor = true;
            this.EliminarArchivo.Click += new System.EventHandler(this.EliminarArchivo_Click);
            // 
            // ObjetosAgregados
            // 
            this.ObjetosAgregados.BackColor = System.Drawing.Color.LightCoral;
            this.ObjetosAgregados.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ObjetosAgregados.FormattingEnabled = true;
            this.ObjetosAgregados.Location = new System.Drawing.Point(457, 36);
            this.ObjetosAgregados.Name = "ObjetosAgregados";
            this.ObjetosAgregados.Size = new System.Drawing.Size(188, 95);
            this.ObjetosAgregados.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Lectura";
            // 
            // Capturar
            // 
            this.Capturar.Location = new System.Drawing.Point(350, 82);
            this.Capturar.Name = "Capturar";
            this.Capturar.Size = new System.Drawing.Size(75, 23);
            this.Capturar.TabIndex = 20;
            this.Capturar.Text = "Capturar";
            this.Capturar.UseVisualStyleBackColor = true;
            this.Capturar.Click += new System.EventHandler(this.Capturar_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Parametro_1
            // 
            this.Parametro_1.HeaderText = "Parametro 1";
            this.Parametro_1.Name = "Parametro_1";
            this.Parametro_1.Width = 140;
            // 
            // Parametro_2
            // 
            this.Parametro_2.HeaderText = "Parametro 2";
            this.Parametro_2.Name = "Parametro_2";
            this.Parametro_2.Width = 140;
            // 
            // Parametro_3
            // 
            this.Parametro_3.HeaderText = "Parametro 3";
            this.Parametro_3.Name = "Parametro_3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(657, 389);
            this.Controls.Add(this.Capturar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ObjetosAgregados);
            this.Controls.Add(this.EliminarArchivo);
            this.Controls.Add(this.ObjetosRegistrados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Finalizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GuardarDatos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NombreObjeto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarObjeto);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "Form1";
            this.Text = "Objetos de Estudio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarObjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreObjeto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GuardarDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Finalizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox ObjetosRegistrados;
        private System.Windows.Forms.Button EliminarArchivo;
        private System.Windows.Forms.ListBox ObjetosAgregados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Capturar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parametro_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parametro_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parametro_3;
    }
}

