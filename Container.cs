namespace goodsoftwarepractice{
  public class Container{
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
    public Item item= null;
    public Container(string n){
      this.Name = n;
    }
  }
}
