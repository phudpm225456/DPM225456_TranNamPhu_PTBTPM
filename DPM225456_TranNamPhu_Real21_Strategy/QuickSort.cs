using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225456_TranNamPhu_Real21_Strategy
{
    class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();  // Default is Quicksort
            Console.WriteLine("QuickSorted list ");
        }
    }
}
