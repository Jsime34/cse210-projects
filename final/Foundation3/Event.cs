public abstract class Event{
    private string _title;
    private string _desc;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string desc, string date, string time, Address address){
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails(){
        return $"Title: {_title}\n Description: {_desc}\n Date: {_date}\n Time: {_time}\n Address: {_address.getAddress()}";
    }

    public abstract string GetFullDetails();

    public virtual string GetShortDescription(){
        return $"Title: {_title}\n Date: {_date}";
    }
}