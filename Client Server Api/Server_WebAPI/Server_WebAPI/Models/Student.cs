using System;
using System.Collections.Generic;

namespace Server_WebAPI.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? Age { get; set; }

    public string? FatherName { get; set; }

    public int? Standard { get; set; }

    public string? Gender { get; set; }
}
