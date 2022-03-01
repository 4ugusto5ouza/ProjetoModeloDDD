using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Descrição")]
        [Required(ErrorMessage = "Campo Descrição obrigatório")]
        [MaxLength(256, ErrorMessage = "Máximo de {0} caractéres permitido")]
        [MinLength(3, ErrorMessage = "Mínimo de {0} caractéres permitido")]
        public string Descricao { get; set; }
        [Display(Name ="Preço")]
        [Required(ErrorMessage = "Campo Preço obrigatório")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0","9999999999999999")]
        public decimal Preco { get; set; }
        [Display(Name = "Disponível?")]
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }
        public ClienteViewModel Cliente { get; set; }
    }
}
