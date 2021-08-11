using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Activity_12_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str;
            int i, wrd, l;


            //str = Console.ReadLine();
            string filename = "C:/Users/ieish/source\repos/Activity 12(1)/Activity 12(1)/Main.cs";
            string str  = System.IO.File.ReadAllText("Input.txt");




            l = 1;
            wrd = 1;

            /* loop till end of string */
            while (l <= str.Length - 1)
            {
                /* check whether the current character is white space or new line or tab character*/
                if ((str[l] == '.' || str[l] == ' ' || str[l] == '\t' || str[l] == '!' || str[l] == ',' || str[l] == '?' || str[l] == '\n') && (str[l - 1] == 't' || str[l - 1] == 'e'))
                {
                    wrd++;
                }


                l++;
            }

            Console.Write("There are {0} words ending in t or e", wrd);
            Console.ReadLine();

        }
    }
}
