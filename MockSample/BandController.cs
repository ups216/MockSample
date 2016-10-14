using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockSample
{
    public class BandController
    {
        IRepository repository;
        public BandController(IRepository repository)
        {
            this.repository = repository;
        }

        public void GetBandList()
        {
            var listOfBands = repository.GetBand();
            foreach(var band in listOfBands)
            {
                Console.WriteLine("Band Name: " + band.Name);
            }
        }


    }
}
