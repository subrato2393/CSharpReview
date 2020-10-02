using System;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace AllProgramApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reflection 
            // ReflectionMethod();

            //Delegate
            // DelegateFuncAndActionMethod();

            //Event
            Button button = new Button();
            button.activity += new Button.Activity(Click);
            Click();
            Console.ReadLine();

        }

        public static  void Click()
        {
            Console.WriteLine("Button Click Event fired");
        }

        private static void DelegateFuncAndActionMethod()
        {
            Action<int, int> action = new Action<int, int>(new Bat().GetBatSize);
            // Bat.BatDelegate batDelegate = new Bat.BatDelegate(new Bat().GetBatSize);
            //batDelegate(5, 8);
            action(5, 9);
            Bat.BatDelegate batDelegate1 = new Bat.BatDelegate(Program.GetHeight);
            batDelegate1(8, 9);

            //Bat.HeightDelegate returnDelegate = new Bat.HeightDelegate(new Bat().GetHeights);
            //var x= returnDelegate.Invoke(4);
            Func<int, int> func = new Func<int, int>(new Bat().GetHeights);
            int x = func(100);
            Console.WriteLine("Return delegate =" + x);
            Console.ReadLine();
        }

        public static void GetHeight(int x, int y)
        {
            Console.WriteLine("Result = "+(x*y));
        }
       
        
        private static void ReflectionMethod()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();

            Console.WriteLine("All types In this assembly");
            foreach (var item in types)
            {
                if (item.Name != "Program")
                {
                    Console.WriteLine(item.Name);
                }
            }
            var type = Type.GetType(assemblyName + ".Player");
            Console.WriteLine("Get The Type Name");
            Console.WriteLine(type.Name);

            ConstructorInfo consInfo = type.GetConstructor(new Type[] { typeof(int), typeof(string) });
            //  var e = consInfo.Invoke(new object[] { 4, "subroto" });
            // Console.WriteLine("0000000000000000000000000 "+e.ToString());
            var parameterInfo = consInfo.GetParameters();
            Console.WriteLine();
            foreach (var item in parameterInfo)
            {
                Console.WriteLine("ffffffffffff" + item.ParameterType + " " + item.Name);
            }
            MethodInfo[] methodInfos = type.GetMethods();
            Console.WriteLine("All Method in Player Class");
            foreach (var item in methodInfos)
            {
                Console.WriteLine(item.Name);
            }
            MethodInfo methodInfo = type.GetMethod("GetPlayerFullInfo");
            var parameter = methodInfo.GetParameters();
            Console.WriteLine("All parameter in Method");
            foreach (var item in parameter)
            {
                Console.WriteLine(item.ParameterType + " " + item.Name);
            }

            PropertyInfo[] propertyInfos = type.GetProperties();
            Console.WriteLine("All properties");
            foreach (var item in propertyInfos)
            {
                Console.WriteLine(item.PropertyType + " " + item.Name);
            }
            Console.WriteLine("Field name in class");
            FieldInfo[] fieldInfos = type.GetFields();
            foreach (var item in fieldInfos)
            {
                Console.WriteLine(item.Name);
            }
            FieldInfo fieldInfo = type.GetField("field");
            Console.WriteLine(".............." + fieldInfo);
            Console.ReadLine();
        }
    }
}
