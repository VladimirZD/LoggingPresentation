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
            try
            {
                Helpers.Logger.Trace("Loggin trace.");
                var d = new Demo();
                d.DoIt();
                d.DoIt2();
            }
            catch (Exception ex)
            {
                Helpers.Logger.Fatal(ex, "OOps");
            }
        }
    }
}
