using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod
{
    public class XmlCacheConfigParserFactory : ICacheConfigParserFactory
    {
        public ICacheConfigurationParser CreateParser()
        {
            return new XmlCacheConfigParser();
        }
    }
}
