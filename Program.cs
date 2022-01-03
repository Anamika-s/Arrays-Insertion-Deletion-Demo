using System;

namespace ArraysDemo
{
    class Program
    {
        static int[] num = new int[] {1,4,6,10,0,0,0,0,0,0};
        static int pos =0;
        static void Main(string[] args)
        {
           Display();
           Console.Write("Enter Element to insert");
           int x = Int32.Parse(Console.ReadLine());
           Insert(x);
           Display();
           Console.Write("Enter Element to delete");
           int x = Int32.Parse(Console.ReadLine());
           Delete(x);
           Display();
       
        }
        static int Get0()
        {
            for(int i = 0; i< num.Length ; i++)
            {
                if(num[i]==0){
                pos = i;
                break; }
            }
            return  pos;
        }
        static void Insert(int x)
        {
            int i;
            int pos = Get0();
           
            if(x < num[0])
            {
                for(int j=Get0() ; j>0 ; j--)
                {
                    num[j] = num[j-1];
                }
                num[0] = x;

            }
            else if(x >= num[pos-1])
            {
                num[pos] = x;
            }
            else  
            {
            for(i=0;i < num.Length; i++)
            {
                if(x >=num[i] && x <num[i+1])
                {
                    for(int j=Get0(); j>i ; j--)
                    {
                     //   Console.WriteLine(num[j] + " " + num[j+1]);
                        num[j] = num[j-1];

                    }
                    num[i+1] = x;
                    break;
                }
            }    
            
            }    
        }
        static void Delete(int x)
        {
           if(x  ==  num[Get0()-1])
               num[Get0()-1] = 0;
               else 
               {
                   for(int i=0;i<num.Length;i++)
               {
                if(x== num[i])
                {
                    Console.WriteLine(num[i] + " element found at "  + i + "position");
                    for(int j = i ;j < Get0() ; j++)
                    {
                        num[j] = num[j+1];
                    }
                }
               }
               }

        }
        static void Display()
        {
            foreach(int temp in num)
            Console.Write(temp + " " );
        }
    }
}
