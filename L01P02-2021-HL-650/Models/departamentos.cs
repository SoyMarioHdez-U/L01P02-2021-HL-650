using System.ComponentModel.DataAnnotations;

namespace L01P02_2021_HL_650.Models
{
    public class departamentos
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Departamento")]
        public string? departamento { get; set; }
    }
}
