using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RetroModels;

[Table("Orders")]
public class Orders
{
    [Key]
    public int OrderID { get; set; }

    private int _customerID;
    public int CustomerID
    {
        get { return _customerID; }
        set { _customerID = value; }
    }

    private string _orderDate;
    public string OrderDate
    {
        get { return _orderDate; }
        set { _orderDate = value; }
    }
    

    private List<CartItems> _orderCart = new List<CartItems>();
    public List<CartItems> OrderCart { get => _orderCart; set => _orderCart = value; }


    private string _orderStatusCode;
    public string OrderStatusCode
    {
        get { return _orderStatusCode; }
        set { _orderStatusCode = value; }
    }
    
    private decimal _orderTotal;
    public decimal OrderTotal
    {
        get { return _orderTotal; }
        set { _orderTotal = value; }
    }
    
    private int _storeID;
    public int StoreID
    {
        get { return _storeID; }
        set { _storeID = value; }
    }
    
    
    [ForeignKey("StoreID")]
    public virtual Stores Stores { get; set; }
    [ForeignKey("CustomerID")]
    public virtual Customers Customers { get; set; }
}
