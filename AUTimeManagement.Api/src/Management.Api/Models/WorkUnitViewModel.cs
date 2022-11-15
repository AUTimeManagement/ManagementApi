namespace AUTimeManagement.Api.Management.Api.Models;

public record WorkUnitViewModel(Guid projectId, Guid userId, DateTime startTime, DateTime endTime, int duration, string comment, DateTime workDate);

