using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public sealed class MyFileStream : MyStream
    {
        public override int Read(byte[] buffer, int offset, int count)
        {
            Console.WriteLine("MyFileStream implementation");
            return count;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            Console.WriteLine("FileStream implementation");
        }
    }
}
