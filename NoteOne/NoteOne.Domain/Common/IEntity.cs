using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoteOne.Domain
{
    public interface IEntity
    {
        public Guid Guid { get; set; }
    }
}