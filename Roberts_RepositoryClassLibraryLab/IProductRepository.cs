using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_RepositoryClassLibraryLab
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductByID(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);

    }
}
