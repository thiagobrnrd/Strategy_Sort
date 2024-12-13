using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Sort
{
    public class QuickSort : ISort
    {
        public void Sort(List<int> lista)
        {
            QuickSortRec(lista, 0, lista.Count - 1);
        }

        private void QuickSortRec(List<int> lista, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(lista, low, high);
                QuickSortRec(lista, low, pivotIndex - 1);
                QuickSortRec(lista, pivotIndex + 1, high);
            }
        }

        private int Partition(List<int> lista, int low, int high)
        {
            int pivot = lista[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (lista[j] <= pivot)
                {
                    i++;
                    int temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                }
            }

            int temp1 = lista[i + 1];
            lista[i + 1] = lista[high];
            lista[high] = temp1;

            return i + 1;
        }
    }

}
