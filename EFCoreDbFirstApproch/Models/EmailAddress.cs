using System;
using System.Collections.Generic;

namespace EFCoreDbFirstApproch.Models;

public partial class EmailAddress
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;
}
