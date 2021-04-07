using System;
using Xunit;
using Store.Repository;
using Store.Domain;

namespace Store.Tests
{
    public class ProductSuplierTest : BaseRepositoryTest<ProductSuplier, ProductSuplierRepository>
    {
    
        [Fact]
        public override void InsertTest()
        {
            var suplier = new ProductSuplier() 
            {
                BankName = "afiorabank",
                Description = "Desc",
                Email = "email@email.com",
                IBAN = "123123",
                LegalAddress = "address",
                Phone = "123123",
                Phone2 = "123123213",
                PostalCode = "123123",
                SuplierName = "Wukong",
                TransportationAddress = "asd123",
                VatID = "123123123",
                IsDeleted = false,
                SuplierGroupID = 1
            };

            int id = _repository.Add(suplier);
            Assert.True(id > 0);
        }


    }
}
