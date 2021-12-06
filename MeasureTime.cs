using System;
using System.Diagnostics;

namespace AlgorytmySortowanie
{
	public class MeasureTime
	{
        /*badanie czasu wykonania
		 *używam klasy Diagnostics   
		 * 
		 * 
		 */
        
        Stopwatch stopwatch = new Stopwatch();

        public void StartTime()
        {
            stopwatch.Restart();
            stopwatch.Start();
        }

        public void StopTimePrint()
        {
            stopwatch.Stop();

            long timeMiliSek = stopwatch.ElapsedMilliseconds;
            long timeCykleProcesora = stopwatch.ElapsedTicks;
            Console.WriteLine("czas w milisekundach= " + timeMiliSek);
            Console.WriteLine("czas w cyklach= " + timeCykleProcesora);
            Console.WriteLine();
        }

 
    }

}