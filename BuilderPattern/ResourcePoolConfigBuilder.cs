using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ResourcePoolConfigBuilder
    {

        public string? Name { get; private set; }
        public int MaxTotal { get; private set; }
        public int MaxIdle { get; private set; }
        public int MinIdle { get; private set; }

        public ResourcePoolConfigBuilder SetMaxIdel(int maxIdel)
        {
            this.MaxIdle = maxIdel;
            return this;
        }

        public ResourcePoolConfigBuilder SetMaxTotal(int maxTotal)
        {
            this.MaxTotal = maxTotal;
            return this;
        }

        public ResourcePoolConfigBuilder SetMinIdel(int minIdel)
        {
            this.MinIdle = minIdel;
            return this;
        }

        public ResourcePoolConfigBuilder SetName(string name)
        {
            this.Name = name;
            return this;
        }

        public ResourcePoolConfig Build()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException("name can't be null or empty and whitespace");
            }
            if (MaxIdle > MaxTotal)
            {
                throw new ArgumentException("MaxIdle can't bigger than MaxTotal");
            }
            if (MinIdle > MaxIdle || MinIdle > MaxTotal)
            {
                throw new ArgumentException("....");
            }

            return new ResourcePoolConfig(this);
        }
    }
}
