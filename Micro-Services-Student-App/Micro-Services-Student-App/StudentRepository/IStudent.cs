using Micro_Services_Student_App.Models;

namespace Micro_Services_Student_App.StudentRepository
{
    public interface IStudent
    {
        public List<StudentRegistor> GetStudents();
        public List<StudentRegistor> EditStudentDetails(int id);
        void AddStudent(StudentRegistor studentRegistor );
      
        //Task<StudentRegistor> UpdateStudent(StudentRegistor studentRegistor);
        //Task<StudentRegistor> GetStudent(int Studentid);
        public int  DeleteStudent(int id);
       
    }
}
