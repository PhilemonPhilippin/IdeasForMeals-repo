
namespace IdeasForMeals.Core.Repositories;

public interface IUserRepository
{
    Task EnsureUserCreated(string idAuth0);
}
