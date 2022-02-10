using System;

namespace CatalogApi.Dtos
{
    public record ItemDto
    {
        public Guid Id { get; init; }

        public string Name { get; init; }

        public decimal Price { get; init; }

        public DateTimeOffset CreatedAtDate { get; init; }
    }
}