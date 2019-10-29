using LoggingTipsTricks;
using System;

namespace dotnetcore_nlog
{
    class Program
    {
        

        private string Folder { get; set; }
        public string File{ get; set; }
        public bool Convert { get; set; }
        static void Main(string[] args)
        {
            
            Helpers.Logger.Trace("Loggin trace.");

        }

        private string[] GetRDLFiles()
        {
            return null;
        }
      
    }
}