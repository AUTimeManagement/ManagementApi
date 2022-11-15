namespace AUTimeManagement.Api.Management.Api.Models;

public record UserViewModel(string userName, string firstName, string lastName, string email, bool isAdmin = false);

