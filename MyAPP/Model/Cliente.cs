using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAPP.Model
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        [MaxLength(200)]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        [MaxLength(200)]
        public string Correo { get; set; } = string.Empty;
        [Required]
        [MaxLength(10)]
        public string Telefono { get; set; } = string.Empty ;
    }
}
