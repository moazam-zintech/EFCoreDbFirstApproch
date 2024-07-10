using System;
using System.Collections.Generic;

namespace EFCoreDbFirstApproch.Models;

public partial class Issue
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Priority { get; set; }

    public DateTime Created { get; set; }

    public DateTime? Completed { get; set; }

    public int IssueType { get; set; }
}
