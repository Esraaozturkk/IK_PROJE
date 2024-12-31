using System.ComponentModel.DataAnnotations;

public class CVCreateViewModel
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string SurName { get; set; }


    public List<string> Skills { get; set; } = new List<string>();

    public List<CertificateInputModel> Certificates { get; set; } = new List<CertificateInputModel>();

    public List<SchoolInputModel> Schools { get; set; } = new List<SchoolInputModel>();

    public List<ProjectInputModel> Projects { get; set; } = new List<ProjectInputModel>();

    public List<ReferenceInputModel> References { get; set; } = new List<ReferenceInputModel>();
}

public class CertificateInputModel
{
    public string Name { get; set; }
    public string Institution { get; set; }
    public DateOnly Date { get; set; }
}

public class SchoolInputModel
{
    public string SchoolName { get; set; }
    public string Department { get; set; }
    public string GraduationType { get; set; }
}

public class ProjectInputModel
{
    public string Name { get; set; }
    public string Description { get; set; }
}

public class ReferenceInputModel
{
    public string Name { get; set; }
    public string Company { get; set; }
}
