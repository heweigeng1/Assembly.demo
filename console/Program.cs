using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Program
    {
       
        static void Main(string[] args)
        {
            try
            {
                string name = typeof(IClass1).Namespace;
                IClass1 ic  = (IClass1)Assembly.Load(name).CreateInstance(name+".Class1");
                ic._console();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
