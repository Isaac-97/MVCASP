using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppProyecto.Models
{
    public class CatTipoSexo
    {
        [Key]
        public int IdTipoSexo { get; set; }
        [Required]
        public int Descripcion { get; set; }
    }
}
