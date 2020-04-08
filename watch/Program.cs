using System;

namespace watch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopstart = new Stopstart();

            while(true)
            {
                try
                {
                    Console.WriteLine("Enter 'start' to start stopwatch\n\n Enter 'stop' to end stopwatch\n\n press any key to stop");
                    var input = Console.ReadLine().ToLower();

                    if (input == "start")
                    { stopstart.Start(); }
                    else if (input == "stop")
                    { stopstart.Stop();
                        Console.WriteLine("Duration: {0}", stopstart.Getduration());
                    }

                    else
                        break;

                }
                catch(InvalidOperationException)
                {
                    Console.WriteLine("stopwatch is in motion");
                }
            }

        }


        


    }
}



