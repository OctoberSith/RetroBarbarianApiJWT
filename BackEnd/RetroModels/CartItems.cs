using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RetroModels;

public class CartItems
{
    [Key]
    public int CartID { get; set; }

    private int _orderID;
    public int OrderID
    {
        get { return _orderID; }
        set { _orderID = value; }
    }

    private decimal _productPrice;
    public decimal ProductPrice
    {
        get { return _productPrice; }
        set { _productPrice = value; }
    }

    private int _productQuantity;
    public int ProductQuantity
    {
        get { return _productQuantity; }
        set { _productQuantity = value; }
    }

    private string _orderDate;
    public string OrderDate
    {
        get { return _orderDate; }
        set { _orderDate = value; }
    }

    [JsonIgnore]
    [ForeignKey("ProductID")]
    public virtual Products Products { get; set; }
    [JsonIgnore]
    [ForeignKey("OrderID")]
    public virtual Orders Orders { get; set; }

}
