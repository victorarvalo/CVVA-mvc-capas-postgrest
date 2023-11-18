using System;
using System.Collections.Generic;

namespace DataLayout.Models;

public partial class TypeTraining
{
    public int IdTypeTraining { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<EducationDatum> EducationData { get; set; } = new List<EducationDatum>();
}
