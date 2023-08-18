
namespace Chore_Score.Repositories
{
    public class AssignmentsRepository
    {

        private List<Assignment> dbAssignments;

        public AssignmentsRepository()
        {
            dbAssignments = new List<Assignment>();
            dbAssignments.Add(new Assignment("Math", 9, true));
            dbAssignments.Add(new Assignment("Science", 2, true));
            dbAssignments.Add(new Assignment("History", 7, true));
            dbAssignments.Add(new Assignment("Economics", 23, true));
        }




        internal List<Assignment> GetAssignments()
        {
            return dbAssignments;
        }





        internal Assignment GetAssignmentByName(string assignmentName)
        {
            Assignment locatedAssignment = dbAssignments.Find(assignment => assignment.Name.ToLower() == assignmentName.ToLower());
            return locatedAssignment;
        }





        internal Assignment EditAssignment(Assignment assignmentData, string assignmentName)
        {
            Assignment assignmentToEdit = dbAssignments.Find(assignment => assignment.Name.ToLower() == assignmentName.ToLower());
            assignmentToEdit.Name = assignmentData.Name;
            assignmentToEdit.AssignmentNumber = assignmentData.AssignmentNumber;
            assignmentToEdit.IsDogFood = assignmentData.IsDogFood;
            return assignmentToEdit;
        }
        
    }
}