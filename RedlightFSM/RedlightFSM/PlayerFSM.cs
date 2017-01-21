using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedlightFSM
{
    public enum PlayerState
    {
        INIT = -1, IDLE = 0, WALK = 1, RUN = 2,
    }

    class PlayerFSM
    {
        private PlayerState currentState;

        public PlayerFSM() { }

        public void Start()
        {
            currentState = PlayerState.INIT;
        }

        public void Update()
        {
            switch (currentState)
            {
                case PlayerState.INIT:
                    InitHandler();
                    break;

                case PlayerState.IDLE:
                    IdleHandler();
                    break;

                case PlayerState.WALK:
                    WalkHandler();
                    break;

                case PlayerState.RUN:
                    RunHandler();
                    break;

                default:
                    break;
            }
        }

        void InitHandler()
        {
            Console.WriteLine("I am initilizing.\n");
            currentState = PlayerState.IDLE;
        }

        void IdleHandler()
        {
            Console.WriteLine("I am idling.\n");
            currentState = PlayerState.WALK;
        }

        void WalkHandler()
        {
            Console.WriteLine("I am walking.\n");
            currentState = PlayerState.RUN;
        }

        void RunHandler()
        {
            Console.WriteLine("I am running.\n");
            currentState = PlayerState.WALK;
        }
    }
}