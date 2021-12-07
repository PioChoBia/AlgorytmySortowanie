using System;


namespace AlgorytmySortowanie
{
    partial class Program
    {
       static  void DisplayResults(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
        }




        static void Main(string[] args)
        {

            MeasureTime measureTime = new MeasureTime();
            int[] tabDemo = { 9, 0, 3, 4, 5, 2, 1, 6, 8, 7 };
            DisplayResults( tabDemo );

            measureTime.StartTime();

            // DisplayResults( BubbleSort(tabDemo) );
            //DisplayResults( SelectionSort(tabDemo) );
            //DisplayResults( InsertSortLinear(tabDemo) );
            DisplayResults( CountingSort(tabDemo) );

            measureTime.StopTimePrint();


        }  
    }
}
