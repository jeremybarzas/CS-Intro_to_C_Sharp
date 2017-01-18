using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialzation_Tutorial
{
    public class Student
    {
        private string mName;
        private int mAge;
        private string mID;

        public Student()
        {
            mName = "Default Name";
            mAge = 0;
            mID = "0000";
        }

        public Student(string n, int a, string i)
        {
            mName = n;
            mAge = a;
            mID = i;
        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public int Age
        {
            get { return mAge; }
            set { mAge = value; }
        }

        public string ID
        {
            get { return mID; }
            set { mID = value; }
        }
    }
}