class Customer{
    private string _name;
    private Address _address;
    public Customer(string name){
        _name = name;
    }

    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public void setAddress(Address newaddress){
        _address = newaddress;
    }

    public Address GetAddress(){
        return _address;
    }

    public bool isintheus(){
        if(_address.isinUS()==true){
            return true;
        }
        else{
            return false;
        }
    }

    public string getName(){
        return _name;
    }

    public void setName(string name){
        _name = name;
    }
}