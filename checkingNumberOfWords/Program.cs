using System;

namespace checkingNumberOfWords
{
    public class Program
    {

        static void Main(string[] args)
        {
            void MyMethod(string stringToBeChecked)
            {
                int i = 0;
            
                foreach(char caracter in stringToBeChecked)
                {
                    if (caracter == ' ') 
                    {
                        i++;
                    }
                }
                i +=1;
                Console.WriteLine(i); ;
            }

            void GPTMethod(string s)
            {
                int count = 0;
                if (!string.IsNullOrEmpty(s))
                {
                    count = s.Split(' ').Length;
                }
                Console.WriteLine(s);
                Console.WriteLine(count); 
            }

            string o = "soa  owowowq k wekwq´ww ";
            var p = o.Split('o');
            foreach(string f in p)
            {
                Console.WriteLine(f);
            }

        }
    }
}
