namespace goodsoftwarepractice{
  public class Place{
    private string _name;
    public string Name{
      get{
        return _name;
      }
      set{
        _name= value;
      }
    }
    public string description="";
    public Container container=null;
    public Place north=null;
    public Place south=null;
    public Place east=null;
    public Place west=null;
    public Place(string n){
      this.Name = n;
    }
  }
}
