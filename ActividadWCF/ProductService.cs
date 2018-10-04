using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadWCF
{
    public class ProductService : IProductService
    {
        public bool Authenticate(User user)
        {
            if (user.NameUser == "IvanPan7")
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public List<Product> GetProducts(User user)
        {
            List<Product> theList = new List<Product>();
            theList.Add(new Product()
            {
                IDProduct = 1,
                NameProduct = "Telefono" ,
                Description = "Samsung S8",
                IDCategory = 1
            });
            theList.Add(new Product()
            {
                IDProduct = 1,
                NameProduct = "Computadora",
                Description = "HP",
                IDCategory = 2
            });
            if (user.NameUser == "IvanPan7")
            {
                return theList;
            }
            //Change it to return Null if you want to use the authentication
            //if not, then just return theList

            return null;
        }

        public List<Product> GetProductsByCategoryID(User user)
        {
            List<Product> theList = new List<Product>();
            var result = theList;
           
            theList.Add(new Product()
            {
                IDProduct = 1,
                NameProduct = "Telefono",
                Description = "Samsung S8",
                IDCategory = 1
            });
            theList.Add(new Product()
            {
                IDProduct = 1,
                NameProduct = "Computadora",
                Description = "HP",
                IDCategory = 2
            });
            if (user.Request != null)
            {
                try
                {
                    result = theList.Where(p => p.IDCategory.ToString() == user.Request.ToString()).ToList();
                }
                catch (Exception)
                {
                    result = null;
                }

            }
            return result;
        }

        public List<Product> GetProductByID(User user)
        {
            List<Product> theList = new List<Product>();
            var result = theList;
            theList.Add(new Product()
            {
                IDProduct = 1,
                NameProduct = "Telefono",
                Description = "Samsung S8",
                IDCategory = 1
            });
            theList.Add(new Product()
            {
                IDProduct = 1,
                NameProduct = "Computadora",
                Description = "HP",
                IDCategory = 2
            });
            if (user.Request != null)
            {
                try
                {
                    
                    result = theList.Where(p => p.IDProduct.ToString() == user.Request.ToString()).ToList();
                }
                catch (Exception)
                {
                    result = null;
                }

            }
            return result;


        }

        public ProductResponse InsertProduct()
        {
            throw new NotImplementedException();
        }
    }
}
