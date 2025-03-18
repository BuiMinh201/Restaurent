using System;
using System.Collections.Generic;

namespace MyCore.Models.Entity;

public partial class Blogs
{
    public long ID { get; set; }

    public string? Img { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public string? Content { get; set; }

    public short? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public long? UpdateBy { get; set; }

    public string? Summary { get; set; }
}
