
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoteOne.Domain
{
    public class Category : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }
        public Guid? UserGuid { get; set; }
        public DateTime Created { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public List<Page>? Pages { get; set; }
        
      
    }
}
