using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    class Ship
    {
        public uint Course { get; private set; }
        public uint Speed { get; private set; }

        public Ship(uint course, uint speed)
        {
            if (speed < 100)    
                Speed = speed;
            else 
                throw new SpeedException(speed);
            
            if (course < 360)
                Course = course;
            else throw new CourseException(course);
        }
    }
}
