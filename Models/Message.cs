using la_mia_pizzeria_crude_mvc.Utils;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Column("title")]
        [Required(ErrorMessage = "Il titolo è obbligatorio")]
        [StringLength(100, ErrorMessage = "Il campo nome non può avre piu di 100 caratteri")]
        public string? Title { get; set; }

        [Column(TypeName = "text")]
        [Required(ErrorMessage = "Il testo è obbligatorio")]
        public string? Text { get; set; }

        [Column("name")]
        [Required(ErrorMessage = "Il nome mittente è obbligatorio")]
        public string? Name { get; set; }

        [Column("email")]
        [EmailAddress(ErrorMessage = "L'email inserita non è valida")]
        [Required(ErrorMessage = "L'email di cotatto è obbligatoria")]
        public string? Email { get; set; }

    }
}
