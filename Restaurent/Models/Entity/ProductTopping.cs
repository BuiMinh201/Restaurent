using System;
using System.Collections.Generic;

namespace MyCore.Models.Entity;

public partial class ProductTopping
{
    public long ID { get; set; }

    public string? Name { get; set; }

    public string? Img { get; set; }

    public decimal? Price { get; set; }

    public short? Status { get; set; }

    public long? ProductID { get; set; }
}
