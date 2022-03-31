using System;

namespace Casting
{ enum  Currency { dollar , euro , lire }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please add azn : ");
            double azn = double.Parse(Console.ReadLine());
            Console.Write("Please select a currency : " +
                "1.Azn to Dollar\n "+
                "2.Azn to Lire\n"+
                "3.Azn to Eure");
            Console.WriteLine();int select = int.Parse(Console.ReadLine());
            
            switch(select)
            {
                case 1:
                    Console.WriteLine(Exchange(Currency.dollar , azn));
                    break;
                case 2:
                    Console.WriteLine(Exchange(Currency.lire, azn));
                    break;
                case 3:
                    Console.WriteLine(Exchange(Currency.euro, azn));
                    break;

            }


            
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
