using entregableNET.Repository;

namespace entregableNET.Services
{
    public interface IUnitOfWork
    {
        public TasksRepository TasksRepository { get; set; }

        public Task<int> Complete();
    }
}
