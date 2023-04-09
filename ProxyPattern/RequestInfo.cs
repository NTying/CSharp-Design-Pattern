using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RequestInfo
    {
        public string ActionName { get; set; }
        public string StartTime { get; set; }
        public string ResponseTime { get; set; }

        public RequestInfo(string actionName, string startTime, string responseTime)
        {
            ActionName = actionName;
            StartTime = startTime;
            ResponseTime = responseTime;
        }

        public override string ToString()
        {
            return $"ActionName: {ActionName}\t\tStartTimeStamp: {StartTime}\t\tResponseTime: {ResponseTime}";
        }
    }
}
