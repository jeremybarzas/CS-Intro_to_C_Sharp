using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RedlightFSM
{
    public enum LightState
    {
        INIT = -1, RED = 0, GREEN = 1, YELLOW = 2, EXIT = 3,
    }

    class Program
    {
        static void redlight()
        {
            Stopwatch timer = new Stopwatch();

            RedlightFSM redlightFSM = new RedlightFSM(timer);

            redlightFSM.Start();

            while (true)
            {
                redlightFSM.Update();
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
            redlight();
        }
    }
}