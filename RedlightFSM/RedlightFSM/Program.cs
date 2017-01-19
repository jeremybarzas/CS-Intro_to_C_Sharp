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
        INIT = 0, RED = 1, GREEN = 2, YELLOW = 3, EXIT = 9000,
    }

    class Program
    {
        static void Main(string[] args)
        {
            Transition InitToRed = new Transition(-1, new State(LightState.INIT));
            Transition RedToGreen = new Transition();
            Transition GreenToYellow = new Transition();
            Transition YellowToRed = new Transition();

            Transition RedToExit = new Transition();
            Transition GreenToExit = new Transition();
            Transition YellowToExit= new Transition();

            State init = new State(LightState.INIT);
            State exit = new State(LightState.EXIT);
            State red = new State(LightState.RED);
            State green = new State(LightState.GREEN);
            State yellow = new State(LightState.YELLOW);
           
            FSM RedlightFSM = new FSM(init);

            Stopwatch timer = new Stopwatch();
            timer.Start();

            while (true)
            {
                Console.WriteLine(timer.Elapsed.Seconds);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}