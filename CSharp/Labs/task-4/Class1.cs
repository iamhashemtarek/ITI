using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class Durationn
    {
        uint hours;
        uint minutes;
        uint seconds;

        public uint Hours
        {
            get { return hours; }
            set
            {
                if (value < 0)
                    throw new Exception("plz enter positive num");
                hours = value;
            }
        }
        public uint Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }
        public uint Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        public static Durationn operator -(Durationn d1,  Durationn d2)
        {
            return new Durationn()
            {
                
            };
        }
        
    }
}
