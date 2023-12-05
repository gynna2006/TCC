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
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/10.png",
                Preco = 85.00M,
            },
            new() {
                Id = 2,
                Nome = "Frasco Quadrado Gelo",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/4.png",
                Preco = 65.00M,
            },
             new() {
                Id = 3,
                Nome = "Aromatizador para Carros",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração. Consultar disponibilidade via whatsapp. Este produto contém 10ML.",
                CategoriaId = 2,
                Foto = "/images/produtos/5.png",
                Preco = 15.00M,
            },
             new() {
                Id = 4,
                Nome = "Frasco Estrela Marrom",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/16.png",
                Preco = 85.00M,
            },
             new() {
                Id = 5,
                Nome = "Frasco Champanhe",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 50ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/15.png",
                Preco = 30.00M,
            },
             new() {
                Id = 6,
                Nome = "Frasco Color Redondo",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/6.png",
                Preco = 85.00M,
            },
             new() {
                Id = 7,
                Nome = "Sabonete Color Redondo (INDISPONÍVEL)",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                CategoriaId = 3,
                Foto = "/images/produtos/3.png",
                Preco = 0,
            },
            new() {
                Id = 8,
                Nome = "Sachê Perfumado",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor. Consultar disponibilidade via whatsapp.",
                CategoriaId = 6,
                Foto = "/images/produtos/1.png",
                Preco = 07.00M,
            },
            new() {
                Id = 9,
                Nome = "Garrafa Cinturinha",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 100ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/14.png",
                Preco = 30.00M,
            },
            new() {
                Id = 10,
                Nome = "Aromatizador Bola",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/21.png",
                Preco = 48.00M,
            },
            new() {
                Id = 11,
                Nome = "Aromatizador Meia Lua",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/12.png",
                Preco = 65.00M,
            },
            new() {
                Id = 12,
                Nome = "Aromatizador Quadrado Âmbar",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 150ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/19.png",
                Preco = 85.00M,
            },
            new() {
                Id = 13,
                Nome = "Home Spray",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 100ML.",
                CategoriaId = 4,
                Foto = "/images/produtos/2.png",
                Preco = 20.00M,
            },
            new() {
                Id = 14,
                Nome = "Água de Lençol",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 150ML.",
                CategoriaId = 5,
                Foto = "/images/produtos/9.png",
                Preco = 30.00M,
            },
            new() {
                Id = 15,
                Nome = "Vidro Estampa Cesta",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/7.png",
                Preco = 85.00M,
            },
            new() {
                Id = 16,
                Nome = "Vidro Degradê",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/8.png",
                Preco = 95.00M,
            },
            new() {
                Id = 17,
                Nome = "Vidro Quadrado Gelo",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/11.png",
                Preco = 65.00M,
            },
            new() {
                Id = 18,
                Nome = "Vidro Âmbar Retangular",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/13.png",
                Preco = 95.00M,
            },
            new() {
                Id = 19,
                Nome = "Vidro Tribal",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/18.png",
                Preco = 85.00M,
            },
            new() {
                Id = 20,
                Nome = "Vidro Lampião",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 300ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/17.png",
                Preco = 95.00M,
            },
            new() {
                Id = 21,
                Nome = "Vidro Bola",
                Descricao = "Por sermos uma marca artesanal, os produtos mostrados podem estar sujeitos a alteração na cor e decoração. Consultar disponibilidade via whatsapp. Este produto contém 250ML.",
                CategoriaId = 1,
                Foto = "/images/produtos/20.png",
                Preco = 79.00M,
            },
        };
        builder.Entity<Produto>().HasData(produtos);


        var role = Activator.CreateInstance<IdentityRole>();
        role.Id = Guid.NewGuid().ToString();
        role.Name = "Administrador";
        role.NormalizedName = "ADMINISTRADOR";
        builder.Entity<IdentityRole>().HasData(role);

        var user = Activator.CreateInstance<IdentityUser>();
        user.Id = Guid.NewGuid().ToString();
        user.UserName = "Admin";
        user.NormalizedUserName = "ADMIN";
        user.Email = "admin@lunascimento.com.br";
        user.NormalizedEmail = "ADMIN@LUNASCIMENTO.COM.BR";
        user.EmailConfirmed = true;
        PasswordHasher<IdentityUser> passwordHasher = new();
        user.PasswordHash = passwordHasher.HashPassword(user, "@Lu123");
        builder.Entity<IdentityUser>().HasData(user);

        var userRole = Activator.CreateInstance<IdentityUserRole<string>>();
        userRole.UserId = user.Id;
        userRole.RoleId = role.Id;
        builder.Entity<IdentityUserRole<string>>().HasData(userRole);

    }
}