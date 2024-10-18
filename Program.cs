using System;

namespace ElvinParse
{
    class Program
    {
        public static int myAge;
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            string age = Console.ReadLine();
            int a = myAge;
            if (tryElvin(age))
            {
                
                if (a < 18)
                {
                    Console.WriteLine("prava ala bilmirsiniz");
                }
                else
                {
                    if (a >= 18 && a < 25)
                    {
                        Console.WriteLine("abcd koteqoriyali prava ala bilersiniz");
                    }
                    else
                    {


                        Console.WriteLine("butun koteqoriyali prava ala bilersiniz");


                    }
                }


            }
            else
            {
                Console.WriteLine("duzgun daxil ele");
            }
        }

       static bool tryElvin(string myString)
        {
            bool result=true;
            try
            {
                myAge = Convert.ToInt32(myString);
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
           
        }
    
    }
}
