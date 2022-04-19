using System.Collections.Generic;
using Xunit;
using Moq;
using RetroModels;
using RetroBL;
using RetroDL;
using System.Threading.Tasks;
using System.Linq;

namespace RetroTest;

public class RetroTesting
{
    [Fact]
    public async Task Should_Add_Customer()
    {
        //Arrange
        string testFirstName = "STEPHEN";
        string testLastName = "STRANGE";
        string testAddress = "117A BlEECKER STREET";
        string testState = "NY";
        string testCity = "NEW YORK CITY";
        int testZipcode = 10011;
        string tCountry = "USA";
        string testEmail = "STEPHEN.STRANGE@AOL.COM";
        string testPassword = "mordoisajerk";
        Customers p_resource = new Customers()
        {
            CustomerLast = testFirstName,
            CustomerFirst = testLastName,
            Address = testAddress,
            State = testState,
            City = testCity,
            Zipcode = testZipcode,
            Country = tCountry,
            Email = testEmail,
            Password = testPassword
        };
        //Act
        Mock<IRepository<Customers>> mockRepo = new Mock<IRepository<Customers>>();
        mockRepo.Setup(repo => repo.Add(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Customers> custBL = new CustomersBL(mockRepo.Object);
        Customers p_resource2 = new Customers();
        p_resource2 = await custBL.Add(p_resource);

        //Assert
        Assert.Same(p_resource, p_resource2);
        Assert.Equal(p_resource.CustomerFirst, p_resource2.CustomerFirst);
        Assert.NotNull(p_resource2);
    }
    
    [Fact]
    public async Task Should_Add_Orders()
    {
        string testOrderStatusCode = "Cancelled";
        Orders p_resource = new Orders(){

            OrderStatusCode = testOrderStatusCode
        };
        Mock<IRepository<Orders>> mockRepo = new Mock<IRepository<Orders>>();
        mockRepo.Setup(repo => repo.Add(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Orders> ordBL = new OrdersBL(mockRepo.Object);
        Orders p_resource2 = new Orders();
        p_resource2 = await ordBL.Add(p_resource);

        Assert.Same(p_resource, p_resource2);
        Assert.Equal(p_resource.OrderStatusCode, p_resource2.OrderStatusCode);
        Assert.NotNull(p_resource2);
    }

    [Fact]
    public async Task Should_Add_Products()
    {
        string testProductName = "Nintendo";
        Products p_resource = new Products(){
            ProductName = testProductName
        };

        Mock<IRepository<Products>> mockRepo = new Mock<IRepository<Products>>();
        mockRepo.Setup(repo => repo.Add(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Products> prodBL = new ProductsBL(mockRepo.Object);
        Products p_resource2 = new Products();
        p_resource2 = await prodBL.Add(p_resource);

        Assert.Same(p_resource, p_resource2);
        Assert.Contains(p_resource.ProductName, p_resource2.ProductName);
        Assert.NotNull(p_resource2);
    }

    [Fact]
    public async Task Should_Add_CartItems()
    {
        string testOrderDate = "1980/10/21";
        CartItems p_resource = new CartItems(){
            OrderDate = testOrderDate
        };

        Mock<IRepository<CartItems>> mockRepo = new Mock<IRepository<CartItems>>();
        mockRepo.Setup(repo => repo.Add(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<CartItems> cartBL = new CartItemsBL(mockRepo.Object);
        CartItems p_resource2 = new CartItems();
        p_resource2 = await cartBL.Add(p_resource);

        Assert.Same(p_resource, p_resource2);
        Assert.Contains(p_resource.OrderDate, p_resource2.OrderDate);
        Assert.NotNull(p_resource2);
    }

    [Fact]
    public async Task Should_Add_Inventory()
    {
        int testInventoryQuantity = 5;
        Inventory p_resource  = new Inventory(){
            InventoryQuantity = testInventoryQuantity
        };

        Mock<IRepository<Inventory>> mockRepo = new Mock<IRepository<Inventory>>();
        mockRepo.Setup(repo => repo.Add(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Inventory> invBL = new InventoryBL(mockRepo.Object);
        Inventory p_resource2 = new Inventory();
        p_resource2 = await invBL.Add(p_resource);

        Assert.Same(p_resource, p_resource2);
        Assert.Equal(p_resource.InventoryQuantity, p_resource2.InventoryQuantity);
        Assert.NotNull(p_resource2);
    }

    [Fact]
    public async Task Should_Add_Stores()
    {
        string testStoreAddress = "1079 Waluhiyi Trail";
        Stores p_resource = new Stores(){
            StoreAddress = testStoreAddress
        };

        Mock<IRepository<Stores>> mockRepo = new Mock<IRepository<Stores>>();
        mockRepo.Setup(repo => repo.Add(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Stores> storeBL = new StoresBL(mockRepo.Object);
        Stores p_resources2 = new Stores();
        p_resources2 = await storeBL.Add(p_resource);

        Assert.Same(p_resource, p_resources2);
        Assert.Contains(p_resource.StoreAddress, p_resources2.StoreAddress);
        Assert.NotNull(p_resources2);
    }

    [Fact]
    public async Task Should_Update_Customer()
    {
        //Arrange
        string testFirstName = "STEPHEN";
        string testLastName = "STRANGE";
        string testAddress = "117A BlEECKER STREET";
        string testState = "NY";
        string testCity = "NEW YORK CITY";
        int testZipcode = 10011;
        string tCountry = "USA";
        string testEmail = "STEPHEN.STRANGE@AOL.COM";
        string testPassword = "mordoisajerk";
        Customers p_resource = new Customers()
        {
            CustomerLast = testFirstName,
            CustomerFirst = testLastName,
            Address = testAddress,
            State = testState,
            City = testCity,
            Zipcode = testZipcode,
            Country = tCountry,
            Email = testEmail,
            Password = testPassword
        };
        //Act
        Mock<IRepository<Customers>> mockRepo = new Mock<IRepository<Customers>>();
        mockRepo.Setup(repo => repo.Update(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Customers> custBL = new CustomersBL(mockRepo.Object);
        Customers p_resource2 = new Customers();
        p_resource2 = await custBL.Update(p_resource);
        //Assert
        Assert.Same(p_resource, p_resource2);
        Assert.Equal(p_resource.CustomerFirst, p_resource2.CustomerFirst);
        Assert.NotNull(p_resource2);
    }

    [Fact]
    public async Task Should_Update_Orders()
    {
        string testOrderStatusCode = "Cancelled";
        Orders p_resource = new Orders(){

            OrderStatusCode = testOrderStatusCode
        };
        Mock<IRepository<Orders>> mockRepo = new Mock<IRepository<Orders>>();
        mockRepo.Setup(repo => repo.Update(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Orders> ordBL = new OrdersBL(mockRepo.Object);
        Orders p_resource2 = new Orders();
        p_resource2 = await ordBL.Update(p_resource);

        Assert.Same(p_resource, p_resource2);
        Assert.Equal(p_resource.OrderStatusCode, p_resource2.OrderStatusCode);
        Assert.NotNull(p_resource2);
    }

    [Fact]
    public async Task Should_Update_Products()
    {
        string testProductName = "Nintendo";
        Products p_resource = new Products(){
            ProductName = testProductName
        };

        Mock<IRepository<Products>> mockRepo = new Mock<IRepository<Products>>();
        mockRepo.Setup(repo => repo.Update(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Products> prodBL = new ProductsBL(mockRepo.Object);
        Products p_resource2 = new Products();
        p_resource2 = await prodBL.Update(p_resource);

        Assert.Same(p_resource, p_resource2);
        Assert.Contains(p_resource.ProductName, p_resource2.ProductName);
        Assert.NotNull(p_resource2);
    }

    [Fact]
    public async Task Should_Update_CartItems()
    {
        string testOrderDate = "1980/10/21";
        CartItems p_resource = new CartItems(){
            OrderDate = testOrderDate
        };

        Mock<IRepository<CartItems>> mockRepo = new Mock<IRepository<CartItems>>();
        mockRepo.Setup(repo => repo.Update(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<CartItems> cartBL = new CartItemsBL(mockRepo.Object);
        CartItems p_resource2 = new CartItems();
        p_resource2 = await cartBL.Update(p_resource);

        Assert.Same(p_resource, p_resource2);
        Assert.Contains(p_resource.OrderDate, p_resource2.OrderDate);
        Assert.NotNull(p_resource2);
    }

    [Fact]
    public async Task Should_Update_Inventory()
    {
        int testInventoryQuantity = 5;
        Inventory p_resource  = new Inventory(){
            InventoryQuantity = testInventoryQuantity
        };

        Mock<IRepository<Inventory>> mockRepo = new Mock<IRepository<Inventory>>();
        mockRepo.Setup(repo => repo.Update(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Inventory> invBL = new InventoryBL(mockRepo.Object);
        Inventory p_resource2 = new Inventory();
        p_resource2 = await invBL.Update(p_resource);

        Assert.Same(p_resource, p_resource2);
        Assert.Equal(p_resource.InventoryQuantity, p_resource2.InventoryQuantity);
        Assert.NotNull(p_resource2);
    }

    [Fact]
    public async Task Should_Update_Stores()
    {
        string testStoreAddress = "1079 Waluhiyi Trail";
        Stores p_resource = new Stores(){
            StoreAddress = testStoreAddress
        };

        Mock<IRepository<Stores>> mockRepo = new Mock<IRepository<Stores>>();
        mockRepo.Setup(repo => repo.Update(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Stores> storeBL = new StoresBL(mockRepo.Object);
        Stores p_resources2 = new Stores();
        p_resources2 = await storeBL.Update(p_resource);

        Assert.Same(p_resource, p_resources2);
        Assert.Contains(p_resource.StoreAddress, p_resources2.StoreAddress);
        Assert.NotNull(p_resources2);
    }
    
    [Fact]
    public async Task Should_Delete_Customer()
    {
        //Arrange
        string testFirstName = "STEPHEN";
        string testLastName = "STRANGE";
        string testAddress = "117A BlEECKER STREET";
        string testState = "NY";
        string testCity = "NEW YORK CITY";
        int testZipcode = 10011;
        string tCountry = "USA";
        string testEmail = "STEPHEN.STRANGE@AOL.COM";
        string testPassword = "mordoisajerk";
        Customers p_resource = new Customers()
        {
            CustomerLast = testFirstName,
            CustomerFirst = testLastName,
            Address = testAddress,
            State = testState,
            City = testCity,
            Zipcode = testZipcode,
            Country = tCountry,
            Email = testEmail,
            Password = testPassword
        };
        //Act
        Mock<IRepository<Customers>> mockRepo = new Mock<IRepository<Customers>>();
        mockRepo.Setup(repo => repo.Delete(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Customers> custBL = new CustomersBL(mockRepo.Object);
        Customers p_resource2 = new Customers();
        p_resource2 = await custBL.Delete(p_resource);
        //Assert
        Assert.Same(p_resource, p_resource2);
        Assert.Equal(p_resource.CustomerFirst, p_resource2.CustomerFirst);
        Assert.NotNull(p_resource2);
    }

    [Fact]
    public async Task Should_Delete_Orders()
    {
        string testOrderStatusCode = "Cancelled";
        Orders p_resource = new Orders(){

            OrderStatusCode = testOrderStatusCode,
        };
        Mock<IRepository<Orders>> mockRepo = new Mock<IRepository<Orders>>();
        mockRepo.Setup(repo => repo.Delete(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Orders> ordBL = new OrdersBL(mockRepo.Object);
        Orders p_resource2 = new Orders();
        p_resource2 = await ordBL.Delete(p_resource);

        Assert.Same(p_resource, p_resource2);
        Assert.Equal(p_resource.OrderStatusCode, p_resource2.OrderStatusCode);
        Assert.NotNull(p_resource2);
    }

    [Fact]
    public async Task Should_Delete_Products()
    {
        string testProductName = "Nintendo";
        Products p_resource = new Products(){
            ProductName = testProductName,
            ProductPrice = 1.50M
        };

        Mock<IRepository<Products>> mockRepo = new Mock<IRepository<Products>>();
        mockRepo.Setup(repo => repo.Delete(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Products> prodBL = new ProductsBL(mockRepo.Object);
        Products p_resource2 = new Products();
        p_resource2 = await prodBL.Delete(p_resource);

        Assert.Same(p_resource, p_resource2);
        Assert.Contains(p_resource.ProductName, p_resource2.ProductName);
        Assert.NotNull(p_resource2);
    }

    [Fact]
    public async Task Should_Delete_CartItems()
    {
        string testOrderDate = "1980/10/21";
        CartItems p_resource = new CartItems(){
            OrderDate = testOrderDate
        };

        Mock<IRepository<CartItems>> mockRepo = new Mock<IRepository<CartItems>>();
        mockRepo.Setup(repo => repo.Delete(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<CartItems> cartBL = new CartItemsBL(mockRepo.Object);
        CartItems p_resource2 = new CartItems();
        p_resource2 = await cartBL.Delete(p_resource);

        Assert.Same(p_resource, p_resource2);
        Assert.Contains(p_resource.OrderDate, p_resource2.OrderDate);
        Assert.NotNull(p_resource2);
    }

    [Fact]
    public async Task Should_Delete_Inventory()
    {
        int testInventoryQuantity = 5;
        Inventory p_resource  = new Inventory(){
            InventoryQuantity = testInventoryQuantity
        };

        Mock<IRepository<Inventory>> mockRepo = new Mock<IRepository<Inventory>>();
        mockRepo.Setup(repo => repo.Delete(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Inventory> invBL = new InventoryBL(mockRepo.Object);
        Inventory p_resource2 = new Inventory();
        p_resource2 = await invBL.Delete(p_resource);

        Assert.Same(p_resource, p_resource2);
        Assert.Equal(p_resource.InventoryQuantity, p_resource2.InventoryQuantity);
        Assert.NotNull(p_resource2);
    }

    [Fact]
    public async Task Should_Delete_Stores()
    {
        string testStoreAddress = "1079 Waluhiyi Trail";
        Stores p_resource = new Stores(){
            StoreAddress = testStoreAddress
        };

        Mock<IRepository<Stores>> mockRepo = new Mock<IRepository<Stores>>();
        mockRepo.Setup(repo => repo.Delete(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Stores> storeBL = new StoresBL(mockRepo.Object);
        Stores p_resources2 = new Stores();
        p_resources2 = await storeBL.Delete(p_resource);

        Assert.Same(p_resource, p_resources2);
        Assert.Contains(p_resource.StoreAddress, p_resources2.StoreAddress);
        Assert.NotNull(p_resources2);
    }

    [Fact]
    public async Task Should_GetAll_Customers()
    {
        List<Customers> _expectedListofCustomers = new List<Customers>();
        Customers _testCustomer = new Customers()
        {
            CustomerFirst = "Hanji",
            CustomerLast = "Zoe",
            CustomerID = 1,
            Address = "111 Paradise Island",
            State = "Wall Maria",
            Country = "Paradise",
            Zipcode = 777777,
        };
        _expectedListofCustomers.Add(_testCustomer);

        Mock<IRepository<Customers>> mockRepo = new Mock<IRepository<Customers>>();
        mockRepo.Setup(repo => repo.GetAll()).ReturnsAsync(_expectedListofCustomers);
        IRetroBL<Customers> _custBL = new CustomersBL(mockRepo.Object);
        List<Customers> _actualListofCustomers = _expectedListofCustomers;
        _actualListofCustomers = await _custBL.GetAll();

        Assert.Same(_actualListofCustomers, _expectedListofCustomers);
        Assert.Equal(_actualListofCustomers[0].CustomerFirst, _expectedListofCustomers[0].CustomerFirst);
        Assert.Matches(_actualListofCustomers[0].Address, _expectedListofCustomers[0].Address);
    }

    [Fact]
    public async Task Should_GetAll_Orders()
    {
        List<Orders> _expectedListofOrders = new List<Orders>();
        Orders _testOrder = new Orders()
        {
            OrderStatusCode = "CANCELLED",
            OrderDate = "1980/10/21",
            OrderTotal = 200,
            OrderID = 1,
        };
        _expectedListofOrders.Add(_testOrder);

        Mock<IRepository<Orders>> mockRepo = new Mock<IRepository<Orders>>();
        mockRepo.Setup(repo => repo.GetAll()).ReturnsAsync(_expectedListofOrders);
        IRetroBL<Orders> _custBL = new OrdersBL(mockRepo.Object);
        List<Orders> _actualListofOrders = _expectedListofOrders;
        _actualListofOrders = await _custBL.GetAll();

        Assert.Same(_actualListofOrders, _expectedListofOrders);
        Assert.Equal(_actualListofOrders[0].OrderTotal, _expectedListofOrders[0].OrderTotal);
        Assert.Matches(_actualListofOrders[0].OrderStatusCode, _expectedListofOrders[0].OrderStatusCode);
    }

    [Fact]
    public async Task Should_GetAll_Products()
    {
        List<Products> _expectedListofProducts = new List<Products>();
        Products _testProduct = new Products()
        {
            ProductID = 1,
            ProductCompany = "Nintendo",
            ProductPrice = 200
        };
        _expectedListofProducts.Add(_testProduct);

        Mock<IRepository<Products>> mockRepo = new Mock<IRepository<Products>>();
        mockRepo.Setup(repo => repo.GetAll()).ReturnsAsync(_expectedListofProducts);
        IRetroBL<Products> _custBL = new ProductsBL(mockRepo.Object);
        List<Products> _actualListofProducts = _expectedListofProducts;
        _actualListofProducts = await _custBL.GetAll();

        Assert.Same(_actualListofProducts, _expectedListofProducts);
        Assert.Equal(_actualListofProducts[0].ProductPrice, _expectedListofProducts[0].ProductPrice);
        Assert.Matches(_actualListofProducts[0].ProductCompany, _expectedListofProducts[0].ProductCompany);
    }

        [Fact]
    public async Task Should_GetAll_CartItems()
    {
        List<CartItems> _expectedListofCartItems = new List<CartItems>();
        CartItems _testCartItem = new CartItems()
        {
            CartID = 1,
            OrderDate = "1980/10/21"
        };
        _expectedListofCartItems.Add(_testCartItem);

        Mock<IRepository<CartItems>> mockRepo = new Mock<IRepository<CartItems>>();
        mockRepo.Setup(repo => repo.GetAll()).ReturnsAsync(_expectedListofCartItems);
        IRetroBL<CartItems> _custBL = new CartItemsBL(mockRepo.Object);
        List<CartItems> _actualListofCartItems = _expectedListofCartItems;
        _actualListofCartItems = await _custBL.GetAll();

        Assert.Same(_actualListofCartItems, _expectedListofCartItems);
        Assert.Equal(_actualListofCartItems[0].CartID, _expectedListofCartItems[0].CartID);
        Assert.Matches(_actualListofCartItems[0].OrderDate, _expectedListofCartItems[0].OrderDate);
    }

        [Fact]
    public async Task Should_GetAll_Stores()
    {
        List<Stores> _expectedListofStores = new List<Stores>();
        Stores _testStore = new Stores()
        {
            StoreID = 1,
            StoreCity = "Atlanta"
        };
        _expectedListofStores.Add(_testStore);

        Mock<IRepository<Stores>> mockRepo = new Mock<IRepository<Stores>>();
        mockRepo.Setup(repo => repo.GetAll()).ReturnsAsync(_expectedListofStores);
        IRetroBL<Stores> _custBL = new StoresBL(mockRepo.Object);
        List<Stores> _actualListofStores = _expectedListofStores;
        _actualListofStores = await _custBL.GetAll();

        Assert.Same(_actualListofStores, _expectedListofStores);
        Assert.Equal(_actualListofStores[0].StoreID, _expectedListofStores[0].StoreID);
        Assert.Matches(_actualListofStores[0].StoreCity, _expectedListofStores[0].StoreCity);
    }

        [Fact]
    public async Task Should_GetAll_Inventory()
    {
        List<Inventory> _expectedListofInventory = new List<Inventory>();
        Inventory _testCustomer = new Inventory()
        {
            InventoryID = 1,
            InventoryQuantity = 50,
        };
        _expectedListofInventory.Add(_testCustomer);

        Mock<IRepository<Inventory>> mockRepo = new Mock<IRepository<Inventory>>();
        mockRepo.Setup(repo => repo.GetAll()).ReturnsAsync(_expectedListofInventory);
        IRetroBL<Inventory> _custBL = new InventoryBL(mockRepo.Object);
        List<Inventory> _actualListofInventory = _expectedListofInventory;
        _actualListofInventory = await _custBL.GetAll();

        Assert.Same(_actualListofInventory, _expectedListofInventory);
        Assert.Equal(_actualListofInventory[0].InventoryID, _expectedListofInventory[0].InventoryID);
        Assert.NotEmpty(_actualListofInventory);
    }
}