using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.Model
{
    public class TodoTask : BaseEntity
    {
        public TodoTask()
        {
            IsFinished = false;
            IsDeleted = false;
        }
        public Guid TaskID { get; set; }
        public Guid BoardID { get; set; }
        public string Name { get; set; }
        public bool Urgency { get; set; }
        public bool Importance { get; set; }


    }
}
