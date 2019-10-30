using LoggingTipsTricks;
using System;

namespace dotnetcore_nlog
{
    internal class Program
    {
        private string Folder { get; set; }
        public string File { get; set; }
        public bool Convert { get; set; }

        private static void Main(string[] args)
        {
            Helpers.Logger.Trace("Loggin trace.");
            var d = new Demo();

            //Console.WriteLine("Any key");
            //Console.ReadLine();
        }
    }
}
