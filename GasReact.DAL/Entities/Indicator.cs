namespace GasReact.DAL.Entities;
public class Indicator
{
    public int IndicatorId { get; set; }
    public int TypeId { get; set; }
    public decimal Value { get; set; }
    public DateTime Date { get; set; }
    public int RecordId { get; set; }

    public virtual TypesIndicators? Type { get; set; }

    public virtual Record? Record { get; set; }
}