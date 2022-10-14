﻿using la_mia_pizzeria_crude_mvc.Models;
using la_mia_pizzeria_crude_mvc.Utils;
using la_mia_pizzeria_static.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_crude_mvc.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        [Required (ErrorMessage ="Il campo nome è obbligatorio")]
        [StringLength(50, ErrorMessage = "Il campo nome non può avre piu di 70 caratteri" )]
        public string? Name { get; set; }

        [Column("description")]
        [Required(ErrorMessage = "La descrizione è obbligatoria")]
        //[SetCorrectLenghtValidation]
        public string? Description { get; set; }

        [Column("Image")]
        [Required(ErrorMessage = "L'immagine è obbligatoria")]
        public string? Image { get; set; }

        [SetCorrectTypePrice]
        [Column(TypeName = "money")]
        [Required(ErrorMessage = "Il prezzo è un campo obbligatorio")]
        [Range(1, 100, ErrorMessage = "Il prezzo deve essere compreso tra 1 e 100")]
        public decimal Price { get; set; }

        //relations
        //personalizzare errore stringa vuota
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<Ingredient>? Ingredients { get; set; }

    }
}
