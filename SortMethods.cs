using System;

namespace AlgorytmySortowanie
{
    public partial class Program
    {
        /*metody sortowania
         * Bubble Sort /bąbelkowe/
         * Selection Sort /przez wybór najmniejszego/
         * Insert Sort/przez wstawianie_bierzemy kolejny i porównujemy z posortowanymi/
         */

        public static int[] BubbleSort(int[] tab)
        {
            for (int i = 0; i < (tab.Length - 1); i++)
            {
                for (int j = 0; j < (tab.Length - 1 - i); j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int i1 = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = i1;
                    }
                }
            }
            return tab;
        }

        public static int[] SelectionSort(int[] tab)
        {
            int minInt, nrMinInt;

            for (int i = 0; i < tab.Length; i++)
            {
                minInt = tab[i];
                nrMinInt = i;
                for (int j = i+1; j < tab.Length; j++)
                {
                    if (minInt > tab[j])
                    {
                        minInt = tab[j];
                        nrMinInt = j;
                    }
                }
                if (nrMinInt != i)
                {
                    tab[nrMinInt] = tab[i];
                    tab[i] = minInt;
                }
            }
            return tab;
        }

        public static int[] InsertSort(int[] tab)
        {
            for (int i = 1; i < tab.Length; i++)
            {
                for (int j = i; j>0; j--)
                {
                    if (tab[j] < tab[j - 1])
                    {
                        int i1 = tab[j];
                        tab[j] = tab[j - 1];
                        tab[j - 1] = i1;                     
                    }
                    else break;
                }

                if (i==9)
                {
                    ;
                }

            }


            return tab;
        }





    }
}
