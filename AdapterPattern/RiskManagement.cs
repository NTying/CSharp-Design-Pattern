using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class RiskManagement
    {
        private List<ISensitiveWordsFilter> filters = new();

        public void addSensitiveWordsFilter(ISensitiveWordsFilter filter)
        {
            filters.Add(filter);
        }

        public string filterSensitiveWords(string text)
        {
            string maskedText = text;
            filters.ForEach(filter => { maskedText = filter.filter(text); });
            return maskedText;
        }
    }
}
