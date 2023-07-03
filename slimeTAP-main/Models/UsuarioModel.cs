using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace slimeTAP.Models
{
    public class UsuarioModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "O campo Nome de Usuário é obrigatório.")]
        public string? UsuarioNome { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        public string? Senha { get; set; }

        public string? Email { get; set; }
        public float? Moeda { get; set; }
        public float? MoedaTotal { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }
        public int Nivel { get; set; }
        public int? Diamante { get; set; }
        public int? Gema { get; set; }
        public float? Multiplicador { get; set; }
        public int? Upgrade1 { get; set; }
        public int? Upgrade2 { get; set; }
        public int? Upgrade3 { get; set; }
        public int? Upgrade4 { get; set; }
        public int? Upgrade5 { get; set; }
        public int? Upgrade6 { get; set; }
        public int? Upgrade7 { get; set; }
        public int? Upgrade8 { get; set; }
        public int? Upgrade9 { get; set; }
        public int? Upgrade10 { get; set; }
        public int? Upgrade11 { get; set; }

        

        public UsuarioModel()
        {
            // Valores padrão
            Moeda = 0;
            Level = 1;
            Diamante = 100;
            Gema = 100;
            Multiplicador = 1;
            MoedaTotal = 0;
            Upgrade1 = 1;
            Upgrade2 = 1;
            Upgrade3 = 1;
            Upgrade4 = 1;
            Upgrade5 = 1;
            Upgrade6 = 1;
            Upgrade7 = 1;
            Upgrade8 = 1;
            Upgrade9 = 1;
            Upgrade10 = 1;
            Upgrade11 = 1;
            
        }
    }
}