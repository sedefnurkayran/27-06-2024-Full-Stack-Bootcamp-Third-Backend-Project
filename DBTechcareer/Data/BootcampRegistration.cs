using System.ComponentModel.DataAnnotations;

namespace DBTechcareer.Data
{

    public class BootcampRegistration
    {

        [Key]
        public int BootcampRegistrationId { get; set; }
        public int BootcampId { get; set; }
        public int StudentId { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}