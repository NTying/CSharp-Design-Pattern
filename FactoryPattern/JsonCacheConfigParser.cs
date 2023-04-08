using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class JsonCacheConfigParser : ICacheConfigurationParser
    {
        public string GetSection(string section)
        {
            return $"JSON {section} Value";
        }

        public void Load(string path)
        {
            Console.WriteLine($"加载JSON文件{path}");
        }
    }
}
