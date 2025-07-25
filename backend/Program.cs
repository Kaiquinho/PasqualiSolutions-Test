using Backend.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;

namespace Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    public class PessoaController : ControllerBase
    {
        private readonly List<Pessoa> _pessoas = new List<Pessoa>
        {
            new Pessoa { Cpf = "123.456.789-00", Nome = "João Silva", Genero = "Masculino", Endereco = "Rua A, 123", Idade = 25, Municipio = "São Paulo", Estado = "SP" },
            new Pessoa { Cpf = "987.654.321-00", Nome = "Maria Oliveira", Genero = "Feminino", Endereco = "Rua Z, 456", Idade = 30, Municipio = "Rio de Janeiro", Estado = "RJ" },
            new Pessoa { Cpf = "111.222.333-44", Nome = "Carlos Souza", Genero = "Masculino", Endereco = "Av. Brasil, 100", Idade = 40, Municipio = "Belo Horizonte", Estado = "MG" },
            new Pessoa { Cpf = "555.666.777-88", Nome = "Ana Costa", Genero = "Feminino", Endereco = "Rua das Flores, 50", Idade = 22, Municipio = "Curitiba", Estado = "PR" },
            new Pessoa { Cpf = "999.888.777-66", Nome = "Pedro Santos", Genero = "Masculino", Endereco = "Rua do Sol, 200", Idade = 35, Municipio = "Porto Alegre", Estado = "RS" },
            new Pessoa { Cpf = "222.333.444-55", Nome = "Juliana Lima", Genero = "Feminino", Endereco = "Av. Central, 300", Idade = 28, Municipio = "Recife", Estado = "PE" },
            new Pessoa { Cpf = "333.444.555-66", Nome = "Lucas Almeida", Genero = "Masculino", Endereco = "Rua Verde, 10", Idade = 19, Municipio = "Fortaleza", Estado = "CE" },
            new Pessoa { Cpf = "444.555.666-77", Nome = "Fernanda Ribeiro", Genero = "Feminino", Endereco = "Rua Azul, 80", Idade = 32, Municipio = "Salvador", Estado = "BA" },
            new Pessoa { Cpf = "777.888.999-00", Nome = "Rafael Martins", Genero = "Masculino", Endereco = "Av. Paulista, 1500", Idade = 27, Municipio = "São Paulo", Estado = "SP" },
            new Pessoa { Cpf = "888.999.000-11", Nome = "Patrícia Carvalho", Genero = "Feminino", Endereco = "Rua da Paz, 45", Idade = 24, Municipio = "Brasília", Estado = "DF" },
            new Pessoa { Cpf = "101.202.303-40", Nome = "Gabriel Torres", Genero = "Masculino", Endereco = "Rua Nova, 12", Idade = 38, Municipio = "Manaus", Estado = "AM" },
            new Pessoa { Cpf = "202.303.404-50", Nome = "Camila Mendes", Genero = "Feminino", Endereco = "Av. das Nações, 500", Idade = 29, Municipio = "Belém", Estado = "PA" },
            new Pessoa { Cpf = "303.404.505-60", Nome = "Bruno Freitas", Genero = "Masculino", Endereco = "Rua do Mercado, 70", Idade = 41, Municipio = "Goiânia", Estado = "GO" },
            new Pessoa { Cpf = "404.505.606-70", Nome = "Larissa Rocha", Genero = "Feminino", Endereco = "Rua do Porto, 33", Idade = 26, Municipio = "Florianópolis", Estado = "SC" },
            new Pessoa { Cpf = "505.606.707-80", Nome = "Eduardo Barros", Genero = "Masculino", Endereco = "Av. Atlântica, 900", Idade = 34, Municipio = "Vitória", Estado = "ES" },
            new Pessoa { Cpf = "606.707.808-90", Nome = "Isabela Nunes", Genero = "Feminino", Endereco = "Rua do Campo, 21", Idade = 23, Municipio = "Natal", Estado = "RN" },
            new Pessoa { Cpf = "707.808.909-01", Nome = "Felipe Teixeira", Genero = "Masculino", Endereco = "Rua do Lago, 17", Idade = 37, Municipio = "João Pessoa", Estado = "PB" },
            new Pessoa { Cpf = "808.909.010-12", Nome = "Aline Pires", Genero = "Feminino", Endereco = "Av. das Palmeiras, 60", Idade = 31, Municipio = "Maceió", Estado = "AL" },
            new Pessoa { Cpf = "909.010.121-23", Nome = "Rodrigo Cunha", Genero = "Masculino", Endereco = "Rua do Mar, 88", Idade = 42, Municipio = "Campo Grande", Estado = "MS" },
            new Pessoa { Cpf = "010.121.232-34", Nome = "Tatiane Lopes", Genero = "Feminino", Endereco = "Rua do Vento, 14", Idade = 20, Municipio = "Teresina", Estado = "PI" },
            new Pessoa { Cpf = "121.232.343-45", Nome = "Vinícius Farias", Genero = "Masculino", Endereco = "Av. das Árvores, 77", Idade = 33, Municipio = "Aracaju", Estado = "SE" },
            new Pessoa { Cpf = "232.343.454-56", Nome = "Letícia Gomes", Genero = "Feminino", Endereco = "Rua do Jardim, 29", Idade = 27, Municipio = "Palmas", Estado = "TO" },
            new Pessoa { Cpf = "343.454.565-67", Nome = "André Moreira", Genero = "Masculino", Endereco = "Rua do Bosque, 55", Idade = 36, Municipio = "Porto Velho", Estado = "RO" },
            new Pessoa { Cpf = "454.565.676-78", Nome = "Renata Dias", Genero = "Feminino", Endereco = "Av. do Comércio, 101", Idade = 39, Municipio = "Macapá", Estado = "AP" },
            new Pessoa { Cpf = "565.676.787-89", Nome = "Marcelo Araújo", Genero = "Masculino", Endereco = "Rua do Aeroporto, 5", Idade = 28, Municipio = "Boa Vista", Estado = "RR" },
            new Pessoa { Cpf = "676.787.898-90", Nome = "Simone Tavares", Genero = "Feminino", Endereco = "Rua do Museu, 8", Idade = 21, Municipio = "Rio Branco", Estado = "AC" },
            new Pessoa { Cpf = "787.898.909-01", Nome = "Thiago Brito", Genero = "Masculino", Endereco = "Av. do Estádio, 300", Idade = 44, Municipio = "São Luís", Estado = "MA" },
            new Pessoa { Cpf = "898.909.010-12", Nome = "Débora Castro", Genero = "Feminino", Endereco = "Rua do Teatro, 19", Idade = 25, Municipio = "Cuiabá", Estado = "MT" },
            new Pessoa { Cpf = "909.010.121-23", Nome = "Gustavo Rezende", Genero = "Masculino", Endereco = "Rua do Parque, 77", Idade = 30, Municipio = "Uberlândia", Estado = "MG" },
            new Pessoa { Cpf = "010.121.232-34", Nome = "Monique Duarte", Genero = "Feminino", Endereco = "Av. do Shopping, 400", Idade = 29, Municipio = "Sorocaba", Estado = "SP" }
        };

        [HttpGet("/api/pessoas")]
        public ActionResult<IEnumerable<Pessoa>> GetPessoas()
        {
            return Ok(_pessoas);
        }
    }
}