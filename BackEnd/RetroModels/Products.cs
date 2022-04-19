using System.ComponentModel.DataAnnotations;

namespace RetroModels;
public class Products
{
    [Key]
    public int ProductID { get; set; }

    private string _productName;
    public string ProductName
    {
        get { return _productName; }
        set { _productName = value; }
    }

    private string _productCompany;
    public string ProductCompany
    {
        get { return _productCompany; }
        set { _productCompany = value; }
    }
    
    private decimal _productPrice;
    public decimal ProductPrice
    {
        get { return _productPrice; }
        set { _productPrice = value; }
    }
    
}
