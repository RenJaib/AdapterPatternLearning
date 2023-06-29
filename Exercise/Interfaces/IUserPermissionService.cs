namespace Exercise.Interfaces
{
    public interface IUserPermissionService
    {
        bool UserHasAccess(string userId);
    }
}