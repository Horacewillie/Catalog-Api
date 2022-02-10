using System;

namespace CatalogApi.Entities
{
    public record Item
    {
        public Guid Id { get; init; }

        public string Name { get; init; }

        public decimal Price { get; init; }

        public DateTimeOffset CreatedAtDate { get; init; }
    }

    //WHy are some types in dotnet are structs and others classes.

    //for example string is a class, while decimal is a struct
}