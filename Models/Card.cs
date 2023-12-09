using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public class Card
    {
        [Key]
        public Guid CardID { get; set; }
        [Required]
        public string CardName { get; set; }

        public Guid BoardID { get; set; }

        [JsonIgnore]
        public Board Board { get; set; }
        [JsonIgnore]
        public List<Row> Rows { get; set; }

    }
}
