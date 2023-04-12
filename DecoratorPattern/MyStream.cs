namespace DecoratorPattern
{
    public abstract class MyStream
    {
        public abstract int Read(byte[] buffer, int offset, int count);

        public abstract void Write(byte[] buffer, int offset, int count);
    }
}