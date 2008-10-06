using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork
{
    public class CharData
    {
        private const int DELTA_LEARNING = 1,
            DEFAULT_LEARN_MATRIX_WIDTH = 10,
            DEFUALT_SPECIAL_SUBMATRIX_WIDTH = 3,
            LEARN_DEPTH = 3, LEARN_DELTA_PIVOT = 7;
        private char _char, _char_t;
        private float[] _binChar_t;
        private float[] _learnedMatrix;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="widthToLearn">Ancho de la matriz de aprendizaje</param>
        public CharData(int widthToLearn)
        {
            _learnedMatrix = new float[widthToLearn * widthToLearn];
            ResetMatrix();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public CharData()
        {
            _learnedMatrix = new float[DEFAULT_LEARN_MATRIX_WIDTH * DEFAULT_LEARN_MATRIX_WIDTH];
            ResetMatrix();
        }

        /// <summary>
        /// Inicializa la matriz del carácter
        /// </summary>
        public void ResetMatrix()
        {
            _learnedMatrix.Initialize();
        }

        /// <summary>
        /// Representa el carácter original
        /// </summary>
        public char CharCode
        {
            get
            {
                return _char;
            }
            set
            {
                _char = value;
                _char_t = BinaryTranslator.Translator.GetTranslatedChar(_char);
                _binChar_t = BinaryTranslator.Translator.GetBinaryArrayFloat(_char);
            }
        }

        /// <summary>
        /// Representa el carácter, ajustado
        /// </summary>
        public char CharCodeTranslated
        {
            get
            {
                return _char_t;
            }
            set
            {
                this.CharCode = BinaryTranslator.Translator.GetOriginalChar(value);
            }
        }

        /// <summary>
        /// Representa el carácter, traducido, en binario, ajustado
        /// </summary>
        public float[] CharBinTranslated
        {
            get
            {
                return _binChar_t;
            }
            set
            {
                this.CharCode = BinaryTranslator.Translator.GetOriginalChar(value);
            }
        }

        /// <summary>
        /// Matriz de coincidencias
        /// </summary>
        public float[] LearnedMatrix
        {
            get
            {
                return _learnedMatrix;
            }
            set
            {
                _learnedMatrix = value;
            }
        }

        /// <summary>
        /// Produce cambios en la matriz de coincidencias
        /// </summary>
        /// <param name="charArrayData">Arreglo con la información del carácter</param>
        public void LearnChar(float[] charArrayData)
        {
            float[,] matrixToLearn = ConvertToSpecialMatrix(charArrayData);
            float[,] actualLearned = ConvertToSquareMatrix(_learnedMatrix);

            for(int i=0; i<matrixToLearn.GetLength(0); i++)
                for(int j=0; j<matrixToLearn.GetLength(1); j++)
                {
                    int delta = DELTA_LEARNING;
                    if (matrixToLearn[i,j] <= 0)
                        delta = -delta;

                    if (Math.Abs(actualLearned[j,i] + delta) > LEARN_DEPTH)
                        delta = 0;

                    actualLearned[j,i] += delta;
                }

            // Establecer la matriz actualizada
            SetCharMatrix(actualLearned);     
        }

        /// <summary>
        /// Comprueba la coincidencia con la matriz del carácter actual
        /// </summary>
        /// <param name="charArrayData">Arreglo con la información del carácter</param>
        /// <returns>Total coincidente</returns>
        public float CheckMatching(float[] charArrayData)
        {
            float[,] matrixToTest = ConvertToSpecialMatrix(charArrayData);
            float[,] actualLearned = ConvertToSquareMatrix(_learnedMatrix);

            float match = 0, delta;
            float fullMatch = LEARN_DELTA_PIVOT * matrixToTest.GetLength(0) * 
                matrixToTest.GetLength(1);
            
            for (int i = 0; i < matrixToTest.GetLength(0); i++)
                for (int j = 0; j < matrixToTest.GetLength(1); j++)
                {
                    delta = actualLearned[i, j] - matrixToTest[i, j];
                    match += (LEARN_DELTA_PIVOT - Math.Abs(delta));              
                }

            return (match * 100) / fullMatch;
        }

        /// <summary>
        /// Genera una matriz especial formada por subconjuntos de la matriz de entrada
        /// </summary>
        /// <param name="charArrayData">Matriz de entrada en un arreglo</param>
        /// <returns>Matriz especial de salida</returns>
        private static float[,] ConvertToSpecialMatrix(float[] charArrayData)
        {
            float[,] input = ConvertToSquareMatrix(charArrayData);
            int w = DEFUALT_SPECIAL_SUBMATRIX_WIDTH;
            int l = input.GetLength(0)/w;

            float[,] output = new float[l, l];

            for (int i = 0; i < l; i++)
                for (int j = 0; j < l; j++)
                    output[i,j] = GetSpecialValue(input, i * w, j * w, w);

            return output;
        }

        /// <summary>
        /// Obtiene el valor del subconjunto de una matriz
        /// </summary>
        /// <param name="m">Matriz</param>
        /// <param name="x">Esquina horizontal de la submatriz</param>
        /// <param name="y">Esquina vertical de la submatriz</param>
        /// <param name="w">Ancho de la submatriz</param>
        /// <returns>Valor representativo de la submatriz</returns>
        private static int GetSpecialValue(float[,] m, int x, int y, int w)
        {
            int c = 0;

            for (int i = x; i < x + w; i++)
                for (int j = y; j < y + w; j++)
                    if (m[i, j] == 1)
                        c++;

            switch (c)
            {
                case 0: return -3;
                case 1: return -2;
                case 2: return -1;
                case 3: return 0;
                case 4: return 1;
                case 5: return 1;
                case 6: return 2;
                case 7: return 2;
                default: return 3;
            }
        }

        /// <summary>
        /// Obtiene la matriz de coincidencia, debe asignarla por medio de aprendizaje
        /// </summary>
        public float[,] GetCharMatrix()
        {
            return ConvertToSquareMatrix(_learnedMatrix);    
        }

        private static float[,] ConvertToSquareMatrix(float[] a)
        {
            int t = (int)Math.Sqrt(a.Length);
            float[,] f = new float[t, t];

            for (int i = 0; i < a.Length; i++)
            {
                f[i % t,i / t] = a[i];
            }
            return f;
        }

        /// <summary>
        /// Establece la matriz de coincidencias
        /// </summary>
        /// <param name="val">Matriz</param>
        public void SetCharMatrix(float[,] val)
        {
            int t = (int)Math.Sqrt(_learnedMatrix.Length);
            for (int i = 0; i < val.GetLength(0); i++)
            {
                for (int j = 0; j < val.GetLength(1); j++)
                {
                    _learnedMatrix[i * t + j] = val[i, j];
                }
            }
        }

    }
}
