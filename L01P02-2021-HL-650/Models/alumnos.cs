using System.ComponentModel.DataAnnotations;

namespace L01P02_2021_HL_650.Models
{
    public class alumnos
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Código")]
        public string? codigo { get; set; }

        [Display(Name = "Nombre")]
        public string? nombre { get; set; }
        [Display(Name = "Apellidos")]
        public string? apellidos { get; set; }
        
        [Display(Name = "DUI")]
        public int? dui {  get; set; }

        [Display(Name = "Estado")]
        public int? estado { get; set; }
    }
}
