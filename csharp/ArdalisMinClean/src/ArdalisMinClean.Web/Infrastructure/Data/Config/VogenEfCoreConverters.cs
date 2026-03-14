using ArdalisMinClean.Web.Domain.CartAggregate;
using ArdalisMinClean.Web.Domain.GuestUserAggregate;
using ArdalisMinClean.Web.Domain.OrderAggregate;
using ArdalisMinClean.Web.Domain.ProductAggregate;
using Vogen;

namespace ArdalisMinClean.Web.Infrastructure.Data.Config;

[EfCoreConverter<ProductId>]
[EfCoreConverter<CartId>]
[EfCoreConverter<CartItemId>]
[EfCoreConverter<GuestUserId>]
[EfCoreConverter<OrderId>]
[EfCoreConverter<OrderItemId>]
[EfCoreConverter<Quantity>]
[EfCoreConverter<Price>]
internal partial class VogenEfCoreConverters;
