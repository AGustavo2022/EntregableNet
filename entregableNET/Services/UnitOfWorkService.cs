using entregableNET.DataAccess;
using entregableNET.Repository;

namespace entregableNET.Services
{
    public class UnitOfWorkService : IUnitOfWork
    {
        private readonly ContextDB _contextDB;
        public TasksRepository TasksRepository { get; set; }
        public UnitOfWorkService(ContextDB contextDB)
        {
            _contextDB = contextDB;
            TasksRepository = new TasksRepository(contextDB);
        }

        public Task<int> Complete()
        {
            return _contextDB.SaveChangesAsync();
        }
    }
}
