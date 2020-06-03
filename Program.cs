using System;

namespace Ten_Bears_song_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Poem();
          /* int Bears_In_Bed = 10;

           while(Bears_In_Bed > 1)
            {
                Console.WriteLine($"{Bears_In_Bed} bears in the bed and the little one said \"I'm crowded... roll over...\"\n");
                Console.WriteLine("so they all rollerd over and one fell out");
                Bears_In_Bed--;
            }
            Console.WriteLine("One beard in the bed and the little one said \"I'm lonely\"");
            MakeBear();*/
            Console.ReadKey();
        }

        static void MakeBear()
        {
           string bear = @" {''-''}
  (o o)
,--`Y'--.
``:   ;''
  / _ \
 ()' `()   ";
            Console.WriteLine(bear);
        }

        static void Poem()
        {
            int Numbers_add = 1;
            

            for(int poem_count = 12; Numbers_add <= poem_count; Numbers_add++)
            {
                Console.WriteLine($"{Numbers_add} and {Numbers_add} are {Numbers_add + Numbers_add}");
                switch (Numbers_add)
                {

                    case 1:
                        Console.WriteLine("Treats for me and you.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("At the candy store.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Let's get a big mix.");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("The candy is so great.");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Order treats again.");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("Life-size candy elf.");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Lick our fingers clean.");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("Feeling kinda green.");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.WriteLine("Tummy getting mean.");
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.WriteLine("Ate way too many!");
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.WriteLine("Vomit on my shoe.");
                        Console.ReadKey();
                        break;
                    case 12:
                        Console.WriteLine("Candy nevermore!");
                        Console.ReadKey();
                        break;

                }

            }

           
        }


    }

}
