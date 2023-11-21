using System;
using System.Collections.Generic;

namespace DataLayout.Models;

public partial class EducationDatum
{
    public int IdEducationData { get; set; }

    public string? DataEducation { get; set; }

    public int? IdTypeTraining { get; set; }

    public int? IdModalityTraining { get; set; }

    public virtual ModalityTraining? IdModalityTrainingNavigation { get; set; }

    public virtual TypeTraining? IdTypeTrainingNavigation { get; set; }
}
