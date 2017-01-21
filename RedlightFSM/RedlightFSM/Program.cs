using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RedlightFSM
{
    class Program
    {
        static void redlight()
        {
            Stopwatch timer = new Stopwatch();

            RedlightFSM redlightFSM = new RedlightFSM(timer);

            redlightFSM.Start();

            while (true)
            {
                if (redlightFSM.current == LightState.INIT)
                {
                    redlightFSM.current = LightState.RED;
                    Console.WriteLine(redlightFSM.current.ToString());
                    redlightFSM.Initialize();
                }

                if (redlightFSM.stopwatch.Elapsed.Seconds > 5 && redlightFSM.current == LightState.RED)
                {
                    redlightFSM.current = LightState.GREEN;
                    redlightFSM.stopwatch.Restart();
                    Console.WriteLine(redlightFSM.current.ToString());
                }

                if (redlightFSM.stopwatch.Elapsed.Seconds > 5 && redlightFSM.current == LightState.GREEN)
                {
                    redlightFSM.current = LightState.YELLOW;
                    redlightFSM.stopwatch.Restart();
                    Console.WriteLine(redlightFSM.current.ToString());
                }

                if (redlightFSM.stopwatch.Elapsed.Seconds > 2 && redlightFSM.current == LightState.YELLOW)
                {
                    redlightFSM.current = LightState.RED;
                    redlightFSM.stopwatch.Restart();
                    Console.WriteLine(redlightFSM.current.ToString());
                }
            }
        }

        static void player()
        {
            PlayerFSM playerfsm = new PlayerFSM();

            playerfsm.Start();
            
            while(true)
            {
                playerfsm.Update();
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            player();
        }
    }
}