using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compare.BO;
using Compare.BL;


namespace Compare.Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Student1 = new Student() { Name = "Jack", Age = 15, StudentId = 100 };
            Student Student2 = new Student() { Name = "Smith", Age = 15, StudentId = 101 };
            Student Student3 = new Student() { Name = "Smith", Age = 15, StudentId = 101 };
            Student Student4 = new Student() { Name = "Smit", Age = 15, StudentId = 102 };
            Student Student5 = new Student() { Name = null, Age = 15, StudentId = 100 };
                        
            if (Compare.BL.Compare.CompareObject<Student>(Student1, Student2))
                Console.WriteLine("Both objects are equal");
            else
                Console.WriteLine("Both objects are not equal");
            if (Compare.BL.Compare.CompareObject< Student>(Student3, Student2))
                Console.WriteLine("Both objects are equal");
            else
                Console.WriteLine("Both objects are not equal");
            if (Compare.BL.Compare.CompareObject< Student>(Student3, Student4))
                Console.WriteLine("Both objects are equal");
            else
                Console.WriteLine("Both objects are not equal");
            if (Compare.BL.Compare.CompareObject(Student1, Student5))
                Console.WriteLine("Both objects are equal");
            else
                Console.WriteLine("Both objects are not equal");
            Console.Read();
        }
    }
    }

