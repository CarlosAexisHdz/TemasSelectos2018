using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasificador
{
    class GFunctions
    {
        /// <summary>
        /// regresa un arreglo de numeros con el inicio, final y paso especificados
        /// </summary>
        /// <param name="start">inicio del arreglo</param>
        /// <param name="end">final del arreglo</param>
        /// <param name="pass">paso entre numeros del arreglo</param>
        /// <returns></returns>
        public double[] linespace(double start, double end, double pass)
        {
            int size = (int)((end - start) / pass) + 1;
            double[] data = new double[size];
            int j = 0;
            for (double i = start; i <= end; i += pass)
            {
                data[j] = i;
                j++;
            }

            return data;
        }

    }
}
