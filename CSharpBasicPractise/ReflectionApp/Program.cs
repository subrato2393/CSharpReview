using System;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ReflectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /////General Way..............
            Console.WriteLine("Please Select Which You Want");
            //Console.WriteLine("Bat");
            //Console.WriteLine("Ball");
            //Console.WriteLine("Cap");

            //while (true)
            //{
            //    var input = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(input))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        if (input == "Bat")
            //        {
            //            var bat = new Bat();
            //            bat.PrintMe();
            //        }
            //        else if (input == "Ball")
            //        {
            //            var boll = new Ball();
            //            boll.PrintMe();
            //        }
            //        else if (input == "Cap")
            //        {
            //            var cap = new Cap();
            //            cap.PrintMe();
            //        }
            //    }
            //}
            ////------Using Reflection...
            Assembly assembly =Assembly.GetExecutingAssembly();
            Type[] types= assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.GetInterfaces().Any(x => x.Name == "IGameItem"))
                {
                    Console.WriteLine(type.Name);
                }
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                var userType = Type.GetType("ReflectionApp" + "." + input);
                var constructorInfo = userType.GetConstructor(new Type[] { });
                var objInfo = (IGameItem)constructorInfo.Invoke(new object[] { });
                objInfo.PrintMe();
            }
           Console.ReadLine();
        }
    }
}
