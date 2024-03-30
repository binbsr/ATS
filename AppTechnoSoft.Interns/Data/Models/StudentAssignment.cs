﻿using AppTechnoSoft.Interns.Data.Enums;

namespace AppTechnoSoft.Interns.Data.Models;
public class StudentAssignment  //join table with payload
{
    public int Id { get; set; }
    public AssignmentStatus Status { get; set; }
    public string? Comment { get; set; }
    public DateTime? Deadline { get; set; }
    public byte Evaluation { get; set; } = 0;  //Out of 100

    public int InstructorId { get; set; }
    public Instructor? Instructor { get; set; }

    public string StudentId { get; set; } = string.Empty;
    public Student? Student { get; set; }

    public int AssignmentId { get; set; }
    public Assignment? Assignment { get; set; }
}
