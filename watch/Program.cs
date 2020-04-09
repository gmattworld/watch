using System;

namespace watch
{
    class Program
    {
        private readonly Stopstart stopstart;

        static void Main(string[] args)
        {
            // Introductory Message
            Console.WriteLine("Welcome to Console StopWatch");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Program program = new Program();
            program.stopwatch();
        }

        public Program()
        {
            // Instatiate Stopwatch
            stopstart = new Stopstart();
        }

        public void stopwatch(bool isrunning = false)
        {
            try
            {
                if (!isrunning)
                {
                    Console.Write("To start the stop watch, kindly Press 'Start' and hit enter button:  ");
                }

                var input = Console.ReadLine().ToLower();

                if (input == "start" || input == "s")
                {
                    stopstart.Start();
                    Console.WriteLine("===============================");
                    Console.WriteLine("Stopwatch running...");
                    Console.Write("To stop the stopwatch, kindly press 'Stop' and hit enter button: ");
                    stopwatch(true);
                }
                else if (input == "stop")
                {
                    stopstart.Stop();
                    Console.WriteLine("===============================");
                    Console.WriteLine("Stopwatch Stopped...");
                    Console.WriteLine($"The stop watch ran for : {stopstart.Getduration()}");

                    Console.WriteLine("\n");
                    Console.WriteLine("===============================");

                    Console.Write("To try again press 'rerun' and hit enter button:  ");
                    var check = Console.ReadLine().ToLower();

                    if (check == "rerun")
                    {
                        Console.WriteLine("\n");
                        stopwatch();
                    }
                    else
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Thank you for using my solution");
                    }
                }
                else
                {
                    Console.WriteLine("===============================");
                    Console.Write("Invalid user input:  ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
