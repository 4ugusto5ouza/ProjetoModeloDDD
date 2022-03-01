using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    [Serializable]
    public class Cliente
    {
        public Cliente()
        {
            Produtos = new List<Produto>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public ICollection<Produto> Produtos { get; set; }

        public bool ClienteEspeial(Cliente cliente) =>
            cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;

    }
}
