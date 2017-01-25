using System;
using System.Diagnostics;

namespace RedlightFSM
{
    class RedlightFSM
    {
        public Stopwatch stopwatch;
        public LightState current;

        public RedlightFSM() { }

        public RedlightFSM(Stopwatch s)
        {
            stopwatch = s;
        }

        private void ChangeState(LightState s)
        {
            current = s;
        }

        public void Initialize()
        {
            stopwatch.Start();
        }

        public void Start()
        {
            ChangeState(LightState.INIT);
        }

        public void Update()
        {
            if (current == LightState.INIT)
            {
                current = LightState.RED;
                Console.WriteLine(current.ToString());
               Initialize();
            }

            if (stopwatch.Elapsed.Seconds > 5 && current == LightState.RED)
            {
                current = LightState.GREEN;
                stopwatch.Restart();
                Console.WriteLine(current.ToString());
            }

            if (stopwatch.Elapsed.Seconds > 5 && current == LightState.GREEN)
            {
                current = LightState.YELLOW;
                stopwatch.Restart();
                Console.WriteLine(current.ToString());
            }

            if (stopwatch.Elapsed.Seconds > 2 && current == LightState.YELLOW)
            {
                current = LightState.RED;
                stopwatch.Restart();
                Console.WriteLine(current.ToString());
            }
        }

        public void End()
        {

        }
    }
}