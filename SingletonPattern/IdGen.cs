using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 单例模式的使用情况：
    /// 1)、有频繁实例化然后销毁的情况，也就是频繁的 new 对象，可以考虑单例模式；
    /// 2)、创建对象时耗时过多或者耗资源过多，但又经常用到的对象；
    /// 3)、频繁访问 IO 资源的对象，例如数据库连接池或访问本地文件
    /// </summary>
    public class HungryIdGen
    {
        private static readonly HungryIdGen _singleton = new HungryIdGen();

        private HungryIdGen() { }

        public static HungryIdGen GetInstance () { return _singleton; }

        public string GetId()
        {
            var id = Guid.NewGuid().ToString();
            return id;
        }
    }

    public class LazyIdGen
    {
        private static volatile LazyIdGen? _singleton;
        private static object _lock = new object();

        private LazyIdGen() { }

        public static LazyIdGen GetInstance()
        {
            if (_singleton == null)
            {
                lock (_lock)
                {
                    if (_singleton == null) 
                        _singleton = new LazyIdGen();
                }
            }
            return _singleton;
        }

        public string GetId()
        {
            var id = Guid.NewGuid().ToString();
            return id;
        }
    }
}
