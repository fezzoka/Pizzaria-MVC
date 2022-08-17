using Pizzaria_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria_MVC.Models.ViewModels.RequestDTO
{
    public class PostPizzaDropdownVM
    {
        public PostPizzaDropdownVM()
        {
            Sabores = new List<Sabor>();
            Tamanhos = new List<Tamanho>();
        }

        public List<Sabor> Sabores { get; set; }
        public List<Tamanho> Tamanhos { get; set; }

    }
}