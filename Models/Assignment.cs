

namespace Chore_Score.Models
{
    public class Assignment
    {
        public string Name {get; set;}
        public int AssignmentNumber {get; set;}
        public bool IsDogFood {get; set;}

        

        public Assignment (string name, int assignmentNumber, bool isDogFood)
        {
            Name = name;
            AssignmentNumber = assignmentNumber;
            IsDogFood = isDogFood;
        }
    }
}