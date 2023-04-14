using System;
using System.Reflection;

namespace Day15_Day16_ReflationPracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Day 15 and Day 16 Practice Problem");
            Console.WriteLine("Select correcct option for\n" +
                "1. To find Closest Even number with all even digit\n" +
                "2. Fetch all class members (like methods, constructors,properties) using reflection.\n" +
                "3. Create empty object (default constructor) of above class using reflection.\n" +
                "4. Create parameterized object using reflection.\n" +
                "5. Invoke method using reflection.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Please Enter Digit ");
                    int givenNumber = Convert.ToInt32(Console.ReadLine());
                    int closestNumber = ClosestNumber.FindClosestEvenNumber(givenNumber);
                    Console.WriteLine("Closest Even number with all even digit is " + closestNumber);
                    break;

                case 2:
                    //Reflaction
                    Console.WriteLine("======******======\nClass Member Data");
                    Type type = typeof(ClosestNumber);
                    MemberInfo[] members = type.GetMembers();

                    foreach (MemberInfo member in members)
                    {
                        Console.WriteLine(member);
                    }
                    break;

                case 3:
                    //Create empty object
                    Console.WriteLine("======******======\nCreate empty object");
                    Type type1 = typeof(ClosestNumber);
                    object obj = Activator.CreateInstance(type1);
                    Console.WriteLine(obj.GetType().Name);
                    break;

                case 4:
                    //Create parameterized object
                    Type type2 = typeof(ClosestNumber);
                    object argument = "This is Mahesh's Code";
                    object parameterizedObj = Activator.CreateInstance(type2, argument);
                    break;

                case 5:
                    //Invoke method using reflection.
                    Type type3 = typeof(ClosestNumber);
                    object objForMethod = Activator.CreateInstance(type3);
                    MethodInfo methodInfo = type3.GetMethod("SampleMethod");
                    methodInfo.Invoke(objForMethod,null);

                    //This is for Static Methode
                    Console.WriteLine("Please Enter Digit ");
                    int inputNumber = Convert.ToInt32(Console.ReadLine());
                    object[] argumentOfStaticMethod = { inputNumber } ;
                    MethodInfo staticMethodInfo = type3.GetMethod("FindClosestEvenNumber"); 
                    int result = (int)staticMethodInfo.Invoke(null, argumentOfStaticMethod);
                    Console.WriteLine("Closest Even number with all even digit is " + result);
                    break;

                default:
                    Console.WriteLine("Select Correct Option for operation");
                    break;
            }
        }
    }
}
