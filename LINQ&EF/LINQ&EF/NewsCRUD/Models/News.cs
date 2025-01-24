using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsCRUD.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(300)]
        public string? Brief { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }

        [Required]
        public int CatalogId { get; set; }

        [ForeignKey("CatalogId")]
        public virtual Catalog Catalog { get; set; }
    }

}
