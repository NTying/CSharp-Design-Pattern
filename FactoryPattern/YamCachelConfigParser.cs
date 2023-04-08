using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class YamCachelConfigParser : ICacheConfigurationParser
    {
        public string GetSection(string section)
        {
            return $"Yaml {section}";
        }

        public void Load(string path)
        {
            Console.WriteLine($"加载 YAML 文件{path}");
        }
    }
}
