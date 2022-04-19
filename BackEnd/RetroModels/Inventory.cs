using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RetroModels;
public class Inventory
{
    [Key]
    public int InventoryID { get; set; }

    private int _productID;
    public int ProductID
    {
        get { return _productID; }
        set { _productID = value; }
    }

    private decimal _productPrice;
    public decimal ProductPrice
    {
        get { return _productPrice; }
        set { _productPrice = value; }
    }
    
    private int _inventoryQuantity;
    public int InventoryQuantity
    {
        get { return _inventoryQuantity; }
        set { _inventoryQuantity = value; }
    }

    private int _storeID;
    public int StoreID
    {
        get { return _storeID; }
        set { _storeID = value; }
    }
    
    [JsonIgnore]
    [ForeignKey("StoreID")]
    public virtual Stores Stores { get; set; }
    [JsonIgnore]
    [ForeignKey("ProductID")]
    public virtual Products Products { get; set; }
    
}
