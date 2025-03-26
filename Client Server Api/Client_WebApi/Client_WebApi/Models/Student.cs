using System.ComponentModel.DataAnnotations;

namespace Client_WebApi.Models
{
    public class Student

    {
        public int id { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public string fatherName { get; set; }
        [Required]
        public int standard { get; set; }
        [Required]
        public string gender { get; set; }
    }


}
