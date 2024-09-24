using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using WebMarket.models;
using WebMarket.Dtos.Product;

namespace WebMarket.Mappers
{
    public static class ProductMappers
    {
        public static ProductDto ToProductDto(this Product ProductModel) => new ProductDto
        {
            Id = ProductModel.Id,
            Name = ProductModel.Name,
            Quantity = ProductModel.Quantity,
            Price = ProductModel.Price,
            BasketCompositions = ProductModel.Basket_Compositions.Select(c => c.ToBasketCompDto()).ToList()
        };
        public static Product ToProductFromCreateDto(this Product ProductModel) => new Product
        {
            Name = ProductModel.Name,
            Quantity = ProductModel.Quantity,
            Price = ProductModel.Price,
            ManufacturerId = ProductModel.ManufacturerId,
            CategoryId = ProductModel.CategoryId
        };
        public static Product ToProductFromUpdateDto(this Product ProductModel) => new Product
        {
            Name = ProductModel.Name,
            Quantity = ProductModel.Quantity,
            Price = ProductModel.Price,
            ManufacturerId = ProductModel.ManufacturerId,
            CategoryId = ProductModel.CategoryId
        };
    }
}
