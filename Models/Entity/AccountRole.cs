using System;
using System.Collections.Generic;

namespace MyCore.Models.Entity;

public partial class AccountRole
{
    public long ID { get; set; }

    public string? RoleName { get; set; }

    public byte? Status { get; set; }

    public DateTime? CreateDate { get; set; }
}
