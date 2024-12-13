using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Sort
{
    public class ContextSort
    {
        private ISort _sortStrategy;

        public ContextSort(ISort sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void SetSortStrategy(ISort sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Sort(List<int> lista)
        {
            _sortStrategy.Sort(lista);
        }
    }
}
