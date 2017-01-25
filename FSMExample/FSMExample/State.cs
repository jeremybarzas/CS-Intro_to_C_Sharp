using System;

namespace FSMExample
{
    class State
    {
        public State()
        { }

        public State(Enum e)
        {
            name = e.ToString();
        }

        public string name;
        public delegate void OnEnter();
        public delegate void OnExit();
        public OnEnter onEnter;
        public OnExit onExit;

        public void AddEnterFunction(Delegate d)
        {
            onEnter += d as OnEnter;
        }
    }
}