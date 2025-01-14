﻿using System;
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

        public Product GetProductByID (int ID)
        {

        }

      
    }
}