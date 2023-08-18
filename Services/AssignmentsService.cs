
namespace Chore_Score.Services
{
    public class AssignmentsService
    {

        private readonly AssignmentsRepository _assignmentsRepository;


        public AssignmentsService(AssignmentsRepository assignmentsRepository)
        {
            _assignmentsRepository = assignmentsRepository;
        }




        internal List<Assignment> GetAssignments()
        {
            List<Assignment> assignments = _assignmentsRepository.GetAssignments();
            return assignments;
        }





        internal Assignment GetAssignmentByName(string assignmentName)
        {
            Assignment assignment = _assignmentsRepository.GetAssignmentByName(assignmentName);

            if(assignment == null)
            {
                throw new Exception($"Aint no assignment named {assignmentName}, Man!");
            }
                return assignment;
        }





        internal Assignment EditAssignment(Assignment assignmentData, string assignmentName)
        {
            Assignment assignment = _assignmentsRepository.EditAssignment(assignmentData, assignmentName);
            return assignment;
        }
    }
}