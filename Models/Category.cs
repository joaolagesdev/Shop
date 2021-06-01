
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Category
    {
        // [Table("Categoria")] => Para gerar uma tabela com nome diferente de Category
        
        [Key]
        // [Column("Cat_ID")] => Para gerar uma coluna com nome diferente
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        // [DataType("nvarchar")] => Alterar o tipo de dado
        public string Title { get; set; }
    }
}