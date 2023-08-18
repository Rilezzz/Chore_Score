

namespace Chore_Score.Models
{
    public class Chore
    {
        public string Name { get; set; }

        public int LengthOfTime { get; set; }

        public bool IsComplete { get; set; }

        public double AllowanceWorth { get; set; }


        // Constructor🔽
        public Chore(string name, int lengthOfTime, bool isComplete, double allowanceWorth)
        {
            Name = name;
            LengthOfTime = lengthOfTime;
            IsComplete = isComplete;
            AllowanceWorth = allowanceWorth;

        }
    }
}