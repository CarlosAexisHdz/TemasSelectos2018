using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasificador
{
    class Calculo
    {
        public enum MetodoIntegral
        {
            Rectangulo, Trapezio, Simpson, TrapecioCompuesto, SimpsonCompuesto, Pmedio, Extrapolacion, Gauss, Adaptativos
        }

        /// <summary>
        /// Regresa el valor de la integral 
        /// </summary>
        /// <param name="x">Valores en X</param>
        /// <param name="y">Valores en Y</param>
        /// <param name="ini">Limite inicial de la integral</param>
        /// <param name="fin">Limite superior de la integral</param>
        /// <param name="metodoIntegral">Metodo de integracion</param>
        /// <returns></returns>
        public double Integral(double[] x, double[] y, double ini, double fin, MetodoIntegral metodoIntegral)
        {
            double paso = x[1] - x[0];
            double salida = 0;

            switch (metodoIntegral)
            {
                case MetodoIntegral.Rectangulo:
                    double[] temp = Rectangulo(x, y);
                    salida = CumSum(temp, ini, fin, paso, x[0]);
                    break;

                case MetodoIntegral.Trapezio:
                    salida = Trapecio(x, y, ini, fin, paso);
                    break;

                case MetodoIntegral.Simpson:
                    salida = Simpson(x, y, ini, fin, paso);
                    break;

                case MetodoIntegral.TrapecioCompuesto:
                    salida = TrapecioCompuesto(x, y, ini, fin, paso);
                    break;

                case MetodoIntegral.SimpsonCompuesto:
                    salida = SimpsonCompuesto(x, y, ini, fin, paso);
                    break;

                case MetodoIntegral.Extrapolacion:
                    salida = Extrapolacion(y, ini, fin);
                    break;

                case MetodoIntegral.Pmedio:
                    salida = Pmedio(x, y, ini, fin);
                    break;

                default:
                    break;
            }
            return salida;
        }

        public double[] Integral(double[] x, double[] y)
        {


            double[] Y = new double[y.Length - 1];
            double h = x[1] - x[0];
            for (int i = 0; i < Y.Length; i++)
            {

                Y[i] = h * y[i];

            }

            return Y;
        }
        public double[] Integral(double paso, double[] y)
        {


            double[] Y = new double[y.Length - 1];
            double h = paso;
            for (int i = 0; i < Y.Length; i++)
            {

                Y[i] = h * y[i];

            }

            return Y;
        }

        /// <summary>
        /// Regresa el valor de la integral definida por el metodo del Rectangulo
        /// </summary>
        /// <param name="x">Valores X de la funcion</param>
        /// <param name="y">Valores Y de la funcion</param>
        /// <param name="ini">Limite inferior de la integral</param>
        /// <param name="fin">Limite superior de la integral</param>
        /// <param name="paso">Valore de paso en los valores de X</param>
        /// <returns></returns>
        private double[] Rectangulo(double[] x, double[] y)
        {
            double[] Y = new double[y.Length];
            double h = x[1] - x[0];
            for (int i = 0; i < y.Length; i++)
            {
                Y[i] = h * y[i];
            }
            return Y;

        }

        /// <summary>
        /// suma el área de los rectangulos
        /// </summary>
        /// <param name="Y">arreglo de areas de los resctangulos</param>
        /// <param name="ini">limite inferior de la integral</param>
        /// <param name="fin">limite superior de la integral</param>
        /// <param name="h">paso entre los valores</param>
        /// <param name="xini">valor inicial del arreglo "X"</param>
        /// <returns></returns>
        private double CumSum(double[] Y, double ini, double fin, double h, double xini)
        {
            double salida = 0;
            for (int i = (int)((ini - xini) / h); i <= (int)((fin - xini) / h); i++)
            {
                salida += Y[i];
            }
            return salida;

        }

        /// <summary>
        /// Regresa el valor de la integral definida por el metodo del Trapecio
        /// </summary>
        /// <param name="x">Valores X de la funcion</param>
        /// <param name="y">Valores Y de la funcion</param>
        /// <param name="ini">Limite inferior de la integral</param>
        /// <param name="fin">Limite superior de la integral</param>
        /// <param name="paso">Valore de paso en los valores de X</param>
        /// <returns></returns>
        private double Trapecio(double[] x, double[] y, double ini, double fin, double paso)
        {
            double c = y[(int)((ini - x[0]) / paso)];
            double d = y[(int)((fin - x[0]) / paso)];
            double h = (fin - ini);
            double result = h / 2 * (y[(int)((ini - x[0]) / paso)] + y[(int)((fin - x[0]) / paso)]);
            return result;
        }

        /// <summary>
        /// Regresa el valor de la integral por el metodo de Simpson 1/3
        /// </summary>
        /// <param name="x">Valores X de la funcion</param>
        /// <param name="y">Valores Y de la funcion</param>
        /// <param name="ini">Limite inferior de la integral</param>
        /// <param name="fin">Limite superior de la integral</param>
        /// <param name="paso">Valore de paso en los valores de X</param>
        /// <returns></returns>
        private double Simpson(double[] x, double[] y, double ini, double fin, double paso)
        {
            double h = (fin - ini) / 2;

            double result = h * (y[(int)((ini - x[0]) / paso)] + y[(int)((fin - x[0]) / paso)] + 4 * (y[(int)((h + ini - x[0]) / paso)])) / 3;
            return result;
        }

        /// <summary>
        /// Regresa el valor de la integral definida por el metodo del Trapecio Compuesto
        /// </summary>
        /// <param name="x">Valores X de la funcion</param>
        /// <param name="y">Valores Y de la funcion</param>
        /// <param name="ini">Limite inferior de la integral</param>
        /// <param name="fin">Limite superior de la integral</param>
        /// <param name="paso">Valore de paso en los valores de X</param>
        /// <returns></returns>
        private double TrapecioCompuesto(double[] x, double[] y, double ini, double fin, double paso)
        {
            double result = y[(int)((ini - x[0]) / paso)] + y[(int)((fin - x[0]) / paso)];
            for (int i = (int)((ini - x[0]) / paso) + 1; i < (int)((fin - x[0]) / paso); i++)
            {
                result += 2 * y[i];
            }

            result = result * (paso / 2);
            return result;
        }


        /// <summary>
        /// Regresa el valor de la integral por el metodo de Simpson Compuesto
        /// </summary>
        /// <param name="x">Valores X de la funcion</param>
        /// <param name="y">Valores Y de la funcion</param>
        /// <param name="ini">Limite inferior de la integral</param>
        /// <param name="fin">Limite superior de la integral</param>
        /// <param name="paso">Valore de paso en los valores de X</param>
        /// <returns></returns>
        private double SimpsonCompuesto(double[] x, double[] y, double ini, double fin, double paso)
        {
            double result = y[(int)((ini - x[0]) / paso)] + y[(int)((fin - x[0]) / paso)];
            double pares = 0;
            double resto = 0;
            for (int i = (int)((ini - x[0]) / paso) + 1; i < (int)((fin - x[0]) / paso); i++)
            {
                if (i % 2 == 0)
                {
                    pares += 2 * y[i];
                }

                else
                {
                    resto += 4 * y[i];
                }
            }

            result = paso * (result + pares + resto) / 3;
            return result;
        }

        /// <summary>
        /// Regresa la interpolacion de un valor por el metodo de Lagrange
        /// </summary>
        /// <param name="x">Valores X de la funcion</param>
        /// <param name="y">Valores Y de la funcion</param>
        /// <param name="valor">Valor en X a interpolar</param>
        /// <returns></returns>
        public double Interpolacion(double[] x, double[] y, double valor)
        {
            double result = 0;
            double auxiliar = 1;
            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (i != j)
                    {
                        auxiliar = auxiliar * ((valor - x[j]) / (x[i] - x[j]));

                    }
                }

                result = result + y[i] * auxiliar;
                auxiliar = 1;
            }
            return result;

        }

        /// <summary>
        /// Funcion Gamma auxiliar para distribuiones de probabilidad
        /// para valores pares
        /// </summary>
        /// <param name="v">Valor a evaluar</param>
        /// <returns></returns>
        public double gammafunc(double v)
        {
            double result = 1;
            if (v == 0)
            {
                result = 1;
            }
            else if (v == 0.5)
            {
                result = Math.Sqrt(Math.PI);
            }
            else if (v % 2 == 0)
            {
                for (int i = 1; i <= v - 1; i++)
                {
                    result = result * i;
                }
            }
            return result;
        }

        //Metodo solo aplicable para tamaño de arreglo "y" divisible entre 4 excepto 4
        private double Extrapolacion(double[] y, double ini, double fin)
        {
            double trapecio_h1 = ((fin - ini) * 0.5) * (y[0] + y[y.Length - 1]);
            double trapecio_h2 = ((fin - ini) / 4) * (y[0] + 2 * y[((y.Length - 1) / 2)] + y[y.Length - 1]);
            double trapecio_h3 = ((fin - ini) / 8) * (y[0] + 2 * (y[(y.Length / 4) - 1] + y[((y.Length / 2) - 1)] + y[((y.Length - 1) * 3 / 4)]) + y[y.Length - 1]);

            double segundo_nivel_a = (4 / 3) * trapecio_h2 - (1 / 3) * trapecio_h1;
            double segundo_nivel_b = (4 / 3) * trapecio_h3 - (1 / 3) * trapecio_h2;

            return (16 / 15) * segundo_nivel_b - (1 / 15) * segundo_nivel_a;

        }

        private double Pmedio(double[] x, double[] y, double ini, double fin)
        {
            //double[] Y = new double[y.Length];
            //double h = x[1] - x[0];
            double suma = 0;

            for (int i = 1; i < y.Length; i += 2)
            {
                suma += y[i];
            }

            return ((fin - ini) / (2 * ((x.Length - 1)) * 0.5)) * (2 * suma + ((y[0] + y[y.Length - 1]) / 4) - ((y[1] + y[y.Length - 2]) / 4));

        }

        #region Derivada
        public double[] diff(double[] f)
        {
            double[] salida = new double[f.Length - 1];
            for (int i = 0; i <= salida.Length - 1; i++)
            {
                salida[i] = f[i + 1] - f[i];

            }
            return salida;
        }
        public double[] diff(double[] f, double paso)
        {
            double[] salida = new double[f.Length - 1];
            for (int i = 0; i <= salida.Length - 1; i++)
            {
                salida[i] = (f[i + 1] - f[i]) / paso;

            }
            return salida;
        }

        #endregion


    }
}
