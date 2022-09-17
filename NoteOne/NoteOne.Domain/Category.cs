
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoteOne.Domain
{
    public class Category : IEntity
    {
        public string CategoryName { get; set; } = string.Empty;
        public List<Page>? Pages { get; set; }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }
    }
}
