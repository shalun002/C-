using OOP_2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IpAddress ip = new IpAddress("192.168.1.2", 24);
            Console.WriteLine(ip.GetUserFriendlyBinaryAddress());
            Console.WriteLine();
        }
    }
}
