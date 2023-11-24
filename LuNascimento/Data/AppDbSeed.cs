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
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ml",
                CategoriaId = 1,
                Foto = "/images/29.png",
                Preco = 85.00M,
            },
            new() {
                Id = 2,
                Nome = "Frasco Quadrado Gelo",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ml",
                CategoriaId = 1,
                Foto = "/images/20.png",
                Preco = 65.00M,
            },
             new() {
                Id = 3,
                Nome = "Aromatizador para Carros",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração. Consultar disponibilidade via whatsapp. Este produto contém 50ML",
                CategoriaId = 2,
                Foto = "/images/12.png",
                Preco = 15.00M,
            },
             new() {
                Id = 4,
                Nome = "Frasco Estrela Marrom",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ml",
                CategoriaId = 1,
                Foto = "/images/27.png",
                Preco = 85.00M,
            },
             new() {
                Id = 5,
                Nome = "Frasco Champanhe",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 50ml",
                CategoriaId = 1,
                Foto = "/images/26.png",
                Preco = 30.00M,
            },
             new() {
                Id = 6,
                Nome = "Frasco Color Redondo",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ml",
                CategoriaId = 1,
                Foto = "/images/14.png",
                Preco = 85.00M,
            },
             new() {
                Id = 7,
                Nome = "Sabonete Color Redondo",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ml",
                CategoriaId = 3,
                Foto = "/images/20.png",
                Preco = 0,
            },
            new() {
                Id = 8,
                Nome = "Sachê Perfumado",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor. Consultar disponibilidade via whatsapp. Este produto contém ",
                CategoriaId = 6,
                Foto = "/images/1.png",
                Preco = 07.00M,
            },
            new() {
                Id = 9,
                Nome = "Sachê Perfumado Grande",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor. Consultar disponibilidade via whatsapp. Este produto contém ",
                CategoriaId = 6,
                Foto = "/images/1.png",
                Preco = 07.00M,
            },
            new() {
                Id = 10,
                Nome = "Garrafa Cinturinha",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 100ML",
                CategoriaId = 1,
                Foto = "/images/25.png",
                Preco = 30.00M,
            },
            new() {
                Id = 11,
                Nome = "Aromatizador Bola",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 150ML",
                CategoriaId = 1,
                Foto = "/images/???.png",
                Preco = 48.00M,
            },
            new() {
                Id = 12,
                Nome = "Aromatizador Meia Lua",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 150ML",
                CategoriaId = 1,
                Foto = "/images/????.png",
                Preco = 65.00M,
            },
            new() {
                Id = 13,
                Nome = "Aromatizador Quadrado Pequeno",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 100ML",
                CategoriaId = 1,
                Foto = "/images/????.png",
                Preco = 35.00M,
            },
            new() {
                Id = 14,
                Nome = "Aromatizador Quadrado Médio",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 150ML",
                CategoriaId = 1,
                Foto = "/images/????.png",
                Preco = 45.00M,
            },
            new() {
                Id = 15,
                Nome = "Home Spray",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 0ML",
                CategoriaId = 4,
                Foto = "/images/????.png",
                Preco = 0.00M,
            },
            new() {
                Id = 16,
                Nome = "Água de Lençol",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 0ML",
                CategoriaId = 5,
                Foto = "/images/????.png",
                Preco = 45.00M,
            },
        };
        builder.Entity<Produto>().HasData(produtos);

    }
}