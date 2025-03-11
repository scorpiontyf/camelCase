using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camelCase
{
    public class Conversor
    {
        public string ConverterParaCamelCase(List<string> palavras)
        {
            var palavraFormatada = "";
            if (palavras != null && palavras.Count > 0)
            {
                foreach(string palavra in palavras)
                {
                    palavraFormatada += char.ToUpper(palavra[0]) + palavra.Substring(1).ToLower();
                }
            }
            return palavraFormatada;
        }
    }
}
