using System.ComponentModel.DataAnnotations;

namespace L01P02_2021_HL_650.Models
{
    public class materias
    {
        [Key] 
        public int id { get; set; }

        [Display(Name = "Materia")]
        public string? materia { get; set; }

        [Display(Name = "UVS")]
        public int? unidades_valorativas { get; set; }

        [Display(Name = "Estado")]
        public string? estado { get; set; }
    }
}
