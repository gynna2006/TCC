using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using LuNascimento.Models;

namespace LuNascimento.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        List<Categoria> categorias = new(){
            new() {
                Id = 1,
                Nome = "Aromatizador de Ambiente"
            },
            new() {
                Id = 2,
                Nome = "Aromatizador de Carro"
            },
            new() {
                Id = 3,
                Nome = "Sabonetes"
            },
             new() {
                Id = 4,
                Nome = "Home Spray"
            },
             new() {
                Id = 5,
                Nome = "Água de Lençol"
            },
             new() {
                Id = 6,
                Nome = "Sachê"
            },
        };
        builder.Entity<Categoria>().HasData(categorias);

        List<Produto> produtos = new() {
            new() {
                Id = 1,
                Nome = "Frasco Quadrado Color",
                Descricao = "250ml",
                CategoriaId = 1,
                Foto = "/images/29.png",
                Preco = 85.00,
            },
            new() {
                Id = 2,
                Nome = "Frasco Quadrado Gelo",
                Descricao = "250ml",
                CategoriaId = 1,
                Foto = "/images/20.png",
                Preco = 65.00,
            },
             new() {
                Id = 3,
                Nome = "Frasco Quadrado Gelo",
                Descricao = "250ml",
                CategoriaId = 1,
                Foto = "/images/20.png",
                Preco = 65.00,
            },
             new() {
                Id = 4,
                Nome = "Frasco Estrela Marrom",
                Descricao = "250ml",
                CategoriaId = 1,
                Foto = "/images/27.png",
                Preco = 85.00,
            },
             new() {
                Id = 5,
                Nome = "Frasco Champanhe",
                Descricao = "50ml",
                CategoriaId = 1,
                Foto = "/images/26.png",
                Preco = 30.00,
            },
             new() {
                Id = 6,
                Nome = "Frasco Color Redondo",
                Descricao = "250ml",
                CategoriaId = 1,
                Foto = "/images/14.png",
                Preco = 85.00,
            },
             new() {
                Id = 7,
                Nome = "Sabonete Color Redondo",
                Descricao = "250ml",
                CategoriaId = 3,
                Foto = "/images/20.png",
                Preco = 0.0,
            },
            new() {
                Id = ,
                Nome = "Sachê Perfumado",
                Descricao = "",
                CategoriaId = 6,
                Foto = "/images/1.png",
                Preco = 7.0,
            },
            new() {
                Id = ,
                Nome = "Garrafa Cinturinha",
                Descricao = "",
                CategoriaId = 1,
                Foto = "/images/25.png",
                Preco = 30.0,
            },
            new() {
                Id = 1,
                Nome = "Aromatizador Bolinha",
                Descricao = "",
                CategoriaId = 1,
                Foto = "/images/1.png",
                Preco = 0,
            },
            new() {
                Id = 1,
                Nome = "Aromatizador Bolinha",
                Descricao = "",
                CategoriaId = 1,
                Foto = "/images/1.png",
                Preco = 0,
            },
            new() {
                Id = 1,
                Nome = "Aromatizador Bolinha",
                Descricao = "",
                CategoriaId = 1,
                Foto = "/images/1.png",
                Preco = 0,
            },

        };
        builder.Entity<Produto>().HasData(produtos);

    }
}
