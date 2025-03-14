using System;
using System.Collections.Generic;

namespace MyCore.Models.Entity;

public partial class Account
{
    public long ID { get; set; }

    public string? Avatar { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public byte? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public long? CraetedBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public long? UpdatedBy { get; set; }

    public long RoleID { get; set; }
}
