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
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Clasificador
{
    public partial class Form1 : Form
    {
        string data_folder = @"Data";
        string[] data;
        string puerto = "COM3";
        string folder_path;
        string[] name_files;
        Objeto[] objetos;
        bool objeto_encontrado = true;
        List<string> objetosposibles1 = new List<string>();
        List<string> objetosposibles2 = new List<string>();
        List<string> objetosposibles3 = new List<string>();
        double parametro1;
        double parametro2;
        double parametro3;
        Dictionary<string, double> probabilidades1 = new Dictionary<string, double>();
        Dictionary<string, double> probabilidades2 = new Dictionary<string, double>();
        Dictionary<string, double> probabilidades3 = new Dictionary<string, double>();
        Dictionary<string, double> probabilidadtotal = new Dictionary<string, double>();
        KeyValuePair<string, double> resultado;

        public Form1()
        {
            InitializeComponent();
            Graficador1.Series.Clear();
            Graficador2.Series.Clear();
            Graficador3.Series.Clear();
            serialPort1.PortName = puerto;
            serialPort1.Open();
            Graficador1.Titles.Add("Posibles objetos de Acuerdo al Parametro 1");
            Graficador2.Titles.Add("Posibles objetos de Acuerdo al Parametro 2");
            Graficador3.Titles.Add("Posibles objetos de Acuerdo al Parametro 3");
            this.folder_path = PathDirectorio();
            this.name_files = Files(folder_path);
            LecturaMuestras();

        }
        #region Manejo de Archivos

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
            if (files.Length == 0)
            {
                MessageBox.Show("No hay base de datos");
                Parametro_1.Enabled = false;
                Parametro_2.Enabled = false;
                Parametro_3.Enabled = false;
            }
            else
            {
                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo info = new FileInfo(files[i]);
                    files[i] = info.Name;
                }

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
            string[] muestras_parametro3;
            double[] parametros1;
            double[] parametros2;
            double[] parametros3;
            string auxiliar;
            objetos = new Objeto[name_files.Length];
            int i = 0;
            foreach (string name in name_files)
            {
                StreamReader lectura = new StreamReader(folder_path + data_folder + @"\" + name);
                auxiliar = lectura.ReadLine();
                muestras_parametro1 = auxiliar.Split(';');
                parametros1 = ConversionDobles(muestras_parametro1);
                auxiliar = lectura.ReadLine();
                muestras_parametro2 = auxiliar.Split(';');
                parametros2 = ConversionDobles(muestras_parametro2);
                auxiliar = lectura.ReadLine();
                muestras_parametro3 = auxiliar.Split(';');
                parametros3 = ConversionDobles(muestras_parametro3);
                objetos[i] = new Objeto(name.Remove(name.Length - 4, 4), parametros1, parametros2, parametros3);
                objetos[i].Calc();
                objetos[i].Linespace(objetos[i].Mean - 4 * objetos[i].Std, objetos[i].Mean + 4 * objetos[i].Std, 0.01, "1");
                objetos[i].Linespace(objetos[i].Mean2 - 4 * objetos[i].Std2, objetos[i].Mean2 + 4 * objetos[i].Std2, 0.01, "2");
                objetos[i].Linespace(objetos[i].Mean3 - 4 * objetos[i].Std3, objetos[i].Mean3 + 4 * objetos[i].Std3, 0.01, "3");
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
            for (int i = 1; i < datos.Length; i++)
            {
                muestra[i - 1] = double.Parse(datos[i]);
            }
            return muestra;
        }

        #endregion

        #region Calculos

        /// <summary>
        /// Lee los datos ingresados desde la interfaz gráfica
        /// </summary>
        private void LecturaParametros()
        {
            try
            {
                this.parametro1 = double.Parse(Parametro_1.Text.ToString());
                this.parametro2 = double.Parse(Parametro_2.Text.ToString());
                this.parametro3 = double.Parse(Parametro_3.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingresa solo valores numericos");
                Parametro_1.Enabled = false;
                Parametro_2.Enabled = false;
                Parametro_3.Enabled = false;
            }

        }

        /// <summary>
        /// Determinar los posiles objetos con base a los parametros ingresador
        /// </summary>
        /// <param name="caso"></param>
        private void PosiblesObjetos(string caso)
        {
            switch (caso)
            {
                case "1":
                    foreach (Objeto i in objetos)
                    {
                        if (i.Mean - 4 * i.Std < parametro1 && parametro1 < i.Mean + 4 * i.Std)
                        {
                            i.normpdf(i.fx, i.Mean, i.Std, "1");
                            objetosposibles1.Add(i.Nombre);
                            Probabilidad(i, parametro1, "1");
                            Plot(i, "1");
                        }
                    }

                    break;
                case "2":
                    foreach (Objeto i in objetos)
                    {
                        if (i.Mean2 - 4 * i.Std2 < parametro2 && parametro2 < i.Mean2 + 4 * i.Std2)
                        {
                            i.normpdf(i.fx2, i.Mean2, i.Std2, "2");
                            objetosposibles2.Add(i.Nombre);
                            Probabilidad(i, parametro2, "2");
                            Plot(i, "2");
                        }
                    }
                    break;
                case "3":  foreach (Objeto i in objetos)
                    {
                        if (i.Mean3 - 4 * i.Std3 < parametro3 && parametro3 < i.Mean3 + 4 * i.Std3)
                        {
                            i.normpdf(i.fx3, i.Mean3, i.Std3, "3");
                            objetosposibles3.Add(i.Nombre);
                            Probabilidad(i, parametro3, "3");
                            Plot(i, "3");
                        }
                    }
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// Calcula las probabilidades de cada parametro
        /// </summary>
        /// <param name="i"></param>
        /// <param name="parametro"></param>
        /// <param name="caso"></param>
        private void Probabilidad(Objeto i, double parametro, string caso)
        {
            switch (caso)
            {
                case "1":
                    if (parametro > i.Mean)
                    {
                        Calculo calculo = new Calculo();
                        double prob = 2*calculo.Integral(i.fx, i.fy, parametro, i.Mean + 4 * i.Std, Calculo.MetodoIntegral.SimpsonCompuesto);
                        probabilidades1.Add(i.Nombre, prob);
                    }
                    else if(parametro <= i.Mean)
                    {
                        Calculo calculo = new Calculo();
                        double prob = 2*calculo.Integral(i.fx, i.fy, i.Mean - 4 * i.Std, parametro, Calculo.MetodoIntegral.SimpsonCompuesto);
                        probabilidades1.Add(i.Nombre, prob);
                    }
                    break;

                case "2":
                    if (parametro > i.Mean2)
                    {
                        Calculo calculo = new Calculo();
                        double prob = 2*calculo.Integral(i.fx2, i.fy2, parametro, i.Mean2 + 4 * i.Std2, Calculo.MetodoIntegral.SimpsonCompuesto);
                        probabilidades2.Add(i.Nombre, prob);
                    }
                    else if (parametro <= i.Mean2)
                    {
                        Calculo calculo = new Calculo();
                        double prob = 2*calculo.Integral(i.fx2, i.fy2, i.Mean2 - 4 * i.Std2, parametro, Calculo.MetodoIntegral.SimpsonCompuesto);
                        probabilidades2.Add(i.Nombre, prob);
                    }
                    break;
                case "3":
                    if (parametro > i.Mean3)
                    {
                        Calculo calculo = new Calculo();
                        double prob = 2 * calculo.Integral(i.fx3, i.fy3, parametro, i.Mean3 + 4 * i.Std3, Calculo.MetodoIntegral.SimpsonCompuesto);
                        probabilidades3.Add(i.Nombre, prob);
                    }
                    else if (parametro <= i.Mean3)
                    {
                        Calculo calculo = new Calculo();
                        
                        double prob = 2 * calculo.Integral(i.fx3, i.fy3, i.Mean3 - 4 * i.Std3, parametro, Calculo.MetodoIntegral.SimpsonCompuesto);
                        probabilidades3.Add(i.Nombre, prob);
                    }
                    break;

                default:
                    break;

            }
            
            
        }

        /// <summary>
        /// Calcula la probabilidad total
        /// </summary>
        private void ProbabilidadTotal()
        {
            if (objetosposibles1.ToArray().Length == 0 && objetosposibles2.ToArray().Length == 0)
            {
                foreach (KeyValuePair<string, double> i in probabilidades3)
                {
                    probabilidadtotal.Add(i.Key, i.Value);

                }
            }

            else if (objetosposibles2.ToArray().Length == 0 && objetosposibles3.ToArray().Length == 0)
            {
                foreach (KeyValuePair<string, double> i in probabilidades1)
                {
                    probabilidadtotal.Add(i.Key, i.Value);

                }
            }

            else if (objetosposibles3.ToArray().Length == 0 && objetosposibles1.ToArray().Length == 0)
            {
                foreach (KeyValuePair<string, double> i in probabilidades2)
                {
                    probabilidadtotal.Add(i.Key, i.Value);

                }
            }

            else
            {
                foreach (KeyValuePair<string, double> i in probabilidades1)
                {
                    if (probabilidades3.ContainsKey(i.Key) && probabilidades2.ContainsKey(i.Key))
                    {
                        double prob = probabilidades2[i.Key] * probabilidades3[i.Key] * i.Value;
                        probabilidadtotal.Add(i.Key, prob);
                    }
                    else if (probabilidades3.ContainsKey(i.Key))
                    {
                        double prob = probabilidades3[i.Key] * i.Value;
                        probabilidadtotal.Add(i.Key, prob);
                    }
                    else if (probabilidades2.ContainsKey(i.Key))
                    {
                        double prob = probabilidades2[i.Key] * i.Value;
                        probabilidadtotal.Add(i.Key, prob);
                    }

                    else
                    {
                        probabilidadtotal.Add(i.Key, i.Value);
                    }
                }
                foreach (KeyValuePair<string, double> i in probabilidades2)
                {
                    if (probabilidadtotal.ContainsKey(i.Key))
                    {

                    }
                    else if (probabilidades1.ContainsKey(i.Key) && probabilidades3.ContainsKey(i.Key))
                    {
                        double prob = probabilidades3[i.Key] * probabilidades1[i.Key] * i.Value;
                        probabilidadtotal.Add(i.Key, prob);
                    }
                    else if (probabilidades1.ContainsKey(i.Key))
                    {
                        double prob = probabilidades1[i.Key] * i.Value;
                        probabilidadtotal.Add(i.Key, prob);
                    }
                    else
                    {
                        probabilidadtotal.Add(i.Key, i.Value);
                    }
                }
                foreach (KeyValuePair<string, double> i in probabilidades3)
                {
                    if (probabilidadtotal.ContainsKey(i.Key))
                    {

                    }
                    else if (probabilidades1.ContainsKey(i.Key) && probabilidades2.ContainsKey(i.Key))
                    {
                        double prob = probabilidades2[i.Key] * probabilidades1[i.Key] * i.Value;
                        probabilidadtotal.Add(i.Key, prob);
                    }
                    else if (probabilidades2.ContainsKey(i.Key))
                    {
                        double prob = probabilidades2[i.Key] * i.Value;
                        probabilidadtotal.Add(i.Key, prob);
                    }
                    else
                    {
                        probabilidadtotal.Add(i.Key, i.Value);
                    }
                }
            }
            
        }

        #endregion

        #region Interfaz Gráfica

        /// <summary>
        /// Grafica los posibles objetos
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="caso"></param>
        private void Plot(Objeto objeto, string caso)
        {
            int indice;
            switch (caso)
            {
                case "1":
                    Graficador1.Series.Add(objeto.Nombre);
                    indice = Graficador1.Series.IndexOf(objeto.Nombre);
                    for (int i = 0; i < objeto.fx.Length; i++)
                    {
                        Graficador1.Series[indice].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        Graficador1.Series[indice].Points.AddXY(objeto.fx[i], objeto.fy[i]);
                    }
                    break;
                case "2":
                    Graficador2.Series.Add(objeto.Nombre);
                    indice = Graficador2.Series.IndexOf(objeto.Nombre);
                    for (int i = 0; i < objeto.fx2.Length; i++)
                    {
                        Graficador2.Series[indice].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        Graficador2.Series[indice].Points.AddXY(objeto.fx2[i], objeto.fy2[i]);
                    }
                    break;
                case "3":
                    Graficador3.Series.Add(objeto.Nombre);
                    indice = Graficador3.Series.IndexOf(objeto.Nombre);
                    for (int i = 0; i < objeto.fx3.Length; i++)
                    {
                        Graficador3.Series[indice].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        Graficador3.Series[indice].Points.AddXY(objeto.fx3[i], objeto.fy3[i]);
                    }
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// Muestra las probabilidades de cada objeto
        /// </summary>
        private void MostrarProbabilidades()
        {
            CheckForIllegalCrossThreadCalls = false;
            foreach (KeyValuePair<string, double> objeto in probabilidadtotal)
            {
                ProbabilidadesFinales.Items.Add(objeto.Key + ": " + (Math.Round(objeto.Value, 10)).ToString());
            }
        }

        #endregion

        #region Eventos de la Interfaz Gráfica
        private void Clasificar()
        {
            
            CheckForIllegalCrossThreadCalls = false;
            Parametro_1.Enabled = false;
            Parametro_2.Enabled = false;
            Parametro_3.Enabled = false;
            LecturaParametros();
            PosiblesObjetos("1");
            PosiblesObjetos("2");
            PosiblesObjetos("3");
            string[] auxiliar = objetosposibles1.ToArray();
            string[] auxiliar2 = objetosposibles2.ToArray();
            string[] auxiliar3 = objetosposibles3.ToArray();
            int cont = 0;
            int cont2 = 0;
            foreach (string i in objetosposibles1)
            {
                if (objetosposibles2.Contains(i))
                {
                    cont++;
                }
                if (objetosposibles3.Contains(i))
                {
                    cont2++;
                }
            }
            foreach (string i in objetosposibles2)
            {
                if (objetosposibles1.Contains(i))
                {
                    cont++;
                }
                if (objetosposibles3.Contains(i))
                {
                    cont2++;
                }
            }
            foreach (string i in objetosposibles3)
            {
                if (objetosposibles1.Contains(i))
                {
                    cont++;
                }
                if (objetosposibles2.Contains(i))
                {
                    cont2++;
                }
            }
            if (cont == 0 && cont2 == 0)
            {
                foreach (KeyValuePair<string, double> i in probabilidades1)
                {
                    probabilidadtotal.Add(i.Key, i.Value);
                }
                foreach (KeyValuePair<string, double> i in probabilidades2)
                {
                    probabilidadtotal.Add(i.Key, i.Value);
                }
                foreach (KeyValuePair<string, double> i in probabilidades3)
                {
                    probabilidadtotal.Add(i.Key, i.Value);
                }
                
                try
                {

                    
                    double[] prob = probabilidadtotal.Values.ToArray();
                    double max = prob.Max();
                    int index = Array.IndexOf(prob, max);
                    this.resultado = probabilidadtotal.ElementAt(index);
                    Conclusion.Text = resultado.Key;
                    objeto_encontrado = true;
                    if (objeto_encontrado)
                    {
                        MostrarProbabilidades();
                        objeto_encontrado = false;
                    }
                }
                catch (Exception ex)
                {
                    objeto_encontrado = false;
                    Conclusion.Text = "No existen objetos registrados " + Environment.NewLine + "para esos parametros";
                }
            }
            else
            {
                
                try
                {
                    ProbabilidadTotal();
                    double[] prob = probabilidadtotal.Values.ToArray();
                    double max = prob.Max();
                    int index = Array.IndexOf(prob, max);
                    this.resultado = probabilidadtotal.ElementAt(index);
                    Conclusion.Text = resultado.Key;
                    objeto_encontrado = true;
                    if (objeto_encontrado)
                    {
                        MostrarProbabilidades();
                        objeto_encontrado = false;
                    }
                }
                catch (Exception ex)
                {
                    Conclusion.Text = "No existen objetos registrados " + Environment.NewLine + "para esos parametros";
                    objeto_encontrado = false;
                }
                
            }
            
        }
        /// <summary>
        /// Clasifica el objeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Clasificar();
            /*
            Parametro_1.Enabled = false;
            Parametro_2.Enabled = false;
            Parametro_3.Enabled = false;
            LecturaParametros();
            PosiblesObjetos("1");
            PosiblesObjetos("2");
            PosiblesObjetos("3");
            string[] auxiliar = objetosposibles1.ToArray();
            string[] auxiliar2 = objetosposibles2.ToArray();
            string[] auxiliar3 = objetosposibles3.ToArray();
            int cont = 0;
            int cont2 = 0;
            foreach (string i in objetosposibles1)
            {
                if (objetosposibles2.Contains(i))
                {
                    cont++;
                }
                if (objetosposibles3.Contains(i))
                {
                    cont2++;
                }
            }
            foreach (string i in objetosposibles2)
            {
                if (objetosposibles1.Contains(i))
                {
                    cont++;
                }
                if (objetosposibles3.Contains(i))
                {
                    cont2++;
                }
            }
            foreach (string i in objetosposibles3)
            {
                if (objetosposibles1.Contains(i))
                {
                    cont++;
                }
                if (objetosposibles2.Contains(i))
                {
                    cont2++;
                }
            }
            if (cont == 0 && cont2 == 0)
            {
                foreach (KeyValuePair<string, double> i in probabilidades1)
                {
                    probabilidadtotal.Add(i.Key, i.Value);
                }
                foreach (KeyValuePair<string, double> i in probabilidades2)
                {
                    probabilidadtotal.Add(i.Key, i.Value);
                }
                foreach (KeyValuePair<string, double> i in probabilidades3)
                {
                    probabilidadtotal.Add(i.Key, i.Value);
                }
                
                try
                {
                    MostrarProbabilidades();
                    double[] prob = probabilidadtotal.Values.ToArray();
                    double max = prob.Max();
                    int index = Array.IndexOf(prob, max);
                    this.resultado = probabilidadtotal.ElementAt(index);
                    Conclusion.Text = resultado.Key;
                }
                catch (Exception ex)
                {
                    Conclusion.Text = "No existen objetos registrados " + Environment.NewLine + "para esos parametros";

                }
            }
            else
            {
                try
                {
                    ProbabilidadTotal();
                    MostrarProbabilidades();
                    double[] prob = probabilidadtotal.Values.ToArray();
                    double max = prob.Max();
                    int index = Array.IndexOf(prob, max);
                    this.resultado = probabilidadtotal.ElementAt(index);
                    Conclusion.Text = resultado.Key;

                }
                catch (Exception ex)
                {
                    Conclusion.Text = "No existen objetos registrados " + Environment.NewLine + "para esos parametros";

                }
            }
            */
        }
        /// <summary>
        /// Limpia datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Parametro_1.Enabled = true;
            Parametro_2.Enabled = true;
            Parametro_3.Enabled = true;
            Graficador1.Series.Clear();
            Graficador2.Series.Clear();
            Graficador3.Series.Clear();
            probabilidades1.Clear();
            probabilidades2.Clear();
            probabilidades3.Clear();
            probabilidadtotal.Clear();
            objetosposibles1.Clear();
            objetosposibles2.Clear();
            objetosposibles3.Clear();
            Parametro_1.Clear();
            Parametro_2.Clear();
            Parametro_3.Clear();
            ProbabilidadesFinales.Items.Clear();
            Conclusion.Text = "";
        }
        /// <summary>
        /// Finaliza el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Finalizar_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Application.Exit();
        }

        #endregion

        #region Comunicacion Serial
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == true)
                {
                        CheckForIllegalCrossThreadCalls = false;
                        data = Regex.Split(serialPort1.ReadLine().ToString(), ",");
                        int estado = Int32.Parse(data[0]);
                        if (estado == 1 && objeto_encontrado)
                        {
                            ManejoDatos();
                        }
                }
            }
            catch
            { }
        }

        private void ManejoDatos()
        {
            CheckForIllegalCrossThreadCalls = false;
            Parametro_1.Enabled = true;
            Parametro_2.Enabled = true;
            Parametro_3.Enabled = true;
            Graficador1.Series.Clear();
            Graficador2.Series.Clear();
            Graficador3.Series.Clear();
            probabilidades1.Clear();
            probabilidades2.Clear();
            probabilidades3.Clear();
            probabilidadtotal.Clear();
            objetosposibles1.Clear();
            objetosposibles2.Clear();
            objetosposibles3.Clear();
            Parametro_1.Clear();
            Parametro_2.Clear();
            Parametro_3.Clear();
            ProbabilidadesFinales.Items.Clear();
            Conclusion.Text = "";
            Parametro_1.Text = data[1];
            Parametro_2.Text = data[2];
            Parametro_3.Text = data[3].Trim('\r');
            objeto_encontrado = false;
            Clasificar();
            

        }
        #endregion

        
    }
}
