using System;

using DewCore.Abstract.Types;
using DewCore.Extensions.Strings;
using DewCore.Extensions.Abstract;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp2
{
    public class Badge
    {
        public string Number;
        public string Id;
    }
    public enum Sex
    {
        M, F
    }
    public struct Geo
    {
        public int X, Y;
        public Geo(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    public class EV : EventArgs
    {

    }
    public class Employee
    {
        public string Name, Surname;
        public ushort Age { get; set; }
        private string CF;
        public DateTime Born;
        public Sex Sex;
        private Badge Badge;
        public Geo Geo;
        public event EventHandler MyEvent = null;
        public event EventHandler<EV> MyEvent1 = null;
        public Employee(string name, string surnaem, ushort age, string cf, Sex s, Badge b, Geo g, DateTime d)
        {
            Name = name;
            Surname = surnaem;
            Age = age;
            CF = cf;
            Sex = s;
            Badge = b;
            Geo = g;
            Born = d;
            MyEvent += Event;
            MyEvent1 += Employee_MyEvent1;
        }

        private void Employee_MyEvent1(object sender, EV e)
        {
            Console.WriteLine("--------------------------------evt1");
        }

        public void Event(object o, EventArgs e)
        {
            Console.WriteLine("--------------------------------evt");
        }
        public void Clear()
        {
            foreach (var item in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                object type = null;
                if (item.PropertyType.IsValueType)
                {
                    type = Activator.CreateInstance(item.PropertyType);
                }
                if (item.CanWrite)
                    item.SetValue(this, type);
            }
            foreach (var item in this.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                object type = null;
                if (item.FieldType.IsValueType)
                {
                    type = Activator.CreateInstance(item.FieldType);
                }
                item.SetValue(this, type);
            }
        }
        public Employee() { MyEvent += Event; }
        public void PrintEmployee()
        {
            try
            {
                MyEvent?.Invoke(this, EventArgs.Empty);
                Console.WriteLine("Person {0} {1}".Formatted(Name, Surname));
                Console.WriteLine("Age and borne {0} {1}".Formatted(Age, Born));
                Console.WriteLine("Sex {0}".Formatted(Sex));
                Console.WriteLine("Badge ID and Number {0}".Formatted(Badge.Id, Badge.Number));
                Console.WriteLine("Geo {0} {1}".Formatted(Geo.X, Geo.Y));
            }
            catch (Exception)
            {


            }

        }
    }
    public interface ITest
    {
        string Test { get; set; }
        [Obsolete]
        string Test1 { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test!");
            TestImplements();

            Console.ReadLine();
        }
        public static void TestImplements()
        {
            var emp1 = new Employee("Andrea", "Vincenzo", 28, "axafafdaf", Sex.M, new Badge() { Id = "1000", Number = "435" }, new Geo(10, 13), DateTime.Now);
            Console.WriteLine("{0}".Formatted(emp1 is ITest));
            foreach (var item in emp1.GetType().GetRuntimeProperties())
            {
                Console.WriteLine(item.Name);
            }
            var x = emp1.Implements<ITest>();
            Console.WriteLine("{0}".Formatted(x is ITest));
            foreach (var item in x.GetType().GetRuntimeProperties())
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void TestDeepClone()
        {
            var emp1 = new Employee("Andrea", "Vincenzo", 28, "axafafdaf", Sex.M, new Badge() { Id = "1000", Number = "435" }, new Geo(10, 13), DateTime.Now);
            emp1.PrintEmployee();
            Task.Delay(2000).Wait();
            var emp2 = (Employee)emp1.DeepClone();
            Console.WriteLine("----------------------");
            emp2.PrintEmployee();
            Console.WriteLine("----------------------");
            emp1.Clear();
            emp1.PrintEmployee();
            Console.WriteLine("----------------------");
            emp2.PrintEmployee();
        }
        public static void TestDeepCopy()
        {
            var emp1 = new Employee("Andrea", "Vincenzo", 28, "axafafdaf", Sex.M, new Badge() { Id = "1000", Number = "435" }, new Geo(10, 13), DateTime.Now);
            emp1.PrintEmployee();
            Task.Delay(2000).Wait();
            var emp2 = new Employee("1", "2", 28, "g", Sex.F, new Badge() { Id = "13000", Number = "5435" }, new Geo(610, 713), DateTime.Now); ;
            Console.WriteLine("----------------------");
            emp2.PrintEmployee();
            Console.WriteLine("----------------------");
            emp2 = (Employee)CloneExtension.DeepCopy(emp1);
            Console.WriteLine("----------------------");
            emp2.PrintEmployee();
        }
        public static bool pippo() => true;
        public static void pluto() => Console.WriteLine("pluto");
        public static bool pippo1(bool a, int b) => a && b == 3;
        public static void pluto1(int a, bool b) => Console.WriteLine("{0} e {1}".Formatted(a, b));
    }
}
