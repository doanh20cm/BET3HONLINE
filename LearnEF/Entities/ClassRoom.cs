using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEF.Entities
{
    [Table("ClassRooms")]
    public class ClassRoom
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public EntityStatus Status { get; set; }
        public Guid? MajorId { get; set; }
        public Major Major { get; set; }
    }
}
