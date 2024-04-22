using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace algorytm_sortowanie
{
    public class Sorting
    {
        public int[] cyfry; 
        public Sorting(int[] cyfry)
        {
            this.cyfry = cyfry;
        }
        /**************************************
     * nazwa funkcji:       FindHighest()
     * parametry wejściowe: Bierze wartosci z int[] cyfry.
     * wartość zwracana:    int, największa liczba w arrayu
     * autor:               Daniel Siwiec
     *************************************/
        public int FindHighest()
        {
            int currentHigh = int.MinValue;

            foreach(int cyfra in cyfry)
            {
                if (cyfra > currentHigh)
                {
                    currentHigh = cyfra;
                }
            }
            return currentHigh;
        }
        /**************************************
  * nazwa funkcji:       FindLowest()
  * parametry wejściowe: Bierze wartosci z int[] cyfry.
  * wartość zwracana:    int, najmniejsza liczba w arrayu
  * autor:               Daniel Siwiec
  *************************************/
        public int FindLowest()
        {
            int currentLow = int.MaxValue;
            foreach(int cyfra in cyfry)
            {
                if(cyfra < currentLow)
                {
                    currentLow = cyfra;
                }
            }
            return currentLow;
        }
        /**************************************
 * nazwa funkcji:       FindLowestAndExchange()
 * parametry wejściowe: Bierze wartosci z int[] _cyfryC.
 * wartość zwracana:    int, najmniejsza liczba w arrayu
 * autor:               Daniel Siwiec
 *************************************/
        public int[] FindLowestAndExchange()
        {
            int[] _cyfryC = (int[])cyfry.Clone();
            int lowestValue = FindLowest();

            for (int i = 0; i < _cyfryC.Length; i++)
            {
                if (_cyfryC[i] == lowestValue)
                    _cyfryC[i] = i;
            }
            return _cyfryC;
        }
        /**************************************
* nazwa funkcji:       Sort()
* parametry wejściowe: Bierze wartosci z int[] sorted_array
* wartość zwracana:    Posortowana tablica metodą przez wybieranie
* autor:               Daniel Siwiec
*************************************/
        public int[] Sort(int[] sorted_array)
        {
            for(int i = 0; i < sorted_array.Length - 1; i++)
            {
                int min = i;
              for(int j=i + 1; j < sorted_array.Length; j++)
                {
                    if (sorted_array[min] > sorted_array[j])
                    {
                        min = j;
                    }
                }
                int temp = sorted_array[i];
                sorted_array[i] = sorted_array[min];
                sorted_array[min] = temp;
            }

            return sorted_array;
        }

    }
}
