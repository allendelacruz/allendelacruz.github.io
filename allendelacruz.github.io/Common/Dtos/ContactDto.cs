using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace allendelacruz.github.io.Common.Dtos
{
    public class ContactDto
    {
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [Required]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [Required]
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        [Required]
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
