using Contracts;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;

        private IProjectRepository _projectRepository;
        private IEmployeeRepository _employeeRepository;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _projectRepository = new ProjectRepository(_context);
            _employeeRepository = new EmployeeRepository(_context);
        }


        public IProjectRepository Project => _projectRepository;
        public IEmployeeRepository Employee => _employeeRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
