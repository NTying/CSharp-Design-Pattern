namespace ProxyPattern
{
    public class MetricUtils
    {
        private static volatile MetricUtils? _singleton;
        private static readonly object _singletonLock = new object();

        private MetricUtils() { }

        public static MetricUtils getInstance()
        {
            if (_singleton == null)
            {
                lock(_singletonLock)
                {
                    if (_singleton == null)
                    {
                        _singleton = new MetricUtils();
                    }
                }
            }
            return _singleton;
        }

        public void recordRequest(RequestInfo requestInfo)
        {
            Console.WriteLine(requestInfo.ToString());
        }
    }
}