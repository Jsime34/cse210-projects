class Lecture : Event{
    private string _speaker;
    private int _capacity;
    private string _type;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        :base(title, description, date, time, address){
            _speaker = speaker;
            _capacity = capacity;
            _type = "lecture";
        }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n Type:{_type}\n Capacity: {_capacity}";
    }

    public string getType(){
        return _type;
    }
}