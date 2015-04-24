﻿namespace Doamin.Service.Order
{
    using System.Collections.Generic;
    using Domain.Model.Orders;
    using EasyErp.Core;

    public interface IOrderService
    {
        IPagedList<Order> SearchOrders(
            int storeId = 0,
            int productId = 0,
            OrderStatus? os = null,
            PaymentStatus? ps = null,
            ShippingStatus? ss = null,
            int pageIndex = 0,
            int pageSize = int.MaxValue);

        Order GetOrderById(int id);
        IList<Order> GetOrdersByIds(int[] orderIds);
    }
}