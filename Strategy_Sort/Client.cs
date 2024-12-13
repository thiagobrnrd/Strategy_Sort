using Strategy_Sort;
using System.Diagnostics;

public class Client
{
    public static void Main()
    {
        //Classe Program.

        Stopwatch sw = Stopwatch.StartNew();
        sw.Start();

        
        List list = new List();

        ContextSort context = new ContextSort(new BubbleSort());
        Console.WriteLine("Bubble Sort:");
        context.Sort(list.GetList());
        list.PrintList();
        Console.WriteLine(sw.Elapsed.ToString());

        context.SetSortStrategy(new MergeSort());
        Console.WriteLine("\nMerge Sort:");
        context.Sort(list.GetList());
        list.PrintList();
        Console.WriteLine(sw.Elapsed.ToString());

        context.SetSortStrategy(new QuickSort());
        Console.WriteLine("\nQuick Sort:");
        context.Sort(list.GetList());
        list.PrintList();
        Console.WriteLine(sw.Elapsed.ToString());

        sw.Stop();
    }
}
        
  
