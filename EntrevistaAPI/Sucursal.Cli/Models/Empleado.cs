using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sucursal.Serv.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [RegularExpression(@"^(?:[1-9]|[1-9][0-9]|100)$", ErrorMessage = "La edad debe ser un número entre 1 y 100")]
        public int Edad { get; set; }
        public int Sexo { get; set; }
        public Puesto Puesto { get; set; }
        public SucursalDir SucursalDir { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Debes de seleccionar un Puesto.")]
        public int PuestoId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Debes de seleccionar una Sucursal.")]
        public int SucursalDirId { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> Puestos { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> SucursalDirs { get; set; }

    }
}
