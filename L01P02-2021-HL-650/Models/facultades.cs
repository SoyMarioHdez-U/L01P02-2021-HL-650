using System.ComponentModel.DataAnnotations;

namespace L01P02_2021_HL_650.Models
{
    public class facultades
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Facultad")]
        public string? facultad {  get; set; }
    }
}
