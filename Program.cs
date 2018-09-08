using System;
using System.Collections.Generic;

namespace GenericsImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> li=new List<int>();
           li.Add(1);
           li.Add(2);li.Add(3);li.Add(4);li.Add(5);
           foreach(int i in li)
           Console.Write(i+" ");
           Console.WriteLine();
          
           li.Insert(3,6);
           foreach(int i in li)
           Console.Write(i+" ");
           Console.WriteLine();
          
           li.Remove(1);
           foreach(int i in li)
           Console.Write(i+" ");
           Console.WriteLine();
           Console.ReadLine();

           
            
        }
    }
    // class Generic1
    // {
    //     public bool Compare(int a,int b)
    //     {
    //         if (a==b)
        
    //         {
    //             return true;
    //             return false;
                
    //         }
            
    //     }
    // }
    
}
