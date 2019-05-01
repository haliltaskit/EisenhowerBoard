using KanbanBoard.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.DAL
{
    public class TaskManagement
    {
        Helper h;
        public TaskManagement()
        {
            h = new Helper();
        }

        public int Insert(TodoTask task)
        {
            string query = "INSERT INTO TodoTask(TaskID,BoardID,Name,Urgency,Importance,IsFinished,IsDeleted,CreatedDate) VALUES(@taskID,@boardID,@name,@urgency,@importance,@isFinished,@isDeleted,@createdDate)";
            List<SqlParameter> parameters = GetParameters(task, true);

            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int Update(TodoTask task)
        {
            string query = "UPDATE TodoTask SET Name = @name, Urgency = @urgency, Importance = @importance, IsFinished = @isFinished,IsDeleted = @isDeleted WHERE TaskID = @taskID";
            List<SqlParameter> parameters = GetParameters(task, false);

            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        List<SqlParameter> GetParameters(TodoTask task, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@taskID", task.TaskID));
            if (isInsert)
            {
                parameters.Add(new SqlParameter("@boardID", task.BoardID));
            }
            parameters.Add(new SqlParameter("@name", task.Name));
            parameters.Add(new SqlParameter("@urgency", task.Urgency));
            parameters.Add(new SqlParameter("@importance", task.Importance));
            parameters.Add(new SqlParameter("@isFinished", task.IsFinished));
            parameters.Add(new SqlParameter("@isDeleted", task.IsDeleted));
            parameters.Add(new SqlParameter("@createdDate", DateTime.Now));
            return parameters;
        }

        public int Delete(Guid taskID)
        {
            string query = "DELETE FROM TodoTask WHERE TaskID = @taskID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@taskID",
                    Value = taskID
                }
            });

            return h.MyExecuteQuery(query);
        }

        public TodoTask GetTaskByID(Guid taskID)
        {
            TodoTask currentTask = new TodoTask();
            string query = "SELECT * FROM TodoTask WHERE TaskID = @taskID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@taskID",
                    Value = taskID
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            currentTask.TaskID = taskID;
            currentTask.BoardID = (Guid)reader["BoardID"];
            currentTask.Name = reader["Name"].ToString();
            currentTask.Urgency = (bool)reader["Urgency"];
            currentTask.Importance = (bool)reader["Importance"];
            currentTask.IsFinished = (bool)reader["IsFinished"];
            currentTask.IsDeleted = (bool)reader["IsDeleted"];
            currentTask.CreatedDate = (DateTime)reader["CreatedDate"];
            reader.Close();
            return currentTask;
        }

        public List<TodoTask> GetAllTasks()
        {
            List<TodoTask> tasks = new List<TodoTask>();
            TodoTask currentTask = null;
            string query = "SELECT * FROM Note";

            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentTask = new TodoTask();
                currentTask.TaskID = (Guid)reader["TaskID"];
                currentTask.BoardID = (Guid)reader["BoardID"];
                currentTask.Name = reader["Name"].ToString();
                currentTask.Urgency = (bool)reader["Urgency"];
                currentTask.Importance = (bool)reader["Importance"];
                currentTask.IsFinished = (bool)reader["IsFinished"];
                currentTask.IsDeleted = (bool)reader["IsDeleted"];
                currentTask.CreatedDate = (DateTime)reader["CreatedDate"];
                tasks.Add(currentTask);
            }
            reader.Close();
            return tasks;
        }



















    }
}
