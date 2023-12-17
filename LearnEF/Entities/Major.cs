using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEF.Entities
{

    [Table("Majors")]
    public class Major
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public EntityStatus Status { get; set; }
        public ICollection<ClassRoom> ClassRooms { get; set; }
    }
}
