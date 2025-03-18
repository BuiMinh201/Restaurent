using System;
using System.Collections.Generic;

namespace MyCore.Models.Entity;

public partial class ProductType
{
    public long ID { get; set; }

    public string? Name { get; set; }

    public short? Status { get; set; }

    public DateTime? CreateDate { get; set; }
}
