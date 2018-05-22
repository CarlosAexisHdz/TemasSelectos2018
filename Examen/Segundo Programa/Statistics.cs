using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasificador
{
    class Statistics
    {
        Calculo calculo = new Calculo();

        /// <summary>
        /// Obtine el promedio 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public double Mean(double[] input)
        {
            double prom = 0;
            for (int i = 0; i < input.Length; i++)
            {
                prom = prom + input[i];
            }
            prom = prom / input.Length;
            return prom;
        }
        /// <summary>
        /// obtiene la varianza de la poblacion
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public double Var(double[] input)
        {
            double desv = Std(input);
            return Math.Pow(desv, 2);
        }
        /// <summary>
        /// Obtiene la desviacion de la poblacion
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public double Std(double[] input)
        {
            double prom = Mean(input);
            double desv = 0;
            for (int i = 0; i < input.Length; i++)
            {
                desv = desv + Math.Pow((input[i] - prom), 2);
            }

            desv = desv / input.Length;
            desv = Math.Sqrt(desv);
            return desv;
        }
        /// <summary>
        /// regresa un valor de la funcion de denisidad normal
        /// </summary>
        /// <param name="mean">promedio</param>
        /// <param name="std">desviacion</param>
        /// <param name="input">valor a evaluar</param>
        /// <returns></returns>
        public double Cnorm(double mean, double std, double input)
        {
            double Salida = Math.Exp(-Math.Pow((input - mean), 2) / (2 * Math.Pow(std, 2))) / (std * Math.Sqrt(2 * Math.PI));
            return Salida;
        }
        /// <summary>
        /// Retorna unarreglo con los datos de la distribucion normal
        /// </summary>
        /// <param name="x">Vector eje x</param>
        /// <param name="media"></param>
        /// <param name="std"></param>
        /// <returns></returns>
        public double[] normpdf(double[] x, double media, double std)
        {
            double[] fx = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                fx[i] = Cnorm(media, std, x[i]);
            }
            return fx;
        }
        /// <summary>
        /// Regresa la probabilidad del numero de éxitos "X" en "N" pruebas con una probabilidad de éxito "P"
        /// </summary>
        /// <param name="X">Numero de éxitos</param>
        /// <param name="N">Numero de pruebas</param>
        /// <param name="P">Probabilidad de éxito</param>
        /// <returns></returns>
        public double binopdf(double X, double N, double P)
        {
            double n = 1;
            double k = 1;
            for (double i = N - X + 1; i <= N; i++)
            {
                n *= i;
            }
            for (double i = 2; i <= X; i++)
            {
                k *= i;
            }

            return (n / k) * Math.Pow(P, X) * Math.Pow(1 - P, N - X);
        }


        //solo para valres de V pares
        public double chi2pdf(double X, double V)
        {
            double gamma = calculo.gammafunc(V / 2);
            double result = (Math.Pow(X, (V / 2) - 1) * Math.Exp(-X / 2) / (gamma * Math.Pow(2, V / 2)));

            return result;
        }

        /// <summary>
        /// Distribucion de probabilidad gamma
        /// </summary>
        /// <param name="X">valor a evaluar</param>
        /// <param name="B">Parámetro positivo</param>
        /// <param name="a">Parámetro positivo</param>
        /// <returns></returns>
        public double gampdf(double X, double B, double a)
        {
            double alpha = calculo.gammafunc(a);
            double result = Math.Pow(X, a - 1) * Math.Exp(-X / B) / (alpha * Math.Pow(B, a));

            return result;
        }

        /*public double tpdf(double X, double V)
        {
            double gamma = calculo.gammafunc(V / 2);
            double result = 
        }*/

    }

}
