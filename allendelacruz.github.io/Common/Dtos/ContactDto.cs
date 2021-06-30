using System.ComponentModel.DataAnnotations;

namespace allendelacruz.github.io.Common.Dtos
{
    public class ContactDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
