using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockSample
{
    public class Repository : IRepository
    {
        public List<Band> GetBand()
        {
            List<Band> bands = new List<Band>();

            bands.Add(new Band()
            {
                Name = "Hard Rock",
                Genre = "USA",
                Origin = "Rock",
                BestSong = "Whatever it is!"
            });
            bands.Add(new Band()
            {
                Name = "Hard Rock #1",
                Genre = "USA",
                Origin = "Rock",
                BestSong = "Whatever it is!"
            });
            bands.Add(new Band()
            {
                Name = "Hard Rock #2",
                Genre = "USA",
                Origin = "Rock",
                BestSong = "Whatever it is!"
            });

            return bands;
        }
    }
}
