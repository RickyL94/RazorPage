using Dapper;
using RazorPage.Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

public class ProductContext
{
    private readonly IDbConnection _connection;

    public ProductContext(IDbConnection connection)
    {
        _connection = connection;
    }

    public async Task AddProductAsync(ProductModel product)
    {
        // Execute Dapper query to insert the product into the database
       
        await _connection.ExecuteAsync("INSERT INTO MyProduct (Name, Description) VALUES (@Name, @Description)", product);
    }


    public async Task<IEnumerable<ProductModel>> GetAllProductsAsync()
    {
        return await _connection.QueryAsync<ProductModel>("SELECT * FROM MyProduct");
    }
}
