namespace AppTechnoSoft.Interns.Data.Enums;
public enum Status
{
    Applied = 1,        // When application received
    Enrolled,           // When assigned to appropriate batch
    PendingFee,         // When fee is pending for individual
    Learning,           // On training now
    ProjectStarted,     // Assinged to a team
    ProjectSubmitted,   // Project done
    Done                // Internship done
}