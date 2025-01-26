using System.Diagnostics;

namespace Tetris
{
    internal class Time
    {
        private static Stopwatch stopwatch = new Stopwatch();

        public static string GetTime()
        {
            var ts = stopwatch.Elapsed; 
            int minutes = (int)ts.TotalMinutes;
            int seconds = (int)(ts.TotalSeconds - (minutes * 60));
            return string.Format("{0:D2}:{1:D2}", minutes, seconds);
        }

        public static void Initialize()
        {
            stopwatch.Start(); 
        }
    }
}
