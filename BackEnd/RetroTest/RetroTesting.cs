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
    public async void Should_Add_Customer()
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
    public async void Should_Add_Orders()
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
    public async void Should_Add_Products()
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

    

}