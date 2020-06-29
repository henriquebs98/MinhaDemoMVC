using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }
       
        [Required(ErrorMessage = "O campo Titulo é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O Título precisa ter entre 3 e 60 caracteres")]
        public string Titulo { get; set; }
       
        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O campo Data de Lancamento é obrigatório")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "O campo Genero é obrigatório")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Genero em formato incorreto")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres")]
        public string Genero { get; set; }
        
        [Range(1,1000, ErrorMessage = "Valor de 1 a 1000")]
        [Required(ErrorMessage = "O campo Valor é obrigatório")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Valor { get; set; }

        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números")]
        [Required(ErrorMessage = "O campo Avaliação é obrigatório")]
        [Display(Name = "Avaliação")]
        public int Avaliacao { get; set; }
    }
}
