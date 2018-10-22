using System;
using System.IO;
using System.Text;
namespace Properties4Net
{
    class Program
    {
        static void Main(string[] args)
        {
            string root = Environment.CurrentDirectory;
            Console.WriteLine(root);

            string fooPath = Path.Join(root,"Data/Foo.properties");

            Properties properties = new Properties(fooPath);

            Console.WriteLine(properties);

            string dir = Path.Join(root,"Data");

            MessageSource ms = new MessageSource(dir,"message");
            Console.WriteLine(ms);

            Console.WriteLine(ms.GetMessage("greet", new string[] { "alking" }, ""));

            Console.WriteLine(ms.GetMessage("greet", new string[]{"alking"}, "zh_CN"));

        }
    }
}
