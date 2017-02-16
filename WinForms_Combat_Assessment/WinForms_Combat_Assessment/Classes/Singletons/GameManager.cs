using System;
using System.Collections.Generic;


namespace WinForms_Combat_Assessment
{
    public class GameManager
    {
        public DataManager DataManager { get; set; }

        private GameManager()
        {
            DataManager = new DataManager();
        }

        private static readonly GameManager instance = new GameManager();

        public static GameManager Instance
        {
            get { return instance; }           
        }
    }
}