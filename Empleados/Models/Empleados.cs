using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Empleados.Models
{
    public class Empleados
    {
        [Key]
        public int Clave_Emp { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Apellido Paterno")]
        public string apPaterno { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Apellido Materno")]
        public string apMaterno { get; set; }
        [Required]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime FecNac { get; set; }
        //[Required]
        //[Display(Name = "Departamento")]
       // public int departamento { get; set; }
        [Required]
        [Display(Name = "Sueldo")]
        public decimal sueldo { get; set; }

        public virtual Departamentos departamento { get; set; }
        public IEnumerable<Departamentos> ListDepas{ get; set; }

    }
}