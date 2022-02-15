using System;
using System.Runtime.InteropServices;

namespace DotnetCrashTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntPtr ptr = Marshal.AllocHGlobal(2);
            Span<byte> bytes;
            unsafe
            {
                bytes = new Span<byte>((byte*)ptr, 10) { [0] = 42 };
            }
            for (int i = 0; i < 10; i++)
            {
                bytes[i] = 25;
            }
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
