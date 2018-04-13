using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasificador
{
    class Objeto
    {
        #region Variables globales  //llevan un "_" al inicio de la variable
        //las listas son dinamicas
        List<double> Entrenamiento1;
        List<double> Entrenamiento2;

        //por default son estaticas
        double _media;
        double _std;
        double _var;
        double[] _x;
        double[] _y;
        double Psimple;
        double _min;
        double _max;

        double _media2;
        double _std2;
        double _var2;
        double[] _x2;
        double[] _y2;
        double Psimple2;
        double _min2;
        double _max2;

        string _Nombre;
        private double[] a;

        #endregion

        #region Constructores
        /*internamente identifica el caso*/

        /// <summary>
        /// Crea un nuevo objeto con ningun calculo y sin valores de entrada
        /// </summary>
        public Objeto(string nombre) //cuando no se pasan las muestras
        {
            Entrenamiento1 = new List<double>();
            Entrenamiento2 = new List<double>();
            this._Nombre = nombre;  //señala la variable; es parecido al self de python
        }

        /// <summary>
        /// Crea un nuevo objeto con calculo y valores de entrada
        /// </summary>
        /// <param name="muestras">los datos de las muestras</param>
        public Objeto(string nombre, double[] muestras1, double[] muestras2) //cuando si se pasen muestras
        {
            Entrenamiento1 = new List<double>(muestras1);
            Entrenamiento2 = new List<double>(muestras2);
            this._Nombre = nombre;
        }




        #endregion

        #region Accesos (get , set)

        /// <summary>
        /// Devuelve la media del objeto
        /// </summary>
        public double Mean
        {
            get { return _media; } //la media solo es de lectura, el usuario no la debe modificar
        }
        /// <summary>
        /// Devuelve la varianza del objeto
        /// </summary>
        public double Var
        {
            get { return _var; } //la varianza solo es de lectura, el usuario no la debe modificar
        }
        /// <summary>
        /// Devuelve la desviacion del objeto
        /// </summary>
        public double Std
        {
            get { return _std; } //la desviacion solo es de lectura, el usuario no la debe modificar
        }
        /// <summary>
        /// Regresa el valr minimo
        /// </summary>
        public double Min
        {
            get { return _min; }
        }
        /// <summary>
        /// Regresa el valor maximo
        /// </summary>
        public double Max
        {
            get { return _max; }
        }
        /// <summary>
        /// Devuelve la media del objeto
        /// </summary>
        public double Mean2
        {
            get { return _media2; } //la media solo es de lectura, el usuario no la debe modificar
        }
        /// <summary>
        /// Devuelve la varianza del objeto
        /// </summary>
        public double Var2
        {
            get { return _var2; } //la varianza solo es de lectura, el usuario no la debe modificar
        }
        /// <summary>
        /// Devuelve la desviacion del objeto
        /// </summary>
        public double Std2
        {
            get { return _std2; } //la desviacion solo es de lectura, el usuario no la debe modificar
        }
        /// <summary>
        /// Regresa el valr minimo
        /// </summary>
        public double Min2
        {
            get { return _min2; }
        }
        /// <summary>
        /// Regresa el valor maximo
        /// </summary>
        public double Max2
        {
            get { return _max2; }
        }
        /*/// <summary>
        /// Devuelve el valor de entrenamiento
        /// </summary>
        public double[] train
        {
            get { return Entrenamiento1.ToArray(); }
        }*/
        /// <summary>
        /// Devuelve el nombre del objeto
        /// </summary>
        public string Nombre
        {
            get { return _Nombre; }
        }
        /// <summary>
        /// Retrona el arreglo de x
        /// </summary>
        public double[] fx
        {
            get { return _x; }
        }
        /// <summary>
        /// retorna el arreglo de y de una distribucion
        /// </summary>
        public double[] fy
        {
            get { return _y; }
        }
        /// <summary>
        /// Retrona el arreglo de x
        /// </summary>
        public double[] fx2
        {
            get { return _x2; }
        }
        /// <summary>
        /// retorna el arreglo de y de una distribucion
        /// </summary>
        public double[] fy2
        {
            get { return _y2; }
        }
        #endregion

        #region Metodos Publicos

        /// <summary>
        /// Añade un valor al entrenamiento
        /// </summary>
        /// <param name="input">Valor a agregar</param>
        public void Add1(double input)
        {
            Entrenamiento1.Add(input);
        }

        /// <summary>
        /// Añade un valor al entrenamiento
        /// </summary>
        /// <param name="input">Valor a agregar</param>
        public void Add2(double input)
        {
            Entrenamiento2.Add(input);
        }
        /// <summary>
        /// Calcula los valores del objeto
        /// </summary>
        public void Calc()
        {
            _media = MPMedia(Entrenamiento1.ToArray());
            _var = MPVar(Entrenamiento1.ToArray());
            _std = MPStd(Entrenamiento1.ToArray());
            _min = MPMin("1");
            _max = MPMax("1");

            _media2 = MPMedia(Entrenamiento2.ToArray());
            _var2 = MPVar(Entrenamiento2.ToArray());
            _std2 = MPStd(Entrenamiento2.ToArray());
            _min2 = MPMin("2");
            _max2 = MPMax("2");
        }

        /// <summary>
        /// Crea un arreglo
        /// </summary>
        /// <param name="inicio">inicio del arreglo</param>
        /// <param name="fin">final del arrglo</param>
        /// <param name="paso">paso entre valores</param>
        public void Linespace(double inicio, double fin, double paso, string parametro)
        {
            MPlinespace(inicio, fin, paso, parametro);
        }

        /// <summary>
        /// Crea un arreglo de valores evaluados en la funcion de distribucion normal
        /// </summary>
        /// <param name="x">valores a evaluar</param>
        /// <param name="media">promedio de de "x"</param>
        /// <param name="desviacion">desvacion estandar de "x"</param>
        public void normpdf(double[] x, double media, double desviacion, string parametro)
        {
            MPnormpdf(x, media, desviacion, parametro);
        }


        /// <summary>
        /// Evalúa un valor en la funcion de distribucion normal
        /// </summary>
        /// <param name="x">valor a evaluar</param>
        /// <param name="media">promedio de la muestra</param>
        /// <param name="desviacion">desviacion estandar de la muestra</param>
        public void cnorm(double x, double media, double desviacion, string parametro)
        {
            MPcnorm(x, media, desviacion, parametro);
        }


        #endregion

        #region Metodos Privados
        /// <summary>
        /// Calcula la media de la muestra
        /// </summary>
        /// <param name="input"></param>
        private double MPMedia(double[] input)
        {
            Statistics a = new Statistics();
            return a.Mean(input);
        }
        /// <summary>
        /// Calcula la varianza
        /// </summary>
        /// <param name="input"></param>
        private double MPVar(double[] input)
        {
            Statistics a = new Statistics();
            return a.Var(input);
        }
        /// <summary>
        /// Calcula la desviacion estandar
        /// </summary>
        /// <param name="input"></param>
        private double MPStd(double[] input)
        {
            Statistics a = new Statistics();
            return a.Std(input);
        }

        /// <summary>
        /// Calcula el valor mínimo que puede tener el arreglo considerando la desviacion estandar
        /// </summary>
        /// <param name="parametro">parametro que se trabajará</param>
        private double MPMin(string parametro)
        {
            if (parametro == "1")
            {
                return (_media - 3 * _std);
            }
            else
            {
                return (_media2 - 3 * _std);
            }
        }

        /// <summary>
        /// Calcula el valor maximo que puede tener el arreglo considerando la desviacion estandar
        /// </summary>
        /// <param name="parametro">parametro que se trabajará</param>
        private double MPMax(string parametro)
        {
            if (parametro == "1")
            {
                return (_media + 3 * _std);
            }
            else
            {
                return (_media2 + 3 * _std);
            }
        }

        /// <summary>
        /// Crea un arreglo de numeros
        /// </summary>
        /// <param name="inicio">inicio del arreglo</param>
        /// <param name="fin">final del arreglo</param>
        /// <param name="paso">paso entre cada valor del arreglo</param>
        /// <param name="parametro">parametro que se trabajará</param>
        private void MPlinespace(double inicio, double fin, double paso, string parametro)
        {
            if (parametro == "1")
            {
                GFunctions a = new GFunctions();
                _x = a.linespace(inicio, fin, paso);
            }
            else
            {
                GFunctions a = new GFunctions();
                _x2 = a.linespace(inicio, fin, paso);
            }
        }

        /// <summary>
        /// Crea un arreglo de valores evaluados en la funcion de distribucion normal
        /// </summary>
        /// <param name="x">Valores a evaluar</param>
        /// <param name="media">promedio de los valores</param>
        /// <param name="desviacion">desviacion estandar de los valores</param>
        /// <param name="parametro">parametro que se trabajará</param>
        private void MPnormpdf(double[] x, double media, double desviacion, string parametro)
        {
            if (parametro == "1")
            {
                Statistics a = new Statistics();
                _y = a.normpdf(x, media, desviacion);
            }
            else
            {
                Statistics a = new Statistics();
                _y2 = a.normpdf(x, media, desviacion);
            }
        }

        /// <summary>
        /// Regresa un valor evaluado en la funcion de distribucion normal
        /// </summary>
        /// <param name="input">valor a evaluar</param>
        /// <param name="media">promedio de la muestra</param>
        /// <param name="desviacion">desviacion de la muestra</param>
        /// <param name="parametro">parametro que se trabajará</param>
        private void MPcnorm(double input, double media, double desviacion, string parametro)
        {
            if (parametro == "1")
            {
                Statistics a = new Statistics();
                Psimple = a.Cnorm(media, desviacion, input);
            }
            else
            {
                Statistics a = new Statistics();
                Psimple2 = a.Cnorm(media, desviacion, input);
            }
        }
        #endregion

        #region Operadores

        #endregion
    }
}
