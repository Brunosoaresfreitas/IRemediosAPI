using System.ComponentModel.DataAnnotations;

namespace IRemedios.Core.Entities
{
    public class Medicine
    {
        public Medicine(string name, string description, string manufacturer, string dosageInstructions, string warnings)
        {
            Name = name;
            Description = description;
            Manufacturer = manufacturer;
            DosageInstructions = dosageInstructions;
            Warnings = warnings;

            PostedAt = DateTime.Now;
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} should have between {2} and {1} caracters!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(200, ErrorMessage = "{0} can't exceed {1} caracters!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "{0} is required!")]
        public string Manufacturer { get; set; }
        [Required(ErrorMessage = "{0} is required!")]
        public string DosageInstructions { get; set; }
        [Required(ErrorMessage = "{0} is required!")]
        public string Warnings { get; set; }
        public DateTime PostedAt { get; set; }
    }
}
