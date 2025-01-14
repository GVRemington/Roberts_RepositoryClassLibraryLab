using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace Roberts_RepositoryClassLibraryLab
{
    public class ProductRepository : IProductRepository
    {
         private readonly SqlConnection _connectionString;

        public ProductRepository(string connectionString)
        {
            _connectionString = new SqlConnection(connectionString);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = new List<Product>();
            using (var connection = _connectionString)
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM Product", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                ProductID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Price = reader.GetDecimal(2),
                                Stock = reader.GetInt32(3),
                            });
                        }
                    }
                }

            }
            return products;
        }

        public Product GetProductByID(int ID)
        {
            using (var connection = _connectionString)
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM Product WHERE ProductID = @ProductID", connection))
                {
                    connection.Parameters.AddWithValue("@ProductID", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Product
                            {
                                ProductID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Price = reader.GetDecimal(2),
                                Stock = reader.GetInt32(3)
                            };
                        }
                    }

                }

            }
            return null;
        }

        public void AddProduct (Product product)
        {
            using (var connection = _connectionString)
            {
                connection.Open();
                using (var command = new SqlCommand("INSERT INTO Product" +
                        "(Name, Price, Stock) Values (@Name, @Price, @Stock)",
                    connection))
                {
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Stock", product.Stock);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct (Product product)
        {
            using (var connection = _connectionString)
            {
                connection.Open();
                using (var command = new SqlCommand("UPDATE Product" +
                        "SET Name = @Name, Price = @Price," +
                        "Stock = @Stock WHERE ProductID = @ProductId",
                        connection))
                {
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Price",product.Price);
                    command.Parameters.AddWithValue("@STock",product.Stock);
                    command.ExecuteNonQuery("@ProductID", product.ProductID);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteProduct (int id)
        {
            using (var connection = _connectionString)
            {
                connection.Open();
                using (var command = new SqlCommand("DELETE FROM" +
                    "Product WHERE ProductID = @ProductID", connection))
                {
                    command.Parameters.AddWithValue("@ProductID",  id);
                    command.ExecuteNonQuery();
                }
            }
        }
      
    }
}
