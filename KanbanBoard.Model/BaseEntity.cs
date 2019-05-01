using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.Model
{
    public abstract class BaseEntity
    {
        public virtual bool IsFinished { get; set; }
        public virtual bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
