using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Alias { get; set; }

        public int ParentId { get; set; }
        public string Desctiption { get; set; }
        public int DisplayOrder { get; set; }
        public string Image { get; set; }
        public bool HomeFlag { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
    }
}