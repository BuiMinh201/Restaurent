using System;
using System.Collections.Generic;

namespace MyCore.Models.Entity;

public partial class Product
{
    public long Id { get; set; }

    public string? Img { get; set; }

    public string? Name { get; set; }

    public string? Content { get; set; }

    public decimal? Price { get; set; }

    public byte? Status { get; set; }

    public long? ProductTypeId { get; set; }

    public string? Summary { get; set; }

    public int? Quantity { get; set; }

    public virtual ProductType? ProductType { get; set; }
}

