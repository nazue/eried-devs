using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTranslator
{
    /// <summary>
    /// Clase abstracta de funciones de traducción de caracteres
    /// </summary>
    public class Translator
    {
        /// <summary>
        /// Genera un arreglo con la codificación del carácter
        /// </summary>
        /// <param name="c">Carácter a codificar</param>
        /// <returns>Arreglo con la codificación</returns>
        public static byte[] GetBinaryArray(char c)
        {
            c = GetTranslatedChar(c);
            String s = Convert.ToString((int)c, 2).PadLeft(6,'0');

            byte[] output = new byte[s.Length];

            for(int i=0; i<s.Length; i++)
                output[i] = (byte)(Convert.ToByte(s.Substring(i, 1)) == 0 ? 0 : 1);

            return output;
        }

        /// <summary>
        /// Genera un arreglo con la codificación del carácter
        /// </summary>
        /// <param name="c">Carácter a codificar</param>
        /// <returns>Arreglo con la codificación</returns>
        public static float[] GetBinaryArrayFloat(char c)
        {
            byte[] m = Translator.GetBinaryArray(c);
            float[] z = new float[m.Length];
            m.CopyTo(z,0);
            return z;
        }

        /// <summary>
        /// Traduce un carácter de acuerdo a una tabla de corrimiento
        /// </summary>
        /// <param name="c">Carácter a traducir</param>
        /// <returns>Carácter traducido</returns>
        public static char GetTranslatedChar(char c)
        {
            int offset = Translator.GetOffsetForChar(c);
            
            if (offset == 0)
                return '?';
            else
                return (char)(c + offset); // Codificar
        }

        /// <summary>
        /// Obtiene el desplazamiento según el carácter
        /// </summary>
        /// <param name="c">Carácter</param>
        /// <returns>Desplazamiento</returns>
        public static int GetOffsetForChar(char c)
        {
            if (c >= '0' && c <= '9')
                return -48;
            if (c >= 'A' && c <= 'Z')
                return -55;
            if (c >= 'a' && c <= 'z')
                return -61;
            return 0;
        }

        public static int GetOffsetForCharRev(char c)
        {
            char nu = (char)(c + 48), ma = (char)(c + 55), mi = (char)(c + 61);

            if (nu >= '0' && nu <= '9')
                return -48;
            if (ma >= 'A' && ma <= 'Z')
                return -55;
            if (mi >= 'a' && mi <= 'z')
                return -61;
            return 0;

        }

        /// <summary>
        /// Obtiene el carácter original dada por la salida de la red neuronal
        /// </summary>
        /// <param name="output">Salida de la red neuronal</param>
        /// <param name="pivot">Pivote de ruptura</param>
        /// <returns>Carácter original, traducido</returns>
        public static char GetOriginalChar(float[] output, float pivot)
        {
            // Convertir a decimal
            String o = "";

            for (int i = 0; i < output.Length; i++)
            {
                o += (output[i]>pivot) ? 1 : 0;
            }

            char c = (char)Convert.ToByte(o, 2);

            return Translator.GetOriginalChar(c);
        }

        /// <summary>
        /// Obtiene el carácter original dada por la salida de la red neuronal
        /// </summary>
        /// <param name="output">Salida de la red neuronal</param>
        /// <returns>Carácter original, traducido</returns>
        public static char GetOriginalChar(float[] output)
        {
            return Translator.GetOriginalChar(output, 0.5f);
        }

        /// <summary>
        /// Obtiene el carácter original dada por la salida de la red neuronal
        /// </summary>
        /// <param name="output">Salida de la red neuronal</param>
        /// <returns>Carácter original, traducido</returns>
        public static char GetOriginalChar(byte[] output)
        {
            float[] z = new float[output.Length];
            output.CopyTo(z, 0);
            return Translator.GetOriginalChar(z, 0.5f);
        }

        /// <summary>
        /// Obtiene el carácter original dado el carácter traducido
        /// </summary>
        /// <param name="c">Carácter traducido</param>
        /// <returns>Carácter original</returns>
        public static char GetOriginalChar(char c)
        {
            int offset = Translator.GetOffsetForCharRev(c);

            if (offset == 0)
                return '?';
            else
                return (char)(c - offset); // Decodificar
        }
    }
}
