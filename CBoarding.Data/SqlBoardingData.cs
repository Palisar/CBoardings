namespace CBoardings.Data
{
    public class SqlBoardingData : IBoardingData
    {
        private readonly BoardingDbContext dbContext;

        public SqlBoardingData(BoardingDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Boarding AddBoarding(Boarding newBoarding)
        {
            dbContext.Boardings.Add(newBoarding);
            Commit();
            return newBoarding;
        }

        public int Commit()
        {
            return dbContext.SaveChanges();

        }

        public Boarding Delete(Guid boardingId)
        {
            var boarding = GetBoardingById(boardingId);
            if (boarding is not null)
            {
                dbContext.Boardings.Remove(boarding);
            }
            return boarding;
        }

        public Boarding GetBoardingById(Guid boardingId)
        {
            return dbContext.Boardings.Find(boardingId);
        }

        public IEnumerable<Boarding> GetBoardings()
        {
            return dbContext.Boardings.AsEnumerable();
        }

        public Boarding RemoveBoarding(Guid boardingId)
        {
            var boarding = dbContext.Boardings.Find(boardingId);
            if (boarding != null)
            {
                dbContext.Remove(boarding);
                Commit();
            }
            return boarding;
        }
    }
}
