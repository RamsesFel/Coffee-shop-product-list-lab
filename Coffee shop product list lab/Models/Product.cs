using System;
using System.Collections.Generic;

namespace Coffee_shop_product_list_lab.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public string? Category { get; set; }
}
