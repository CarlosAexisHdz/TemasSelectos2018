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

namespace Clasificador
{
    public partial class Form1 : Form
    {
        string data_folder = @"Data";
        string folder_path;
        string[] name_files;
        Objeto[] objetos;

        public Form1()
        {
            InitializeComponent();
            Graficador1.Titles.Add("Parametro 1");
            Graficador2.Titles.Add("Parametro 2");
            this.folder_path = PathDirectorio();
            this.name_files = Files(folder_path);
            LecturaMuestras();

        }
        /// <summary>
        /// Obtiene la ruta de la carpeta que contiene los archivos
        /// </summary>
        /// <returns></returns>
        private string PathDirectorio()
        {
            string path_folder = Application.StartupPath;
            string[] path = path_folder.Split('\\');
            string folder_path = "";
            for (int i = 0; i < path.Length; i++)
            {
                if (i == path.Length - 4 || i == path.Length - 3)
                {
                    folder_path += "Entrenamiento\\";
                }
                else
                {
                    folder_path += path[i] + "\\";
                }
            }
            return folder_path;
        }

        /// <summary>
        /// Obtiene los nombres de los archivos
        /// </summary>
        /// <param name="folder_path">Ruta de los archivos</param>
        private string[] Files(string folder_path)
        {
            string[] files = Directory.GetFiles(folder_path + data_folder);
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                files[i] = info.Name;
            }
            return files;
        }

        /// <summary>
        /// Hace la lectura de los archivos y crea los objetos
        /// </summary>
        private void LecturaMuestras()
        {
            string[] muestras_parametro1;
            string[] muestras_parametro2;
            double[] parametro1;
            double[] parametro2;
            string auxiliar;
            objetos = new Objeto[name_files.Length];
            int i = 0;
            foreach (string name in name_files)
            {
                StreamReader lectura = new StreamReader(folder_path + data_folder + @"\" + name );
                auxiliar = lectura.ReadLine();
                muestras_parametro1 = auxiliar.Split(';');
                parametro1 = ConversionDobles(muestras_parametro1);
                auxiliar = lectura.ReadLine();
                muestras_parametro2 = auxiliar.Split(';');
                parametro2 = ConversionDobles(muestras_parametro2);
                objetos[i] = new Objeto(name, parametro1, parametro2);
                objetos[i].Calc();
                i++;
            }
            i = 0;
        }

        /// <summary>
        /// Convierte los datos a tipo double
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        private double[] ConversionDobles(string[] datos)
        {
            double[] muestra = new double[datos.Length - 1];
            for (int i = 1; i < datos.Length ; i++)
            {
                muestra[i - 1] = double.Parse(datos[i]);
            }
            return muestra;
        }

        

    }
}
