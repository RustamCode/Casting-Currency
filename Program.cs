using System;

namespace Casting
{ enum  Currency { dollar , euro , lire }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please add azn : ");
            double azn = double.Parse(Console.ReadLine());
            Console.WriteLine(Exchange(Currency.dollar,azn));


            
        }
        public static double Exchange(Enum obj , double azn)
        {
            if (obj is Enum)
            {
                switch (obj)
                {
                    case Currency.dollar:
                        {
                            azn = azn / 1.7;
                            break;
                        }
                    case Currency.lire:
                        {
                           azn = azn * 8.3;
                            break;
                        }
                    case Currency.euro:
                        {
                            azn =azn /2;
                            break;
                        }
                      
                }

               
                }
                else
                {
                Console.WriteLine("Please select a currency");
                }
            return azn;

            
        }
    }
}
