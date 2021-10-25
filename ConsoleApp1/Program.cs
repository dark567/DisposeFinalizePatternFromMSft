using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Test();
            Console.ReadLine();
        }

        private static void Test()
        {
            SomeClass s = null;
            try
            {
                s = new SomeClass();
            }
            finally
            {
                if (s != null)
                {
                    s.Dispose();
                }
            }
        }
    }

    public class SomeClass : IDisposable
    {
        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("protected virtual void Dispose(bool disposing)");
                    Console.ReadLine();
                }
                disposed = true;
            }
        }
        ~SomeClass()
        {
            Dispose(false);
        }
    }
}
