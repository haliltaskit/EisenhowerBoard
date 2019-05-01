using KanbanBoard.DAL;
using KanbanBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.BLL
{
    public class TodoTaskController
    {
        TaskManagement _taskManagement;
        public TodoTaskController()
        {
            _taskManagement = new TaskManagement();
        }

        public bool Add(TodoTask task)
        {
            task.TaskID = Guid.NewGuid();
            return _taskManagement.Insert(task) > 0;
        }

        public bool Update(TodoTask task)
        {
            return _taskManagement.Update(task) > 0;
        }

        public bool Delete(TodoTask task)
        {
            task.IsDeleted = true;
            return _taskManagement.Update(task) > 0;
        }

        public bool Complete(TodoTask task)
        {
            task.IsFinished = true;
            return _taskManagement.Update(task) > 0;
        }

        public TodoTask GetNote(Guid taskID)
        {
            return _taskManagement.GetTaskByID(taskID);
        }

        public List<TodoTask> GetListOfTodoTask()
        {
            return _taskManagement.GetAllTasks();
        }

        public List<TodoTask> GetListByBoard(Guid boardID)
        {
            List<TodoTask> todoTasks = new List<TodoTask>();
            foreach (TodoTask item in _taskManagement.GetAllTasks())
            {
                if (item.BoardID==boardID && !item.IsDeleted && !item.IsFinished)
                {
                    todoTasks.Add(item);
                }
            }
            return todoTasks;
        }








    }
}
