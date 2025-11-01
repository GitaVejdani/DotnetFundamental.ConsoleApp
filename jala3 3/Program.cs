using System;

namespace jala3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 0; i <10; i++)
            {
                if (i == 4)
                {
                    break;
                        }
                    
                i =( i * i);
                Console.WriteLine(i);
                
            }

            for (int j = 0; j <10; j++)
            {
                if (j == 4)
                {
                    continue;
                }
                j = (j*2);
                Console.WriteLine(j);
            }


            while(true)
                {
               
                Console.WriteLine("hi");
                break;
           
            }
            int l = 0;
            do
            {
                l = l * 2;
                Console.WriteLine(l);
                l++;
            }
            while (l < 10);
        }
    }
}
