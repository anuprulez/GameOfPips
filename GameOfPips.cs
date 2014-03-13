using System;

namespace GameOfPips
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = 0, temp = 0;
            
            Console.WriteLine("\nEnter how many numbers");
            count = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[count];
            for (int counter = 0; counter < count; counter++)
            {
                Console.WriteLine("\nEnter number: ");
                numbers[counter] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);
            temp = numbers[0];

            for (int counter = 0; counter < numbers.Length; counter++)
            {
                if ((numbers[counter] % temp) != 0)
                {
                    Console.WriteLine("Not a factor");
                    Console.ReadLine();
                    break;
                }

                if(counter == (numbers.Length - 1))
                {
                    while(true)
                    {
                        if((temp % 2) == 0)
                        {
                            temp = temp / 2;
                        }
                        else
                        {
                            Console.WriteLine("\nThe number is: " + temp);
                            Console.ReadLine();
                            break;
                        }
                    }
                }
            }
        }
    }
}
