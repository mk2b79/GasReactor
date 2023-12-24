namespace GasReact.DAL.Entities
{
    public class Fermentator
    {
        public int Id { get; set; }
        public string? FermentatorName { get; set; }

        public virtual IEnumerable<Record>? Records { get; set; }
    }
}
