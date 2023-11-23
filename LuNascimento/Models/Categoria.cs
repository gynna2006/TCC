using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LuNascimento.Models;

    [Table("Categoria")]
    public class Categoria
    {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public byte Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(40, ErrorMessage = "O Nome deve possuir no máximo 40 caracteres")]
    public string Nome { get; set; }
    }
