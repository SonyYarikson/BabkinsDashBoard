using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        [Key]
        public Guid UserID { get; set; }
        [Required]
        public string Login { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }
        [Required]
        public Guid RoleID { get; set; }
        [JsonIgnore] public UserRole Role { get; set; }
        [JsonIgnore] public List<Board> Board { get; set; }
    }
}
