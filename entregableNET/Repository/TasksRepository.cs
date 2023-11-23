using Microsoft.EntityFrameworkCore;
using entregableNET.DataAccess;
using entregableNET.DTO;
using entregableNET.Entities;



namespace entregableNET.Repository
{
    public class TasksRepository : Repository<Tasks>
    {

        public TasksRepository(ContextDB contextDB) : base(contextDB)
        {

        }

        public async Task<List<Tasks>> GetAllUsers()
        {
            try
            {
                return await _contextDB.Tasks.Where(x => x.IsCompleted == false).ToListAsync(); ;
            }
            catch (Exception ex) {

                return null;
            }
            
        }

        public async Task<Tasks?> GetUserId(int id)
        {
            try
            {
                return await _contextDB.Tasks.Where(x => x.Id == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public async Task<bool> InsertTasks(Tasks tasksDTO)
        {
            try
            {
                var arg = new Tasks();
                arg = tasksDTO;

                return await base.Insert(arg);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateTasks(TasksDTO tasksDTO, int id)
        {
            try
            {
                var arg = new Tasks();
                arg = tasksDTO;
                arg.Id = id;
                arg.Title = tasksDTO.Title;
                arg.Description = tasksDTO.Description;
                arg.IsCompleted = true;

                return await base.Update(arg);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteTasks(int id)
        {
            try
            {
                var arg = await GetUserId(id);
                arg.IsCompleted = true;

                return await base.Delete(id);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
