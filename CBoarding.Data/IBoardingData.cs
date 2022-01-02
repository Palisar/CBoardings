using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBoardings.Data
{
    public interface IBoardingData
    {
        IEnumerable<Boarding> GetBoardings();
        Boarding AddBoarding(Boarding newBoarding);
    }

    public class InMemoryBoardingData : IBoardingData
    {
        readonly List<Boarding> boardings;
        public InMemoryBoardingData()
        {
            boardings = new List<Boarding>()
            {
                new Boarding(){Id = Guid.NewGuid(), BoardingTime = DateTime.Now, LatDeg=53, LatMin=04, LongDeg=005, LongMin=34, IsArrested=false, Description="Routine Boarding."},
                new Boarding(){Id = Guid.NewGuid(), BoardingTime = DateTime.Now, LatDeg=51, LatMin=01, LongDeg=006, LongMin=34, IsArrested=false, Description="Exercise no inspection."},
                new Boarding(){Id = Guid.NewGuid(), BoardingTime = DateTime.Now, LatDeg=51, LatMin=15, LongDeg=007, LongMin=01, IsArrested=false, Description="Routine inspection, went thought everything."},
            };
        }

        public Boarding AddBoarding(Boarding newBoarding)
        {
            boardings.Add(newBoarding);
            return newBoarding;
        }

        public IEnumerable<Boarding> GetBoardings()
        {
            return boardings.AsEnumerable<Boarding>();
        }
    }
}
