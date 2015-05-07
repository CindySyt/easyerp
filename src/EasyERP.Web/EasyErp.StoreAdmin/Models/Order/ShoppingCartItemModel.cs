namespace EasyErp.StoreAdmin.Models.Order
{
    using System;
    using Domain.Model.Products;
    using Domain.Model.Stores;

    /// <summary>
    /// Represents a shopping cart item
    /// </summary>
    public class ShoppingCartItemModel
    {
        public int ShoppingCartTypeId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string AttributesXml { get; set; }
        public decimal CustomerEnteredPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public virtual Product Product { get; set; }
        public virtual Store Customer { get; set; }
    }
}