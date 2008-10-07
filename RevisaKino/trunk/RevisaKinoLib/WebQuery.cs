using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace WebQueryLib
{
    public class WebQuery
    {
        private String _query;
        private String[] _tokens;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="urlQuery">La dirección de consulta con las variables</param>
        /// <param name="keyTokens">Las variables reemplazables de la consulta</param>
        public WebQuery(String urlQuery, String[] keyTokens)
        {
            _query = urlQuery;
            _tokens = keyTokens;
        }

        /// <summary>
        /// Realiza una nueva consulta
        /// </summary>
        /// <param name="keywords">Palabras clave</param>
        /// <returns>El código de respuesta</returns>
        public string Query(String[] keywords)
        {
            String output = "";

            if (keywords.Length == _tokens.Length)
            {
                try
                {
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(ReplaceQueryTokens(_query, _tokens, keywords));
                    myRequest.Method = "GET";
                    WebResponse myResponse = myRequest.GetResponse();
                    StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                    output = sr.ReadToEnd();
                    sr.Close();
                    myResponse.Close();
                }
                catch {}
            }

            return output;
        }

        private String ReplaceQueryTokens(String query, String[] tokens, String[] keywords)
        {
            int i=0;
            foreach (String token in tokens)
                query = query.Replace(token, keywords[i++]);
            
            return query;
        }
    }
}
