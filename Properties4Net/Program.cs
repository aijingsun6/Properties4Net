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

            Console.WriteLine(properties["language"]);

        }
    }
}
