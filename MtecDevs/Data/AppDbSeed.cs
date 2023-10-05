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
        //Criptografar a senha 
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> password = new();
            user.PasswordHash = password.HashPassword(user, "@Etec123");
        }
        builder.Entity<IdentityUser>().HasData(users);

        //Cria o usuário
        List<Usuario> usuarios = new(){
            new Usuario() {
                UserId = users[0].Id,
                Nome = "Gustavo Santos Buzacarini",
                DataNascimento = DateTime.Parse("12/04/2006"),
                Foto = "/img/usuarios/gustavo.jpg",
                TipoDevId = 2
            }
        };
        builder.Entity<Usuario>().HasData(usuarios);

        //Define o perfil do usuário criado
        List<IdentityUserRole<string>> userRoles = new() {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = perfis [0].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
     }   
}
