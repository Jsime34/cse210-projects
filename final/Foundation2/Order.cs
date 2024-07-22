class Order{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer){
        _customer = customer;
        _products = new List<Product>();
    }

    public Order(Customer customer, List<Product> products){
        _customer = customer;
        _products = new List<Product>();
        foreach(Product p in products){
            _products.Add(p);
        }
    }

    public void AddProduct(Product p){
        _products.Add(p);
    }

    public int getTotalCost(){
        int cost=0;
        foreach(Product p in _products){
            cost+=p.getTotalCost();
        }
        if(_customer.isintheus()==true){
            cost+=5;
        }
        else{
            cost+=35;
        }
        return cost;
    }
    public string packetLabel(){
        string label = "";
        foreach(Product p in _products){
            label+=$"Name: {p.getName()}\n";
            label+=$"ID: {p.getId()}\n";
        }
        return label;
    }

    public string shippingLabel(){
        string ship = "";
        ship += $"{_customer.getName()}\n";
        ship += $"{_customer.GetAddress()}\n";
        return ship;
    }
}