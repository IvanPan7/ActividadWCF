using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ActividadWCF
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        ProductResponse InsertProduct();

        [OperationContract]
        bool Authenticate(User user);

        [OperationContract]
        List<Product> GetProducts(User user);

        [OperationContract]
        List<Product> GetProductsByCategoryID(User user);

        [OperationContract]
        List<Product> GetProductByID(User user);


    }
}
