namespace cs_web_app.models;

public class SortParam
{
    public enum Ordering
    {
       asc,
       dsc,
    }

    public SortParam()
    {
    }

    public SortParam(Ordering mOrdering = default) => (MOrdering) = (mOrdering);

    public Ordering MOrdering { get; set; }
    public override string ToString()
    {
        return "Ordering : " + MOrdering;
    }
}