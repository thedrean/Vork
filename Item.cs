namespace goodsoftwarepractice{
  public class Item{
    private string _name;
    public string Name{
      get{
        return _name;
      }
      set{
        _name=value;
      }
    }
    public string description="";
    public Item(string n){
      this.Name=n;
    }
  }
}
