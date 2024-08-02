using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDatabaseApp.Data
{
    public class Student
    {
        
        public int Id { get; set; }
        public string  StudentName { get; set; }
        public string StudentlastName { get; set; }
        public string StudentEmail { get; set; }
        public int StudentPhone { get; set; }
        public DateTime DOB { get; set; }
        public string StudentAddress { get; set; }





    }
}
