using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp4
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
