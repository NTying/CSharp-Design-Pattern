using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ResourcePoolConfig
    {
        private string Name { get; set; }
        private int MaxTotal { get; set; }
        private int MaxIdle { get; set; }
        private int MinIdle { get; set; }

        public ResourcePoolConfig(ResourcePoolConfigBuilder builder)
        {
            this.Name = builder.Name;
            this.MaxTotal = builder.MaxTotal;
            this.MaxIdle = builder.MaxIdle;
            this.MinIdle = builder.MinIdle;            
        }

        public override string ToString()
        {
            return $"ResourcePool Name: {Name}\r\nMaxTotal: {MaxTotal}\r\nMaxIdle: {MaxIdle}\r\nMinIdle: {MinIdle}";
        }
    }
}
