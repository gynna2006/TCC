using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace LuNascimento.Models;

    [Table("Usuario")]
    public class Usuario
    {
         [Key]
        public string UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public IdentityUser ContaUsuario { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
        public string Nome { get; set; }
    }
