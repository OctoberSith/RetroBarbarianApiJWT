using System.ComponentModel.DataAnnotations;

namespace RetroModels;
public class Customers
{
    [Key]
    public int CustomerID { get; set; }

    private string _customerFirst;
    public string CustomerFirst
    {
        get { return _customerFirst; }
        set { _customerFirst = value; }
    }

    private string _customerLast;
    public string CustomerLast
    {
        get { return _customerLast; }
        set { _customerLast = value; }
    }
    

    private int _birthMonth;
    public int BirthMonth
    {
        get { return _birthMonth; }
        set { _birthMonth = value; }
    
    }

    private int _birthDay;
    public int BirthDay
    {
        get { return _birthDay; }
        set { _birthDay = value; }
    
    }

    private int _birthYear;
    public int BirthYear
    {
        get { return _birthYear; }
        set { _birthYear = value; }
    
    }

    private string _address;
    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }
    
    private string _city;
    public string City
    {
        get { return _city; }
        set { _city = value; }
    }
    
    private string _state;
    public string MyProperty
    {
        get { return _state; }
        set { _state = value; }
    }

    private int _zipcode;
    public int Zipcode
    {
        get { return _zipcode; }
        set { _zipcode = value; }
    }

    private string _email;
    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }
    
    private string _password;
    public string Password
    {
        get { return _password; }
        set { _password = value; }
    }
    

}
