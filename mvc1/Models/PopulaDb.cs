using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace mvc1.Models
{
    public static class PopulaDb
    {
        public static void IncluiDadosDB(IApplicationBuilder app){
            IncluiDadosDB(app.ApplicationServices.GetRequiredService<Context>());
        }

        public static void IncluiDadosDB(Context context){
            Console.WriteLine("aplicando migração...");
            context.Database.Migrate();
            if(!context.Produtos.Any()){
                Console.WriteLine("Criando dados...");
                context.Produtos.AddRange(
                    new Produto("Panela","cosinha",200),
                    new Produto("celular","tecnologia",2000),
                    new Produto("TV","sala",2500),
                    new Produto("Geladeira","cosinha",4000)
                );
            context.SaveChanges();
            }
            else{
                Console.WriteLine("dados ja existem...");
            }
        }
    }
}