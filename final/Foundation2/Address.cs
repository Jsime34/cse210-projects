class Address{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool isinUS(){
        bool isinus = false;
        if(_country == "USA" || _country=="US" || _country=="United States"){
            isinus = true;
        }
        return isinus;
    }

    public string getAddress(){
        string address = "";
        address += $"Street: {_street}\n";
        address += $"City: {_city}\n";
        address += $"State/Province: {_state}\n";
        address += $"Country: {_country}";
        return address;
    }
}