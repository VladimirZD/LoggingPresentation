using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace LoggingTipsTricks
{
    public class Demo : DemoBase
    {
        public NLog.Logger LoggerLocal = NLog.LogManager.GetCurrentClassLogger();

        public Demo()
        {
            LoggerLocal.Info("Hi from demo");
            LoggerLocal.Info($"Ovo traje dulje od 10 sekundi");
            base.Logger.Info("Hi from demo");
        }

        public void  DoIt()
        {
            var sw = new Stopwatch();
            sw.Start();
            LoggerLocal.Debug("Starting DO It operation");
            Thread.Sleep(2 * 1000);
            sw.Stop();
            LoggerLocal.Warn($"Operation don in {sw.ElapsedMilliseconds} ms");

        }

        public void DoIt2()
        {
            var d = 0;
            var c = 1;
            var k = c / d;

        }
    }
}
