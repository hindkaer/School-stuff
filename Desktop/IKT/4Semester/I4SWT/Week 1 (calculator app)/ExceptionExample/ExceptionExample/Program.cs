using System;

namespace ExceptionExample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Course for new ship? ");
            var course = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Speed for new ship? ");
            var speed = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("");


            try
            {
                Console.WriteLine("Creating ship...");
                var ship = new Ship(course, speed); // Should throw exception if i > 7
                Console.WriteLine("Done. New Ship created, heading course {0} at {1} knots", ship.Course, ship.Speed);
            }
            catch (CourseException ce)
            {
                Console.WriteLine("Error in course. Is {0}, should be in [0;360[", ce.Course);
            }

            catch (SpeedException se)
            {
                Console.WriteLine("Error in speed. Is {0}, should be in [0;100[", se.Speed);
            }
            finally
            {
                Console.WriteLine("In finally{}");
            }

        }
    }
}
