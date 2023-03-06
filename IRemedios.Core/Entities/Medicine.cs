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
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public string DosageInstructions { get; set; }
        public string Warnings { get; set; }
    }
}
