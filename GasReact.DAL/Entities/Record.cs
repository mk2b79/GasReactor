namespace GasReact.DAL.Entities
{
    public class Record
    {
        public int RecordId { get; set; }
        public int FermentatorId { get; set; }

        public virtual Fermentator? Fermentator { get; set; }

        public virtual IEnumerable<Indicator>? Indicators { get; set; }
    }
}
