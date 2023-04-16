using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AdapterPattern
{
    public class SinaSensitiveWordsFilter
    {
        public string filterSensitiveWords(string word)
        {
            return $"SinaSensitiveWordsFilter filter sexy words {word}";
        }
    }
}
