using System.ComponentModel.DataAnnotations;

namespace TwoDataBaseProject.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string ContactNo { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]

        public string Address { get; set; }

    }
}