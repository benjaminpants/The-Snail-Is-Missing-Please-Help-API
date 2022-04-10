using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSIMPH
{
    public static class Logger
    {
        public enum LogLevel
        {
            Debug,
            Info,
            Warn,
            Error,
            Fatal
        }


        public static void Log(string log, LogLevel level = LogLevel.Debug)
        {
            switch(level)
            {

                case LogLevel.Error:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case LogLevel.Warn:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case LogLevel.Fatal:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                    
                case LogLevel.Debug:
                    #if RELEASE
                        return;
                    #endif
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;

                case LogLevel.Info:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                default:
                    break;

            }
            Console.WriteLine(log);
            Console.ResetColor();
        }
    }
}
