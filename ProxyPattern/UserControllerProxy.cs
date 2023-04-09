using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class UserControllerProxy : UserController
    {
        private readonly MetricUtils _metricUtils;

        public UserControllerProxy(MetricUtils metricUtils)
        {
            _metricUtils = metricUtils;
        }

        public override string login(string username, string password)
        {
            var startTime = DateTime.UtcNow;
            // TODO 登录验证
            base.login(username, password);

            long responseTime = Convert.ToInt64((DateTime.UtcNow - startTime).TotalSeconds);
            _metricUtils.recordRequest(new RequestInfo
                ("login", startTime.ToString(), responseTime.ToString()));
            return "登录成功";
        }

        public override string register(string username, string password)
        {
            var startTime = DateTime.UtcNow;
            // TODO 注册
            base.register(username, password);

            long responseTime = Convert.ToInt64((DateTime.UtcNow - startTime).TotalSeconds);
            _metricUtils.recordRequest(new RequestInfo
                ("login", startTime.ToString(), responseTime.ToString()));
            return "注册成功";
        }
    }
}
