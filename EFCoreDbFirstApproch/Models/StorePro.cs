using System;
using System.Collections.Generic;

namespace EFCoreDbFirstApproch.Models;

public partial class StorePro
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
}
