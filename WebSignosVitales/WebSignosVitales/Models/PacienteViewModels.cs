using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebSignosVitales.Models
{
    public class PacienteViewModels
    {
        public int Idpaciente { get; set; }

        [Display(Name = "Nombre paciente")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Debe ingresar el nombre del paciente")]
        public string Nombrepas { get; set; }
        
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public string Estadocivil { get; set; }
        public Nullable<System.DateTime> Fecha_nac { get; set; }
        public string Domicilio { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
    }
}