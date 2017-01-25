using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMExample
{
     public enum LightState
        {
            INIT = -1, RED = 0, GREEN = 1, YELLOW = 2, EXIT = 3,
        }

        public enum PlayerState
        {
            INIT = 0,
            IDLE = 1,
            WALK = 2,
            RUN = 3,
        }

        public enum PLAYER
        {
            SMOKE,
            IDLE,
            JUMP,
            MOVE,
            GROUNDED,
            AIRBORNE,
        }
   
    class Program
    {     
        class LightBehaviour
        {
            static public void RedLightBehaviour()
            {
                Console.WriteLine("I'm at the redlight");
            }
            static public void GreenLightBehaviour()
            {
                Console.WriteLine("I'm at the greenlight");
            }
            static public void YellowLightBehaviour()
            {
                Console.WriteLine("I'm at the yellowlight");
            }
        }

        public delegate void Handler();

        static void Main(string[] args)
        {
            //FSM<PLAYER> fsm = new FSM<PLAYER>();
            //usage would be 
            FSM<LightState> trafficFSM = new FSM<LightState>();

            trafficFSM.AddTransition(LightState.INIT, LightState.RED);
            trafficFSM.AddTransition(LightState.RED, LightState.GREEN);
            trafficFSM.AddTransition(LightState.GREEN, LightState.YELLOW);
            trafficFSM.AddTransition(LightState.YELLOW, LightState.RED);
            trafficFSM.GetState(LightState.RED).AddEnterFunction((Handler)LightBehaviour.RedLightBehaviour);

            trafficFSM.Start();

            while (true)
            {
                trafficFSM.Update();
            }
        }
    }
}