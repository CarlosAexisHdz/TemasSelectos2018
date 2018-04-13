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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AgregarObjeto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreObjeto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Parametro_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parametro_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardarDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Finalizar = new System.Windows.Forms.Button();
            this.ObjetosAgregados = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarObjeto
            // 
            this.AgregarObjeto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AgregarObjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarObjeto.Location = new System.Drawing.Point(67, 60);
            this.AgregarObjeto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgregarObjeto.Name = "AgregarObjeto";
            this.AgregarObjeto.Size = new System.Drawing.Size(107, 24);
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
            this.NombreObjeto.BackColor = System.Drawing.SystemColors.MenuText;
            this.NombreObjeto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NombreObjeto.Location = new System.Drawing.Point(114, 22);
            this.NombreObjeto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombreObjeto.Name = "NombreObjeto";
            this.NombreObjeto.Size = new System.Drawing.Size(100, 20);
            this.NombreObjeto.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parametro_1,
            this.Parametro_2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 144);
            this.dataGridView1.TabIndex = 3;
            // 
            // Parametro_1
            // 
            this.Parametro_1.HeaderText = "Parametro 1";
            this.Parametro_1.Name = "Parametro_1";
            // 
            // Parametro_2
            // 
            this.Parametro_2.HeaderText = "Parametro 2";
            this.Parametro_2.Name = "Parametro_2";
            // 
            // GuardarDatos
            // 
            this.GuardarDatos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GuardarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarDatos.Location = new System.Drawing.Point(81, 286);
            this.GuardarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GuardarDatos.Name = "GuardarDatos";
            this.GuardarDatos.Size = new System.Drawing.Size(104, 24);
            this.GuardarDatos.TabIndex = 4;
            this.GuardarDatos.Text = "Guardar Datos";
            this.GuardarDatos.UseVisualStyleBackColor = true;
            this.GuardarDatos.Click += new System.EventHandler(this.GuardarDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Objetos Agregados Recientemente";
            // 
            // Finalizar
            // 
            this.Finalizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Finalizar.Location = new System.Drawing.Point(405, 286);
            this.Finalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(75, 24);
            this.Finalizar.TabIndex = 8;
            this.Finalizar.Text = "Finalizar";
            this.Finalizar.UseVisualStyleBackColor = true;
            this.Finalizar.Click += new System.EventHandler(this.Finalizar_Click);
            // 
            // ObjetosAgregados
            // 
            this.ObjetosAgregados.BackColor = System.Drawing.SystemColors.MenuText;
            this.ObjetosAgregados.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ObjetosAgregados.FormattingEnabled = true;
            this.ObjetosAgregados.Location = new System.Drawing.Point(359, 60);
            this.ObjetosAgregados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ObjetosAgregados.Name = "ObjetosAgregados";
            this.ObjetosAgregados.Size = new System.Drawing.Size(188, 139);
            this.ObjetosAgregados.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(657, 330);
            this.Controls.Add(this.ObjetosAgregados);
            this.Controls.Add(this.Finalizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GuardarDatos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NombreObjeto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarObjeto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Entrenamiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarObjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreObjeto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parametro_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parametro_2;
        private System.Windows.Forms.Button GuardarDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Finalizar;
        private System.Windows.Forms.CheckedListBox ObjetosAgregados;
    }
}

