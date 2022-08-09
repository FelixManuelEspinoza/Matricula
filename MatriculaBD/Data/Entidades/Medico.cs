using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaBD.Data.Entidades
{
    [Index(nameof(MatriculaMedica), Name = "Numero de matricula", IsUnique =true)]
    
    public class Medico
    {
        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public int ID { get; set; }

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string DNI { get; set; }

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string MatriculaMedica { get; set; }

    }
}
