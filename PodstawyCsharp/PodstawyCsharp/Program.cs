using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            authorisation logowanie = new authorisation();

            logowanie.login();

            Console.ReadKey();

        }
    }

}  
        
    

