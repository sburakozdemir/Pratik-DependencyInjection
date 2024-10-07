namespace Pratik_DependencyInjection.Models
{
    public class Classroom
    {
        private readonly ITeacher _teacher; // Dependency Injection

        // Constructor Injection
        public Classroom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo(); 
        }
    }
}
