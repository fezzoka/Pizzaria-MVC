using System;

namespace Pizzaria_MVC.Models.Intefaces
{
    public interface IEntidade
    {

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }

    }
}