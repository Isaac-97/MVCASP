using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppProyecto.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        [Display(Name = "Nick o Alaias")]
        public string Alias { get; set; }
        [Required]
        [Display(Name = "Contraseña")]
        public string Contrasena { get; set; }
        [Required]
        public int IdTipoUsuario { get; set; }
        [Required]
        public int IdEmpleado { get; set; }
    }
}
