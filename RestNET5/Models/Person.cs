using RestNET5.Models.BaseModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestNET5.Models
{
    [Table("person")]
    public class Person : BaseEntity
    {
        [Column("first_name")]
        public string Name { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("gender")]
        public string Gender { get; set; }
    }
}
