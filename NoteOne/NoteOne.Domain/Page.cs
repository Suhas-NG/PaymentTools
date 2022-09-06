using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOne.Domain
{
    public class Page : IEntity
    {
        public string PageName { get; set; }
        public string PageTitle { get; set; }
        public List<Note> Notes { get; set; }
        public Guid Guid { get; set; }
    }
}
