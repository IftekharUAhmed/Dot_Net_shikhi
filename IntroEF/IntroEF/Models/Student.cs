using System;
using System.Collections.Generic;

namespace IntroEF.Models;

public partial class Student
{
    public int Id { get; set; }

    public double Cgpa { get; set; }

    // string er pashe ? deyar mane holo eita faka (nullable) hote pare
    public string? Departments { get; set; }

    // Name ekhono add na kore thakle kore nin, ekhaneo ? diben
    public string? Name { get; set; }
    public string? Gender {  get; set; }
}