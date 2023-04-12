using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class MyBufferedStream : MyStream
    {
        private readonly MyStream _stream;

        public MyBufferedStream(MyStream stream)
        {
            _stream = stream;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            _stream.Read(buffer, offset, count);
            Console.WriteLine("MyBufferedStream implementation");
            // TODO 实现缓冲流
            return count;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            _stream.Write(buffer, offset, count);
            // TODO 实现缓冲流
            Console.WriteLine("MyBufferedStream implementation");
        }
    }
}
