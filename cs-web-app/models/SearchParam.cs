namespace cs_web_app.models;

public class SearchParam
{
   public SearchParam() { }
   public SearchParam(long? id = default) => (Id) = (id);
   public long? Id { get; set; }
   public override string ToString()
   {
      return "Searching Id : " + this.Id;
   }
}