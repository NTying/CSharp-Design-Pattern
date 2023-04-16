using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class TwitterSensitiveWordsFilterAdaptor : ISensitiveWordsFilter
    {
        private readonly TwitterSensitiveWordsFilter _filter;

        public TwitterSensitiveWordsFilterAdaptor(TwitterSensitiveWordsFilter filter)
        {
            _filter = filter;
        }

        public string filter(string text)
        {
            string maskedText = _filter.filterSexyWords(text);
            maskedText = _filter.filterPoliticalWords(maskedText);
            return maskedText;
        }
    }
}
