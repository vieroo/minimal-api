using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Dominio.Enums;

namespace minimal_api.Dominio.Entidades
{
    public class Administrador
    {
        public Administrador(){}
        public Administrador(int id, string email, string senha, Perfil perfil) {
            Id = id;
            Email = email;
            Senha = senha;
            Perfil = perfil.ToString();
        }
        public Administrador(string email, string senha, Perfil perfil) {
            Email = email;
            Senha = senha;
            Perfil = perfil.ToString();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default!;

        [Required]
        [StringLength(255)]
        public string Email { get; set; } = default!;

        [Required]
        [StringLength(50)]
        public string Senha { get; set; } = default!;

        [Required]
        [StringLength(10)]
        public string Perfil { get; set; } = default!;
    }
}