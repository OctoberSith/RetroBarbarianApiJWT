using System.Collections.Generic;
using Xunit;
using Moq;
using RetroModels;
using RetroBL;
using RetroDL;
using System.Threading.Tasks;

namespace RetroTest;

public class RetroTesting
{
    [Fact]
    public async void Should_Add_Customer()
    {

        //Arrange
        string FN = "STEPHEN";
        string LN = "STRANGE";
        string Ad = "117A BlEECKER STREET";
        string St = "NY";
        string Ci = "NEW YORK CITY";
        int Zi = 10011;
        string Co = "USA";
        string Em = "STEPHEN.STRANGE@AOL.COM";
        string Pa = "mordoisajerk";


        Customers p_resource = new Customers()
        {
            CustomerLast = FN,
            CustomerFirst = LN,
            Address = Ad,
            State = St,
            City = Ci,
            Zipcode = Zi,
            Country = Co,
            Email = Em,
            Password = Pa
        };

        Mock<DbContextCustomersRepo> mockRepo = new Mock<DbContextCustomersRepo>();

        mockRepo.Setup(repo => repo.Add(p_resource)).ReturnsAsync(p_resource);
        IRetroBL<Customers> custBL = new CustomersBL(mockRepo.Object);
        Customers p_resource2 = new Customers();
        p_resource2 = await custBL.Add(p_resource2);

            //Assert
            Assert.Same(p_resource, p_resource2);
            Assert.Equal(p_resource.CustomerFirst, p_resource2.CustomerFirst);
            Assert.NotNull(p_resource2);
    }
}