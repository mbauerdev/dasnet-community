namespace WhatsNewInDotnet10;

// Microsoft Docs:
// https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-10.0/whatsnew#linq-and-sql-translation

// More info:
// Runtime:     https://github.com/dotnet/runtime/issues/110292
// Language:    https://github.com/dotnet/csharplang/discussions/8892
public static class LeftJoinRightJoin
{
    public static void Examples()
    {
        var result =
            from category in Categories
            join product in Products on category.Id equals product.CategoryId
            //     into productGroup
            // from product in productGroup.DefaultIfEmpty()
            select new
            {
                CategoryName = category.Name,
                ProductName = product?.Name ?? "--- empty ---"
            };

        foreach (var item in result)
        {
            Console.WriteLine($"{item.CategoryName}: {item.ProductName}");
        }
    }

    public static void ExamplesFinal()
    {
        _ = from category in Categories
            join product in Products on category.Id equals product.CategoryId
                into productGroup
            from product in productGroup.DefaultIfEmpty()
            select new
            {
                CategoryName = category.Name,
                ProductName = product?.Name ?? "--- empty ---"
            };

        // _ = from category in Categories
        //     left join product in Products on category.Id equals product.CategoryId
        //     select new
        //     {
        //         CategoryName = category.Name,
        //         ProductName = product?.Name ?? "--- empty ---"
        //     };


        var leftJoinResultOld = Categories
            .RightJoin(
                Products,
                category => category.Id,
                product => product.CategoryId,
                (t, product) => new
                {
                    CategoryName = t.Name,
                    ProductName = product?.Name ?? "--- empty ---"
                });

        foreach (var item in leftJoinResultOld)
        {
            Console.WriteLine($"{item.CategoryName}: {item.ProductName}");
        }

        var leftJoinResultNew = Categories
            .LeftJoin(
                Products,
                category => category.Id,
                product => product.CategoryId,
                (category, product) => new
                {
                    CategoryName = category.Name,
                    ProductName = product?.Name ?? "--- empty ---"
                });

        foreach (var item in leftJoinResultNew)
        {
            Console.WriteLine($"{item.CategoryName}: {item.ProductName}");
        }
    }

    public record Category(int Id, string Name);
    public record Product(int CategoryId, string Name);


    private static readonly List<Category> Categories = new()
    {
        new Category(1, "Electronics"),
        new Category(2, "Books"),
        new Category(3, "Clothing")
    };

    private static readonly List<Product> Products = new()
    {
        new Product(1, "Smartphone"),
        new Product(1, "Laptop"),
        new Product(2, "C# Programming Book"),
        // No product for CategoryId 3
    };
}
