using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Nome obrigatório")]
        [MaxLength(38, ErrorMessage = "Máximo de {0} caractéres permitido")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caractéres permitido")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Sobrenome obrigatório")]
        [MaxLength(48, ErrorMessage = "Máximo de {0} caractéres permitido")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caractéres permitido")]
        public string Sobrenome { get; set; }
        [Display(Name ="E-mail")]
        [Required(ErrorMessage = "Campo E-mail obrigatório")]
        [MaxLength(28, ErrorMessage = "Máximo de {0} caractéres permitido")]
        [MinLength(8, ErrorMessage = "Mínimo de {0} caractéres permitido")]
        [EmailAddress(ErrorMessage ="Imforme um e-mail válido!")]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        //public ICollection<ProdutoViewModel> Produtos { get; set; }
    }
}
