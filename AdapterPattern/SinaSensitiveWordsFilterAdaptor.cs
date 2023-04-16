using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class SinaSensitiveWordsFilterAdaptor : SinaSensitiveWordsFilter, ISensitiveWordsFilter
    {       
        public string filter(string text)
        {
            return this.filterSensitiveWords(text);
        }
    }
}
