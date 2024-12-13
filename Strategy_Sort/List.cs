using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Sort
{
    public class List
    {
        private List<int> lista = new List<int> { 3, 1, 4, 2, 5, 9, 2, 6, 5, 3, 5 };

        public List<int> GetList()
        {
            return lista;
        }

        public void PrintList()
        {
            foreach (var item in lista)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
