namespace cs_web_app.models;

public class SomeModel
{
   public SomeModel()
   {
   }

   public long? Id { get; set; }
   public string? Name { get; set; }
   public SortParam? SortParam { get; set; }
   public SearchParam? SearchParam { get; set; }

   // public SomeModel(SortParam? sortParam = null, SearchParam? searchParam = null, long? id = default,
   //    string? name = null)
   // {
   //    SortParam = sortParam;
   //    SearchParam = searchParam;
   //    Id = id;
   //    Name = name;
   // }

   public override string ToString()
   {
      return "SomeModel Id : " + this.Id + "Name : " +  this.Name + this.SortParam + this.SearchParam;
   }
}