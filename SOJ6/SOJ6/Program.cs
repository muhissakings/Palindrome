using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOJ6
{
    class Program
    {
        static void Main()
        {
            int arr_number = int.Parse(Console.ReadLine());
            for(int i=0; i<arr_number; i++)
            {
                String hint_number = Console.ReadLine().TrimEnd();
                char[] r_number = hint_number.ToCharArray();
                int n = hint_number.Length;
                for(int j=0; j<n/2; i++)
                {
                    r_number[n - j - 1] = r_number[j];
                }
                if (String.Compare(new string(r_number), hint_number) > 0)
                {
                    Console.WriteLine(new String(r_number));
                    continue;

                }

            }
        }
    }
}
