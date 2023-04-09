using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class UserController
    {
        public virtual string login(string username, string password)
        {
            //TODO 登录操作
            Console.WriteLine("基类登录操作执行完成");
            return "登陆成功";
        }

        public virtual string register (string username, string password)
        {
            //TODO 注册操作
            Console.WriteLine("基类注册操作执行完成");
            return "注册成功";
        }

    }
}
