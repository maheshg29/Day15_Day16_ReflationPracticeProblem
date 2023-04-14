using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Day16_ReflationPracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Day 15 and Day 16 Practice Problem");
            Console.WriteLine("Please Enter Digit ");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            int closestNumber = ClosestNumber.FindClosestEvenNumber(givenNumber);
            Console.WriteLine("Closest Even number with all even digit is "+closestNumber);

            //Reflaction
            Console.WriteLine("======******======\nClass Member Data");
            Type type = typeof(ClosestNumber);
            MemberInfo[] members = type.GetMembers();

            foreach (MemberInfo member in members)
            {
                Console.WriteLine(member);
            }

            //Create empty object
            Console.WriteLine("======******======\nCreate empty object");
            object obj = Activator.CreateInstance(type);
            Console.WriteLine(obj.GetType().Name);
        }
    }
}
