using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Sort
{
    public class MergeSort : ISort
    {
        public void Sort(List<int> lista)
        {
            if (lista.Count <= 1) return;

            int mid = lista.Count / 2;
            var left = lista.GetRange(0, mid);
            var right = lista.GetRange(mid, lista.Count - mid);

            Sort(left);
            Sort(right);

            Merge(lista, left, right);
        }

        private void Merge(List<int> lista, List<int> left, List<int> right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i] <= right[j])
                {
                    lista[k++] = left[i++];
                }
                else
                {
                    lista[k++] = right[j++];
                }
            }

            while (i < left.Count)
            {
                lista[k++] = left[i++];
            }

            while (j < right.Count)
            {
                lista[k++] = right[j++];
            }
        }
    }

}
