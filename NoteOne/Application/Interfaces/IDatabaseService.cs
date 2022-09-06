using NoteOne.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOne.Application.Interfaces
{
    public interface IDatabaseService
    {
        IEnumerable<User> Users { get; set; }

        IEnumerable<Category> Categories { get; set; }

        IEnumerable<Page> Pages { get; set; }

        IEnumerable<Note> Notes { get; set; }

        IEnumerable<Tag> Tags { get; set; }
        void Save();
    }
}
