using System.ComponentModel.DataAnnotations;

namespace RetroModels;

public class Stores
{
    [Key]
    public int StoreID { get; set;}

    private string _storeAddress;
    public string StoreAddress
    {
        get { return _storeAddress; }
        set { _storeAddress = value; }
    }

    private string _storeCity;
    public string StoreCity
    {
        get { return _storeCity; }
        set { _storeCity = value; }
    }

    private string _storeState;
    public string StoreState
    {
        get { return _storeState; }
        set { _storeState = value; }
    }

    private int _storeZipcode;
    public int StoreZipcode
    {
        get { return _storeZipcode; }
        set { _storeZipcode = value; }
    }

}