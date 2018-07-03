using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Examen.Entidades
{
    public class DatosPersonas
    {
       
        public int ID { get; set; }

        [Required(ErrorMessage = "Es necesario llenar este campo")]
        [DisplayName("Nombre:")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Es necesario llenar este campo")]
        [DisplayName("Apellido Paterno:")]
        [StringLength(60)]
        public string aPaterno { get; set; }

        [Required(ErrorMessage = "Es necesario llenar este campo")]
        [DisplayName("Apellido Materno:")]
        [StringLength(60)]
        public string aMaterno { get; set; }

        [Required(ErrorMessage = "Es necesario llenar este campo")]
        [DisplayName("CURP:")]
        [RegularExpression("[0-9a-zA-Z]+$", ErrorMessage = "Solo se permiten letras y números")]
        [StringLength(18, MinimumLength = 18, ErrorMessage = "Formato incorrecto")]
        public string curp { get; set; }

    }
}
