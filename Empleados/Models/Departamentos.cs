using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Empleados.Models
{
    public class Departamentos
    {
        [Key]
        public int puesto { get; set; }
        [Required]
        [MaxLength(50)]
        public string descripcion { get; set; }
        //public Empleados empleado { get; set; }
        public virtual ObservableCollection<Empleados> empleados { get; set; }
    }
}