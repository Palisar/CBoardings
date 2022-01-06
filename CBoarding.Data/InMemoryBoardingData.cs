namespace CBoardings.Data
{
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

        public int Commit()
        {
            return 0;
        }

        public Boarding Delete(Guid boardingId)
        {
            var boarding = boardings.Find(b => b.Id == boardingId);
            if (boarding is not null)
            {
                boardings.Remove(boarding);
            }
            return boarding;
        }

        public Boarding GetBoardingById(Guid boardingId)
        {
            return boardings.SingleOrDefault(b => b.Id == boardingId);
        }

        public IEnumerable<Boarding> GetBoardings()
        {
            return boardings.AsEnumerable<Boarding>();
        }

        public Boarding RemoveBoarding(Guid boardingId)
        {
            var boarding = boardings.FirstOrDefault(b => b.Id == boardingId);
            if (boarding is not null)
            {
                boardings.Remove(boarding);
            }
            return boarding;
        }
    }
}
