namespace Contracts
{
    public interface IRepositoryManager
    {
        IProjectRepository Project { get; }
        IEmployeeRepository Employee { get; }
        void Save();
    }
}
