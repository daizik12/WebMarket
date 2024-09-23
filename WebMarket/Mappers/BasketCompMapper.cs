using WebMarket.models;
using WebMarket.Dtos.Basket_composition;

namespace WebMarket.Mappers
{
    public static class BasketCompMapper
    {
        public static BasketCompDto ToBasketCompDto(this Basket_composition BasketCompModel) => new BasketCompDto
        {
            Id = BasketCompModel.Id,
            Quatity = BasketCompModel.Quatity,
            ProductId = BasketCompModel.ProductId,
            Discription = BasketCompModel.Discription
        };
        public static Basket_composition ToBasketFromCreateDto(this Basket_composition BasketCompModel) => new Basket_composition
        {
            Quatity = BasketCompModel.Quatity,
            ProductId = BasketCompModel.ProductId,
            Discription = BasketCompModel.Discription
        };
        public static Basket_composition ToBasketFromUpdateDto(this Basket_composition BasketCompModel) => new Basket_composition
        {
            Quatity = BasketCompModel.Quatity,
            ProductId = BasketCompModel.ProductId,
            Discription = BasketCompModel.Discription
        };
    }
}
