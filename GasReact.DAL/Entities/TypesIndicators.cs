namespace GasReact.DAL.Entities
{
    public class TypesIndicators
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public virtual IEnumerable<Indicator>? Indicators { get; set; }
    }
}
