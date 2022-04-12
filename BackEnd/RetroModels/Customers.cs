namespace RetroModels;
public class Customers
{
    public int CustomerID { get; set; }
    private string _CustomerFirst;
    public string CustomerFirst
    {
        get { return _CustomerFirst; }
        set { _CustomerFirst = value; }
    }

    private string _CustomerLast;
    public string CustomerLast
    {
        get { return _CustomerLast; }
        set { _CustomerLast = value; }
    }
    

    private int _BirthMonth;
    public int BirthMonth
    {
        get { return _BirthMonth; }
        set { _BirthMonth = value; }
    
    }

    private int _BirthDay;
    public int BirthDay
    {
        get { return _BirthDay; }
        set { _BirthDay = value; }
    
    }

    private int _BirthYear;
    public int BirthYear
    {
        get { return _BirthYear; }
        set { _BirthYear = value; }
    
    }

    private string _Address;
    public string Address
    {
        get { return _Address; }
        set { _Address = value; }
    }
    
    private string _City;
    public string City
    {
        get { return _City; }
        set { _City = value; }
    }
    
    private string _State;
    public string MyProperty
    {
        get { return _State; }
        set { _State = value; }
    }

    private int _Zipcode;
    public int Zipcode
    {
        get { return _Zipcode; }
        set { _Zipcode = value; }
    }

    private string _Email;
    public string Email
    {
        get { return _Email; }
        set { _Email = value; }
    }
    
    private string _Password;
    public string Password
    {
        get { return _Password; }
        set { _Password = value; }
    }
    

}
