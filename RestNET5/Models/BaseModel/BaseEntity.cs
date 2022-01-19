using System.ComponentModel.DataAnnotations.Schema;

namespace RestNET5.Models.BaseModel
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
