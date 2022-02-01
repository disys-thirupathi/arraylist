using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class print
{
    public void show(ArrayList arr)
    {
        for (int i = 0; i < arr.Count; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        print p = new print();
        ArrayList arr = new ArrayList();
        arr.Add("Akash");
        arr.Add("Nitesh");
        arr.Add("Jeydev");
        p.show(arr);
        Console.WriteLine("Appending element will add at the end of all other elements in the list");
        arr.Add("Thirupathi");
        p.show(arr);
        Console.WriteLine("Insert using index value");
        arr.Insert(2, "Vishwa");
        p.show(arr);
        Console.WriteLine("Searching operation in arraylist");
        if (arr.Contains("Thirupathi"))
        {
            Console.WriteLine("Element found 'Thirupathi'");
        }
        else
        {
            Console.WriteLine("Element not found");
        }
        Console.WriteLine("Enter the starting element to search in the arraylist");
        string filterME = Console.ReadLine();
        int flag = 0;
        foreach (string s in arr)
        {
            if (s.Contains(filterME))
            {
                flag++;
            }
        }
        if (flag >= 1)
        {
            Console.WriteLine("Element found");
        }
        else
        {
            Console.WriteLine("Element not found");
        }
        Console.ReadLine();
    }
}