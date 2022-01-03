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

        Boarding RemoveBoarding(Guid boardingId);
        Boarding GetBoardingById(Guid boardingId);
        public int Commit();
    }
}
