using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOne.Domain
{
    public class Tag : IEntity
    {
        public Guid Guid { get; set; }
    }
}
