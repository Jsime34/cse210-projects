using System.ComponentModel.Design.Serialization;

class Product{
    private string _name;
    private int _id;
    private int _price;
    private int _quantity;

    public Product(string name, int id, int price, int quantity){
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public int getTotalCost(){
        int total_cost = _price * _quantity;
        return total_cost;
    }

    public int getId(){
        return _id;
    }

    public void setId(int id){
        _id = id;
    }

    public string getName(){
        return _name;
    }

    public void setName(string name){
        _name = name;
    }
}