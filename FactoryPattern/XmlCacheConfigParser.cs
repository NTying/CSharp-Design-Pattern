using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class XmlCacheConfigParser : ICacheConfigurationParser
    {
        public string GetSection(string section)
        {
            return $"XML {section} Value";
        }

        public void Load(string path)
        {
            Console.WriteLine($"加载XML文件 {path}");
        }
    }
}
