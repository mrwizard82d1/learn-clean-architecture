using ArdalisMinClean.Web.Domain.ProductAggregate;

namespace ArdalisMinClean.Web.ProductFeatures;
public record ProductDto(ProductId Id, string Name, decimal UnitPrice);
