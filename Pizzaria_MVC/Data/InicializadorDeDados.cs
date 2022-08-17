
using AtividadePizzaria.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Pizzaria_MVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pizzaria_MVC.Data
{
    public class InicializadorDeDados
    {
        public static void Inicializar(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope
                    .ServiceProvider
                    .GetService<PizzariaDbContext>();

                context.Database.EnsureCreated();

                if (!context.Sabores.Any())
                {
                    context.Sabores.AddRange(new List<Sabor>()
                    {
                        new Sabor("Massa Tradicional", "https://www.anamariabrogui.com.br/assets/uploads/receitas/fotos/usuario-3680-a12a8f7a3290dc305bd28255427c27d4.jpg"),
                        new Sabor("Atum", "https://espetinhodesucesso.com.br/wp-content/uploads/2022/04/Como-fazer-atum.jpg"),
                        new Sabor("Calabresa", "https://as2.ftcdn.net/v2/jpg/03/17/84/95/1000_F_317849554_2sPeZXR5WGQ1SS9sgoDSKpuakkw6YvVQ.jpg"),
                        new Sabor("Mussarela", "https://thumbs.dreamstime.com/b/fecho-do-queijo-picado-ser-servido-na-festa-temperado-com-or%C3%A9gano-sal-e-azeite-prazer-em-apreciado-acompanhado-de-cerveja-foco-168492727.jpg")
                    });
                    context.SaveChanges();
                }

                if (!context.Tamanhos.Any())
                {
                    context.Tamanhos.AddRange(new List<Tamanho>()
                    {
                        new Tamanho("Pequena"),
                        new Tamanho("Média"),
                        new Tamanho("Grande")
                    });
                    context.SaveChanges();
                }

                if (!context.Pizzas.Any())
                {
                    context.Pizzas.AddRange(new List<Pizza>()
                    {
                        new Pizza("Marguerita",30,"https://static.phdvasia.com/br/menu/single/desktop_thumbnail_57217b2a-38f8-4145-8eb4-da2a56a7f580.jpg",1),
                        new Pizza("Cinco Queijos",40,"https://static.phdvasia.com/br/menu/single/desktop_thumbnail_c99089cc-e6ab-4e27-8c9e-322942f31755.jpg",2),
                        new Pizza("Pepperoni",50,"https://static.phdvasia.com/br/menu/single/desktop_thumbnail_b2e4adc6-a1ff-43dd-99f1-d4009a38bd71.jpg",3)
                    });
                    context.SaveChanges();
                }

                if (!context.PizzasSabores.Any())
                {
                    context.PizzasSabores.AddRange(new List<PizzaSabor>()
                    {
                        new PizzaSabor(1,3),
                        new PizzaSabor(2,4),
                        new PizzaSabor(3,2),
                        new PizzaSabor(1,1),
                        new PizzaSabor(2,1),
                        new PizzaSabor(3,1)
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}