﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Dominio.Entidades
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public long CategoriaId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Nome { get; set; }

        [JsonIgnore]
        public virtual IEnumerable<Livro> Livros { get; set; }
    }
}