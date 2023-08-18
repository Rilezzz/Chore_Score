


namespace Chore_Score.Repositories
{
    public class ChoresRepository
    {

        private List<Chore> dbChores;

        public ChoresRepository()
        {
            dbChores = new List<Chore>();
            dbChores.Add(new Chore("Dishes", 20, false, 5));
            dbChores.Add(new Chore("Mow Lawn", 45, false, 10));
            dbChores.Add(new Chore("Vaccum", 30, false, 7.50));
            dbChores.Add(new Chore("Laundry", 60, false, 10));
        }


        internal List<Chore> GetChores()
    {
        return dbChores;
    }

        internal Chore GetChoreByName(string choreName)
        {
            Chore foundChore = dbChores.Find(chore => chore.Name.ToLower() == choreName.ToLower());
            return foundChore;
        }

        internal Chore CreateChore(Chore choreData)
        {
            dbChores.Add(choreData);
            return choreData;
        }

        internal Chore RemoveChore(string choreName)
        {
            Chore choreToBeRemoved = GetChoreByName (choreName);
            dbChores.Remove(choreToBeRemoved);
            return choreToBeRemoved;
        }
    }



}