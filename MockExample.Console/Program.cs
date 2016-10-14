using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockSample;

namespace MockExample.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bandController = new BandController(new Repository());
            bandController.GetBandList();
            Console.ReadLine();
            
        }
    }
}
