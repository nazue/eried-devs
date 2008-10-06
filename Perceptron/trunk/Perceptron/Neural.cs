using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Perceptron
{
    class Neural
    {
        private double[] _weights, _error;
        private int _length;
        private ArrayList data;
        private double b = 0.5;

        public Neural(ArrayList trainData)
        {
            data = trainData;

            int length = ((TestCase)data[0]).Length;
            _length = length;
            _weights = new double[length];
            _error = new double[data.Count];

            Reset();
        }

        /// <summary>
        /// Inicializa los pesos y los errores
        /// </summary>
        public void Reset()
        {
            Random rnd = new Random();

            for (int i = 0; i < _length; i++)
                _weights[i] = rnd.NextDouble() - 0.5;
                //_weights[i] = 0;

            for (int i = 0; i < _error.Length; i++)
                _error[i] = 1;
        }

        /// <summary>
        /// Retorna el absoluto de la suma de los errores actuales
        /// </summary>
        /// <returns></returns>
        private double ErrorSum()
        {
            double _e = 0;
            for (int i = 0; i < _error.Length; i++)
                _e += Math.Abs(_error[i]);
            return _e;
        }

        private double ErrorMax()
        {
            double _e = 0, _me;
            for (int i = 0; i < _error.Length; i++)
            {
                _me = Math.Abs(_error[i]);

                if (_me > _e)
                    _e = _me;
            }
            return _e;
        }

        public double GetWeight(int n)
        {
            return _weights[n % _weights.Length];
        }

        public double[] GetWeights
        {
            get
            {
                return _weights;
            }
        }

        /// <summary>
        /// Función que prueba entradas con los pesos actuales
        /// </summary>
        /// <param name="input">Entradas</param>
        /// <returns>Valor de salida</returns>
        public double Test(int[] input)
        {
            double temp = 0;

            for (int i = 0; i < _length; i++)
                temp += input[i] * _weights[i];

            return temp;
        }

        /// <summary>
        /// Función que prueba entradas con los pesos actuales, ahora basándose en un pivote
        /// </summary>
        /// <param name="input">Entradas</param>
        /// <returns>Valor de salida</returns>
        public double Eval(int[] input)
        {
            if (Test(input) >= b)
                return 1;
            return 0;
            
        }
        
        /// <summary>
        /// Rutina principal de entrenamiento
        /// </summary>
        /// <param name="alpha">Coeficiente de aprendizaje</param>
        /// <param name="minError">Error mínimo aceptado</param>
        /// <param name="maxIterations">Máximo de iteraciones a realizar</param>
        /// <returns>Número de iteraciones realizadas</returns>
        public int Train(double alpha, double minError, int maxIterations)
        {
            int iteration = 0;

            while (this.ErrorSum() > minError && iteration < maxIterations)
            {
                int testCase;

                for (testCase = 0; testCase < data.Count; testCase++)
                {
                    TestCase testData = (TestCase)data[testCase];

                    double testOut = Eval(testData.Inputs);

                    if (testOut != testData.Output)
                    {
                        for (int i = 0; i < _length; i++)
                            _weights[i] += (alpha * (testData.Output - testOut) * testData.Input(i));
                    }
                }
/*
                String s = "Los pesos actuales son\n";
                for (int i = 0; i < _length; i++)
                    s+= "\n Peso(" + i + "): " + _weights[i];

                s += "\n\ny los errores\n";
                for (int i = 0; i < data.Count; i++)
                {
                    TestCase testData = (TestCase)data[i];
                    s += "\n Se esperaba " + testData.Output + " y se entregó " + Eval(testData.Inputs);
                }

                MessageBox.Show(s);
*/
                for(testCase = 0; testCase < data.Count; testCase++)
                {
                    TestCase testData = (TestCase)data[testCase];
                        _error[testCase] = testData.Output - Eval(testData.Inputs);
                }

                iteration++;
            }

            return iteration;
        }

    }
}
