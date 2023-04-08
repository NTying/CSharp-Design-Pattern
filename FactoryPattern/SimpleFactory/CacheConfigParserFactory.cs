using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.SimpleFactory
{
    public class CacheConfigParserFactory
    {
        public ICacheConfigurationParser createParser(string configFormat)
        {
            ICacheConfigurationParser parser = null;
            if (string.Equals("json", configFormat, StringComparison.OrdinalIgnoreCase))
            {
                parser = new JsonCacheConfigParser();
            } else if (string.Equals("xml", configFormat, StringComparison.OrdinalIgnoreCase))
            {
                parser = new XmlCacheConfigParser();
            } else if (string.Equals("yaml", configFormat, StringComparison.OrdinalIgnoreCase))
            {
                parser = new YamCachelConfigParser();
            }

            return parser;
        }
    }
}
