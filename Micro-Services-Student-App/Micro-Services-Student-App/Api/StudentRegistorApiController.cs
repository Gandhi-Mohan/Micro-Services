using Micro_Services_Student_App.Models;
using Micro_Services_Student_App.StudentRepository;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Micro_Services_Student_App.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRegistorApiController : ControllerBase
    {
        private IStudent _StudentRepository;

        public StudentRegistorApiController(IStudent student)
        {
            _StudentRepository = student;
        }
        
        Student student = new Student();
        // GET: api/<StudentRegistorApiController>
        [HttpGet]
        public IEnumerable<StudentRegistor> Get()
        {
            List<StudentRegistor> StudentList = new List<StudentRegistor>();

            try
            {
                StudentList = _StudentRepository.GetStudents();
            }
            catch(Exception ex)
            {
                var message = ex.Message;
            }
            
            return StudentList;
            //return new string[] { "value1", "value2" };
        }

        // GET api/<StudentRegistorApiController>/5
        [HttpGet("{id}")]
        public IEnumerable<StudentRegistor> Get(int id)
        {
            List<StudentRegistor> StudentDetailsList = new List<StudentRegistor>();

            try
            {
                StudentDetailsList = _StudentRepository.EditStudentDetails(id);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }

            return StudentDetailsList;
        }

        // POST api/<StudentRegistorApiController>
        [HttpPost]
        public void Post([FromBody] StudentRegistor StudentRegistor)
        {
            _StudentRepository.AddStudent(StudentRegistor);
        }


        //public IActionResult POST(StudentRegistor StudentRegistor)
        //{
        //    _StudentRepository.AddStudent(StudentRegistor);
        //    return null;
        //}
        //[HttpPost]
        //public IActionResult Post( StudentRegistor product)
        //{
        //      _StudentRepository.AddStudent(product);
        //    return null;

        //}

        // PUT api/<StudentRegistorApiController>/5
        [HttpPut("{id}")]
        public  void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentRegistorApiController>/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
           var result= _StudentRepository.DeleteStudent(id);
            return result;
        }
    }
}
