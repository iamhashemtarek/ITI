using System;

namespace task_2
{
    public struct Rectangle
    {
        int width;
        int height;

        public int Width {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("invalid input. width must be a positive number");
                width = value;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("invalid input. height must be a positive number");
                height = value;
            }
        }
        public int getArea()
        {
            return width * height;
        }
        public double getPerimeter()
        {
            return (width + height) * 2;
        }
        public override string ToString()
        {
            return $"width: {width}, height: {height}";
        }
    }
    public struct TimeSpan 
    {
        int hours;
        int minutes;
        int seconds;
        public TimeSpan (int h, int m, int s)
        {
            Hours = h;
            Minutes = m;
            Seconds = s;
        }
        public int Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if(hours < 0 || hours > 24)
                {
                    throw new Exception("invalid input");
                }else
                {
                    hours = value;
                }
            }
        }
        public int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                if (minutes < 0 || hours > 60)
                {
                    throw new Exception("invalid input");
                }else
                {
                    minutes = value;
                }
            }
        }
        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                if (hours < 0 || hours > 60)
                {
                    throw new Exception("invalid input");
                }else
                {
                    seconds = value;
                }
            }
        }
        public long getTotalSeconds()
        {
            return ((Hours * 60 * 60) + (Minutes * 60) + (Seconds));
        }
        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}"; 
        }
        
    }
    
}
