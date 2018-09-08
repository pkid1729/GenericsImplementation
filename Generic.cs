using System;
using System.Collections.Generic;

namespace GenericsImplementation
{

    class Generic1
    {
        public bool Compare(int a,int b)
        {
            if (a==b)
        
            
                return true;
                return false;
                
            
            
        }
        static void Main()
        {
            Generic1 obj=new Generic1();
             bool result=obj.Compare(10,20);
             Console.WriteLine(result);
             Console.ReadLine();

        }
    }
}