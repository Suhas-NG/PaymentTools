using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOne.Domain
{
    public class Page : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }
        public string? PageName { get; set; }
        public string? PageTitle { get; set; }
        public List<Note>? Notes { get; set; }
        public Guid? CategoryGuid { get; set; } 
        public DateTime Created { get; set; }

    }
}
