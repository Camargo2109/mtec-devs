using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MtecDevs.Models;
namespace MtecDevs.Data;

public class AppDbSeed
{
     public AppDbSeed(ModelBuilder builder)
     {
        // Popular os dados de Tipos de Dev
        #region  Popular dados TipoDev
        List<TipoDev> tipoDevs = new() {
            new TipoDev() {
                Id = 1,
                Nome = "FullStack"
            },
            new TipoDev() {
                Id = 2,
                Nome = "FrontEnd"
            },
            new TipoDev() {
                Id = 3,
                Nome = "BackEnd"
            },
            new TipoDev() {
                Id = 4,
                Nome = "Design"
            },
            new TipoDev() {
                Id = 5,
                Nome = "Jogos"
            }
        };
        builder.Entity<TipoDev>().HasData(tipoDevs);
        #endregion

        #region Popular dados de Perfis de Usuário
        List<IdentityRole> perfis =  new(){
            new IdentityRole() {
                Id = Guid.NewGuid().ToString(),
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole() {
                Id = Guid.NewGuid().ToString(),
                Name = "Moderador",
                NormalizedName = "MODERADOR"
            },
            new IdentityRole() {
                Id = Guid.NewGuid().ToString(),
                Name = "Usuário",
                NormalizedName = "USUÁRIO"
            }
        };
        builder.Entity<IdentityRole>().HasData(perfis);
        #endregion 

        #region Popular Dados de Usuário
        //Lista de IdentityUser
        List<IdentityUser> users = new() {
            new IdentityUser(){
                Id = Guid.NewGuid().ToString(),
                UserName = "Zaza",
                NormalizedUserName = "ZAZA",
                Email = "arthurcamargoetec@gmail.com",
                NormalizedEmail = "ARTHURCAMARGOETEC@GMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = true
            }
        };
        builder.Entity<IdentityUser>().HasData(users);
        //Criptografar a senha

        //Cria o usuário

        //Define o perfil do usuário criado
        #endregion
     }   
}
