using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

namespace NeuralNetwork
{
    public class NeuralNetwork
    {
        private ArrayList _charData;

        /// <summary>
        /// Constructor
        /// </summary>
        public NeuralNetwork()
        {
            _charData = new ArrayList();
            /*
            // Crear el carácter predeterminado
            CharData c = new CharData();
            c.CharCodeTranslated = '?';
            _charData.Add(c);*/
        }

        /// <summary>
        /// Entrena la red según la información del carácter
        /// </summary>
        /// <param name="dataToLearn">Datos "binarios" del carácter</param>
        /// <param name="output">Salida esperada</param>
        public void Learn(float[] dataToLearn, float[] output)
        {
            // Buscar si la salida especificada existe, usarla o crearla
            int p = FindCharDataPos(output);
            
            CharData c;
            if (p == -1)
            {
                // Nuevo carácter
                c = new CharData();

                // Establecer carácter
                c.CharBinTranslated = output;

                // Entrenar y añadir
                c.LearnChar(dataToLearn);
                _charData.Add(c);
            }
            else
            {
                c = (CharData)_charData[p];
                c.LearnChar(dataToLearn);
            }
        }

        private int FindCharDataPos(float[] output)
        {
            for(int i=0; i<_charData.Count; i++)
                if (IsEqualCharBit(((CharData)_charData[i]).CharBinTranslated, output))
                    return i;
            return -1;     
        }

        private bool IsEqualCharBit(float[] a, float[] b)
        {
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                    if (a[i] != b[i])
                        return false;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Una lista de datos de carácter</param>
        public NeuralNetwork(ArrayList c)
        {
            _charData = c;
        }

        /// <summary>
        /// Carga una red desde archivo
        /// </summary>
        /// <param name="filePath">Ruta al archivo</param>
        /// <returns>El objeto que representa la red</returns>
        public static NeuralNetwork LoadFromFile(String filePath)
        {
            XmlSerializer z = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(CharData), typeof(BinaryTranslator.Translator) });
            TextReader reader = new StreamReader(filePath);

            return new NeuralNetwork((ArrayList)z.Deserialize(reader));
        }

        /// <summary>
        /// Guarda a archivo los datos del objeto
        /// </summary>
        /// <param name="filePath">Ruta al archivo</param>
        public void SaveToFile(string filePath)
        {
            try
            {
                XmlSerializer z = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(CharData), typeof(BinaryTranslator.Translator) });
                TextWriter writer = new StreamWriter(filePath);

                z.Serialize(writer, _charData);
            }
            catch { }
        }

        /// <summary>
        /// Calcula un arreglo "binario" del carácter más aproximada a la entrada proporcionada
        /// </summary>
        /// <param name="test">Entrada, información del carácter</param>
        /// <returns>Arreglo de salida</returns>
        public float[] Output(float[] test)
        {
            int bestMatch = 0;
            float percentBestMatch = 0, percentMatch;
            CharData c;

            for (int i = 0; i < _charData.Count; i++)
            {
                c = (CharData)_charData[i];
                percentMatch = c.CheckMatching(test);

                if (percentMatch > percentBestMatch)
                {
                    bestMatch = i;
                    percentBestMatch = percentMatch;
                }
            }

            return ((CharData)_charData[bestMatch]).CharBinTranslated;

        }
/*
        /// <summary>
        /// Convierte un arreglo de float en un String de ceros y unos
        /// </summary>
        /// <param name="z">Arreglo de entrada</param>
        /// <returns>Cadena con ceros y unos</returns>
        private static String ToBinString(float[] z)
        {
            String o = "";
            for (int i = 0; i < z.Length; i++)
                o += "" + (int)((z[i]==0) ? 0:1);
            return o;
        }*/
    }
}
