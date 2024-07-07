using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PhoneBook.Domain.Entities
{
    public class PhoneEntity
    {
        [JsonIgnore]
        public int? PhoneId { get; set; }
        public string PhoneNumber { get; set; }

        [JsonIgnore]
        public int? ContactId { get; set; }
        [JsonIgnore]
        public ContactEntity Contact { get; set; }

    }
}
