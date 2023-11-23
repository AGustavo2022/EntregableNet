using entregableNET.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using entregableNET.Infrastructure;
using entregableNET.DTO;

namespace entregableNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TasksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TasksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return  ResponseFactory.CreateSuccessResponse(200,await _unitOfWork.TasksRepository.GetAll());
        }


        [HttpPost]
        [Route("Post")]
        public async Task<IActionResult> Post(TasksDTO tasksDTO)
        {
            var result = await _unitOfWork.TasksRepository.InsertTasks(tasksDTO);
            if (result)
            {

                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(201, "El usuario se registro correctamente");
            }
            return ResponseFactory.CreateErrorResponse(400, "Error Contactar a sistema");

        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(int id, TasksDTO tasksDTO)
        {
            var result = await _unitOfWork.TasksRepository.UpdateTasks(tasksDTO, id);
            if (result)
            {
                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(200, "El usuario se actualizo correctamente");
            }
            return ResponseFactory.CreateErrorResponse(400, "Error Contactar a sistema");

        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.TasksRepository.DeleteTasks(id);
            if (result)
            {
                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(200, "El usuario se Elimino correctamente");
            }
            return ResponseFactory.CreateErrorResponse(400, "Error Contactar a sistema");

        }
    }
}
