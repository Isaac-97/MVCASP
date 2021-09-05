using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppProyecto.Models
{
    public class Empleado
    {
        [Key]
        [Display (Name = "CvEmpleado")]
        public int IdEmpleado { get; set; }
        [Display (Name = "Nombre")]
        public string Nombre { get; set; }
        [Display (Name = "A.Paterno")]
        public string APaterno { get; set; }
        [Display (Name = "A.Materno")]
        public string AMaterno { get; set; }
        [Display (Name = "Celular")]
        public string Telefono { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "F.Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [DataType (DataType.Date)]
        [Display(Name = "F.Registro")]
        public DateTime FechaRegistro { get; set; }
        [StringLength (18, MinimumLength = 18)]
        [Display (Name = "Curp")]
        public string CURP { get; set; }
        [Display (Name = "Tipo Sexo")]
        public int IdSexo { get; set; }
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }
        [Display(Name = "Email")]
        public string Correo { get; set; }
    }
}
