using System.Diagnostics;

namespace RedlightFSM
{
    public enum LightState
    {
        INIT = -1, RED = 0, GREEN = 1, YELLOW = 2, EXIT = 3,
    }

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

        }

        public void End()
        {

        }
    }
}