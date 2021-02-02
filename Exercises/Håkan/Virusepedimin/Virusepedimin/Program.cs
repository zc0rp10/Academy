using System;
using System.Collections.Generic;

namespace Virusepedimin
{
    class Program
    {

        static void Main(string[] args)
        {
            // Setup
            var diskotek = new List<Person>();
            for (int i = 0; i < 999; i++)
            {
                diskotek.Add(new Person(false, false));
            }
            diskotek.Add(new Person(true, false, 5));


            // Infect
            int hour = 0;
            int infected = 0;
            int immune = 0;
            int spread = 1;

            while (true)
            {
                hour++;
                for (int i = 0; i < diskotek.Count; i++)
                {
                    if (!diskotek[i].Immune)
                    {

                        if (diskotek[i].Infected == true)
                        {
                            if (diskotek[i].InfectedWhen != -1)
                                diskotek[i].InfectedWhen--;
                                
                            if (diskotek[i].InfectedWhen == 0)
                            {
                                immune++;
                                diskotek[i].Immune = true;
                            }
                            else
                                infected++;
                        }

                        else
                            if (spread > 0)
                        {

                            spread--;
                            infected++;
                            diskotek[i].InfectedWhen = 5;
                            diskotek[i].Infected = true;
                        }
                    }
                    else
                        immune++;
                }

                // Present
                Console.WriteLine($"Infected: {infected}, Immune: {immune}, Hour: {hour}");
                Console.ReadKey(true);
                spread = infected;
                infected = 0;
                immune = 0;
            }
        }
    }
}