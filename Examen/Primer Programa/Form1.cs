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
using System.Text.RegularExpressions;

namespace Entrenamiento
{
    public partial class Form1 : Form
    {
        string objeto;
        string data_folder = Application.StartupPath + @"\Data";
        string file_name;

        public Form1()
        {
            InitializeComponent();
            MostrarObjetosRegistrados();
            CrearCarpeta();
            dataGridView1.Enabled = false;
            GuardarDatos.Enabled = false;
        }


        /// <summary>
        /// Crea una carpeta que contendrá los archivos con las muestras
        /// </summary>
        private void CrearCarpeta()
        {
            if (Directory.Exists(data_folder))
            {
            }
            else
            {
                Directory.CreateDirectory(data_folder);
            }
        }

        private void AgregarObjeto_Click(object sender, EventArgs e)
        {
            this.objeto = NombreObjeto.Text;
            dataGridView1.Enabled = true;
            GuardarDatos.Enabled = true;
            dataGridView1.Rows.Clear();
            CrearArchivo();
        }

        private void GuardarDatos_Click(object sender, EventArgs e)
        {
            int[] tamaño = Tamaño_Muestra();
            double[] parametro1 = new double[tamaño[0]+1];
            double[] parametro2 = new double[tamaño[1]+1];
            dataGridView1.Enabled = false;
            GuardarDatos.Enabled = false;

            try
            {
                for (int i = 0; i < tamaño[0]; i++)
                {
                    parametro1[i] = double.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                }
                for (int i = 0; i < tamaño[1]; i++)
                {
                    parametro2[i] = double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }

                dataGridView1.Rows.Clear();
                NombreObjeto.Clear();
                GuardarDatosArchivo(parametro1, parametro2);

            }
            catch (Exception ex)
            {
                File.Delete(data_folder + file_name);
                MessageBox.Show("Ingresa solo valores numericos");
            }

        }

        
        /// <summary>
        /// Calcula el tamaño de la muestra para cada parametro
        /// </summary>
        /// <returns>Regresa el tamaño de las muestras</returns>
        private int[] Tamaño_Muestra()
        {
            int[] tamaño = new int[2];
            int tamaño_1 = 0;
            int tamaño_2 = 0;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    tamaño_1 += 1;
                }

                if (dataGridView1.Rows[i].Cells[1].Value != null)
                {
                    tamaño_2 += 1;
                }

            }
                
            tamaño[0] = tamaño_1;
            tamaño[1] = tamaño_2;

            return tamaño;

        }

        /// <summary>
        /// Crea un archivo con el nombre del objeto
        /// </summary>
        private void CrearArchivo()
        {
            this.file_name =@"\" + objeto + ".txt";

            if (File.Exists(data_folder + file_name))
            {
                MessageBox.Show("Ese Objeto ya se agregó");
                dataGridView1.Enabled = false;
                GuardarDatos.Enabled = false;
                dataGridView1.Rows.Clear();
            }
            else
            {
                using (File.Create(data_folder + file_name));
            }
            
        }

        /// <summary>
        /// Almacena los datos de la muestra en el archivo correspondiente
        /// </summary>
        /// <param name="parametro1">Datos de la muestra para el primer parametro</param>
        /// <param name="parametro2">Datos de la muestra para el segundo parametro</param>
        private void GuardarDatosArchivo(double[] parametro1, double[] parametro2)
        {
            
            StreamWriter archivo = new StreamWriter(data_folder + file_name);
            archivo.Write("Parametro1");
            for (int i = 0; i < parametro1.Length - 1; i++)
            {
                archivo.Write(";" + parametro1[i].ToString());
            }
            archivo.WriteLine("");
            archivo.Write("Parametro2");
            for (int i = 0; i < parametro2.Length - 1; i++)
            {
                archivo.Write(";" + parametro2[i].ToString());
            }
            archivo.WriteLine("");
            MostrarObjetos();
            archivo.Close();
        }

        /// <summary>
        /// Muestra los objetos que se agregaron recientemente
        /// </summary>
        private void MostrarObjetos()
        {
            ObjetosAgregados.Items.Add(objeto);
        }

        /// <summary>
        /// Muestra los objetos que estan registrados
        /// </summary>
        private void MostrarObjetosRegistrados()
        {
            string[] files = Directory.GetFiles(data_folder);
            for (int i = 0; i < files.Length ; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                ObjetosRegistrados.Items.Add(info.Name);
            }
        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string[] datos = Regex.Split(Clipboard.GetText().ToString(), "\r\n");
                string[] auxiliar = new string[2]; 

                if (datos[0].Contains('\t'))
                {
                    for (int i = 0; i < datos.Length-1; i++)
                    {
                        auxiliar = datos[i].Split('\t');
                        dataGridView1.Rows.Add();
                        if (auxiliar[0] != "")
                        {
                            dataGridView1.Rows[i].Cells[0].Value = auxiliar[0].ToString();
                        }

                        if (auxiliar[1] != "")
                        {
                            dataGridView1.Rows[i].Cells[1].Value = auxiliar[1].ToString();
                        }
                    }
                }
            }
        }
    }
}
