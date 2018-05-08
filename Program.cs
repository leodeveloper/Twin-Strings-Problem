using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        /*
         * Complete the function below.
         * DO NOT MODIFY CODE OUTSIDE THIS FUNCTION!
         */
        static string[] twins(string[] a, string[] b)
        {
            string[] veri = new string[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                char[] text = a[i].ToCharArray();
                int sayi = 0;
                for (int j = 0; j < text.Length; j++)
                {

                    if (sayi < 2)
                    {
                        char temp = text[j];
                        text[j] = text[j + 2];
                        text[j + 2] = temp;
                    }
                    else if (sayi == 4)
                    {
                        sayi = 0;
                    }

                    sayi++;
                }
                string str = "";
                for (int k = 0; k < text.Length; k++)
                {
                    str += text[k].ToString();
                }
                veri[i] = str;
            }

            string[] sonuc = new string[2];
            for (int l = 0; l < b.Length; l++)
            {
                if (veri[l] == b[l])
                {
                    sonuc[l] = "Yes";
                }
                else
                {
                    sonuc[l] = "No";
                }
            }
            return sonuc;
        }
        // DO NOT MODIFY CODE OUTSIDE THE ABOVE FUNCTION!

        static void Main(String[] args)
        {
            string[] res;

            int _a_size = 0;
            _a_size = Convert.ToInt32(Console.ReadLine());
            string[] _a = new string[_a_size];
            string _a_item;
            for (int _a_i = 0; _a_i < _a_size; _a_i++)
            {
                _a_item = Console.ReadLine();
                _a[_a_i] = _a_item;
            }


            int _b_size = 0;
            _b_size = Convert.ToInt32(Console.ReadLine());
            string[] _b = new string[_b_size];
            string _b_item;
            for (int _b_i = 0; _b_i < _b_size; _b_i++)
            {
                _b_item = Console.ReadLine();
                _b[_b_i] = _b_item;
            }

            res = twins(_a, _b);
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }

            Console.ReadLine();
        }
    }
}
