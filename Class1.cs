using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsЗCheck
{
    class Class1: IClass
    {    
        private int [] arr;
        public static int n;
        public Class1(int k)
        {
            Random rand = new Random();
            if (k < 10)
            {
                n = rand.Next(10) + 10;

            }
            else
            {
                n = k;
            }
        }

        public int this[int index]
        {
            get
            {
                return arr[index];
            }
        }


        public string Method1()
        {
            arr = new int[n];
            int lenght = n;
            string ss = "";
            Random rand = new Random();
            for (int i=0; i<lenght; i++)
            {
                arr[i] = rand.Next(100)-50;
                ss = ss + arr[i] + "; ";
            }
                    
            int s = 0;
            for(int i=0;i<lenght; i++)
            {
                if (arr[i] %2 == 0)
                {
                    s++;
                }
            }
            ss = ss +" Четных чисел = "+ s + " ";
            return ss;
        }

        public string Method1(int number)
        {
            arr = new int[n];
            int lenght = n;
            string ss = "";
            Random rand = new Random();
            for (int i = 0; i < lenght; i++)
            {
                arr[i] = rand.Next(100)-50;
                ss = ss + arr[i] + ";";
            }
            int[] a = new int[lenght];
            int j = 0;        
            for (int i = 0; i < lenght; i++)
            {
                if (arr[i] > 0 && arr[i] > number)
                {
                    a[j] = arr[i];
                    j++;
                }
            }
            ss = ss + " Нужные числа: ";        
            for (int i = j-1; i>=0; i--)
            {
                ss = ss  + a[i] + " ";
            }
            return ss;
        }       
    }
}
