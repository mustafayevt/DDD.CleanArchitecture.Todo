using System.Threading.Tasks;
using AppDomain.Entities;

namespace AppDomain.Services
{
    public interface ITaskManager
    {
        Task AssignTaskToPerson(ToDoTask task, Person person);
    }
}