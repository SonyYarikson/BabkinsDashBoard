using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Models
{
    [Table(nameof(Board)+"s")]
    public class Board
    {
        [Key]
        public Guid BoardID { get; set; }
        public string BoardName { get; set; }
        public string Privacy { get; set; }
        public Guid UserID { get; set; }
        [JsonIgnore] public User User { get; set; }
        [JsonIgnore] public List<Card> Cards { get; set; }
    }
}