using System.ComponentModel.DataAnnotations;

namespace shrestha.Models.Student
{
    public class Class
    {

        
            public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string phone { get; set; }
        public DataType EnrollmentDate {  get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }


    }
}
