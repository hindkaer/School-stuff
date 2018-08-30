using System;

namespace ExceptionExample
{
    public class CourseException : Exception
    {
        public uint Course { get; private set; }
        public CourseException(uint course)
        {
            Course = course;
        }
    }
}