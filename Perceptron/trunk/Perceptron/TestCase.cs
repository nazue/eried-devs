using System;
using System.Collections.Generic;
using System.Text;

namespace Perceptron
{
    class TestCase
    {
        private int[] _data;
        private int _result;

        /// <summary>
        /// Representa un nuevo caso conocido
        /// </summary>
        /// <param name="data">Entradas</param>
        /// <param name="result">Salida</param>
        public TestCase(int[] inputs, int result)
        {
            _data = inputs;
            _result = result;
        }

        /// <summary>
        /// Retorna la salida esperada
        /// </summary>
        public int Output
        {
            get
            {
                return _result;
            }
        }

        public int Length
        {
            get
            {
                return _data.Length;
            }
        }

        public int[] Inputs
        {
            get
            {
                return _data;
            }
        }

        /// <summary>
        /// Retorna una entrada del caso
        /// </summary>
        /// <param name="n">Número de entrada</param>
        /// <returns>Valor de entrada</returns>
        public int Input(int n)
        {
            return _data[n%_data.Length];
        }
    }
}
