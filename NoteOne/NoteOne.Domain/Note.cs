using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOne.Domain
{
    public class Note
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime Created { get; set; }
        public Guid Guid { get; set; }
    }

}
